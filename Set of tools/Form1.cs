using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Set_of_tools
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd;
        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNotebook();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program includes different usefull tools. \nAuthor is Lubomyr Maevskiy", "About");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            ++count;
            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            --count;
            lblCount.Text = count.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
            lblRand.Text = n.ToString();
            if (cbRand.Checked)
            {
                int cnt = 0;
                while (tbRand.Text.IndexOf(n.ToString()) != -1 && cnt <= 1000)
                {
                    n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                    ++cnt;
                }
                if (cnt <= 1000)
                    tbRand.AppendText(n + " ");
            }
            else tbRand.AppendText(n + " ");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRandClear_Click(object sender, EventArgs e)
        {
            tbRand.Clear();
        }

        private void btnRandCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRand.Text);
        }

        private void pasteTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotebook.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
            rtbNotebook.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotebook.SaveFile("notebook.rtf");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed save", "Error");
            }
        }

        void LoadNotebook()
        {
            try
            {
                rtbNotebook.LoadFile("notebook.rtf");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed load", "Error");
            }
        }
        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotebook();
        }
    }
}
