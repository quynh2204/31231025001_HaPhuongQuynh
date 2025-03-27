namespace Module1Bai5_HaPhuongQuynh
{
    partial class frmTextStyle
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
            txtNhapTen = new TextBox();
            text = new Label();
            radRed = new RadioButton();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            chkItalic = new CheckBox();
            groupBox1 = new GroupBox();
            radBlack = new RadioButton();
            groupBox2 = new GroupBox();
            chkBold = new CheckBox();
            chkUnderline = new CheckBox();
            button1 = new Button();
            label1 = new Label();
            lblLapTrinh = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(210, 27);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(125, 27);
            txtNhapTen.TabIndex = 0;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text.ForeColor = Color.IndianRed;
            text.Location = new Point(85, 359);
            text.Name = "text";
            text.Size = new Size(101, 20);
            text.TabIndex = 1;
            text.Text = "Lập Trình Bởi";
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(32, 47);
            radRed.Name = "radRed";
            radRed.Size = new Size(56, 24);
            radRed.TabIndex = 2;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radColor_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(32, 97);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(69, 24);
            radGreen.TabIndex = 3;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radColor_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(32, 148);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(59, 24);
            radBlue.TabIndex = 4;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radColor_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkItalic.Location = new Point(62, 117);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(113, 24);
            chkItalic.TabIndex = 6;
            chkItalic.Text = "Nghiên Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(radBlack);
            groupBox1.Controls.Add(radRed);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Location = new Point(53, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 256);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.ForeColor = Color.Black;
            radBlack.Location = new Point(32, 203);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(65, 24);
            radBlack.TabIndex = 5;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radColor_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSalmon;
            groupBox2.Controls.Add(chkBold);
            groupBox2.Controls.Add(chkUnderline);
            groupBox2.Controls.Add(chkItalic);
            groupBox2.Location = new Point(395, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 256);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBold.Location = new Point(62, 55);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(100, 24);
            chkBold.TabIndex = 8;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            chkUnderline.Location = new Point(62, 182);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(101, 24);
            chkUnderline.TabIndex = 7;
            chkUnderline.Text = "Gạch Chân";
            chkUnderline.UseVisualStyleBackColor = true;
            chkUnderline.CheckedChanged += chkUnderline_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(469, 350);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.LawnGreen;
            label1.Location = new Point(106, 32);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 10;
            label1.Text = "Nhập Tên";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.AutoSize = true;
            lblLapTrinh.Location = new Point(210, 359);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(50, 20);
            lblLapTrinh.TabIndex = 11;
            lblLapTrinh.Text = "label2";
            // 
            // frmTextStyle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLapTrinh);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(text);
            Controls.Add(txtNhapTen);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmTextStyle";
            Text = "Định dạng (Fomater)";
            Load += frmTextStyle_Load;
            KeyDown += frmTextStyle_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNhapTen;
        private Label text;
        private RadioButton radGreen;
        private RadioButton radBlue;

        private CheckBox chkItalic;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radBlack;
        private CheckBox chkUnderline;
        private Button button1;
        private Label label1;
        private CheckBox chkBold;
        private Label lblLapTrinh;
        private RadioButton radRed;
    }
}
