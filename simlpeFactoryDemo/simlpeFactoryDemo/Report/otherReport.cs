using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simlpeFactoryDemo.Report
{
    class otherReport : Factory.IReport
    {
        public void StartPrint()
        {
            System.Windows.Forms.MessageBox.Show("using otherReport");
        }
    }
}
