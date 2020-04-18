using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_1
{
    public partial class frmCoboRandom : Form
    {
        Random y = new Random();
        public frmCoboRandom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbRandom1.ResetText();      
            cmbRandom1.Items.Clear();    
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                cmbRandom1.Items.Add(r.Next(100, 999));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                cmbRandom2.Items.Add(r.Next(10, 99));
            }
            label1.Text = Convert.ToString(cmbRandom2.Items.Count);
        }

        private void RadioLess1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnReset1_Click(object sender, EventArgs e)
        {
            cmbRandom1.ResetText();
            cmbRandom1.Items.Clear();
            RadioLess1.Checked = false;
            RadioGreater2.Checked = false;
        }

        private void cmbRandom1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbRandom1.Text) > 499)
            {
                RadioGreater2.Checked = true;
            }
            else
            {
                RadioLess1.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void cmbRandom2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbRandom2.Text) > 49)
            {
                RadioGreater2.Checked = true;
            }
            else
            {
                RadioLess2.Checked = true;
            }
        }

        private void BtnReset2_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();
            RadioLess2.Checked = false;
            RadioGreater2.Checked = false;
            label1.Text = Convert.ToString(cmbRandom2.Items.Count);

        }
    }
}
