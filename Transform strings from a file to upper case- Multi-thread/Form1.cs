using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lower_to_upper;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace lower_to_upper
{
    public partial class Form1 : Form
    {
       public string name1;
        public string name2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                name1 = ofd.FileName;
                textBox1.Text = File.ReadAllText(name1);
               
            }

          

        }
private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                 name2 = ofd.FileName;
                textBox2.Text = File.ReadAllText(name2);


            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
            lower_to_upper.ToUpper upp = new ToUpper();
            textBox1.Text = upp.upper(textBox1.Text);
            textBox2.Text = upp.upper(textBox2.Text);

            
            
            
            Thread a = new Thread(File1);
          
            a.Start();

            textBox3.Text = abc + "ms";
           
         

//

            var watch2 = Stopwatch.StartNew();
            
            Thread b = new Thread(File2);
            b.Start();
            watch2.Stop();
           
            textBox4.Text = watch2.ElapsedMilliseconds + " ms";
        }
        long abc;
        public void File1()
        {
            
            var watch1 = Stopwatch.StartNew();
            
            StreamWriter file = new StreamWriter(Path.GetFileNameWithoutExtension(name1) + "ToUpper.txt");
            file.Write(textBox1.Text);
            file.Close();
            watch1.Stop();


           abc = watch1.ElapsedMilliseconds;

        }

        public void File2()
        {
           
 
           
            StreamWriter file2 = new StreamWriter(Path.GetFileNameWithoutExtension(name2) + "ToUpper.txt");
            file2.Write(textBox2.Text);
            file2.Close();
          

          
        }



    }
}
