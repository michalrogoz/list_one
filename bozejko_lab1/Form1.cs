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

        public Form1()
        {
            InitializeComponent();            
        }

        Form1_1 f1;
        private void zadanie1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            //if (f1 == null)
            //{
                f1 = new Form1_1();
                f1.FormClosed += f1_FormClosed;
                f1.Show();
            //}
            //else
            //{
            //    f1.Activate();
            //    f1.Show();
            //}            
        }

        Form2 f2;
        private void zadanie2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
                       
            f2 = new Form2();
            f2.FormClosed += f2_FormClosed;
            f2.Show();                  
        }

        Form3 f3;
        private void zadanie3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3 = new Form3();
            f3.FormClosed += f3_FormClosed;
            f3.Show();
        }       

        void f1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        } 
        void f3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        

       
    }
}
