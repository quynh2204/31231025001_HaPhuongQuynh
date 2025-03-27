namespace Module1Bai5_HaPhuongQuynh
{
    public partial class frmTextStyle : Form
    {
        public frmTextStyle()
        {
            InitializeComponent();
        }

        private void frmTextStyle_Load(object sender, EventArgs e)
        {
            radRed.Checked = true; // Chọn mặc định
            lblLapTrinh.ForeColor = Color.Red; // Đặt màu chữ mặc định là đỏ
            txtNhapTen.ForeColor = Color.Red; // Màu nhập liệu cũng là đỏ
            txtNhapTen.Focus(); // Đặt con trỏ vào ô nhập tên
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }
        private void radColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;

            switch (r.Name)
            {
                case "radRed":
                    lblLapTrinh.ForeColor = Color.Red;
                    txtNhapTen.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    lblLapTrinh.ForeColor = Color.Green;
                    txtNhapTen.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    lblLapTrinh.ForeColor = Color.Blue;
                    txtNhapTen.ForeColor = Color.Blue;
                    break;
                case "radBlack":
                    lblLapTrinh.ForeColor = Color.Black;
                    txtNhapTen.ForeColor = Color.Black;
                    break;
            }
        }
        private void UpdateFontStyle()
        {
            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
                style |= FontStyle.Bold;
            if (chkItalic.Checked)
                style |= FontStyle.Italic;
            if (chkUnderline.Checked)
                style |= FontStyle.Underline;

            lblLapTrinh.Font = new Font(lblLapTrinh.Font.FontFamily, lblLapTrinh.Font.Size, style);
            txtNhapTen.Font = new Font(txtNhapTen.Font.FontFamily, txtNhapTen.Font.Size, style);
        }
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmTextStyle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
