Use utc time enricher with below steps.
In App config add in using "Serilog.Enrichers.UtcTime" and in template use "{UtcTimeStamp}".
it will add the time in UTC format like "2023-02-11T20:47:39.9393331Z"

