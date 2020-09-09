﻿using Crawler.Models;
using Crawler.Selenium.Helper;
using Crawler.Service.Config;
using Crawler.Utility.HttpHelper;
using CrawlerConsole.DiService;
using CrawlerConsole.token;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrawlerConsole.Job
{

    [PersistJobDataAfterExecution]//执行后保留数据,更新JobDataMap
    [DisallowConcurrentExecution]//拒绝同一时间重复执行，同一任务串行
    public class KolShortCodeJob : IJob
    {
        private static string TokenString = string.Empty;
        public async Task Execute(IJobExecutionContext context)
        {
            List<JData> listTasks = Program.jDatas.Where(x => x.action.ToLower().Equals("instagged")).ToList();
            foreach (JData jData in listTasks)
            {
                var url = jData.targetUrl;
                //selenium登录https://www.instagram.com/tijneyewear/
                ShortCode(jData);
            }
           
            //获取shortcode
            //写入数据库
            await Task.Delay(1);
        }

        public static RemoteWebDriver driver = null ?? ServiceDiExtension.GetService<SeleniumHelper>().Login(Config.CookieInfoOptions, Config.igUrl);
        private static Queue<string> queueList = new Queue<string>(); //存放列表
        public void ShortCode(JData jData, string cls = "_bz0w")
        {
            var url = jData.targetUrl;
            SeleniumHelper sHelper = ServiceDiExtension.GetService<SeleniumHelper>();
            if (driver.Url != url)
            {
                driver.Url = url;
            }
            long height = 0; //存放鼠标上一次执行后浏览器的高度
            bool isGoto = true;         //是否循环获取数据
            bool isFirst = true;          //第一次加载
            while (isGoto)
            {
                if (!isFirst)
                {
                    sHelper.ScrollMouse(driver, 3000);
                }
                else
                {
                    isFirst = false;
                }
                object scrolHeight = sHelper.GetScrollHeight(driver); //获取高度

                Thread.Sleep(100);
                if (string.IsNullOrEmpty(scrolHeight?.ToString()))
                {
                    throw new Exception("获取数据长度为空");
                }
                long.TryParse(scrolHeight?.ToString(), out long tobeequal);
                object newScrolHeight = 0;   //存放鼠标滚动后高度
                long newTobeequal = 0;   //新的高度
                if (tobeequal == height)
                {
                    var nextDelay = TimeSpan.FromMilliseconds(10000);  // 重试3次
                    for (int i = 0; i != 3; ++i)
                    {
                        try
                        {
                            newScrolHeight = sHelper.GetScrollHeight(driver);
                            long.TryParse(newScrolHeight?.ToString(), out newTobeequal);
                            if (newTobeequal != height)
                            {
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(this.GetType() + "GetList", ex.Message);
                            Quit();
                            throw;
                        }
                        Thread.Sleep(nextDelay);
                        nextDelay = nextDelay + nextDelay;
                    }
                    if (newTobeequal == height)
                    {
                        isGoto = false;
                    }
                }
                height = tobeequal;
                EnqueueShortCode(cls); //获取shortcode

            }
            bool isInsert = true;
            InsertDB(isInsert, queueList,jData);    //所有数据获取完毕再写入数据库避免重复
        }
        /// <summary>
        /// 获取队列
        /// </summary>
        /// <param name="cls"></param>
        private void EnqueueShortCode(string cls)
        {
            // xpath = //*[@id="react-root"]/section/main/div/div[3]/article/div[1]/div   
            IEnumerable<IWebElement> listres = driver.FindElementsByClassName(cls);          //获取最新数据  

            foreach (var item in listres)
            {
                var href = string.Empty;
                //var href = item.FindElement(By.TagName("div a"))?.GetAttribute("href");
                try
                {
                    var div_a = item.FindElement(By.TagName("div a"));
                    if (div_a != null)
                    {
                        href = div_a.GetAttribute("href");

                    }
                    if (!string.IsNullOrEmpty(href))
                    {
                        if (!queueList.Contains(href))
                        {
                            queueList.Enqueue(href);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(this.GetType() + "EnqueueShortCode", ex.Message);
                    Quit();
                }

            }
        }
        private void InsertDB(bool goOn, Queue<string> list,JData jData)
        {
            if (string.IsNullOrWhiteSpace(TokenString))
            {
                TokenHelper helper = ServiceDiExtension.GetService<TokenHelper>();
                TokenString = helper.GetToken(Config.uniboneTokenUrl, "application/json", Config.jsonPars);
            }
            WebUtils webUtils = ServiceDiExtension.GetService<WebUtils>();
            foreach (var shortcode in queueList)
            {
                int index = 1;
            //准备写入数据库       shortcode 截取  、
            Dictionary<string, string> dicPars = new Dictionary<string, string>
                                {
                                    {"ShortCode",shortcode }
                                };
            Dictionary<string, string> headers = new Dictionary<string, string>
                                 {
                                     {"Authorization","Bearer "+TokenString }
                                 };
            var postResult = webUtils.DoPost("https://unibone.dev.heywind.cn"+jData.postBackUrl, null, "application/json", JsonConvert.SerializeObject(dicPars), false, headers);
                Console.WriteLine($"第 {index} 轮任务返回结果...{postResult}");
                index++;
            }
        }
        /// <summary>
        /// 退出
        /// </summary>
        public void Quit()
        {
            if (null != driver)
            {
                driver.Quit();
            }

        }
    }
}