using System.Collections.Generic;
using System.IO;

namespace FourthCoffee.LogProcessor
{
    /// <summary>
    /// Represents the <see cref="FourthCoffee.LogProcessor.LogLocator" /> class in the object model.
    /// </summary>
    public class LogLocator
    {
        string _logDirectoryPath;

        
        public LogLocator(string logDirectoryRoot)
        {
            // TODO: 01: Ensure log file directory exists.
            if (!Directory.Exists(logDirectoryRoot))
                throw new DirectoryNotFoundException();

            this._logDirectoryPath = logDirectoryRoot;
        }

       
        public IEnumerable<string> GetLogFilePaths()
        {
            // TODO: 02: Get all log file paths.
            return Directory.GetFiles(
                this._logDirectoryPath,
                "*.txt");
        }
    }
}
