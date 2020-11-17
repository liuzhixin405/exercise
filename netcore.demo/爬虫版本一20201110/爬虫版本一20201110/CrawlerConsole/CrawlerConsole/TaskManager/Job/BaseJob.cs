﻿using Crawler.Common;
using Crawler.Models;
using Crawler.Selenium.Helper;
using Crawler.Utility.HttpHelper;
using CrawlerConsole.DiService;
using CrawlerConsole.token;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace CrawlerConsole.TaskManager.Job
{
    /// <summary>
    /// 公共模块
    /// </summary>
    public class BaseJob
    {
        public RestClientHelper restClientHelper;
        public RestClient restClient;
        public  string tokenString;
        public  HttpClientHelper httpClientHelper;
        public  HttpClient httpClient;
        public  WebUtils webUtils;
        public TokenHelper helper;
        public SeleniumHelper seleniumHelper;
        public BaseJob(HttpClientHelper httpClientHelper, HttpClient httpClient, WebUtils webUtils,TokenHelper helper, SeleniumHelper seleniumHelper,
        RestClientHelper restClientHelper,
            RestClient restClient
            )
        {
            this.helper = helper;
            if (string.IsNullOrWhiteSpace(tokenString))
            {
                try
                {
                    tokenString = this.helper.GetToken(Config.uniboneTokenUrl, "application/json", Config.jsonPars);
                    CommonHelper.ConsoleAndLogger(tokenString, CommonHelper.LoggerType.Info);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                
            }
            this.httpClientHelper = httpClientHelper;
            this.httpClient = httpClient;
            this.webUtils = webUtils; 
            this.restClientHelper = restClientHelper;
            this.restClient = restClient;
            this.seleniumHelper = seleniumHelper;
        }

        public IList<JData> GetCommList(string actionType)
        {
            return Program.jDatas.Where(x => x.action.ToLower().Equals(actionType)).OrderByDescending(x => x.level).ToList();
        }
    }
}
