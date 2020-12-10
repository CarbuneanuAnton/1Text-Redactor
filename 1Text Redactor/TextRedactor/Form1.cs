using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRedactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|Ant TextRedactor File (*.tnf)|*.tnf";
            
        }

        private void СохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text); 
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
               string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
        }
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            richTextBox1.Text = fileText;
        }

        private void ОтменитьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Undo();

        private void ВырезатьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Cut();

        private void КопироватьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Copy();

        private void ВставитьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Paste();

        private void ВыделитьВсеToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.SelectAll();

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void настройкиФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e) => richTextBox1.Copy();

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e) => richTextBox1.Paste();

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e) => richTextBox1.Cut();

        private void выделитьToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.SelectAll();
    }
}
