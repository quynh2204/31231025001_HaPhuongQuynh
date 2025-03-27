namespace Module1BaiSo10_HaPhuongQuynh
{
    public partial class FontChooser : Form
    {
        public FontChooser()
        {
            InitializeComponent();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPicture = new OpenFileDialog();

            // Chỉ cho phép chọn file ảnh
            ofdPicture.Filter = "Image Files (*.bmp;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff)|" +
                                "*.bmp;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff|" +
                                "All Files (*.*)|*.*";

            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(ofdPicture.FileName);

                // Hiển thị thông tin file trong GroupBox
                lblSize.Text = $"File Size: {file.Length} Bytes";
                lblDateModified.Text = $"Date last modified: {file.LastWriteTime}";
                lblDateAccessed.Text = $"Date last accessed: {file.LastAccessTime}";

                // Hiển thị ảnh trong PictureBox
                pbImage.Image = new Bitmap(ofdPicture.FileName);
            }
        }
    }
}
