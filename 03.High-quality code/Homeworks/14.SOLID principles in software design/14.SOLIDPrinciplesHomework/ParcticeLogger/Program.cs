﻿using LoggerLibrary;
using LoggerLibrary.Models;

namespace ParcticeLogger
{
    class Program
    {
        static void Main()
        {
            var simpleLayout = new SimpleLayout();

            var consoleAppender = new ConsoleAppender(simpleLayout);
            var fileAppender = new FileAppender(simpleLayout);
            fileAppender.FilePath = "../../log.txt";

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
            logger.Warn("Warning - missing files.");


            //var xmlLayout = new XmlLayout();
            //var consoleAppender = new ConsoleAppender(xmlLayout);
            //var logger = new Logger(consoleAppender);

            //logger.Fatal("mscorlib.dll does not respond");
            //logger.Critical("No connection string found in App.config");


            //var simpleLayout = new SimpleLayout();
            //var consoleAppender = new ConsoleAppender(simpleLayout);
            //consoleAppender.ReportLevel = ReportLevel.Error;

            //var logger = new Logger(consoleAppender);

            //logger.Info("Everything seems fine");
            //logger.Warn("Warning: ping is too high - disconnect imminent");
            //logger.Error("Error parsing request");
            //logger.Critical("No connection string found in App.config");
            //logger.Fatal("mscorlib.dll does not respond");
        }
    }
}
