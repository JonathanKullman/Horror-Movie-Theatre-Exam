﻿
namespace GUI
{
    partial class PickedMovieForm
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
            this.pBoxSelectedMovie = new System.Windows.Forms.PictureBox();
            this.tBoxMovieSummary = new System.Windows.Forms.TextBox();
            this.panelCustomerInput = new System.Windows.Forms.Panel();
            this.pBoxCheckboxTickets = new System.Windows.Forms.PictureBox();
            this.cBoxChooseTicketAmount = new System.Windows.Forms.ComboBox();
            this.btnBookNow = new System.Windows.Forms.Button();
            this.pBoxBookedApprovedGif = new System.Windows.Forms.PictureBox();
            this.pBoxPhoneNumberValidCheckgif = new System.Windows.Forms.PictureBox();
            this.pBoxLastNameValidCheckgif = new System.Windows.Forms.PictureBox();
            this.pBoxFirstNameValidCheckgif = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblChooseTime = new System.Windows.Forms.Label();
            this.lblWheelChair = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.chBoxWheelChairYes = new System.Windows.Forms.CheckBox();
            this.chBoxWheelChairNO = new System.Windows.Forms.CheckBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tBoxLastName = new System.Windows.Forms.TextBox();
            this.tBoxFirstName = new System.Windows.Forms.TextBox();
            this.panelTicketSeatHallInfo = new System.Windows.Forms.Panel();
            this.lblTheatreHallChange = new System.Windows.Forms.Label();
            this.lblTheatreHallText = new System.Windows.Forms.Label();
            this.lblTicketsLeftChange = new System.Windows.Forms.Label();
            this.lblTicketsLeftText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSelectedMovie)).BeginInit();
            this.panelCustomerInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCheckboxTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBookedApprovedGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoneNumberValidCheckgif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLastNameValidCheckgif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFirstNameValidCheckgif)).BeginInit();
            this.panelTicketSeatHallInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBoxSelectedMovie
            // 
            this.pBoxSelectedMovie.Location = new System.Drawing.Point(5, 7);
            this.pBoxSelectedMovie.Name = "pBoxSelectedMovie";
            this.pBoxSelectedMovie.Size = new System.Drawing.Size(218, 337);
            this.pBoxSelectedMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxSelectedMovie.TabIndex = 0;
            this.pBoxSelectedMovie.TabStop = false;
            // 
            // tBoxMovieSummary
            // 
            this.tBoxMovieSummary.Location = new System.Drawing.Point(240, 12);
            this.tBoxMovieSummary.Multiline = true;
            this.tBoxMovieSummary.Name = "tBoxMovieSummary";
            this.tBoxMovieSummary.Size = new System.Drawing.Size(335, 140);
            this.tBoxMovieSummary.TabIndex = 8;
            // 
            // panelCustomerInput
            // 
            this.panelCustomerInput.Controls.Add(this.pBoxPhoneNumberValidCheckgif);
            this.panelCustomerInput.Controls.Add(this.tBoxPhoneNumber);
            this.panelCustomerInput.Controls.Add(this.pBoxCheckboxTickets);
            this.panelCustomerInput.Controls.Add(this.cBoxChooseTicketAmount);
            this.panelCustomerInput.Controls.Add(this.btnBookNow);
            this.panelCustomerInput.Controls.Add(this.pBoxBookedApprovedGif);
            this.panelCustomerInput.Controls.Add(this.pBoxLastNameValidCheckgif);
            this.panelCustomerInput.Controls.Add(this.pBoxFirstNameValidCheckgif);
            this.panelCustomerInput.Controls.Add(this.comboBox1);
            this.panelCustomerInput.Controls.Add(this.lblChooseTime);
            this.panelCustomerInput.Controls.Add(this.lblWheelChair);
            this.panelCustomerInput.Controls.Add(this.lblTickets);
            this.panelCustomerInput.Controls.Add(this.chBoxWheelChairYes);
            this.panelCustomerInput.Controls.Add(this.chBoxWheelChairNO);
            this.panelCustomerInput.Controls.Add(this.lblPhoneNumber);
            this.panelCustomerInput.Controls.Add(this.lblLastName);
            this.panelCustomerInput.Controls.Add(this.lblFirstName);
            this.panelCustomerInput.Controls.Add(this.tBoxLastName);
            this.panelCustomerInput.Controls.Add(this.tBoxFirstName);
            this.panelCustomerInput.Location = new System.Drawing.Point(240, 158);
            this.panelCustomerInput.Name = "panelCustomerInput";
            this.panelCustomerInput.Size = new System.Drawing.Size(383, 403);
            this.panelCustomerInput.TabIndex = 9;
            // 
            // pBoxCheckboxTickets
            // 
            this.pBoxCheckboxTickets.Image = global::GUI.Properties.Resources.CheckmarkIcon;
            this.pBoxCheckboxTickets.Location = new System.Drawing.Point(318, 262);
            this.pBoxCheckboxTickets.Name = "pBoxCheckboxTickets";
            this.pBoxCheckboxTickets.Size = new System.Drawing.Size(35, 32);
            this.pBoxCheckboxTickets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCheckboxTickets.TabIndex = 17;
            this.pBoxCheckboxTickets.TabStop = false;
            this.pBoxCheckboxTickets.Visible = false;
            // 
            // cBoxChooseTicketAmount
            // 
            this.cBoxChooseTicketAmount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cBoxChooseTicketAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cBoxChooseTicketAmount.FormattingEnabled = true;
            this.cBoxChooseTicketAmount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.cBoxChooseTicketAmount.Location = new System.Drawing.Point(152, 262);
            this.cBoxChooseTicketAmount.Name = "cBoxChooseTicketAmount";
            this.cBoxChooseTicketAmount.Size = new System.Drawing.Size(150, 33);
            this.cBoxChooseTicketAmount.TabIndex = 7;
            this.cBoxChooseTicketAmount.Visible = false;
            this.cBoxChooseTicketAmount.SelectedIndexChanged += new System.EventHandler(this.cBoxChooseTicketAmount_SelectedIndexChanged);
            // 
            // btnBookNow
            // 
            this.btnBookNow.BackColor = System.Drawing.SystemColors.Info;
            this.btnBookNow.Enabled = false;
            this.btnBookNow.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBookNow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBookNow.Location = new System.Drawing.Point(91, 322);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(143, 46);
            this.btnBookNow.TabIndex = 8;
            this.btnBookNow.Text = "Book Now";
            this.btnBookNow.UseVisualStyleBackColor = false;
            this.btnBookNow.Visible = false;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // pBoxBookedApprovedGif
            // 
            this.pBoxBookedApprovedGif.Image = global::GUI.Properties.Resources.Checkmarkgif;
            this.pBoxBookedApprovedGif.Location = new System.Drawing.Point(188, 242);
            this.pBoxBookedApprovedGif.Name = "pBoxBookedApprovedGif";
            this.pBoxBookedApprovedGif.Size = new System.Drawing.Size(210, 205);
            this.pBoxBookedApprovedGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxBookedApprovedGif.TabIndex = 18;
            this.pBoxBookedApprovedGif.TabStop = false;
            this.pBoxBookedApprovedGif.Visible = false;
            // 
            // pBoxPhoneNumberValidCheckgif
            // 
            this.pBoxPhoneNumberValidCheckgif.Image = global::GUI.Properties.Resources.CheckmarkIcon;
            this.pBoxPhoneNumberValidCheckgif.Location = new System.Drawing.Point(318, 208);
            this.pBoxPhoneNumberValidCheckgif.Name = "pBoxPhoneNumberValidCheckgif";
            this.pBoxPhoneNumberValidCheckgif.Size = new System.Drawing.Size(35, 32);
            this.pBoxPhoneNumberValidCheckgif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxPhoneNumberValidCheckgif.TabIndex = 16;
            this.pBoxPhoneNumberValidCheckgif.TabStop = false;
            this.pBoxPhoneNumberValidCheckgif.Visible = false;
            // 
            // pBoxLastNameValidCheckgif
            // 
            this.pBoxLastNameValidCheckgif.Image = global::GUI.Properties.Resources.CheckmarkIcon;
            this.pBoxLastNameValidCheckgif.Location = new System.Drawing.Point(318, 160);
            this.pBoxLastNameValidCheckgif.Name = "pBoxLastNameValidCheckgif";
            this.pBoxLastNameValidCheckgif.Size = new System.Drawing.Size(35, 32);
            this.pBoxLastNameValidCheckgif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLastNameValidCheckgif.TabIndex = 15;
            this.pBoxLastNameValidCheckgif.TabStop = false;
            this.pBoxLastNameValidCheckgif.Visible = false;
            // 
            // pBoxFirstNameValidCheckgif
            // 
            this.pBoxFirstNameValidCheckgif.Image = global::GUI.Properties.Resources.CheckmarkIcon;
            this.pBoxFirstNameValidCheckgif.Location = new System.Drawing.Point(318, 111);
            this.pBoxFirstNameValidCheckgif.Name = "pBoxFirstNameValidCheckgif";
            this.pBoxFirstNameValidCheckgif.Size = new System.Drawing.Size(35, 32);
            this.pBoxFirstNameValidCheckgif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxFirstNameValidCheckgif.TabIndex = 14;
            this.pBoxFirstNameValidCheckgif.TabStop = false;
            this.pBoxFirstNameValidCheckgif.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "20:00 - 22:00",
            "22:00 - 00:00",
            "00:00 - 02:00",
            "02:00 - 04:00"});
            this.comboBox1.Location = new System.Drawing.Point(152, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 33);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblChooseTime
            // 
            this.lblChooseTime.AutoSize = true;
            this.lblChooseTime.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseTime.Location = new System.Drawing.Point(54, 65);
            this.lblChooseTime.Name = "lblChooseTime";
            this.lblChooseTime.Size = new System.Drawing.Size(49, 22);
            this.lblChooseTime.TabIndex = 12;
            this.lblChooseTime.Text = "Time:";
            // 
            // lblWheelChair
            // 
            this.lblWheelChair.AutoSize = true;
            this.lblWheelChair.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWheelChair.Location = new System.Drawing.Point(35, 21);
            this.lblWheelChair.Name = "lblWheelChair";
            this.lblWheelChair.Size = new System.Drawing.Size(96, 22);
            this.lblWheelChair.TabIndex = 10;
            this.lblWheelChair.Text = "WheelChair";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTickets.Location = new System.Drawing.Point(54, 267);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(63, 22);
            this.lblTickets.TabIndex = 7;
            this.lblTickets.Text = "Tickets";
            this.lblTickets.Visible = false;
            // 
            // chBoxWheelChairYes
            // 
            this.chBoxWheelChairYes.AutoSize = true;
            this.chBoxWheelChairYes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.chBoxWheelChairYes.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chBoxWheelChairYes.Location = new System.Drawing.Point(152, 20);
            this.chBoxWheelChairYes.Name = "chBoxWheelChairYes";
            this.chBoxWheelChairYes.Size = new System.Drawing.Size(61, 26);
            this.chBoxWheelChairYes.TabIndex = 1;
            this.chBoxWheelChairYes.Text = "Yes";
            this.chBoxWheelChairYes.UseVisualStyleBackColor = false;
            this.chBoxWheelChairYes.CheckedChanged += new System.EventHandler(this.chBoxWheelChairYes_CheckedChanged);
            // 
            // chBoxWheelChairNO
            // 
            this.chBoxWheelChairNO.AutoSize = true;
            this.chBoxWheelChairNO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.chBoxWheelChairNO.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chBoxWheelChairNO.Location = new System.Drawing.Point(241, 20);
            this.chBoxWheelChairNO.Name = "chBoxWheelChairNO";
            this.chBoxWheelChairNO.Size = new System.Drawing.Size(55, 26);
            this.chBoxWheelChairNO.TabIndex = 2;
            this.chBoxWheelChairNO.Text = "No";
            this.chBoxWheelChairNO.UseVisualStyleBackColor = false;
            this.chBoxWheelChairNO.CheckedChanged += new System.EventHandler(this.chBoxWheelChairNO_CheckedChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.Location = new System.Drawing.Point(23, 212);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(114, 22);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(36, 164);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 22);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(35, 115);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(85, 22);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Visible = false;
            // 
            // tBoxPhoneNumber
            // 
            this.tBoxPhoneNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tBoxPhoneNumber.Location = new System.Drawing.Point(152, 208);
            this.tBoxPhoneNumber.Name = "tBoxPhoneNumber";
            this.tBoxPhoneNumber.Size = new System.Drawing.Size(150, 31);
            this.tBoxPhoneNumber.TabIndex = 6;
            this.tBoxPhoneNumber.Visible = false;
            this.tBoxPhoneNumber.TextChanged += new System.EventHandler(this.tBoxPhoneNumber_TextChanged);
            // 
            // tBoxLastName
            // 
            this.tBoxLastName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tBoxLastName.Location = new System.Drawing.Point(152, 162);
            this.tBoxLastName.Name = "tBoxLastName";
            this.tBoxLastName.Size = new System.Drawing.Size(150, 31);
            this.tBoxLastName.TabIndex = 5;
            this.tBoxLastName.Visible = false;
            this.tBoxLastName.TextChanged += new System.EventHandler(this.tBoxLastName_TextChanged);
            // 
            // tBoxFirstName
            // 
            this.tBoxFirstName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tBoxFirstName.Location = new System.Drawing.Point(152, 111);
            this.tBoxFirstName.Name = "tBoxFirstName";
            this.tBoxFirstName.Size = new System.Drawing.Size(150, 31);
            this.tBoxFirstName.TabIndex = 4;
            this.tBoxFirstName.Visible = false;
            this.tBoxFirstName.TextChanged += new System.EventHandler(this.tBoxFirstName_TextChanged);
            // 
            // panelTicketSeatHallInfo
            // 
            this.panelTicketSeatHallInfo.Controls.Add(this.lblTheatreHallChange);
            this.panelTicketSeatHallInfo.Controls.Add(this.lblTheatreHallText);
            this.panelTicketSeatHallInfo.Controls.Add(this.lblTicketsLeftChange);
            this.panelTicketSeatHallInfo.Controls.Add(this.lblTicketsLeftText);
            this.panelTicketSeatHallInfo.Location = new System.Drawing.Point(5, 364);
            this.panelTicketSeatHallInfo.Name = "panelTicketSeatHallInfo";
            this.panelTicketSeatHallInfo.Size = new System.Drawing.Size(218, 285);
            this.panelTicketSeatHallInfo.TabIndex = 10;
            // 
            // lblTheatreHallChange
            // 
            this.lblTheatreHallChange.AutoSize = true;
            this.lblTheatreHallChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTheatreHallChange.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTheatreHallChange.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTheatreHallChange.Location = new System.Drawing.Point(98, 116);
            this.lblTheatreHallChange.Name = "lblTheatreHallChange";
            this.lblTheatreHallChange.Size = new System.Drawing.Size(27, 27);
            this.lblTheatreHallChange.TabIndex = 3;
            this.lblTheatreHallChange.Text = "0";
            this.lblTheatreHallChange.Visible = false;
            // 
            // lblTheatreHallText
            // 
            this.lblTheatreHallText.AutoSize = true;
            this.lblTheatreHallText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTheatreHallText.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTheatreHallText.Location = new System.Drawing.Point(32, 89);
            this.lblTheatreHallText.Name = "lblTheatreHallText";
            this.lblTheatreHallText.Size = new System.Drawing.Size(170, 27);
            this.lblTheatreHallText.TabIndex = 2;
            this.lblTheatreHallText.Text = "Theatre Hall: ";
            this.lblTheatreHallText.Visible = false;
            // 
            // lblTicketsLeftChange
            // 
            this.lblTicketsLeftChange.AutoSize = true;
            this.lblTicketsLeftChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTicketsLeftChange.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketsLeftChange.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTicketsLeftChange.Location = new System.Drawing.Point(99, 39);
            this.lblTicketsLeftChange.Name = "lblTicketsLeftChange";
            this.lblTicketsLeftChange.Size = new System.Drawing.Size(27, 27);
            this.lblTicketsLeftChange.TabIndex = 1;
            this.lblTicketsLeftChange.Text = "0";
            this.lblTicketsLeftChange.Visible = false;
            // 
            // lblTicketsLeftText
            // 
            this.lblTicketsLeftText.AutoSize = true;
            this.lblTicketsLeftText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTicketsLeftText.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketsLeftText.Location = new System.Drawing.Point(38, 12);
            this.lblTicketsLeftText.Name = "lblTicketsLeftText";
            this.lblTicketsLeftText.Size = new System.Drawing.Size(160, 27);
            this.lblTicketsLeftText.TabIndex = 0;
            this.lblTicketsLeftText.Text = "Tickets Left: ";
            this.lblTicketsLeftText.Visible = false;
            // 
            // PickedMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(775, 661);
            this.Controls.Add(this.panelTicketSeatHallInfo);
            this.Controls.Add(this.panelCustomerInput);
            this.Controls.Add(this.tBoxMovieSummary);
            this.Controls.Add(this.pBoxSelectedMovie);
            this.Name = "PickedMovieForm";
            this.Text = "Horror Movie Theatre Booker";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSelectedMovie)).EndInit();
            this.panelCustomerInput.ResumeLayout(false);
            this.panelCustomerInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCheckboxTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBookedApprovedGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoneNumberValidCheckgif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLastNameValidCheckgif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFirstNameValidCheckgif)).EndInit();
            this.panelTicketSeatHallInfo.ResumeLayout(false);
            this.panelTicketSeatHallInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxSelectedMovie;
        private System.Windows.Forms.TextBox tBoxMovieSummary;
        private System.Windows.Forms.Panel panelCustomerInput;
        private System.Windows.Forms.TextBox tBoxPhoneNumber;
        private System.Windows.Forms.TextBox tBoxLastName;
        private System.Windows.Forms.TextBox tBoxFirstName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnBookNow;
        private System.Windows.Forms.Label lblWheelChair;
        private System.Windows.Forms.CheckBox chBoxWheelChairNO;
        private System.Windows.Forms.CheckBox chBoxWheelChairYes;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.ComboBox cBoxChooseTicketAmount;
        private System.Windows.Forms.Panel panelTicketSeatHallInfo;
        private System.Windows.Forms.Label lblTheatreHallChange;
        private System.Windows.Forms.Label lblTheatreHallText;
        private System.Windows.Forms.Label lblTicketsLeftChange;
        private System.Windows.Forms.Label lblTicketsLeftText;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblChooseTime;
        private System.Windows.Forms.PictureBox pBoxFirstNameValidCheckgif;
        private System.Windows.Forms.PictureBox pBoxPhoneNumberValidCheckgif;
        private System.Windows.Forms.PictureBox pBoxLastNameValidCheckgif;
        private System.Windows.Forms.PictureBox pBoxCheckboxTickets;
        private System.Windows.Forms.PictureBox pBoxBookedApprovedGif;
    }
}