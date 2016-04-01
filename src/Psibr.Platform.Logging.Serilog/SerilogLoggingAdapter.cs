﻿using System;
using Serilog;

namespace Psibr.Platform.Logging.Serilog
{
    public class SerilogLoggingAdapter
        : IPlatformLogger
    {
        private readonly ILogger _logger;

        public SerilogLoggingAdapter(ILogger serilogLogger)
        {
            _logger = serilogLogger;
        }

        public IPlatformLogger ForContext(string propertyName, object value, bool destructureObjects = false) => 
            new SerilogLoggingAdapter(_logger.ForContext(propertyName, value, destructureObjects));

        public IPlatformLogger ForContext<TSource>() =>
            new SerilogLoggingAdapter(_logger.ForContext<TSource>());

        public IPlatformLogger ForContext(Type source) =>
            new SerilogLoggingAdapter(_logger.ForContext(source));

        public void Verbose(string messageTemplate, params object[] propertyValues) =>
            _logger.Verbose(messageTemplate, propertyValues);

        public void Verbose(Exception exception, string messageTemplate, params object[] propertyValues) =>
            _logger.Verbose(exception, messageTemplate, propertyValues);

        public void Debug(string messageTemplate, params object[] propertyValues) =>
            _logger.Debug(messageTemplate, propertyValues);

        public void Debug(Exception exception, string messageTemplate, params object[] propertyValues) =>
            _logger.Debug(exception, messageTemplate, propertyValues);

        public void Information(string messageTemplate, params object[] propertyValues) =>
            _logger.Information(messageTemplate, propertyValues);

        public void Information(Exception exception, string messageTemplate, params object[] propertyValues) =>
            _logger.Information(exception, messageTemplate, propertyValues);

        public void Warning(string messageTemplate, params object[] propertyValues) =>
            _logger.Warning(messageTemplate, propertyValues);

        public void Warning(Exception exception, string messageTemplate, params object[] propertyValues) =>
            _logger.Warning(exception, messageTemplate, propertyValues);

        public void Error(string messageTemplate, params object[] propertyValues) =>
            _logger.Error(messageTemplate, propertyValues);

        public void Error(Exception exception, string messageTemplate, params object[] propertyValues) =>
            _logger.Error(exception, messageTemplate, propertyValues);

        public void Fatal(string messageTemplate, params object[] propertyValues) =>
            _logger.Fatal(messageTemplate, propertyValues);

        public void Fatal(Exception exception, string messageTemplate, params object[] propertyValues) =>
            _logger.Fatal(exception, messageTemplate, propertyValues);
    }
}
