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
    public partial class Form1 : Form
    {
        Calculations calc;

        public Form1()
        {
            InitializeComponent();
            calc = new Calculations();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(tbX.Text);
            int y = Convert.ToInt32(tbY.Text);

            lbCelling.Text = calc.celling(x).ToString();
            lbFloor.Text = calc.floor(x).ToString();
            lbFractional.Text = calc.frac(x).ToString();

            int xx = Convert.ToInt32(x);
            label4.Text = xx + " mod " + y;
            lbModulo.Text = calc.modulo(xx,y).ToString();
        }

       
    }
}
