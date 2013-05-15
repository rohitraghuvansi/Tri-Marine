using System;
using System.Collections.Generic;
using System.Text;

namespace TMG.Logging
{
    /// <summary>
    /// The source of Logging.
    /// </summary>
    public enum Source
    {
        TMGWinForms,
    }
    /// <summary>
    /// Category type for logging.
    /// </summary>
    public enum LogCategory
    {
        Audit,
        Exception,
    }
    /// <summary>
    /// Log Type.
    /// </summary>
    public enum LogType
    {
        Error,
        Warning,
        Information
    }

}
