using IE322_Hilal_1845513;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IE322_HILAL_1845513
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            frmImage frm = new frmImage();
            frm.ShowDialog();
        }

        private void Button21_Click(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Hilal" && textBox2.Text == "112233")
            {
                MessageBox.Show("Login successful");
            }
            else if (textBox1.Text == "Hilal" || textBox2.Text == "112233")
                if (textBox1.Text != "Hilal")
                {
                    MessageBox.Show("wrong username");
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            else
            {
                MessageBox.Show("Incorrect login");
            }
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void Button8_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.ShowDialog();
        }

        private void BTNComba_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.ShowDialog();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void BTNChexkbox_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
        }

        private void BTNRandomComba_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void BTNRandom_Click(object sender, EventArgs e)
        {

        }
    }
}
