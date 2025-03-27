namespace Module1BaiSo4_HaPhuongQuynh
{
    public partial class frmCurrencyExchange : Form
    {
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }
        private const double USD_RATE = 17861;
        private const double EUR_RATE = 27043;
        private double GetUSDRate()
        {
            return double.TryParse(txtUSDRate.Text, out double rate) ? rate : 17861;
        }

        private double GetEURRate()
        {
            return double.TryParse(txtEURRate.Text, out double rate) ? rate : 27043;
        }
        private void ValidateAmount()
        {
            if (!double.TryParse(txtAmount.Text, out _))
            {
                errorProvider1.SetError(txtAmount, "Invalid number");
                return;
            }
            errorProvider1.SetError(txtAmount, "");
        }

        private void btnVNDtoUSD_Click(object sender, EventArgs e)
        {
            ValidateAmount();
            if (!double.TryParse(txtAmount.Text, out double amount)) return;

            double result = amount / GetUSDRate();
            lblResult.Text = $"{Math.Round(result, 2)} USD";
        }

        private void btnUSDtoVND_Click(object sender, EventArgs e)
        {
            ValidateAmount();
            if (!double.TryParse(txtAmount.Text, out double amount)) return;

            double result = amount * GetUSDRate();
            lblResult.Text = $"{Math.Round(result, 2)} VND";
        }

        private void btnVNDtoEUR_Click(object sender, EventArgs e)
        {
            ValidateAmount();
            if (!double.TryParse(txtAmount.Text, out double amount)) return;

            double result = amount / GetEURRate();
            lblResult.Text = $"{Math.Round(result, 2)} EUR";
        }

        private void btnEURtoVND_Click(object sender, EventArgs e)
        {
            ValidateAmount();
            if (!double.TryParse(txtAmount.Text, out double amount)) return;

            double result = amount * GetEURRate();
            lblResult.Text = $"{Math.Round(result, 2)} VND";
        }

        private void frmCurrencyExchange_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy sự kiện đóng form
            }
        }



    }
}
