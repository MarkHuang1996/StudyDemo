using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simlpeFactoryDemo.Report
{
    class ExcelReport : Factory.IReport
    {
        public void StartPrint()
        {
            //detials of the report 
            MessageBox.Show("using the excel do the report");
        }
    }
}
