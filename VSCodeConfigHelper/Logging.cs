using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VSCodeConfigHelper
{
    public enum LogType
    {
        Info,
        Warning,
        Error,
        Multiline
    }
    public static class Logging
    {
        static string LogFilePath
        {
            get
            {
                return "VSCH.log";
            }
        }
        public static void Clear()
        {
            if (File.Exists(LogFilePath)) File.Delete(LogFilePath);
        }
        public static void Log(string message, LogType type = LogType.Info)
        {
            StreamWriter sw = new StreamWriter(LogFilePath, true);

            string log = $"[{DateTime.Now:yyyy-MM-dd hh:mm:ss}] ";
            switch (type)
            {
                case LogType.Info:
                    log += "[INFO]    ";
                    break;
                case LogType.Warning:
                    log += "[WARNING] ";
                    break;
                case LogType.Error:
                    log += "[ERROR]   ";
                    break;
                case LogType.Multiline:
                    log += Environment.NewLine;
                    break;
            }
            log += message;
            log += Environment.NewLine;
            sw.Write(log);
            sw.Flush();
            sw.Close();
        }
    }
}
