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
            TxtEmployeeFirstname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeFirstname.Location = new Point(146, 52);
            TxtEmployeeFirstname.Margin = new Padding(1, 2, 1, 2);
            TxtEmployeeFirstname.Name = "TxtEmployeeFirstname";
            TxtEmployeeFirstname.Size = new Size(250, 31);
            TxtEmployeeFirstname.TabIndex = 12;
            TxtEmployeeFirstname.MaskInputRejected += s_MaskInputRejected;
            // 
            // TxtEmployeeLastname
            // 
            TxtEmployeeLastname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeLastname.Location = new Point(146, 97);
            TxtEmployeeLastname.Margin = new Padding(1, 2, 1, 2);
            TxtEmployeeLastname.Name = "TxtEmployeeLastname";
            TxtEmployeeLastname.Size = new Size(250, 31);
            TxtEmployeeLastname.TabIndex = 13;
            // 
            // TxtEmployeeAddress
            // 
            TxtEmployeeAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeAddress.Location = new Point(146, 142);
            TxtEmployeeAddress.Margin = new Padding(1, 2, 1, 2);
            TxtEmployeeAddress.Name = "TxtEmployeeAddress";
            TxtEmployeeAddress.Size = new Size(250, 31);
            TxtEmployeeAddress.TabIndex = 14;
            // 
            // TxtEmployeeStreetnumber
            // 
            TxtEmployeeStreetnumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeStreetnumber.Location = new Point(146, 187);
            TxtEmployeeStreetnumber.Margin = new Padding(1, 2, 1, 2);
            TxtEmployeeStreetnumber.Name = "TxtEmployeeStreetnumber";
            TxtEmployeeStreetnumber.Size = new Size(250, 31);
            TxtEmployeeStreetnumber.TabIndex = 15;
            // 
            // txtBoxPhoneNumberEmp
            // 
            txtBoxPhoneNumberEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPhoneNumberEmp.Location = new Point(146, 367);
            txtBoxPhoneNumberEmp.Margin = new Padding(1, 2, 1, 2);
            txtBoxPhoneNumberEmp.Name = "txtBoxPhoneNumberEmp";
            txtBoxPhoneNumberEmp.Size = new Size(250, 31);
            txtBoxPhoneNumberEmp.TabIndex = 19;
            // 
            // TxtEmployeeSex
            // 
            TxtEmployeeSex.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeSex.Location = new Point(146, 322);
            TxtEmployeeSex.Margin = new Padding(1, 2, 1, 2);
            TxtEmployeeSex.Name = "TxtEmployeeSex";
            TxtEmployeeSex.Size = new Size(250, 31);
            TxtEmployeeSex.TabIndex = 18;
            // 
            // TxtEmployeePlace
            // 
            TxtEmployeePlace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeePlace.Location = new Point(146, 277);
            TxtEmployeePlace.Margin = new Padding(1, 2, 1, 2);
            TxtEmployeePlace.Name = "TxtEmployeePlace";
            TxtEmployeePlace.Size = new Size(250, 31);
            TxtEmployeePlace.TabIndex = 17;
            // 
            // TxtEmployeeZIPcode
            // 
            TxtEmployeeZIPcode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeZIPcode.Location = new Point(146, 232);
            TxtEmployeeZIPcode.Margin = new Padding(1, 2, 1, 2);
            TxtEmployeeZIPcode.Name = "TxtEmployeeZIPcode";
            TxtEmployeeZIPcode.Size = new Size(250, 31);
            TxtEmployeeZIPcode.TabIndex = 16;
            // 
            // txtBoxEmailAdressEmp
            // 
            txtBoxEmailAdressEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxEmailAdressEmp.Location = new Point(146, 458);
            txtBoxEmailAdressEmp.Margin = new Padding(1, 2, 1, 2);
            txtBoxEmailAdressEmp.Name = "txtBoxEmailAdressEmp";
            txtBoxEmailAdressEmp.Size = new Size(250, 31);
            txtBoxEmailAdressEmp.TabIndex = 21;
            // 
            // txtBoxMobileNumberEmp
            // 
            txtBoxMobileNumberEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxMobileNumberEmp.Location = new Point(146, 412);
            txtBoxMobileNumberEmp.Margin = new Padding(1, 2, 1, 2);
            txtBoxMobileNumberEmp.Name = "txtBoxMobileNumberEmp";
            txtBoxMobileNumberEmp.Size = new Size(250, 31);
            txtBoxMobileNumberEmp.TabIndex = 20;
            // 
            // TxtTitleEmployeeRegistration
            // 
            TxtTitleEmployeeRegistration.Font = new Font("Segoe UI", 15F);
            TxtTitleEmployeeRegistration.Location = new Point(30, 37);
            TxtTitleEmployeeRegistration.Margin = new Padding(1, 2, 1, 2);
            TxtTitleEmployeeRegistration.Multiline = true;
            TxtTitleEmployeeRegistration.Name = "TxtTitleEmployeeRegistration";
            TxtTitleEmployeeRegistration.Size = new Size(403, 56);
            TxtTitleEmployeeRegistration.TabIndex = 22;
            TxtTitleEmployeeRegistration.TabStop = false;
            TxtTitleEmployeeRegistration.Text = "MITARBEITER ERFASSUNG";
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
            tableLayoutPanel1.Controls.Add(LblEmployeeZIPcode, 0, 5);
            tableLayoutPanel1.Controls.Add(TxtEmployeeSex, 1, 7);
            tableLayoutPanel1.Controls.Add(LblEmployeePlace, 0, 6);
            tableLayoutPanel1.Controls.Add(TxtEmployeePlace, 1, 6);
            tableLayoutPanel1.Controls.Add(LblEmployeeSex, 0, 7);
            tableLayoutPanel1.Controls.Add(TxtEmployeeZIPcode, 1, 5);
            tableLayoutPanel1.Controls.Add(TxtEmployeePhonenumber, 0, 8);
            tableLayoutPanel1.Controls.Add(TxtEmployeeStreetnumber, 1, 4);
            tableLayoutPanel1.Controls.Add(TxtEmployeeMobilenumber, 0, 9);
            tableLayoutPanel1.Controls.Add(TxtEmployeeAddress, 1, 3);
            tableLayoutPanel1.Controls.Add(TxtEmployeeLastname, 1, 2);
            tableLayoutPanel1.Controls.Add(TxtEmployeeFirstname, 1, 1);
            tableLayoutPanel1.Controls.Add(TxtEmployeeEmail, 0, 10);
            tableLayoutPanel1.Location = new Point(34, 122);
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
            btnSaveEmpoloyeRegistration.Location = new Point(471, 582);
            btnSaveEmpoloyeRegistration.Margin = new Padding(1, 2, 1, 2);
            btnSaveEmpoloyeRegistration.Name = "btnSaveEmpoloyeRegistration";
            btnSaveEmpoloyeRegistration.Size = new Size(147, 50);
            btnSaveEmpoloyeRegistration.TabIndex = 24;
            btnSaveEmpoloyeRegistration.Text = "Speichern";
            btnSaveEmpoloyeRegistration.UseVisualStyleBackColor = true;
            // 
            // UserRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(717, 647);
            Controls.Add(btnSaveEmpoloyeRegistration);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(TxtTitleEmployeeRegistration);
            Margin = new Padding(1, 2, 1, 2);
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