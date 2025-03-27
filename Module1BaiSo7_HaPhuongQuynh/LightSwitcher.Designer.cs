namespace Module1BaiSo7_HaPhuongQuynh
{
    partial class frmLightSwitcher
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
            picTurnOn = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            lblHienThi = new Label();
            toolTip1 = new ToolTip(components);
            picTurnOff = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picTurnOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTurnOff).BeginInit();
            SuspendLayout();
            // 
            // picTurnOn
            // 
            picTurnOn.Image = Properties.Resources.light;
            picTurnOn.Location = new Point(191, 96);
            picTurnOn.Name = "picTurnOn";
            picTurnOn.Size = new Size(111, 100);
            picTurnOn.SizeMode = PictureBoxSizeMode.StretchImage;
            picTurnOn.TabIndex = 0;
            picTurnOn.TabStop = false;
            picTurnOn.Click += picTurnOn_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.TryAgain;
            button1.Location = new Point(331, 266);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "E&xit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 38);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 266);
            label2.Name = "label2";
            label2.Size = new Size(226, 20);
            label2.TabIndex = 3;
            label2.Text = "Designed by: ______________________";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(191, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            // 
            // lblHienThi
            // 
            lblHienThi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHienThi.BorderStyle = BorderStyle.Fixed3D;
            lblHienThi.Location = new Point(128, 220);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(262, 25);
            lblHienThi.TabIndex = 5;
            lblHienThi.Text = "label3";
            // 
            // picTurnOff
            // 
            picTurnOff.Image = Properties.Resources.dentat;
            picTurnOff.Location = new Point(191, 96);
            picTurnOff.Name = "picTurnOff";
            picTurnOff.Size = new Size(111, 100);
            picTurnOff.SizeMode = PictureBoxSizeMode.StretchImage;
            picTurnOff.TabIndex = 6;
            picTurnOff.TabStop = false;
            picTurnOff.Click += picTurnOff_Click;
            // 
            // frmLightSwitcher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 338);
            Controls.Add(picTurnOff);
            Controls.Add(lblHienThi);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(picTurnOn);
            Name = "frmLightSwitcher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmLightSwitcher_Load;
            ((System.ComponentModel.ISupportInitialize)picTurnOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTurnOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picTurnOn;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label lblHienThi;
        private ToolTip toolTip1;
        private PictureBox picTurnOff;
    }
}
