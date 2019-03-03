using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using simlpeFactoryDemo.Factory;
using simlpeFactoryDemo.Report;



namespace simlpeFactoryDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            IReport objReport = new ExcelReport();
            objReport.StartPrint();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            IReport objReport = new WordReport();
            objReport.StartPrint();
        }

        private void btnFactory_Click(object sender, EventArgs e)
        {
            IReport objReport = Factory.Factory.ChooseReportType();
            objReport.StartPrint();
        }
    }
}
