namespace Module1BaiSo8_HaPhuongQuynh
{
    public partial class LinearEquation : Form
    {
        public LinearEquation()
        {
            InitializeComponent();
        }
        private void LinearEquation_Load(object sender, EventArgs e)
        {
            txtA.Focus();
            // Ban đầu disable các nút Tính và Xóa
            btnTinh.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void ValidateInputs()
        {
            bool aValid = double.TryParse(txtA.Text, out _);
            bool bValid = double.TryParse(txtB.Text, out _);

            // Hiển thị lỗi nếu nhập không hợp lệ
            errorProvider1.SetError(txtA, !aValid ? "Phải nhập số hợp lệ" : "");
            errorProvider1.SetError(txtB, !bValid ? "Phải nhập số hợp lệ" : "");

            // Chỉ enable nút Tính khi cả hai hệ số đều hợp lệ
            btnTinh.Enabled = aValid && bValid;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            string ketQua = GiaiPhuongTrinh(a, b);

            lblNghiem.Text = ketQua;
            btnTinh.Enabled = false;
            btnXoa.Enabled = true;
        }

        private string GiaiPhuongTrinh(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                    return "Phương trình có vô số nghiệm";
                else
                    return "Phương trình vô nghiệm";
            }
            else
            {
                double nghiem = -b / a;
                return $"Nghiệm: x = {Math.Round(nghiem, 2)}";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lblNghiem.Text = "";
            txtA.Focus();
            btnXoa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
