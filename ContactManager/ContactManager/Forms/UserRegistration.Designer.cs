namespace ContactManager.Forms
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
            LblEmployeeFirstname = new Label();
            LblEmployeeLastname = new Label();
            lblBoxAdressEmp = new Label();
            LblEmployeeStreetnumber = new Label();
            LblEmployeeZIPcode = new Label();
            LblEmployeePlace = new Label();
            LblEmployeeSex = new Label();
            TxtEmployeePhonenumber = new Label();
            TxtEmployeeMobilenumber = new Label();
            TxtEmployeeEmail = new Label();
            TxtEmployeeFirstname = new MaskedTextBox();
            TxtEmployeeLastname = new MaskedTextBox();
            TxtEmployeeAddress = new MaskedTextBox();
            TxtEmployeeStreetnumber = new MaskedTextBox();
            txtBoxPhoneNumberEmp = new MaskedTextBox();
            TxtEmployeeSex = new MaskedTextBox();
            TxtEmployeePlace = new MaskedTextBox();
            TxtEmployeeZIPcode = new MaskedTextBox();
            txtBoxEmailAdressEmp = new MaskedTextBox();
            txtBoxMobileNumberEmp = new MaskedTextBox();
            TxtTitleEmployeeRegistration = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSaveEmpoloyeRegistration = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxTrainee
            // 
            checkBoxTrainee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxTrainee.AutoSize = true;
            checkBoxTrainee.Location = new Point(1, 2);
            checkBoxTrainee.Margin = new Padding(1, 2, 1, 2);
            checkBoxTrainee.Name = "checkBoxTrainee";
            checkBoxTrainee.Size = new Size(143, 41);
            checkBoxTrainee.TabIndex = 0;
            checkBoxTrainee.Text = "Trainee";
            checkBoxTrainee.UseVisualStyleBackColor = true;
            checkBoxTrainee.CheckedChanged += checkBoxTrainee_CheckedChanged;
            // 
            // LblEmployeeFirstname
            // 
            LblEmployeeFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeFirstname.AutoSize = true;
            LblEmployeeFirstname.Location = new Point(1, 45);
            LblEmployeeFirstname.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeFirstname.Name = "LblEmployeeFirstname";
            LblEmployeeFirstname.Size = new Size(143, 45);
            LblEmployeeFirstname.TabIndex = 2;
            LblEmployeeFirstname.Text = "Vorname";
            LblEmployeeFirstname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeLastname
            // 
            LblEmployeeLastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeLastname.AutoSize = true;
            LblEmployeeLastname.Location = new Point(1, 90);
            LblEmployeeLastname.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeLastname.Name = "LblEmployeeLastname";
            LblEmployeeLastname.Size = new Size(143, 45);
            LblEmployeeLastname.TabIndex = 3;
            LblEmployeeLastname.Text = "Nachname";
            LblEmployeeLastname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBoxAdressEmp
            // 
            lblBoxAdressEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBoxAdressEmp.AutoSize = true;
            lblBoxAdressEmp.Location = new Point(1, 135);
            lblBoxAdressEmp.Margin = new Padding(1, 0, 1, 0);
            lblBoxAdressEmp.Name = "lblBoxAdressEmp";
            lblBoxAdressEmp.Size = new Size(143, 45);
            lblBoxAdressEmp.TabIndex = 4;
            lblBoxAdressEmp.Text = "Adresse";
            lblBoxAdressEmp.TextAlign = ContentAlignment.MiddleLeft;
            lblBoxAdressEmp.Click += lblBoxAdressEmp_Click;
            // 
            // LblEmployeeStreetnumber
            // 
            LblEmployeeStreetnumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeStreetnumber.AutoSize = true;
            LblEmployeeStreetnumber.Location = new Point(1, 180);
            LblEmployeeStreetnumber.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeStreetnumber.Name = "LblEmployeeStreetnumber";
            LblEmployeeStreetnumber.Size = new Size(143, 45);
            LblEmployeeStreetnumber.TabIndex = 5;
            LblEmployeeStreetnumber.Text = "Hausnummer";
            LblEmployeeStreetnumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeZIPcode
            // 
            LblEmployeeZIPcode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeZIPcode.AutoSize = true;
            LblEmployeeZIPcode.Location = new Point(1, 225);
            LblEmployeeZIPcode.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeZIPcode.Name = "LblEmployeeZIPcode";
            LblEmployeeZIPcode.Size = new Size(143, 45);
            LblEmployeeZIPcode.TabIndex = 6;
            LblEmployeeZIPcode.Text = "PLZ";
            LblEmployeeZIPcode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeePlace
            // 
            LblEmployeePlace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeePlace.AutoSize = true;
            LblEmployeePlace.Location = new Point(1, 270);
            LblEmployeePlace.Margin = new Padding(1, 0, 1, 0);
            LblEmployeePlace.Name = "LblEmployeePlace";
            LblEmployeePlace.Size = new Size(143, 45);
            LblEmployeePlace.TabIndex = 7;
            LblEmployeePlace.Text = "Ort";
            LblEmployeePlace.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeSex
            // 
            LblEmployeeSex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeSex.AutoSize = true;
            LblEmployeeSex.Location = new Point(1, 315);
            LblEmployeeSex.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeSex.Name = "LblEmployeeSex";
            LblEmployeeSex.Size = new Size(143, 45);
            LblEmployeeSex.TabIndex = 8;
            LblEmployeeSex.Text = "Geschlecht";
            LblEmployeeSex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeePhonenumber
            // 
            TxtEmployeePhonenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeePhonenumber.AutoSize = true;
            TxtEmployeePhonenumber.Location = new Point(1, 360);
            TxtEmployeePhonenumber.Margin = new Padding(1, 0, 1, 0);
            TxtEmployeePhonenumber.Name = "TxtEmployeePhonenumber";
            TxtEmployeePhonenumber.Size = new Size(143, 45);
            TxtEmployeePhonenumber.TabIndex = 9;
            TxtEmployeePhonenumber.Text = "Telefonummer";
            TxtEmployeePhonenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeMobilenumber
            // 
            TxtEmployeeMobilenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeMobilenumber.AutoSize = true;
            TxtEmployeeMobilenumber.Location = new Point(1, 405);
            TxtEmployeeMobilenumber.Margin = new Padding(1, 0, 1, 0);
            TxtEmployeeMobilenumber.Name = "TxtEmployeeMobilenumber";
            TxtEmployeeMobilenumber.Size = new Size(143, 45);
            TxtEmployeeMobilenumber.TabIndex = 10;
            TxtEmployeeMobilenumber.Text = "Mobilnummer";
            TxtEmployeeMobilenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeEmail
            // 
            TxtEmployeeEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeEmail.AutoSize = true;
            TxtEmployeeEmail.Location = new Point(1, 450);
            TxtEmployeeEmail.Margin = new Padding(1, 0, 1, 0);
            TxtEmployeeEmail.Name = "TxtEmployeeEmail";
            TxtEmployeeEmail.Size = new Size(143, 48);
            TxtEmployeeEmail.TabIndex = 11;
            TxtEmployeeEmail.Text = "Email-Adresse";
            TxtEmployeeEmail.TextAlign = ContentAlignment.MiddleLeft;
            TxtEmployeeEmail.Click += label11_Click;
            // 
            // TxtEmployeeFirstname
            // 
            txtBoxPreNameEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPreNameEmp.Location = new Point(102, 29);
            txtBoxPreNameEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxPreNameEmp.Name = "txtBoxPreNameEmp";
            txtBoxPreNameEmp.Size = new Size(175, 23);
            txtBoxPreNameEmp.TabIndex = 12;
            // 
            // TxtEmployeeLastname
            // 
            txtBoxSurNameEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxSurNameEmp.Location = new Point(102, 56);
            txtBoxSurNameEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxSurNameEmp.Name = "txtBoxSurNameEmp";
            txtBoxSurNameEmp.Size = new Size(175, 23);
            txtBoxSurNameEmp.TabIndex = 13;
            // 
            // TxtEmployeeAddress
            // 
            txtBoxAdressEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxAdressEmp.Location = new Point(102, 83);
            txtBoxAdressEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxAdressEmp.Name = "txtBoxAdressEmp";
            txtBoxAdressEmp.Size = new Size(175, 23);
            txtBoxAdressEmp.TabIndex = 14;
            // 
            // TxtEmployeeStreetnumber
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
            txtBoxPhoneNumberEmp.Size = new Size(250, 31);
            txtBoxPhoneNumberEmp.TabIndex = 19;
            // 
            // TxtEmployeeSex
            // 
            txtBoxSexEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxSexEmp.Location = new Point(102, 191);
            txtBoxSexEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxSexEmp.Name = "txtBoxSexEmp";
            txtBoxSexEmp.Size = new Size(175, 23);
            txtBoxSexEmp.TabIndex = 18;
            // 
            // TxtEmployeePlace
            // 
            txtBoxPlaceEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPlaceEmp.Location = new Point(102, 164);
            txtBoxPlaceEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxPlaceEmp.Name = "txtBoxPlaceEmp";
            txtBoxPlaceEmp.Size = new Size(175, 23);
            txtBoxPlaceEmp.TabIndex = 17;
            // 
            // TxtEmployeeZIPcode
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
            txtBoxEmailAdressEmp.Size = new Size(250, 31);
            txtBoxEmailAdressEmp.TabIndex = 21;
            // 
            // txtBoxMobileNumberEmp
            // 
            txtBoxMobileNumberEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxMobileNumberEmp.Location = new Point(102, 245);
            txtBoxMobileNumberEmp.Margin = new Padding(1, 1, 1, 1);
            txtBoxMobileNumberEmp.Name = "txtBoxMobileNumberEmp";
            txtBoxMobileNumberEmp.Size = new Size(250, 31);
            txtBoxMobileNumberEmp.TabIndex = 20;
            // 
            // TxtTitleEmployeeRegistration
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
            tableLayoutPanel1.Controls.Add(LblEmployeeFirstname, 0, 1);
            tableLayoutPanel1.Controls.Add(LblEmployeeLastname, 0, 2);
            tableLayoutPanel1.Controls.Add(checkBoxTrainee, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBoxEmailAdressEmp, 1, 10);
            tableLayoutPanel1.Controls.Add(lblBoxAdressEmp, 0, 3);
            tableLayoutPanel1.Controls.Add(txtBoxMobileNumberEmp, 1, 9);
            tableLayoutPanel1.Controls.Add(LblEmployeeStreetnumber, 0, 4);
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
            tableLayoutPanel1.Size = new Size(397, 498);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // btnSaveEmpoloyeRegistration
            // 
            btnSaveEmpoloyeRegistration.Location = new Point(330, 349);
            btnSaveEmpoloyeRegistration.Margin = new Padding(1, 1, 1, 1);
            btnSaveEmpoloyeRegistration.Name = "btnSaveEmpoloyeRegistration";
            btnSaveEmpoloyeRegistration.Size = new Size(147, 50);
            btnSaveEmpoloyeRegistration.TabIndex = 24;
            btnSaveEmpoloyeRegistration.Text = "Speichern";
            btnSaveEmpoloyeRegistration.UseVisualStyleBackColor = true;
            btnSaveEmpoloyeRegistration.Click += btnSaveEmpoloyeRegistration_Click_1;
            // 
            // UserRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(717, 647);
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
        private Label LblEmployeeFirstname;
        private Label LblEmployeeLastname;
        private Label lblBoxAdressEmp;
        private Label LblEmployeeStreetnumber;
        private Label LblEmployeeZIPcode;
        private Label LblEmployeePlace;
        private Label LblEmployeeSex;
        private Label TxtEmployeePhonenumber;
        private Label TxtEmployeeMobilenumber;
        private Label TxtEmployeeEmail;
        private MaskedTextBox TxtEmployeeFirstname;
        private MaskedTextBox TxtEmployeeLastname;
        private MaskedTextBox TxtEmployeeAddress;
        private MaskedTextBox TxtEmployeeStreetnumber;
        private MaskedTextBox txtBoxPhoneNumberEmp;
        private MaskedTextBox TxtEmployeeSex;
        private MaskedTextBox TxtEmployeePlace;
        private MaskedTextBox TxtEmployeeZIPcode;
        private MaskedTextBox txtBoxEmailAdressEmp;
        private MaskedTextBox txtBoxMobileNumberEmp;
        private TextBox TxtTitleEmployeeRegistration;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSaveEmpoloyeRegistration;
    }
}