using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FourthCoffee.LogProcessor
{
    /// <summary>
    /// Represents the <see cref="FourthCoffee.LogProcessor.LogCombiner" /> class in the object model.
    /// </summary>
    public class LogCombiner
    {
        LogLocator _locator;

    
        public LogCombiner(LogLocator locator)
        {
            if (locator == null)
                throw new NullReferenceException("locator");

            this._locator = locator;
        }

        public void CombineLogs(string combinedLogPath)
        {
            // TODO: 03: Check for existing combined log file and delete if it already exists.
            if (File.Exists(combinedLogPath))
                File.Delete(combinedLogPath);

            var logFiles = this._locator.GetLogFilePaths();

            if (logFiles.Count() == 0)
            {
                File.WriteAllText(combinedLogPath, "No log files to combine.");
            }
            else
            {
                this.WriteFileHeading(combinedLogPath);

                foreach (var logFile in logFiles)
                    this.WriteLog(combinedLogPath, logFile);
            }
        }

        private void WriteFileHeading(string combinedLogPath)
        {
            var heading = new List<string>();
            heading.Add("########################################");
            heading.Add("######### Combined Log File ############");
            heading.Add("########################################");

            // TODO: 04: Write the heading to the combined log file.
            File.AppendAllLines(combinedLogPath, heading);
        }

        private void WriteLog(string combinedLogPath, string logPath)
        {
            // TODO: 05: Get the log file name without the file extension.
            var logName = Path.GetFileNameWithoutExtension(logPath);

            if (logName.Equals("combinedlog"))
                return;

            var logText = this.GetLogFileText(logPath);

            var logContent = new List<string>();
            logContent.Add("");
            logContent.Add(string.Format("######### [{0}]", logName));
            logContent.Add(logText);
            logContent.Add("");

            // TODO: 07: Write the log file contents to the combined log file.
            File.AppendAllLines(combinedLogPath, logContent);
        }

        private string GetLogFileText(string logPath)
        {
            // TODO: 06: Read the contents of the existing log file.
            var logText = File.ReadAllText(logPath);

            if (string.IsNullOrEmpty(logText))
            {
                logText = "No entries";
            }

            return logText;
        }
    }
}
