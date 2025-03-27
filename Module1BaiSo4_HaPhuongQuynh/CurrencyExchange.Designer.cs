namespace Module1BaiSo4_HaPhuongQuynh
{
    partial class frmCurrencyExchange
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
            label1 = new Label();
            txtAmount = new TextBox();
            label2 = new Label();
            btnVNDtoEUR = new Button();
            btnEURtoVND = new Button();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            lblResult = new Label();
            btnVNDtoUSD = new Button();
            btnUSDtoVND = new Button();
            txtUSDRate = new TextBox();
            txtEURRate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 100);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Tiền qui đổi:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(235, 93);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 252);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Kết quả:";
            // 
            // btnVNDtoEUR
            // 
            btnVNDtoEUR.Location = new Point(368, 170);
            btnVNDtoEUR.Name = "btnVNDtoEUR";
            btnVNDtoEUR.Size = new Size(103, 29);
            btnVNDtoEUR.TabIndex = 6;
            btnVNDtoEUR.Text = "VND to EUR";
            btnVNDtoEUR.UseVisualStyleBackColor = true;
            btnVNDtoEUR.Click += btnVNDtoEUR_Click;
            // 
            // btnEURtoVND
            // 
            btnEURtoVND.Location = new Point(527, 170);
            btnEURtoVND.Name = "btnEURtoVND";
            btnEURtoVND.Size = new Size(100, 29);
            btnEURtoVND.TabIndex = 7;
            btnEURtoVND.Text = "UER to VND";
            btnEURtoVND.UseVisualStyleBackColor = true;
            btnEURtoVND.Click += btnEURtoVND_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(268, 24);
            label3.Name = "label3";
            label3.Size = new Size(109, 26);
            label3.TabIndex = 8;
            label3.Text = "ĐỔI TIỀN";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(235, 252);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(56, 20);
            lblResult.TabIndex = 9;
            lblResult.Text = "Ketqua";
            // 
            // btnVNDtoUSD
            // 
            btnVNDtoUSD.Location = new Point(35, 170);
            btnVNDtoUSD.Name = "btnVNDtoUSD";
            btnVNDtoUSD.Size = new Size(122, 29);
            btnVNDtoUSD.TabIndex = 10;
            btnVNDtoUSD.Text = "VND to USD";
            btnVNDtoUSD.UseVisualStyleBackColor = true;
            btnVNDtoUSD.Click += btnVNDtoUSD_Click;
            // 
            // btnUSDtoVND
            // 
            btnUSDtoVND.Location = new Point(205, 170);
            btnUSDtoVND.Name = "btnUSDtoVND";
            btnUSDtoVND.Size = new Size(111, 29);
            btnUSDtoVND.TabIndex = 11;
            btnUSDtoVND.Text = "USD to VND";
            btnUSDtoVND.UseVisualStyleBackColor = true;
            btnUSDtoVND.Click += btnUSDtoVND_Click;
            // 
            // txtUSDRate
            // 
            txtUSDRate.Location = new Point(560, 40);
            txtUSDRate.Name = "txtUSDRate";
            txtUSDRate.Size = new Size(125, 27);
            txtUSDRate.TabIndex = 12;
            // 
            // txtEURRate
            // 
            txtEURRate.Location = new Point(560, 97);
            txtEURRate.Name = "txtEURRate";
            txtEURRate.Size = new Size(125, 27);
            txtEURRate.TabIndex = 13;
            // 
            // frmCurrencyExchange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 326);
            Controls.Add(txtEURRate);
            Controls.Add(txtUSDRate);
            Controls.Add(btnUSDtoVND);
            Controls.Add(btnVNDtoUSD);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(btnEURtoVND);
            Controls.Add(btnVNDtoEUR);
            Controls.Add(label2);
            Controls.Add(txtAmount);
            Controls.Add(label1);
            Name = "frmCurrencyExchange";
            Text = "Form1";
            FormClosing += frmCurrencyExchange_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAmount;
        private TextBox textBox2;
        private Label label2;
        private Button btnVNDtoUSD;
        private Button btnUSDtoVND;
        private Button btnVNDtoEUR;
        private Button btnEURtoVND;
        private Label label3;
        private ErrorProvider errorProvider1;
        private Label lblResult;
        private TextBox txtEURRate;
        private TextBox txtUSDRate;
    }
}
