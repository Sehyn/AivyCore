﻿using AivyData.Entities;
using AivyDofus.Protocol.Parser;
using AivyDofus.Proxy;
using AivyDofus.Proxy.Callbacks;
using AivyDomain.API.Proxy;
using AivyDomain.Callback.Proxy;
using AivyDomain.Mappers.Proxy;
using AivyDomain.Repository.Proxy;
using AivyDomain.UseCases.Proxy;
using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AivyDofus
{
    public class Program
    {
        static readonly ConsoleTarget log_console = new ConsoleTarget("log_console");
        static readonly LoggingConfiguration configuration = new LoggingConfiguration();
        static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static void Main(string[] args)
        {
            configuration.AddRule(LogLevel.Info, LogLevel.Fatal, log_console);
            LogManager.Configuration = configuration;

            DofusProxy proxy = new DofusProxy("D:/DofusApp", 666);
            proxy.Active(true);

            Console.ReadLine();
        }
    }
}