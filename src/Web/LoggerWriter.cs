﻿using Huanent.Logging.Abstract;
using Microsoft.Extensions.Logging;
using System;

namespace Web
{
    public class LoggerWriter : ILoggerWriter
    {
        public void WriteLog(LogLevel level, string message, string name, Exception exception, EventId eventId)
        {
            //记录日志到你希望保存的地方
        }
    }
}
