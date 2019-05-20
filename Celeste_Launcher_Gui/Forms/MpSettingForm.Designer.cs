﻿namespace Celeste_Launcher_Gui.Forms
{
    partial class MpSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MpSettingForm));
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBoxButtonCustom1 = new Celeste_AOEO_Controls.PictureBoxButtonCustom();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_Other = new System.Windows.Forms.RadioButton();
            this.rb_Wan = new System.Windows.Forms.RadioButton();
            this.tb_remoteIp = new System.Windows.Forms.TextBox();
            this.rb_Lan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnSmall1 = new Celeste_AOEO_Controls.CustomBtn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_NatPunchtrough = new System.Windows.Forms.RadioButton();
            this.rb_UPnP = new System.Windows.Forms.RadioButton();
            this.rb_Manual = new System.Windows.Forms.RadioButton();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonCustom1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BackgroundImage = global::Celeste_Launcher_Gui.Properties.Resources.DialogBoxSmall;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Controls.Add(this.pictureBoxButtonCustom1);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(781, 283);
            this.panel8.TabIndex = 3;
            // 
            // pictureBoxButtonCustom1
            // 
            this.pictureBoxButtonCustom1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxButtonCustom1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxButtonCustom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxButtonCustom1.DisabledImage = null;
            this.pictureBoxButtonCustom1.HoverImage = global::Celeste_Launcher_Gui.Properties.Resources.XButton_Hover;
            this.pictureBoxButtonCustom1.Image = global::Celeste_Launcher_Gui.Properties.Resources.XButton_Normal;
            this.pictureBoxButtonCustom1.Location = new System.Drawing.Point(726, 13);
            this.pictureBoxButtonCustom1.Name = "pictureBoxButtonCustom1";
            this.pictureBoxButtonCustom1.NormalImage = global::Celeste_Launcher_Gui.Properties.Resources.XButton_Normal;
            this.pictureBoxButtonCustom1.ShowToolTip = true;
            this.pictureBoxButtonCustom1.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxButtonCustom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxButtonCustom1.TabIndex = 60;
            this.pictureBoxButtonCustom1.TabStop = false;
            this.pictureBoxButtonCustom1.ToolTipText = "Close";
            this.pictureBoxButtonCustom1.Click += new System.EventHandler(this.PictureBoxButtonCustom1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 257);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 104);
            this.panel2.TabIndex = 52;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rb_Other, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.rb_Wan, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_remoteIp, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.rb_Lan, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 104);
            this.tableLayoutPanel2.TabIndex = 53;
            // 
            // rb_Other
            // 
            this.rb_Other.AutoSize = true;
            this.rb_Other.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Other.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_Other.Location = new System.Drawing.Point(3, 38);
            this.rb_Other.Name = "rb_Other";
            this.rb_Other.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rb_Other.Size = new System.Drawing.Size(77, 24);
            this.rb_Other.TabIndex = 53;
            this.rb_Other.Text = "Other";
            this.rb_Other.UseVisualStyleBackColor = true;
            this.rb_Other.CheckedChanged += new System.EventHandler(this.Rb_Other_CheckedChanged);
            // 
            // rb_Wan
            // 
            this.rb_Wan.AutoSize = true;
            this.rb_Wan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Wan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_Wan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_Wan.Location = new System.Drawing.Point(3, 3);
            this.rb_Wan.Name = "rb_Wan";
            this.rb_Wan.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rb_Wan.Size = new System.Drawing.Size(185, 29);
            this.rb_Wan.TabIndex = 51;
            this.rb_Wan.Text = "WAN";
            this.rb_Wan.UseVisualStyleBackColor = true;
            this.rb_Wan.CheckedChanged += new System.EventHandler(this.Rb_Wan_CheckedChanged);
            // 
            // tb_remoteIp
            // 
            this.tb_remoteIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_remoteIp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_remoteIp.Location = new System.Drawing.Point(201, 74);
            this.tb_remoteIp.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.tb_remoteIp.Name = "tb_remoteIp";
            this.tb_remoteIp.ReadOnly = true;
            this.tb_remoteIp.Size = new System.Drawing.Size(171, 25);
            this.tb_remoteIp.TabIndex = 50;
            this.tb_remoteIp.Text = "127.0.0.1";
            this.tb_remoteIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb_Lan
            // 
            this.rb_Lan.AutoSize = true;
            this.rb_Lan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Lan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_Lan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_Lan.Location = new System.Drawing.Point(194, 3);
            this.rb_Lan.Name = "rb_Lan";
            this.rb_Lan.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rb_Lan.Size = new System.Drawing.Size(185, 29);
            this.rb_Lan.TabIndex = 52;
            this.rb_Lan.Text = "LAN Only";
            this.rb_Lan.UseVisualStyleBackColor = true;
            this.rb_Lan.CheckedChanged += new System.EventHandler(this.Rb_Lan_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 35);
            this.label4.TabIndex = 46;
            this.label4.Text = "Remote Ip:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label3);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(382, 66);
            this.panel11.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 66);
            this.label3.TabIndex = 43;
            this.label3.Text = "Connection Type:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Celeste_Launcher_Gui.Properties.Resources.BarSeparator;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel5.Location = new System.Drawing.Point(0, 171);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(382, 27);
            this.panel5.TabIndex = 54;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnSmall1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 198);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(382, 59);
            this.panel10.TabIndex = 57;
            // 
            // btnSmall1
            // 
            this.btnSmall1.BackColor = System.Drawing.Color.Transparent;
            this.btnSmall1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSmall1.BackgroundImage")));
            this.btnSmall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSmall1.BtnText = "SAVE";
            this.btnSmall1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSmall1.Location = new System.Drawing.Point(95, 7);
            this.btnSmall1.Margin = new System.Windows.Forms.Padding(0);
            this.btnSmall1.Name = "btnSmall1";
            this.btnSmall1.Size = new System.Drawing.Size(188, 42);
            this.btnSmall1.TabIndex = 53;
            this.btnSmall1.Click += new System.EventHandler(this.BtnSmall1_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Celeste_Launcher_Gui.Properties.Resources.BarSeparatorVertical;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel4.Location = new System.Drawing.Point(382, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 257);
            this.panel4.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel3.Location = new System.Drawing.Point(409, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 257);
            this.panel3.TabIndex = 51;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label7);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(318, 66);
            this.panel9.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 66);
            this.label7.TabIndex = 43;
            this.label7.Text = "Port Mapping (WAN):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rb_NatPunchtrough, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rb_UPnP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rb_Manual, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 66);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 191);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // rb_NatPunchtrough
            // 
            this.rb_NatPunchtrough.AutoSize = true;
            this.rb_NatPunchtrough.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_NatPunchtrough.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_NatPunchtrough.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_NatPunchtrough.Location = new System.Drawing.Point(3, 3);
            this.rb_NatPunchtrough.Name = "rb_NatPunchtrough";
            this.rb_NatPunchtrough.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rb_NatPunchtrough.Size = new System.Drawing.Size(312, 57);
            this.rb_NatPunchtrough.TabIndex = 53;
            this.rb_NatPunchtrough.Text = "NAT Punchthrough (default)";
            this.rb_NatPunchtrough.UseVisualStyleBackColor = true;
            // 
            // rb_UPnP
            // 
            this.rb_UPnP.AutoSize = true;
            this.rb_UPnP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_UPnP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_UPnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_UPnP.Location = new System.Drawing.Point(3, 66);
            this.rb_UPnP.Name = "rb_UPnP";
            this.rb_UPnP.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rb_UPnP.Size = new System.Drawing.Size(312, 57);
            this.rb_UPnP.TabIndex = 50;
            this.rb_UPnP.Text = "UPnP using Open.NAT";
            this.rb_UPnP.UseVisualStyleBackColor = true;
            this.rb_UPnP.CheckedChanged += new System.EventHandler(this.Rb_Automatic_CheckedChanged);
            // 
            // rb_Manual
            // 
            this.rb_Manual.AutoSize = true;
            this.rb_Manual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Manual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_Manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_Manual.Location = new System.Drawing.Point(3, 129);
            this.rb_Manual.Name = "rb_Manual";
            this.rb_Manual.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rb_Manual.Size = new System.Drawing.Size(312, 59);
            this.rb_Manual.TabIndex = 51;
            this.rb_Manual.Text = "Manual (Protocol: UDP, Port: 1000)";
            this.rb_Manual.UseVisualStyleBackColor = true;
            this.rb_Manual.CheckedChanged += new System.EventHandler(this.Rb_Manual_CheckedChanged);
            // 
            // MpSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(781, 283);
            this.ControlBox = false;
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MpSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Celeste Fan Project";
            this.Load += new System.EventHandler(this.MpSettingBox_Load);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonCustom1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_remoteIp;
        private System.Windows.Forms.RadioButton rb_Wan;
        private System.Windows.Forms.RadioButton rb_Lan;
        private Celeste_AOEO_Controls.CustomBtn btnSmall1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rb_Manual;
        private System.Windows.Forms.RadioButton rb_UPnP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rb_Other;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private Celeste_AOEO_Controls.PictureBoxButtonCustom pictureBoxButtonCustom1;
        private System.Windows.Forms.RadioButton rb_NatPunchtrough;
    }
}