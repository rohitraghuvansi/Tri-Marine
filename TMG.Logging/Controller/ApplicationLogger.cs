using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Logging.Database;
using System.Diagnostics;
using System.Globalization;

namespace TMG.Logging
{
    public class ApplicationLogger : ILogger
    {

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Class Name           : ApplicationLogger
        // Purpose              : This class will be used to perform basic Message and 
        //                      :   logging.
        // Created (mm/dd/yyyy) : 06/05/2013
        // Author               : Rohit Raghuvansi
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Modification History
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Date (mm/dd/yy)   By Whom              Details
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public ApplicationLogger() { }

        /// <summary>
        /// Log exception using Mcrosoft EnterpriseLibrary
        /// </summary>
        /// <param name="message">A string type representing the message to be logged.</param>
        /// <param name="logCategories">Collection of LogCategory type representing the type of logging that needs to be done.</param>
        /// <param name="priority">An integer type representing the priority of the message.</param>
        /// <param name="severity">A TraceEventType type representing the severity of the message.</param>
        /// <param name="source">A Source type representing the source of the message.</param>
        /// <param name="messageTimeStamp">A DataTime type representing the Timespamp of the message.</param>
        public void WriteLogEntry(string message, ICollection<LogCategory> logCategories, int priority, TraceEventType severity, Source source, DateTime messageTimeStamp)
        {
            Dictionary<string, object> extendedInformation = new Dictionary<string, object>();
            extendedInformation.Add("Source", Convert.ToString(source, CultureInfo.InvariantCulture));

            LogEntry logEntry = new LogEntry();
            logEntry.Priority = priority;
            logEntry.Severity = severity;
            logEntry.Message = message;
            logEntry.TimeStamp = messageTimeStamp;
            logEntry.ExtendedProperties = extendedInformation;

            foreach (LogCategory category in logCategories)
            {
                logEntry.Categories.Add(category.ToString());
            }

            Logger.Write(logEntry);
        }
    }
}
