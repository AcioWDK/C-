using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int x = int.Parse(textBox1.Text);

            string[]cifre = { "zero", "unu", "doua", "trei", "patru", "cinci", "sase", "sapte", "opt", "noua" };

            if(x<10)
            textBox2.Text = cifre[x].ToString() ;
            if (x == 10)
                textBox2.Text = "zece";
            if(x>10 && x<20)
                textBox2.Text = cifre[x % 10].ToString() + "sprezece "  ;
            if (x > 20)
                textBox2.Text = cifre[x / 10 % 10].ToString() + "zeci si " + cifre[x % 10].ToString();
            if(x>10 && x%10==0)
                textBox2.Text = cifre[x/10 % 10].ToString() + "zeci ";
          
            
            //Exceptii?..
            if (x == 14)
                textBox2.Text = "paisprezece";
            if (x == 16)
                textBox2.Text = "saisprezece";
            if (x == 60)
                textBox2.Text = "saizeci";
            if (x == 100)
                textBox2.Text = "prea mult";
            if (x > 100)
                Close();


            textBox1.Clear();
        }
        }
    }
