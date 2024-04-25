using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadTabs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private RichTextBox GetRichTextBox()
        {
            RichTextBox rtb = null;
            TabPage tp = tabControl1.SelectedTab;

            if(tp!=null)
            {
                rtb = tp.Controls[0] as RichTextBox;
            }

            return rtb;
        }

        //new
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("Untitled");
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;

            tp.Controls.Add(rtb);
            tabControl1.TabPages.Add(tp);
        }
        //cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Cut();
        }
        //copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }
        //paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();
        }
        //open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                if((myStream = openFileDialog.OpenFile())!=null)
                {
                    string strfilename = openFileDialog.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    GetRichTextBox().Text = filetext;

                    tabControl1.SelectedTab.Text = Path.GetFileName(openFileDialog.FileName);
                }
            }
        }
        //save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using(Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(GetRichTextBox().Text);

                    tabControl1.SelectedTab.Text = Path.GetFileName(saveFileDialog1.FileName);
                }
            }
        }
        //highlight
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int index = 0;
            String temp = GetRichTextBox().Text;
            GetRichTextBox().Text = temp;

            while (index < GetRichTextBox().Text.LastIndexOf(toolStripTextBox1.Text))
            {
                GetRichTextBox().Find(toolStripTextBox1.Text, index, GetRichTextBox().TextLength, RichTextBoxFinds.None);
                GetRichTextBox().SelectionBackColor = Color.Magenta;
                index = GetRichTextBox().Text.IndexOf(toolStripTextBox1.Text, index) + 1;
            }

        }
        //remove current tab
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TabPage current_tab = tabControl1.SelectedTab;

            tabControl1.TabPages.Remove(current_tab);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Redo();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.ShowColor = true;
            if(fontDialog1.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(GetRichTextBox().Text))
                {
                GetRichTextBox().SelectionFont = fontDialog1.Font;
                GetRichTextBox().SelectionColor = fontDialog1.Color;
            }
        }
    }
}
