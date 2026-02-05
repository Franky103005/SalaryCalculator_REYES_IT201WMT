using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator_REYES_IT201WMT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblHours_Click(object sender, EventArgs e)
        {

        }

        private void lblRate_Click(object sender, EventArgs e)
        {

        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double v1, v2;
            double.TryParse(txtHours.Text, out v1);
            double.TryParse(txtRate.Text, out v2);
            
            txtSalary.Text = (v1*v2*24).ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHours.Clear();
            txtRate.Clear();
            txtSalary.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
