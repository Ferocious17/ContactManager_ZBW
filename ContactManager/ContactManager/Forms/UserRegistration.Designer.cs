﻿namespace ContactManager.Forms
{
    partial class UserRegistration
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
            checkBoxTrainee = new CheckBox();
            lblBoxPreNameEmp = new Label();
            lblBoxSurNameEmp = new Label();
            lblBoxAdressEmp = new Label();
            lblBoxHouseNumberEmp = new Label();
            lblBoxPLZEmp = new Label();
            lblBoxPlaceEmp = new Label();
            lblBoxSexEmp = new Label();
            lbltxtBoxPhoneNumberEmp = new Label();
            lblBoxMobileNumberEmp = new Label();
            lblBoxEmailAdressEmp = new Label();
            txtBoxPreNameEmp = new MaskedTextBox();
            txtBoxSurNameEmp = new MaskedTextBox();
            txtBoxAdressEmp = new MaskedTextBox();
            txtBoxHouseNumberEmp = new MaskedTextBox();
            txtBoxPhoneNumberEmp = new MaskedTextBox();
            txtBoxSexEmp = new MaskedTextBox();
            txtBoxPlaceEmp = new MaskedTextBox();
            txtBoxPLZEmp = new MaskedTextBox();
            txtBoxEmailAdressEmp = new MaskedTextBox();
            txtBoxMobileNumberEmp = new MaskedTextBox();
            txtBoxErfassungTitel = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSaveEmpoloyeRegistration = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxTrainee
            // 
            checkBoxTrainee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxTrainee.AutoSize = true;
            checkBoxTrainee.Location = new Point(1, 1);
            checkBoxTrainee.Margin = new Padding(1, 1, 1, 1);
            checkBoxTrainee.Name = "checkBoxTrainee";
            checkBoxTrainee.Size = new Size(99, 25);
            checkBoxTrainee.TabIndex = 0;
            checkBoxTrainee.Text = "Trainee";
            checkBoxTrainee.UseVisualStyleBackColor = true;
            checkBoxTrainee.CheckedChanged += checkBoxTrainee_CheckedChanged;
            // 
            // lblBoxPreNameEmp
            // 
            lblBoxPreNameEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBoxPreNameEmp.AutoSize = true;
            lblBoxPreNameEmp.Location = new Point(1, 27);
            lblBoxPreNameEmp.Margin = new Padding(1, 0, 1, 0);
            lblBoxPreNameEmp.Name = "lblBoxPreNameEmp";
            lblBoxPreNameEmp.Size = new Size(99, 27);
            lblBoxPreNameEmp.TabIndex = 2;
            lblBoxPreNameEmp.Text = "Vorname";
            lblBoxPreNameEmp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBoxSurNameEmp
            // 
            lblBoxSurNameEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBoxSurNameEmp.AutoSize = true;
            lblBoxSurNameEmp.Location = new Point(1, 54);
            lblBoxSurNameEmp.Margin = new Padding(1, 0, 1, 0);
            lblBoxSurNameEmp.Name = "lblBoxSurNameEmp";
            lblBoxSurNameEmp.Size = new Size(99, 27);
            lblBoxSurNameEmp.TabIndex = 3;
            lblBoxSurNameEmp.Text = "Nachname";
            lblBoxSurNameEmp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBoxAdressEmp
            // 
            lblBoxAdressEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBoxAdressEmp.AutoSize = true;
            lblBoxAdressEmp.Location = new Point(1, 81);
            lblBoxAdressEmp.Margin = new Padding(1, 0, 1, 0);
            lblBoxAdressEmp.Name = "lblBoxAdressEmp";
            lblBoxAdressEmp.Size = new Size(99, 27);
            lblBoxAdressEmp.TabIndex = 4;
            lblBoxAdressEmp.Text = "Adresse";
            lblBoxAdressEmp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBoxHouseNumberEmp
            // 
            lblBoxHouseNumberEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBoxHouseNumberEmp.AutoSize = true;
            lblBoxHouseNumberEmp.Location = new Point(1, 108);
            lblBoxHouseNumberEmp.Margin = new Padding(1, 0, 1, 0);
            lblBoxHouseNumberEmp.Name = "lblBoxHouseNumberEmp";
            lblBoxHouseNumberEmp.Size = new Size(99, 27);
            lblBoxHouseNumberEmp.TabIndex = 5;
            lblBoxHouseNumberEmp.Text = "Hausnummer";
            lblBoxHouseNumberEmp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBoxPLZEmp
            // 
            lblBoxPLZEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBoxPLZEmp.AutoSize = true;
            lblBoxPLZEmp.Location = new Point(1, 135);
            lblBoxPLZEmp.Margin = new Padding(1, 0, 1, 0);
            lblBoxPLZEmp.Name = "lblBoxPLZEmp";
            lblBoxPLZEmp.Size = new Size(99, 27);
            lblBoxPLZEmp.TabIndex = 6;
            lblBoxPLZEmp.Text = "PLZ";
            lblBoxPLZEmp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBoxPlaceEmp
            // 
            lblBoxPlaceEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBoxPlaceEmp.AutoSize = true;
            lblBoxPlaceEmp.Location = new Point(1, 162);
            lblBoxPlaceEmp.Margin = new Padding(1, 0, 1, 0);
            lblBoxPlaceEmp.Name = "lblBoxPlaceEmp";
            lblBoxPlaceEmp.Size = new Size(99, 27);
            lblBoxPlaceEmp.TabIndex = 7;
            lblBoxPlaceEmp.Text = "Ort";
            lblBoxPlaceEmp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBoxSexEmp
            // 
            lblBoxSexEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBoxSexEmp.AutoSize = true;
            lblBoxSexEmp.Location = new Point(1, 189);
            lblBoxSexEmp.Margin = new Padding(1, 0, 1, 0);
            lblBoxSexEmp.Name = "lblBoxSexEmp";
            lblBoxSexEmp.Size = new Size(99, 27);
            lblBoxSexEmp.TabIndex = 8;
            lblBoxSexEmp.Text = "Geschlecht";
            lblBoxSexEmp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbltxtBoxPhoneNumberEmp
            // 
            lbltxtBoxPhoneNumberEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbltxtBoxPhoneNumberEmp.AutoSize = true;
            lbltxtBoxPhoneNumberEmp.Location = new Point(1, 216);
            lbltxtBoxPhoneNumberEmp.Margin = new Padding(1, 0, 1, 0);
            lbltxtBoxPhoneNumberEmp.Name = "lbltxtBoxPhoneNumberEmp";
            lbltxtBoxPhoneNumberEmp.Size = new Size(99, 27);
            lbltxtBoxPhoneNumberEmp.TabIndex = 9;
            lbltxtBoxPhoneNumberEmp.Text = "Telefonummer";
            lbltxtBoxPhoneNumberEmp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBoxMobileNumberEmp
            // 
            lblBoxMobileNumberEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBoxMobileNumberEmp.AutoSize = true;
            lblBoxMobileNumberEmp.Location = new Point(1, 243);
            lblBoxMobileNumberEmp.Margin = new Padding(1, 0, 1, 0);
            lblBoxMobileNumberEmp.Name = "lblBoxMobileNumberEmp";
            lblBoxMobileNumberEmp.Size = new Size(99, 27);
            lblBoxMobileNumberEmp.TabIndex = 10;
            lblBoxMobileNumberEmp.Text = "Mobilnummer";
            lblBoxMobileNumberEmp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBoxEmailAdressEmp
            // 
            lblBoxEmailAdressEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBoxEmailAdressEmp.AutoSize = true;
            lblBoxEmailAdressEmp.Location = new Point(1, 270);
            lblBoxEmailAdressEmp.Margin = new Padding(1, 0, 1, 0);
            lblBoxEmailAdressEmp.Name = "lblBoxEmailAdressEmp";
            lblBoxEmailAdressEmp.Size = new Size(99, 29);
            lblBoxEmailAdressEmp.TabIndex = 11;
            lblBoxEmailAdressEmp.Text = "Email-Adresse";
            lblBoxEmailAdressEmp.TextAlign = ContentAlignment.MiddleLeft;
            lblBoxEmailAdressEmp.Click += label11_Click;
            // 
            // txtBoxPreNameEmp
            // 
            txtBoxPreNameEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPreNameEmp.Location = new Point(102, 29);
            txtBoxPreNameEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxPreNameEmp.Name = "txtBoxPreNameEmp";
            txtBoxPreNameEmp.Size = new Size(175, 23);
            txtBoxPreNameEmp.TabIndex = 12;
            // 
            // txtBoxSurNameEmp
            // 
            txtBoxSurNameEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxSurNameEmp.Location = new Point(102, 56);
            txtBoxSurNameEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxSurNameEmp.Name = "txtBoxSurNameEmp";
            txtBoxSurNameEmp.Size = new Size(175, 23);
            txtBoxSurNameEmp.TabIndex = 13;
            // 
            // txtBoxAdressEmp
            // 
            txtBoxAdressEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxAdressEmp.Location = new Point(102, 83);
            txtBoxAdressEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxAdressEmp.Name = "txtBoxAdressEmp";
            txtBoxAdressEmp.Size = new Size(175, 23);
            txtBoxAdressEmp.TabIndex = 14;
            // 
            // txtBoxHouseNumberEmp
            // 
            txtBoxHouseNumberEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxHouseNumberEmp.Location = new Point(102, 110);
            txtBoxHouseNumberEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxHouseNumberEmp.Name = "txtBoxHouseNumberEmp";
            txtBoxHouseNumberEmp.Size = new Size(175, 23);
            txtBoxHouseNumberEmp.TabIndex = 15;
            // 
            // txtBoxPhoneNumberEmp
            // 
            txtBoxPhoneNumberEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPhoneNumberEmp.Location = new Point(102, 218);
            txtBoxPhoneNumberEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxPhoneNumberEmp.Name = "txtBoxPhoneNumberEmp";
            txtBoxPhoneNumberEmp.Size = new Size(175, 23);
            txtBoxPhoneNumberEmp.TabIndex = 19;
            // 
            // txtBoxSexEmp
            // 
            txtBoxSexEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxSexEmp.Location = new Point(102, 191);
            txtBoxSexEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxSexEmp.Name = "txtBoxSexEmp";
            txtBoxSexEmp.Size = new Size(175, 23);
            txtBoxSexEmp.TabIndex = 18;
            // 
            // txtBoxPlaceEmp
            // 
            txtBoxPlaceEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPlaceEmp.Location = new Point(102, 164);
            txtBoxPlaceEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxPlaceEmp.Name = "txtBoxPlaceEmp";
            txtBoxPlaceEmp.Size = new Size(175, 23);
            txtBoxPlaceEmp.TabIndex = 17;
            // 
            // txtBoxPLZEmp
            // 
            txtBoxPLZEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPLZEmp.Location = new Point(102, 137);
            txtBoxPLZEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxPLZEmp.Name = "txtBoxPLZEmp";
            txtBoxPLZEmp.Size = new Size(175, 23);
            txtBoxPLZEmp.TabIndex = 16;
            // 
            // txtBoxEmailAdressEmp
            // 
            txtBoxEmailAdressEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxEmailAdressEmp.Location = new Point(102, 273);
            txtBoxEmailAdressEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxEmailAdressEmp.Name = "txtBoxEmailAdressEmp";
            txtBoxEmailAdressEmp.Size = new Size(175, 23);
            txtBoxEmailAdressEmp.TabIndex = 21;
            // 
            // txtBoxMobileNumberEmp
            // 
            txtBoxMobileNumberEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxMobileNumberEmp.Location = new Point(102, 245);
            txtBoxMobileNumberEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxMobileNumberEmp.Name = "txtBoxMobileNumberEmp";
            txtBoxMobileNumberEmp.Size = new Size(175, 23);
            txtBoxMobileNumberEmp.TabIndex = 20;
            // 
            // txtBoxErfassungTitel
            // 
            txtBoxErfassungTitel.Font = new Font("Segoe UI", 15F);
            txtBoxErfassungTitel.Location = new Point(21, 22);
            txtBoxErfassungTitel.Margin = new Padding(1, 1, 1, 1);
            txtBoxErfassungTitel.Multiline = true;
            txtBoxErfassungTitel.Name = "txtBoxErfassungTitel";
            txtBoxErfassungTitel.Size = new Size(283, 35);
            txtBoxErfassungTitel.TabIndex = 22;
            txtBoxErfassungTitel.TabStop = false;
            txtBoxErfassungTitel.Text = "MITARBEITER ERFASSUNG";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.6442947F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.3557053F));
            tableLayoutPanel1.Controls.Add(lblBoxPreNameEmp, 0, 1);
            tableLayoutPanel1.Controls.Add(lblBoxSurNameEmp, 0, 2);
            tableLayoutPanel1.Controls.Add(checkBoxTrainee, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBoxEmailAdressEmp, 1, 10);
            tableLayoutPanel1.Controls.Add(lblBoxAdressEmp, 0, 3);
            tableLayoutPanel1.Controls.Add(txtBoxMobileNumberEmp, 1, 9);
            tableLayoutPanel1.Controls.Add(lblBoxHouseNumberEmp, 0, 4);
            tableLayoutPanel1.Controls.Add(txtBoxPhoneNumberEmp, 1, 8);
            tableLayoutPanel1.Controls.Add(lblBoxPLZEmp, 0, 5);
            tableLayoutPanel1.Controls.Add(txtBoxSexEmp, 1, 7);
            tableLayoutPanel1.Controls.Add(lblBoxPlaceEmp, 0, 6);
            tableLayoutPanel1.Controls.Add(txtBoxPlaceEmp, 1, 6);
            tableLayoutPanel1.Controls.Add(lblBoxSexEmp, 0, 7);
            tableLayoutPanel1.Controls.Add(txtBoxPLZEmp, 1, 5);
            tableLayoutPanel1.Controls.Add(lbltxtBoxPhoneNumberEmp, 0, 8);
            tableLayoutPanel1.Controls.Add(txtBoxHouseNumberEmp, 1, 4);
            tableLayoutPanel1.Controls.Add(lblBoxMobileNumberEmp, 0, 9);
            tableLayoutPanel1.Controls.Add(txtBoxAdressEmp, 1, 3);
            tableLayoutPanel1.Controls.Add(txtBoxSurNameEmp, 1, 2);
            tableLayoutPanel1.Controls.Add(txtBoxPreNameEmp, 1, 1);
            tableLayoutPanel1.Controls.Add(lblBoxEmailAdressEmp, 0, 10);
            tableLayoutPanel1.Location = new Point(24, 73);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.Size = new Size(278, 299);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // btnSaveEmpoloyeRegistration
            // 
            btnSaveEmpoloyeRegistration.Location = new Point(330, 349);
            btnSaveEmpoloyeRegistration.Margin = new Padding(1, 1, 1, 1);
            btnSaveEmpoloyeRegistration.Name = "btnSaveEmpoloyeRegistration";
            btnSaveEmpoloyeRegistration.Size = new Size(103, 30);
            btnSaveEmpoloyeRegistration.TabIndex = 24;
            btnSaveEmpoloyeRegistration.Text = "Speichern";
            btnSaveEmpoloyeRegistration.UseVisualStyleBackColor = true;
            // 
            // UserRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(502, 388);
            Controls.Add(btnSaveEmpoloyeRegistration);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtBoxErfassungTitel);
            Margin = new Padding(1, 1, 1, 1);
            Name = "UserRegistration";
            Text = "Mitarbeitererfassung";
            Load += UserRegistration_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxTrainee;
        private Label lblBoxPreNameEmp;
        private Label lblBoxSurNameEmp;
        private Label lblBoxAdressEmp;
        private Label lblBoxHouseNumberEmp;
        private Label lblBoxPLZEmp;
        private Label lblBoxPlaceEmp;
        private Label lblBoxSexEmp;
        private Label lbltxtBoxPhoneNumberEmp;
        private Label lblBoxMobileNumberEmp;
        private Label lblBoxEmailAdressEmp;
        private MaskedTextBox txtBoxPreNameEmp;
        private MaskedTextBox txtBoxSurNameEmp;
        private MaskedTextBox txtBoxAdressEmp;
        private MaskedTextBox txtBoxHouseNumberEmp;
        private MaskedTextBox txtBoxPhoneNumberEmp;
        private MaskedTextBox txtBoxSexEmp;
        private MaskedTextBox txtBoxPlaceEmp;
        private MaskedTextBox txtBoxPLZEmp;
        private MaskedTextBox txtBoxEmailAdressEmp;
        private MaskedTextBox txtBoxMobileNumberEmp;
        private TextBox txtBoxErfassungTitel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSaveEmpoloyeRegistration;
    }
}