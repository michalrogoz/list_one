using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bozejko_lab1
{
    public partial class Form2 : Form
    {
        Calculations calc;
        public Form2()
        {
            InitializeComponent();
            calc = new Calculations();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbN.Text);
            List <int> liczby = calc.primes(n);
            
            string result = null;

            foreach (int i in liczby)
	        {
                result += i.ToString() + ", ";
	        }
            
            tbResult.Text = (result);
        }
    }
}
