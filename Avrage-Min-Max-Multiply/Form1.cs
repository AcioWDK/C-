using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6._1
{
    public partial class Form1 : Form
    {
        Double media;
        Double maxim=0;
        
        Double minim = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }
        //media -
        //maximul-
        //minimul-
        //produsul nr nenule
      
        private void button3_Click(object sender, EventArgs e)
        {
            Double sum = 0;
            
            Double prod = 1;
            int s = 0;
            if (this.textBox5.Text != "")
            {


                listBox1.Items.Add(this.textBox5.Text);
                this.textBox5.Focus();
                this.textBox5.Clear();
                minim = Convert.ToDouble(listBox1.Items[0]);

            }
            else
            {
                MessageBox.Show("Please enter a number first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox5.Focus();
            }

          

            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                sum = sum + Convert.ToDouble(listBox1.Items[i]);

                if (Convert.ToDouble(listBox1.Items[i]) > maxim)
                    maxim = Convert.ToDouble(listBox1.Items[i]);
                if (minim > Convert.ToDouble(listBox1.Items[i]))
                    minim = Convert.ToDouble(listBox1.Items[i]);
                if (Convert.ToDouble(listBox1.Items[i]) != 0)
                    prod *= Convert.ToDouble(listBox1.Items[i]);

            }
            media = sum / listBox1.Items.Count;
            textBox6.Text = "media: " + media + "\r\n" + "max: " + maxim + "\r\n" + "min: " + minim + "\r\n" + "prod: " + prod;
        
        }

        private void button4_Click(object sender, EventArgs e)
        { Double sum = 0;
            
            Double prod = 1;

            if(this.listBox1.SelectedIndex >=0)
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                minim = Convert.ToDouble(listBox1.Items[0]);
                maxim = 0;

                for (int i = 0; i < listBox1.Items.Count; i++)
            {

                sum = sum + Convert.ToDouble(listBox1.Items[i]);

                if (Convert.ToDouble(listBox1.Items[i]) > maxim)
                    maxim = Convert.ToDouble(listBox1.Items[i]);
                if (minim > Convert.ToDouble(listBox1.Items[i]))
                    minim = Convert.ToDouble(listBox1.Items[i]);
                if (Convert.ToDouble(listBox1.Items[i]) != 0)
                    prod *= Convert.ToDouble(listBox1.Items[i]);

            }
            
            media = sum / listBox1.Items.Count;
            textBox6.Text = "media: " + media + "\r\n" + "max: " + maxim + "\r\n" + "min: " + minim + "\r\n" + "prod: " + prod;


            }
            
           
          



        }
    }
}
