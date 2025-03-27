namespace Module1BaiSo1
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void clickme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked.");
        }

        private void FormLoad(object sender, EventArgs e)
        {
            MessageBox.Show("Hi , Welcome to C# 2010 programming!");
        }

        private void ClickForm(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }
    }
}
