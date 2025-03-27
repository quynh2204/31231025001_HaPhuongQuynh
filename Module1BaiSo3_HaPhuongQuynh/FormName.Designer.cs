namespace Module1BaiSo3_HaPhuongQuynh
{
    partial class FormName
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
            btnHo = new Button();
            btnTen = new Button();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            label1 = new Label();
            label2 = new Label();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // btnHo
            // 
            btnHo.Location = new Point(119, 253);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(94, 29);
            btnHo.TabIndex = 0;
            btnHo.Text = "&Họ lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(280, 253);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(94, 29);
            btnTen.TabIndex = 1;
            btnTen.Text = "&Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(249, 110);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(175, 27);
            txtHo.TabIndex = 2;
            txtHo.KeyDown += txtHo_KeyDown;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.IndianRed;
            txtTen.Location = new Point(249, 176);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(175, 27);
            txtTen.TabIndex = 3;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(445, 253);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(94, 29);
            btnHoTen.TabIndex = 4;
            btnHoTen.Text = "Họ và Tên ";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(228, 312);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(177, 29);
            btnKetThuc.TabIndex = 5;
            btnKetThuc.Text = "Thoát chương trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += this.btnKetThuc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 110);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 6;
            label1.Text = "Họ lót";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 176);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 7;
            label2.Text = "Tên";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.BackColor = SystemColors.ActiveCaption;
            lblHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(249, 20);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(65, 28);
            lblHoTen.TabIndex = 8;
            lblHoTen.Text = "label3";
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // FormName
            // 
            AcceptButton = btnHoTen;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKetThuc;
            ClientSize = new Size(696, 370);
            Controls.Add(lblHoTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKetThuc);
            Controls.Add(btnHoTen);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            KeyPreview = true;
            Name = "FormName";
            Text = "Form1";
            KeyDown += FormName_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHo;
        private Button btnTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHoTen;
        private Button btnKetThuc;
        private Label label1;
        private Label label2;
        private Label lblHoTen;
    }
}
