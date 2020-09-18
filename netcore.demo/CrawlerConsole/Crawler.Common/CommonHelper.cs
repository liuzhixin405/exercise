﻿using Crawler.Logger;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Crawler.Common
{
    public class CommonHelper
    {
       
        public static bool IsUrl(string str)
        {
            try
            {
                string Url = @"^http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
                return Regex.IsMatch(str, Url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static void ConsoleAndLogger(string message,LoggerType loggerType)
        {
            var current = ConsoleColor.White;
            switch (loggerType)
            {
                case LoggerType.Error:
                    LoggerHelper.Error(message);
                    current = ConsoleColor.Red;
                    break;            
                case LoggerType.Warn:
                    LoggerHelper.Warn(message);
                    current = ConsoleColor.White;
                    break;
                case LoggerType.Info:
                default:
                    current = ConsoleColor.White;
                    LoggerHelper.Info(message);
                    break;
            }
            ConsoleHelper.WriteLine("", message, "", current);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public enum LoggerType
        {
            Error,
            Info,
            Warn
        }
    }
}
