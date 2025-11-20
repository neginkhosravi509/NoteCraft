using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _8
{
    public partial class Form1 : Form
    {
        string a;
        public Form1()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = textBox1.SelectedText;
            textBox1.SelectedText="";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = textBox1.SelectedText;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = a;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length!=0)
            {
                if (MessageBox.Show("sava?","save",MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                    {
                        a = saveFileDialog1.FileName;
                        File.WriteAllText(a,textBox1.Text);
                    }
                    if (openFileDialog1.ShowDialog()==DialogResult.OK)
                    {
                        a = openFileDialog1.FileName;
                        textBox1.Text = File.ReadAllText(a);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a=="")
            {
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    a = saveFileDialog1.FileName;
                    File.WriteAllText(a, textBox1.Text);
                }
                else
                    File.WriteAllText(a, textBox1.Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                a = saveFileDialog1.FileName;
                File.WriteAllText(a, textBox1.Text);
            }
            else
                File.WriteAllText(a, textBox1.Text);
        }
    }
}
