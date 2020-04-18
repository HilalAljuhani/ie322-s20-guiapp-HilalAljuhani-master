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
    public partial class frmImage : Form
    {
        public frmImage()
        {
            InitializeComponent();
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Btnload_Click(object sender, EventArgs e)
        {
            try
            {

                pic1.Image = Image.FromFile("C:\\Users\\Helal\\Desktop.rrr.jpg");

            }
            catch
            {
                MessageBox.Show("Error creating image!");
            }

        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
