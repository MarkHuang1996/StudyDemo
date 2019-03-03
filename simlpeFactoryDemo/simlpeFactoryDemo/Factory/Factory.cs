using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using simlpeFactoryDemo.Report;

namespace simlpeFactoryDemo.Factory
{
    class Factory
    {
        //1 declear the interface param
        static IReport objReport = null;

        //2 add a new app.config
        // <appSettings>
        //  <add key = "ReportType" value="ExcelReport"/>
        //</appSettings>

        //3 read the config file
        static string reportType = ConfigurationManager.AppSettings["ReportType"].ToString();

        //4 choose report type

        public static IReport ChooseReportType()
        {
            switch (reportType)
            {
                case "ExcelReport":
                    objReport = new ExcelReport();
                    break;
                case "WordReport":
                    objReport = new WordReport();
                    break;
             
            }
            return objReport;
        }

    }
}
