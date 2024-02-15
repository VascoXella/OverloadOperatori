using OverloadOperatori.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverloadOperatori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (Fraction.TryParse(txt1.Text, out Fraction v1))
            {
                if (Fraction.TryParse(txt2.Text, out Fraction v2))
                {                                      

                    if (v1.Equals(v2) ||  (v1.n == 0 && v2.n == 0))
                        lbl.Text = "sono uguali";
                    else
                        lbl.Text = "sono diverse";
                }
            }            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
