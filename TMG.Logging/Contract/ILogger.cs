using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace TMG.Logging
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    // Class Name           : ILogger
    // Purpose              : This interface will be implemented and used for logging 
    //                         purpose.
    // Created (mm/dd/yyyy) : 06/05/2013
    // Author               : Rohit Raghuvansi
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    // Modification History
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    // Date (mm/dd/yy)   By Whom              Details
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    /// <summary>
    /// Interface that will be implemented by loggers.
    /// </summary>
    public interface ILogger
    {
        void WriteLogEntry(string message, ICollection<LogCategory> logCategories, int priority, TraceEventType severity, Source source, DateTime messageTimeStamp);
    }
}
