// Copyright (C) 2020 Guyutongxue
// 
// This file is part of VSCodeConfigHelper.
// 
// VSCodeConfigHelper is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// VSCodeConfigHelper is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with VSCodeConfigHelper.  If not, see<http://www.gnu.org/licenses/>.

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

        public static void Log(Exception ex, string adj = "")
        {
            Log(adj + " error occured. ", LogType.Error);
            string detail = "Type: " + ex.GetType().Name + Environment.NewLine
                + "Info: " + ex.Message + Environment.NewLine
                + "StackTrace: " + Environment.NewLine + ex.StackTrace;
            Log(detail, LogType.Multiline);
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
