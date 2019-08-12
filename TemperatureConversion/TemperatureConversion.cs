using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            //pass input as parameter to Temperature 
            Temperature temp = new Temperature(textBox1.Text, rdCelsius.Checked);

            //result
            lblResult.Text = temp.getConvTemp();
            textBox1.Text = "";
        }
    }
}
