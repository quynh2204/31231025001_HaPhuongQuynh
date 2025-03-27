namespace Module1BaiSo9_HaPhuongQuynh
{
    partial class LinkLabelDemo
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
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(153, 73);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(251, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Windows Forms Community Website";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(164, 181);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(229, 20);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Launch Calculator | Open C: Drive";
            linkLabel2.LinkClicked += this.linkLabel2_LinkClicked;
            // 
            // LinkLabelDemo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 270);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Name = "LinkLabelDemo";
            Text = "LinkLabelDemo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}
