using Microsoft.AspNetCore.Http;
using Serilog.Core;
using Serilog.Events;
using System;

namespace Serilog.Enrichers.UtcTime.Enrichers
{
    /// <summary>
    /// Enriches log events with an UtcTime property for the current request.
    /// </summary>
    class UtcTimeEnricher
        : ILogEventEnricher
    {
        private const string UtcTimePropertyName = "UtcTimeStamp";
        private readonly IHttpContextAccessor _contextAccessor;

        public UtcTimeEnricher() : this(new HttpContextAccessor())
        {
        }

        public UtcTimeEnricher(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }


        /// <summary>
        /// Enrich the log event.
        /// </summary>
        /// <param name="logEvent">The log event to enrich.</param>
        /// <param name="propertyFactory">Factory for creating new properties to add to the event.</param>
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            var property = propertyFactory.CreateProperty(UtcTimePropertyName, DateTime.UtcNow.ToString("O") ?? "-");
            logEvent.AddOrUpdateProperty(property);
        }
    }
}
