﻿
namespace airline_reservation_system
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTitleBox = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.LogOut = new FontAwesome.Sharp.IconButton();
            this.ViewRes = new FontAwesome.Sharp.IconButton();
            this.CancelRes = new FontAwesome.Sharp.IconButton();
            this.RescheduleRes = new FontAwesome.Sharp.IconButton();
            this.AddRes = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitleBox.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.MenuPanel.Controls.Add(this.LogOut);
            this.MenuPanel.Controls.Add(this.ViewRes);
            this.MenuPanel.Controls.Add(this.CancelRes);
            this.MenuPanel.Controls.Add(this.RescheduleRes);
            this.MenuPanel.Controls.Add(this.AddRes);
            this.MenuPanel.Controls.Add(this.panel2);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(260, 459);
            this.MenuPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 100);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sri Lankan Airlines";
            // 
            // panelTitleBox
            // 
            this.panelTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTitleBox.Controls.Add(this.lblTitle);
            this.panelTitleBox.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBox.Location = new System.Drawing.Point(260, 0);
            this.panelTitleBox.Name = "panelTitleBox";
            this.panelTitleBox.Size = new System.Drawing.Size(617, 60);
            this.panelTitleBox.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(76, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Home";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(260, 60);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(617, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelChildForm.Controls.Add(this.label4);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(260, 69);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(617, 390);
            this.panelChildForm.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(246, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sri Lankan Airlines";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Admin Dashboard!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::airline_reservation_system.Properties.Resources.airplane_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(185, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 37;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(28, 25);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(42, 37);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // LogOut
            // 
            this.LogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.White;
            this.LogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.LogOut.IconColor = System.Drawing.Color.White;
            this.LogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogOut.IconSize = 25;
            this.LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.Location = new System.Drawing.Point(0, 389);
            this.LogOut.Name = "LogOut";
            this.LogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.LogOut.Size = new System.Drawing.Size(260, 70);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "Log Out";
            this.LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // ViewRes
            // 
            this.ViewRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewRes.FlatAppearance.BorderSize = 0;
            this.ViewRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewRes.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRes.ForeColor = System.Drawing.Color.White;
            this.ViewRes.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.ViewRes.IconColor = System.Drawing.Color.White;
            this.ViewRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewRes.IconSize = 25;
            this.ViewRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewRes.Location = new System.Drawing.Point(0, 310);
            this.ViewRes.Name = "ViewRes";
            this.ViewRes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ViewRes.Size = new System.Drawing.Size(260, 70);
            this.ViewRes.TabIndex = 4;
            this.ViewRes.Text = "View Reservations";
            this.ViewRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewRes.UseVisualStyleBackColor = true;
            this.ViewRes.Click += new System.EventHandler(this.ViewRes_Click);
            // 
            // CancelRes
            // 
            this.CancelRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.CancelRes.FlatAppearance.BorderSize = 0;
            this.CancelRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelRes.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelRes.ForeColor = System.Drawing.Color.White;
            this.CancelRes.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelRes.IconColor = System.Drawing.Color.White;
            this.CancelRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelRes.IconSize = 25;
            this.CancelRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelRes.Location = new System.Drawing.Point(0, 240);
            this.CancelRes.Name = "CancelRes";
            this.CancelRes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CancelRes.Size = new System.Drawing.Size(260, 70);
            this.CancelRes.TabIndex = 3;
            this.CancelRes.Text = "Cancel Reservation";
            this.CancelRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelRes.UseVisualStyleBackColor = true;
            this.CancelRes.Click += new System.EventHandler(this.CancelRes_Click);
            // 
            // RescheduleRes
            // 
            this.RescheduleRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.RescheduleRes.FlatAppearance.BorderSize = 0;
            this.RescheduleRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RescheduleRes.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RescheduleRes.ForeColor = System.Drawing.Color.White;
            this.RescheduleRes.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.RescheduleRes.IconColor = System.Drawing.Color.White;
            this.RescheduleRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RescheduleRes.IconSize = 25;
            this.RescheduleRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RescheduleRes.Location = new System.Drawing.Point(0, 170);
            this.RescheduleRes.Name = "RescheduleRes";
            this.RescheduleRes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.RescheduleRes.Size = new System.Drawing.Size(260, 70);
            this.RescheduleRes.TabIndex = 2;
            this.RescheduleRes.Text = "Reschedule Reservation";
            this.RescheduleRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RescheduleRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RescheduleRes.UseVisualStyleBackColor = true;
            this.RescheduleRes.Click += new System.EventHandler(this.RescheduleRes_Click);
            // 
            // AddRes
            // 
            this.AddRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddRes.FlatAppearance.BorderSize = 0;
            this.AddRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRes.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRes.ForeColor = System.Drawing.Color.White;
            this.AddRes.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.AddRes.IconColor = System.Drawing.Color.White;
            this.AddRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddRes.IconSize = 25;
            this.AddRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRes.Location = new System.Drawing.Point(0, 100);
            this.AddRes.Name = "AddRes";
            this.AddRes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AddRes.Size = new System.Drawing.Size(260, 70);
            this.AddRes.TabIndex = 1;
            this.AddRes.Text = "Add Reservation";
            this.AddRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddRes.UseVisualStyleBackColor = true;
            this.AddRes.Click += new System.EventHandler(this.AddRes_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.Image = global::airline_reservation_system.Properties.Resources.airplane_removebg_preview;
            this.Logo.Location = new System.Drawing.Point(50, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(140, 67);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(877, 459);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBox);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Reservation System";
            this.MenuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTitleBox.ResumeLayout(false);
            this.panelTitleBox.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private FontAwesome.Sharp.IconButton AddRes;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton LogOut;
        private FontAwesome.Sharp.IconButton ViewRes;
        private FontAwesome.Sharp.IconButton CancelRes;
        private FontAwesome.Sharp.IconButton RescheduleRes;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panelTitleBox;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}