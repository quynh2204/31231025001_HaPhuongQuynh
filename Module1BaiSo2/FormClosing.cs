using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module1BaiSo2_HaPhuongQuynh
{
    public partial class frmBaiTap1 : Form
    {
        public frmBaiTap1()
        {
            InitializeComponent();
        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYourName.Text))
                errorProvider1.SetError(txtYourName, "You must enter Your Name");
            else
                errorProvider1.SetError(txtYourName, "");
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYear.Text) && !int.TryParse(txtYear.Text, out _))
                errorProvider1.SetError(txtYear, "This is not a valid number");
            else
                errorProvider1.SetError(txtYear, "");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYourName.Text))
                {
                MessageBox.Show("Please enter your name");
                return;
            }
            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Please enter valid year");
                return;
            }

            int age = DateTime.Now.Year - year;
            MessageBox.Show($"My Name is: {txtYourName.Text}\nAge: {age}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
