using System;
using Serilog.Configuration;
using Serilog.Enrichers.UtcTime.Enrichers;

namespace Serilog
{
    /// <summary>
    /// Extends <see cref="LoggerConfiguration"/> to add enrichers for the current UtcTime/>.
    /// capabilities.
    /// </summary>
    public static class UtcTimeLoggerConfigurationExtensions
    {
        /// <summary>
        /// Enrich log events with a UtcTime property containing the current UtcTime/>.
        /// </summary>
        /// <param name="enrichmentConfiguration">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithUtcTime(
           this LoggerEnrichmentConfiguration enrichmentConfiguration)
        {
            if (enrichmentConfiguration == null) throw new ArgumentNullException(nameof(enrichmentConfiguration));
            return enrichmentConfiguration.With<UtcTimeEnricher>();
        }
    }
}