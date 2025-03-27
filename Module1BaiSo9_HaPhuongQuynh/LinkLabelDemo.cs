namespace Module1BaiSo9_HaPhuongQuynh
{
    public partial class LinkLabelDemo : Form
    {
        public LinkLabelDemo()
        {
            InitializeComponent();

            // Gán dữ liệu cho từng phần của linkLabel2
            linkLabel2.Links.Add(0, "Launch Calculator".Length, "calc.exe");
            linkLabel2.Links.Add(linkLabel2.Text.IndexOf("Open C: Drive"), "Open C: Drive".Length, "C:\\");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var url = "https://learn.microsoft.com/en-us/visualstudio/ide/create-csharp-winform-visual-studio?view=vs-2022";
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở trang web: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link.LinkData.ToString() == "calc.exe")
            {
                System.Diagnostics.Process.Start("calc.exe"); // Mở Calculator
            }
            else if (e.Link.LinkData.ToString() == "C:\\")
            {
                System.Diagnostics.Process.Start("explorer.exe", "C:\\"); // Mở ổ C
            }
        }
    }
}
