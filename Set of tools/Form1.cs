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
        char[] spec_chars = new char[] { '#', '%', '@', '$', '_', '&' };
        Dictionary<string, double> metrica;
        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
            metrica = new Dictionary<string, double>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNotebook();
            clbPassword.SetItemChecked(0, true);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nudPassLength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void clbPassword_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bCreatePassword_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < nudPassLength.Value; i++)
            {
                int n = rnd.Next(0, clbPassword.CheckedItems.Count);
                string s = clbPassword.CheckedItems[n].ToString();
                switch(s)
                {
                    case "Digits": password += rnd.Next(10).ToString(); 
                        break;
                    case "Uppercase letters": password += Convert.ToChar(rnd.Next(65, 88)); 
                        break;
                    case "Lowcase letters": password += Convert.ToChar(rnd.Next(97, 122)); 
                        break;
                    default:
                        password += spec_chars[rnd.Next(spec_chars.Length)];
                        break;
                }
                tbPassword.Text = password;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbPassword.Text);
        }

        private void btnClearPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Clear();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btnConvector_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cbFrom.Text];
            double m2 = metrica[cbTo.Text];
            double num = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (num * m1 / m2).ToString();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string temp = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = temp;

            temp = tbFrom.Text;
            tbFrom.Text = tbTo.Text;
            tbTo.Text = temp;
        }

        private void tbTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMetrics_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetrics.Text)
            {
                case "Length":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 1000000);
                    metrica.Add("mile", 1609344);

                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("mm");
                    cbFrom.Items.Add("cm");
                    cbFrom.Items.Add("dm");
                    cbFrom.Items.Add("m");
                    cbFrom.Items.Add("km");
                    cbFrom.Items.Add("mile");

                    cbTo.Items.Clear();
                    cbTo.Items.Add("mm");
                    cbTo.Items.Add("cm");
                    cbTo.Items.Add("dm");
                    cbTo.Items.Add("m");
                    cbTo.Items.Add("km");
                    cbTo.Items.Add("mile");

                    cbFrom.Text = "mm";
                    cbTo.Text = "mm";
                    break;

                case "Mass":
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 283);

                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("g");
                    cbFrom.Items.Add("kg");
                    cbFrom.Items.Add("t");
                    cbFrom.Items.Add("lb");
                    cbFrom.Items.Add("oz");

                    cbTo.Items.Clear();
                    cbTo.Items.Add("g");
                    cbTo.Items.Add("kg");
                    cbTo.Items.Add("t");
                    cbTo.Items.Add("lb");
                    cbTo.Items.Add("oz");

                    cbFrom.Text = "g";
                    cbTo.Text = "g";
                    break;
                default:
                    break;
            } 
        }
    }
}
