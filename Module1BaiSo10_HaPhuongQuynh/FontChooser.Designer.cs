namespace Module1BaiSo10_HaPhuongQuynh
{
    partial class FontChooser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpFileInfo = new GroupBox();
            lblDateAccessed = new Label();
            lblDateModified = new Label();
            lblSize = new Label();
            label1 = new Label();
            btnBrowse = new Button();
            pnlImageContainer = new Panel();
            pbImage = new PictureBox();
            grpFileInfo.SuspendLayout();
            pnlImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // grpFileInfo
            // 
            grpFileInfo.Controls.Add(lblDateAccessed);
            grpFileInfo.Controls.Add(lblDateModified);
            grpFileInfo.Controls.Add(lblSize);
            grpFileInfo.Location = new Point(46, 91);
            grpFileInfo.Name = "grpFileInfo";
            grpFileInfo.Size = new Size(373, 134);
            grpFileInfo.TabIndex = 0;
            grpFileInfo.TabStop = false;
            grpFileInfo.Text = "File Statistics";
            // 
            // lblDateAccessed
            // 
            lblDateAccessed.AutoSize = true;
            lblDateAccessed.Location = new Point(6, 98);
            lblDateAccessed.Name = "lblDateAccessed";
            lblDateAccessed.Size = new Size(0, 20);
            lblDateAccessed.TabIndex = 2;
            // 
            // lblDateModified
            // 
            lblDateModified.AutoSize = true;
            lblDateModified.Location = new Point(6, 68);
            lblDateModified.Name = "lblDateModified";
            lblDateModified.Size = new Size(0, 20);
            lblDateModified.TabIndex = 1;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(6, 35);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(0, 20);
            lblSize.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(242, 20);
            label1.TabIndex = 1;
            label1.Text = "Click button to open a picture file:  ";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(325, 33);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse..";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // pnlImageContainer
            // 
            pnlImageContainer.AutoScroll = true;
            pnlImageContainer.Controls.Add(pbImage);
            pnlImageContainer.Location = new Point(46, 241);
            pnlImageContainer.Name = "pnlImageContainer";
            pnlImageContainer.Size = new Size(373, 210);
            pnlImageContainer.TabIndex = 3;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(0, 0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(359, 193);
            pbImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // FontChooser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 504);
            Controls.Add(pnlImageContainer);
            Controls.Add(btnBrowse);
            Controls.Add(label1);
            Controls.Add(grpFileInfo);
            Name = "FontChooser";
            Text = "Form1";
            grpFileInfo.ResumeLayout(false);
            grpFileInfo.PerformLayout();
            pnlImageContainer.ResumeLayout(false);
            pnlImageContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpFileInfo;
        private Label label1;
        private Button btnBrowse;
        private Panel pnlImageContainer;
        private Label lblDateAccessed;
        private Label lblDateModified;
        private Label lblSize;
        private PictureBox pbImage;
    }
}
