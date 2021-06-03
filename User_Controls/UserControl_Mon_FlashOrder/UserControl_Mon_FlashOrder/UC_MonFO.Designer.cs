﻿namespace UserControl_Mon_FlashOrder
{
    partial class UC_MonFO
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.lblTenMon = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSLGoi = new Guna.UI.WinForms.GunaLabel();
            this.lblGiaTien = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaGradient2Panel2.SuspendLayout();
            this.gunaLinePanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(59)))));
            this.picHinhAnh.Image = global::UserControl_Mon_FlashOrder.Properties.Resources.beefSteak;
            this.picHinhAnh.Location = new System.Drawing.Point(9, 7);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(255, 167);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhAnh.TabIndex = 0;
            this.picHinhAnh.TabStop = false;
            // 
            // lblTenMon
            // 
            this.lblTenMon.BackColor = System.Drawing.Color.Transparent;
            this.lblTenMon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenMon.Font = new System.Drawing.Font("SVN-Nexa Bold", 18F, System.Drawing.FontStyle.Italic);
            this.lblTenMon.ForeColor = System.Drawing.Color.Black;
            this.lblTenMon.Location = new System.Drawing.Point(0, 0);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(322, 57);
            this.lblTenMon.TabIndex = 1;
            this.lblTenMon.Text = "Gà hấp lá chanh";
            this.lblTenMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.gunaGradient2Panel2);
            this.gunaLinePanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinePanel1.LineBottom = 3;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Blue;
            this.gunaLinePanel1.LineLeft = 3;
            this.gunaLinePanel1.LineRight = 3;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 3;
            this.gunaLinePanel1.Location = new System.Drawing.Point(264, 8);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(322, 57);
            this.gunaLinePanel1.TabIndex = 2;
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.White;
            this.gunaGradient2Panel2.Controls.Add(this.lblTenMon);
            this.gunaGradient2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradient2Panel2.ForeColor = System.Drawing.Color.Red;
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(241)))));
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(322, 57);
            this.gunaGradient2Panel2.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("SVN-Haptic Script", 20F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(260, 73);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(214, 51);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Số lần được gọi:";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(131)))));
            this.gunaLinePanel3.Controls.Add(this.panel1);
            this.gunaLinePanel3.Controls.Add(this.lblSLGoi);
            this.gunaLinePanel3.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel3.Controls.Add(this.gunaLinePanel1);
            this.gunaLinePanel3.Controls.Add(this.picHinhAnh);
            this.gunaLinePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel3.LineBottom = 6;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.gunaLinePanel3.LineLeft = 6;
            this.gunaLinePanel3.LineRight = 6;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.LineTop = 6;
            this.gunaLinePanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(593, 181);
            this.gunaLinePanel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGiaTien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(260, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 46);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SVN-Haptic Script", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSLGoi
            // 
            this.lblSLGoi.BackColor = System.Drawing.Color.Transparent;
            this.lblSLGoi.Font = new System.Drawing.Font("SVN-Haptic Script", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLGoi.ForeColor = System.Drawing.Color.Black;
            this.lblSLGoi.Location = new System.Drawing.Point(472, 66);
            this.lblSLGoi.Name = "lblSLGoi";
            this.lblSLGoi.Size = new System.Drawing.Size(82, 58);
            this.lblSLGoi.TabIndex = 0;
            this.lblSLGoi.Text = "500";
            this.lblSLGoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaTien.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGiaTien.Font = new System.Drawing.Font("SVN-Haptic Script", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.ForeColor = System.Drawing.Color.Black;
            this.lblGiaTien.Location = new System.Drawing.Point(220, 0);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(74, 46);
            this.lblGiaTien.TabIndex = 0;
            this.lblGiaTien.Text = "500";
            this.lblGiaTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("SVN-Haptic Script", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giá tiền: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_MonFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLinePanel3);
            this.Name = "UC_MonFO";
            this.Size = new System.Drawing.Size(593, 181);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.gunaLinePanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHinhAnh;
        private Guna.UI.WinForms.GunaLabel lblTenMon;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel lblSLGoi;
        private Guna.UI.WinForms.GunaLabel lblGiaTien;
    }
}
