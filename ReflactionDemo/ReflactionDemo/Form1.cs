using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ICL;


namespace ReflactionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //动态加载程序集并创建对象
            ICalculator objCal =
             (ICalculator)Assembly.LoadFrom("CalDLL.dll").CreateInstance("CalDLL.Calculator");


            int ressult = objCal.Add(Convert.ToInt32(this.tbFnumber.Text.Trim()), Convert.ToInt32(this.tbSnumber.Text.Trim()));

            this.tbReuslt.Text = ressult.ToString();


        }
    }
}
