﻿
namespace GUI
{
    partial class CancelBookingForm
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
            this.panelFilledBackground = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNotFoundPhoneNumber = new System.Windows.Forms.Label();
            this.pBoxSearchPNumberValidOrNot = new System.Windows.Forms.PictureBox();
            this.lblSearchBarHeader = new System.Windows.Forms.Label();
            this.tBoxSearchBar = new System.Windows.Forms.TextBox();
            this.pBoxSearchBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFilledBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSearchPNumberValidOrNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSearchBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilledBackground
            // 
            this.panelFilledBackground.Controls.Add(this.label2);
            this.panelFilledBackground.Controls.Add(this.lblNotFoundPhoneNumber);
            this.panelFilledBackground.Controls.Add(this.pBoxSearchPNumberValidOrNot);
            this.panelFilledBackground.Controls.Add(this.lblSearchBarHeader);
            this.panelFilledBackground.Controls.Add(this.tBoxSearchBar);
            this.panelFilledBackground.Controls.Add(this.pBoxSearchBar);
            this.panelFilledBackground.Controls.Add(this.label1);
            this.panelFilledBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilledBackground.Location = new System.Drawing.Point(0, 0);
            this.panelFilledBackground.Name = "panelFilledBackground";
            this.panelFilledBackground.Size = new System.Drawing.Size(711, 397);
            this.panelFilledBackground.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(283, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Phone Number";
            // 
            // lblNotFoundPhoneNumber
            // 
            this.lblNotFoundPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotFoundPhoneNumber.AutoSize = true;
            this.lblNotFoundPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotFoundPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.lblNotFoundPhoneNumber.Location = new System.Drawing.Point(174, 192);
            this.lblNotFoundPhoneNumber.Name = "lblNotFoundPhoneNumber";
            this.lblNotFoundPhoneNumber.Size = new System.Drawing.Size(412, 21);
            this.lblNotFoundPhoneNumber.TabIndex = 5;
            this.lblNotFoundPhoneNumber.Text = "Sorry! Could not find a booking on that phone number.";
            this.lblNotFoundPhoneNumber.Visible = false;
            // 
            // pBoxSearchPNumberValidOrNot
            // 
            this.pBoxSearchPNumberValidOrNot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBoxSearchPNumberValidOrNot.Location = new System.Drawing.Point(484, 139);
            this.pBoxSearchPNumberValidOrNot.Name = "pBoxSearchPNumberValidOrNot";
            this.pBoxSearchPNumberValidOrNot.Size = new System.Drawing.Size(33, 35);
            this.pBoxSearchPNumberValidOrNot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxSearchPNumberValidOrNot.TabIndex = 5;
            this.pBoxSearchPNumberValidOrNot.TabStop = false;
            this.pBoxSearchPNumberValidOrNot.Visible = false;
            // 
            // lblSearchBarHeader
            // 
            this.lblSearchBarHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchBarHeader.AutoSize = true;
            this.lblSearchBarHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchBarHeader.Location = new System.Drawing.Point(309, 63);
            this.lblSearchBarHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchBarHeader.Name = "lblSearchBarHeader";
            this.lblSearchBarHeader.Size = new System.Drawing.Size(108, 40);
            this.lblSearchBarHeader.TabIndex = 2;
            this.lblSearchBarHeader.Text = "Search";
            // 
            // tBoxSearchBar
            // 
            this.tBoxSearchBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxSearchBar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxSearchBar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tBoxSearchBar.Location = new System.Drawing.Point(261, 144);
            this.tBoxSearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxSearchBar.MaxLength = 15;
            this.tBoxSearchBar.Name = "tBoxSearchBar";
            this.tBoxSearchBar.Size = new System.Drawing.Size(166, 26);
            this.tBoxSearchBar.TabIndex = 1;
            this.tBoxSearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxSearchBar.TextChanged += new System.EventHandler(this.tBoxSearchBar_TextChanged);
            this.tBoxSearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxSearchBar_KeyPress);
            // 
            // pBoxSearchBar
            // 
            this.pBoxSearchBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBoxSearchBar.Image = global::GUI.Properties.Resources.searchbar3;
            this.pBoxSearchBar.Location = new System.Drawing.Point(238, 40);
            this.pBoxSearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxSearchBar.Name = "pBoxSearchBar";
            this.pBoxSearchBar.Size = new System.Drawing.Size(250, 233);
            this.pBoxSearchBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxSearchBar.TabIndex = 0;
            this.pBoxSearchBar.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(283, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "by phone number";
            // 
            // CancelBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 397);
            this.Controls.Add(this.panelFilledBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CancelBookingForm";
            this.Text = "Form4";
            this.panelFilledBackground.ResumeLayout(false);
            this.panelFilledBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSearchPNumberValidOrNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSearchBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilledBackground;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNotFoundPhoneNumber;
        private System.Windows.Forms.PictureBox pBoxSearchPNumberValidOrNot;
        private System.Windows.Forms.Label lblSearchBarHeader;
        private System.Windows.Forms.TextBox tBoxSearchBar;
        private System.Windows.Forms.PictureBox pBoxSearchBar;
        private System.Windows.Forms.Label label1;
    }
}