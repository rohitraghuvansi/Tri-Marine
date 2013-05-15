using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace TMG.Logging
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    // Class Name           : LoggingHelper
    // Purpose              : This class will be used to perform basic Message and 
    //                      :  Exception logging.
    // Created (mm/dd/yyyy) : 06/05/2013
    // Author               : Rohit Raghuvansi
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    // Modification History
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    // Date (mm/dd/yy)   By Whom              Details
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    /// <summary>
    /// A static class that will be used to perform basic Message and Exception logging.
    /// </summary>
    public static class LoggingHelper
    {
        #region Exception Logger

        /// <summary>
        /// Log Exception in the Application.
        /// </summary>
        /// <param name="exception">An Exception type representing the exception that needs to be logged.</param>
        /// <param name="source">A Source type representing the part of the application that raised the exception.</param>
        public static void LogException(Exception exception, Source source)
        {
            ILogger logger = new ApplicationLogger();
            LogCategory[] logCategories = { LogCategory.Exception };
            logger.WriteLogEntry(
                PrepareLogMessage(exception),
                logCategories,
                Constant.DEFAULTPRIORITY,
                TraceEventType.Error,
                source,
                DateTime.UtcNow);
        }

        /// <summary>
        /// Log Exception in the Application along with custom Message.
        /// </summary>
        /// <param name="message">A string type representing the custom message.</param>
        /// <param name="exception">An Exception type representing the exception that needs to be logged.</param>
        /// <param name="source">A Source type representing the part of the application that raised the exception.</param>
        public static void LogException(string message, Exception exception, Source source)
        {
            ILogger logger = new ApplicationLogger();
            LogCategory[] logCategories = { LogCategory.Exception };
            logger.WriteLogEntry(
                PrepareLogMessage(exception, message),
                logCategories,
                Constant.DEFAULTPRIORITY,
                TraceEventType.Error,
                source,
                DateTime.UtcNow);
        }

        #endregion

        #region Message Logger

        /// <summary>
        /// Log Message in the Application.
        /// </summary>
        /// <param name="message">A string type representing the message that needs to be logged.</param>
        /// <param name="source">A Source type representing the part of the application that raised the exception.</param>
        /// <param name="logCategory">A LogCategory type representing the tyoe of logging that needs to be done.</param>
        public static void LogMessage(string message, Source source, params LogCategory[] logCategory)
        {
            ILogger logger = new ApplicationLogger();
            logger.WriteLogEntry(
                message,
                logCategory,
                Constant.DEFAULTPRIORITY,
                TraceEventType.Information,
                source,
                DateTime.UtcNow);
        }

        /// <summary>
        /// Log Message in the Application.
        /// </summary>
        /// <param name="message">A string type representing the message that needs to be logged.</param>
        /// <param name="dateTime">A DateTime type representing the Time stamp.</param>
        /// <param name="source">A Source type representing the part of the application that raised the exception.</param>
        /// <param name="logCategory">A LogCategory type representing the tyoe of logging that needs to be done.</param>
        public static void LogMessage(string message, DateTime dateTime, Source source, params LogCategory[] logCategory)
        {
            ILogger logger = new ApplicationLogger();
            logger.WriteLogEntry(
                message,
                logCategory,
                Constant.DEFAULTPRIORITY,
                TraceEventType.Information,
                source,
                dateTime);
        }

        /// <summary>
        /// Log Message in the Application.
        /// </summary>
        /// <param name="message">A string type representing the message that needs to be logged.</param>
        /// <param name="dateTime">A DateTime type representing the Time stamp.</param>
        /// <param name="source">A Source type representing the part of the application that raised the exception.</param>
        /// <param name="logCategory">A LogCategory type representing the tyoe of logging that needs to be done.</param>
        public static void LogWarning(string message, Source source, params LogCategory[] logCategory)
        {
            ILogger logger = new ApplicationLogger();
            logger.WriteLogEntry(
                message,
                logCategory,
                Constant.DEFAULTPRIORITY,
                TraceEventType.Warning,
                source,
                DateTime.Now);
        }

        #endregion
        #region Private Methods

        /// <summary>
        /// Generate Log Message from the given Exception.
        /// </summary>
        /// <param name="ex">An Exception type representing the excaption for which message needs to be created.</param>
        /// <returns>A string type representing the message for the given Exception.</returns>
        private static string PrepareLogMessage(Exception ex)
        {
            StringBuilder message = new StringBuilder();

            if (!(ex == null))
                message.Append(string.Format("{0}\n{1}\n{2}",
                    ex.Message,
                    ex.StackTrace,
                    (ex.InnerException != null) ? ex.InnerException.Message : string.Empty));

            return message.ToString();
        }

        /// <summary>
        /// Generate Log Message from the given Exception.
        /// </summary>
        /// <param name="ex">An Exception type representing the excaption for which message needs to be created.</param>
        /// <param name="ex">A string type representing custom message.</param>
        /// <returns>A string type representing the message for the given Exception.</returns>
        private static string PrepareLogMessage(Exception ex, string customMessage)
        {
            StringBuilder message = new StringBuilder();

            if (!(ex == null))
                message.Append(string.Format("{0}\n{1}\n{2}\n{3}",
                    customMessage,
                    ex.Message,
                    ex.StackTrace,
                    (ex.InnerException != null) ? ex.InnerException.Message : string.Empty));

            return message.ToString();
        }
        #endregion
    }
}
