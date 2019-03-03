using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simlpeFactoryDemo.Report
{
    class WordReport : Factory.IReport
    {
        public void StartPrint()
        {
            MessageBox.Show("using the word do the report");
        }
    }
}
