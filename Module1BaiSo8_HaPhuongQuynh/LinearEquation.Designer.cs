namespace Module1BaiSo8_HaPhuongQuynh
{
    partial class LinearEquation
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
            components = new System.ComponentModel.Container();
            txtA = new TextBox();
            txtB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnTinh = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lblNghiem = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(310, 113);
            txtA.Name = "txtA";
            txtA.Size = new Size(197, 27);
            txtA.TabIndex = 0;
            txtA.TextChanged += txtA_TextChanged;
            // 
            // txtB
            // 
            txtB.Location = new Point(310, 165);
            txtB.Name = "txtB";
            txtB.Size = new Size(197, 27);
            txtB.TabIndex = 1;
            txtB.TextChanged += txtB_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.BurlyWood;
            label1.Location = new Point(204, 32);
            label1.Name = "label1";
            label1.Size = new Size(366, 38);
            label1.TabIndex = 3;
            label1.Text = "PHƯƠNG TRÌNH AX + B = 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 120);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 4;
            label2.Text = "Nhập A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 172);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "Nhập B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 235);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 6;
            label4.Text = "Nghiệm PT";
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(140, 319);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 7;
            btnTinh.Text = "&Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(331, 319);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(520, 319);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "&Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblNghiem
            // 
            lblNghiem.BorderStyle = BorderStyle.Fixed3D;
            lblNghiem.Location = new Point(310, 235);
            lblNghiem.Name = "lblNghiem";
            lblNghiem.Size = new Size(197, 25);
            lblNghiem.TabIndex = 10;
            lblNghiem.Text = "nghiem";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LinearEquation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNghiem);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "LinearEquation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LinearEquation_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnTinh;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblNghiem;
        private ErrorProvider errorProvider1;
    }
}
