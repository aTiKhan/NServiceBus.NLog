namespace NServiceBus
{
    using System;
    using Logging;

    /// <summary>
    /// Configure NServiceBus logging messages to use NLog.  Use by calling <see cref="LogManager.Use{T}"/> the T is <see cref="NLogFactory"/>.
    /// </summary>
    [ObsoleteEx(
        Message = "NServiceBus is now providing support for logging libraries through the Microsoft.Extensions.Logging abstraction. Remove the NServiceBus.NLog package. Install the NServiceBus.Extensions.Logging and NLog.Extensions.Logging packages instead.",
        RemoveInVersion = "5.0.0",
        TreatAsErrorFromVersion = "4.0.0")]
    public class NLogFactory : LoggingFactoryDefinition
    {
        /// <summary>
        /// <see cref="LoggingFactoryDefinition.GetLoggingFactory"/>.
        /// </summary>
        protected override ILoggerFactory GetLoggingFactory()
        {
            throw new NotImplementedException("NServiceBus is now providing support for logging libraries through the Microsoft.Extensions.Logging abstraction. Remove the NServiceBus.NLog package. Install the NServiceBus.Extensions.Logging and NLog.Extensions.Logging packages instead.");
        }
    }
}
