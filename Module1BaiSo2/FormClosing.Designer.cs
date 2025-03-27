namespace Module1BaiSo2_HaPhuongQuynh
{
    partial class frmBaiTap1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtYourName = new TextBox();
            txtYear = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnShow = new Button();
            btnClear = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 151);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 0;
            label1.Text = "Your Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 239);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 2;
            label2.Text = "Year of birth:";
            // 
            // txtYourName
            // 
            txtYourName.BorderStyle = BorderStyle.FixedSingle;
            txtYourName.Location = new Point(396, 151);
            txtYourName.Margin = new Padding(4, 3, 4, 3);
            txtYourName.Name = "txtYourName";
            txtYourName.Size = new Size(282, 29);
            txtYourName.TabIndex = 1;
            txtYourName.Leave += txtYourName_Leave;
            // 
            // txtYear
            // 
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.Location = new Point(396, 239);
            txtYear.Margin = new Padding(4, 3, 4, 3);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(282, 29);
            txtYear.TabIndex = 3;
            txtYear.TextChanged += txtYear_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(230, 311);
            btnShow.Margin = new Padding(4, 3, 4, 3);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(118, 32);
            btnShow.TabIndex = 4;
            btnShow.Text = "&Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(435, 311);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 32);
            btnClear.TabIndex = 5;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(653, 311);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 32);
            btnExit.TabIndex = 6;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmBaiTap1
            // 
            AcceptButton = btnShow;
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(1000, 495);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnShow);
            Controls.Add(txtYear);
            Controls.Add(txtYourName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmBaiTap1";
            Text = "My name Project";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtYourName;
        private TextBox txtYear;
        private ErrorProvider errorProvider1;
        private Button btnExit;
        private Button btnClear;
        private Button btnShow;
    }
}