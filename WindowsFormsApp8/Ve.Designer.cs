﻿namespace WindowsFormsApp8
{
    partial class Ve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ve));
            this.pnlVe = new System.Windows.Forms.Panel();
            this.lblTenghe = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlQR = new System.Windows.Forms.Panel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.pnlVe.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVe
            // 
            this.pnlVe.Controls.Add(this.groupBox1);
            this.pnlVe.Location = new System.Drawing.Point(3, 28);
            this.pnlVe.Name = "pnlVe";
            this.pnlVe.Size = new System.Drawing.Size(364, 354);
            this.pnlVe.TabIndex = 1;
            // 
            // lblTenghe
            // 
            this.lblTenghe.AutoSize = true;
            this.lblTenghe.Location = new System.Drawing.Point(14, 180);
            this.lblTenghe.Name = "lblTenghe";
            this.lblTenghe.Size = new System.Drawing.Size(35, 13);
            this.lblTenghe.TabIndex = 3;
            this.lblTenghe.Text = "label4";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 134);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label3";
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Location = new System.Drawing.Point(14, 85);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(35, 13);
            this.lblTenPhim.TabIndex = 1;
            this.lblTenPhim.Text = "label2";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(14, 43);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(35, 13);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolbtnPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(367, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPhong);
            this.groupBox1.Controls.Add(this.lblTenghe);
            this.groupBox1.Controls.Add(this.lblTenPhim);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 357);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Vé";
            // 
            // pnlQR
            // 
            this.pnlQR.Location = new System.Drawing.Point(3, 27);
            this.pnlQR.Name = "pnlQR";
            this.pnlQR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlQR.Size = new System.Drawing.Size(364, 364);
            this.pnlQR.TabIndex = 4;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolbtnPrint
            // 
            this.toolbtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnPrint.Image")));
            this.toolbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnPrint.Name = "toolbtnPrint";
            this.toolbtnPrint.Size = new System.Drawing.Size(23, 22);
            this.toolbtnPrint.Text = "toolStripButton2";
            this.toolbtnPrint.Click += new System.EventHandler(this.toolbtnPrint_Click);
            // 
            // Ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 383);
            this.Controls.Add(this.pnlQR);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlVe);
            this.IsMdiContainer = true;
            this.Name = "Ve";
            this.Text = "Ve";
            this.Load += new System.EventHandler(this.Ve_Load_1);
            this.pnlVe.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVe;
        private System.Windows.Forms.Label lblTenghe;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolbtnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlQR;
    }
}