using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module1BaiSo6_HaPhuongQuynh
{
    public partial class frmCDMessage : Form
    {
        public frmCDMessage()
        {
            InitializeComponent();
        }

        private void frmCDMessage_Load(object sender, EventArgs e)
        {
            picBig.Visible = true;
            picSmall.Visible = false;
            // Đưa con trỏ vào ô Name
            txtName.Focus();          
            // Gán tooltip cho hình ảnh
            toolTip1.SetToolTip(picBig, "Click Me");
            toolTip1.SetToolTip(picSmall, "Click Me");
        }
        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picSmall.Visible = false;
            picBig.Visible = true;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + " : " + txtMessage.Text;
            lblMessage.Visible = chkVisible.Checked;
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Nhấn Enter
            {
                btnDisplay.PerformClick(); // Gọi sự kiện Display
                e.Handled = true; // Ngăn không cho xuống dòng
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtName.Clear();
            lblMessage.Text = "";
        }
        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked) lblMessage.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked) lblMessage.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked) lblMessage.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked) lblMessage.ForeColor = Color.Black;
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkVisible.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCDMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


    }
}
