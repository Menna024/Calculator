using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plusBtn_Click_1(object sender, EventArgs e)
        {

            ServiceReference1.calcSoapClient s = new ServiceReference1.calcSoapClient();
            Result.Text = s.add(int.Parse(FirstNumber.Text), int.Parse(SecondNumber.Text)).ToString();
        }

        private void minusBtn_Click_1(object sender, EventArgs e)
        {
            ServiceReference1.calcSoapClient s = new ServiceReference1.calcSoapClient();
            Result.Text = s.sub(int.Parse(FirstNumber.Text), int.Parse(SecondNumber.Text)).ToString();

        }

        private void multiplyBtn_Click_1(object sender, EventArgs e)
        {
            ServiceReference1.calcSoapClient s = new ServiceReference1.calcSoapClient();
            Result.Text = s.multiply(int.Parse(FirstNumber.Text), int.Parse(SecondNumber.Text)).ToString();

        }

        private void divideBtn_Click_1(object sender, EventArgs e)
        {
            ServiceReference1.calcSoapClient s = new ServiceReference1.calcSoapClient();
            Result.Text = s.divide(int.Parse(FirstNumber.Text), int.Parse(SecondNumber.Text)).ToString();

        }
    }
}
