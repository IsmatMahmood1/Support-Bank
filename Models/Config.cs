//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NLog;
//using NLog.Config;
//using NLog.Targets;

//namespace Support_Bank.Models
//{
//    class Config
//    {
//        var config = new LoggingConfiguration();
//        var target = new FileTarget { FileName = @"C:\Work\Logs\SupportBank.log", Layout = @"${longdate} ${level} - ${logger}: ${message}" };
//        config.AddTarget("File Logger", target);
//            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Debug, target));
//            LogManager.Configuration = config;

//    }
//}
