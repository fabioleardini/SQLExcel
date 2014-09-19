using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace SQLExcel.Helper
{
    class SettingsHelper
    {
        public string ConnectionString { get { return ConfigurationSettings.AppSettings["ConnectionString"]; } }
        public string FilesPath { get { return ConfigurationSettings.AppSettings["FilesPath"]; } }
        public string TemplateFile { get { return ConfigurationSettings.AppSettings["TemplateFile"]; } }
        public string TemplateFilePath { get { return ConfigurationSettings.AppSettings["TemplateFilePath"]; } }

        public string CreateXlsConnection(string xlsPath)
        {
            return string.Format(ConfigurationSettings.AppSettings["ExcelConnectionString"], xlsPath);
        }
    }
}
