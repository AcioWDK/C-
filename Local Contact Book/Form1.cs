using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6._2_Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add(String name, String nr, String email)
        {
            String[] row = { name, nr, email };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            add(textBox1.Text, textBox2.Text, textBox3.Text);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
            listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
            listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
           
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }


        private void removebtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sure?","Remove",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
           textBox1.Text= listView1.SelectedItems[0].SubItems[0].Text;
           textBox2.Text= listView1.SelectedItems[0].SubItems[1].Text;
           textBox3.Text= listView1.SelectedItems[0].SubItems[2].Text;

        }
    }
}
