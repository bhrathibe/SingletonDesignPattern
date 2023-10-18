using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPattern
{
    /// <summary>
    /// Represents a singleton class for logging messages to a file.
    /// </summary>
    public class SingletonClass
    {
        string logFilePath = "bhlog.txt"; // Path to the log file.

        StreamWriter writer; // Object for writing to the file.

        // Singleton instance created when class is loaded.
        private static SingletonClass singleTonObj = new SingletonClass();

        // Private constructor ensures only one instance can be created.
        private SingletonClass()
        {
            // Create a file stream and a writer to append to the log file.
            FileStream fs = new FileStream(logFilePath, FileMode.Append, FileAccess.Write);
            writer = new StreamWriter(fs);
        }

        /// <summary>
        /// Gets the singleton instance of SingletonClass.
        /// </summary>
        /// <returns>The singleton instance.</returns>
        public static SingletonClass getInstance()
        {
            return singleTonObj;
        }

        /// <summary>
        /// Logs an entry message with a timestamp to the log file.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        public void LogEntryMessage(string message)
        {
            writer.WriteLine(DateTime.Now + ": " + message); // Write message along with timestamp.
            writer.Flush(); // Ensure the message is written immediately.
        }

        /// <summary>
        /// Destructor that ensures the writer is closed when the object is garbage collected.
        /// </summary>
        ~SingletonClass()
        {
            writer.Close();
        }
    }
}
