using System;
using Microsoft.Extensions.Logging;
using System.IO;

namespace Ntt_Frmwrk_Cr
{
    class LoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new nLogger();
        }
        public void Dispose() { }
        private class nLogger : ILogger
        {
            public IDisposable BeginScope<TState>(TState state)
            {
                return null;
            }
            public bool IsEnabled(LogLevel logLevel)
            {
                return true;
            }
            public void Log<TState>(LogLevel logLevel, EventId eventId,
                TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                File.AppendAllText("log.txt", formatter(state, exception));
                Console.WriteLine(formatter(state, exception));
            }
        }
    }
}
