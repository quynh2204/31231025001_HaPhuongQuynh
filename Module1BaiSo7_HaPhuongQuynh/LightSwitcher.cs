namespace Module1BaiSo7_HaPhuongQuynh
{
    public partial class frmLightSwitcher : Form
    {
        public frmLightSwitcher()
        {
            InitializeComponent();
        }
        private void frmLightSwitcher_Load(object sender, EventArgs e)
        {

            txtName.Text = "Jack";
            lblHienThi.Text = $"{txtName.Text}. Turn Off the Light, please!";
            picTurnOff.Visible = false;

            // Thiết lập ToolTip
            toolTip1.SetToolTip(picTurnOn, "Click me to Turn OFF the Light!");
            toolTip1.SetToolTip(picTurnOff, "Click me to Turn ON the Light!");
        }
        private void picTurnOn_Click(object sender, EventArgs e)
        {
            picTurnOn.Visible = false;
            picTurnOff.Visible = true;
            lblHienThi.Text = $"{txtName.Text}. Turn On the Light, please!";
        }

        private void picTurnOff_Click(object sender, EventArgs e)
        {
            picTurnOff.Visible = false;
            picTurnOn.Visible = true;
            lblHienThi.Text = $"{txtName.Text}. Turn Off the Light, please!";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
