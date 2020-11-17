﻿using Crawler.Common;
using Crawler.Models;
using Crawler.Service;
using Crawler.Utility.HttpHelper;
using CrawlerConsole.DiService;
using CrawlerConsole.TaskManager.Job;
using CrawlerConsole.token;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quartz;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static CrawlerConsole.Model.ShortCode;

namespace CrawlerConsole.TaskManager
{

    [PersistJobDataAfterExecution]
    [DisallowConcurrentExecution]
    public class KolPostJob : IJob
    {
        private BaseJob baseJob;       
        public KolPostJob()
        {
            baseJob = CustomApplicationService.GetService<BaseJob>();      
        }
        public async Task Execute(IJobExecutionContext context)
        {
            int index = 1;
            IList<JData> listTasks = baseJob.GetCommList("inspost");
            foreach (var data in listTasks)
            {
                string shortcode = JObject.Parse(data.parameters?.ToString()).GetValue("ShortCode")?.ToString();
           
                CommonHelper.ConsoleAndLogger($"{nameof(KolPostJob)}=> {index} 任务开始...{CommonHelper.GetSTime(Config.iSLocalEnvironment)}", CommonHelper.LoggerType.Info);
                var result = string.Empty;
                //获取post列表
                try
                {
                    Dictionary<string, string> headers = new Dictionary<string, string>
                                 {
                                     {"Cookie",Config.Cookie }
                                 };
                    Thread.Sleep(2000);
                    result = await baseJob.restClientHelper.GetRequestAsync(baseJob.restClient, Config.igUrl, data.targetUrl.Replace(Config.igUrl, ""), headers);
                    //Console.WriteLine($"第{index}post请求完成");
                    CommonHelper.ConsoleAndLogger($"第{index}post请求完成", CommonHelper.LoggerType.Info);
                }
                catch (Exception ex)
                {
                    var message = $"{nameof(KolPostJob)}获取shortcode报错: {ex.Message} 错误数据: 内容: {data.id}";
                    CommonHelper.ConsoleAndLogger(message, CommonHelper.LoggerType.Error);
                }

                if (!string.IsNullOrEmpty(result) && !result.Contains("e!r!r!o!r") && !result.StartsWith("<!DOCTYPE html>"))
                {
                    //准备写入数据库
                    Dictionary<string, string> dicPars = new Dictionary<string, string>
                                {
                                    {"Shortcode",shortcode },
                                    {"OringinalJson",result },
                                    {"IsCrawlerRequest","true" }
                                };
                    Dictionary<string, string> headers = new Dictionary<string, string>
                                 {
                                     {"Authorization",$"Bearer {baseJob.tokenString}" },
                                     {"content-type","application/json" }
                                 };
                    try
                    {
                        Thread.Sleep(100);
                        
                        var postResult = await baseJob.restClientHelper.PostRequestAsync(baseJob.restClient, Config.unUrl, data.postBackUrl, headers, dicPars);
                        //Console.WriteLine($"{nameof(KolPostJob)}-> {data.id} 任务返回结果...{postResult}");
                        CommonHelper.ConsoleAndLogger($"{nameof(KolPostJob)}-> {data.id} 任务返回结果...{postResult}", CommonHelper.LoggerType.Info);
                    }
                    catch (Exception ex)
                    {

                        var message = $"{nameof(KolPostJob)}写入数据库报错: {ex.Message} 错误数据: 内容: {data.id}";
                        CommonHelper.ConsoleAndLogger(message, CommonHelper.LoggerType.Error);
                    }
                }
                else
                {
                    Console.WriteLine($"第{index}post请求未完成,错误:{result}");
                }
                //Console.WriteLine($"任务{index}完成");
                CommonHelper.ConsoleAndLogger($"任务{index}完成", CommonHelper.LoggerType.Info);
                index++;
            }
        }
    }
}
