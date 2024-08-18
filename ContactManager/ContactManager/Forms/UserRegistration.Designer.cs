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
            TxtEmployeePhonenumber = new Label();
            TxtEmployeeMobilenumber = new Label();
            TxtEmployeeLastname = new MaskedTextBox();
            TxtEmployeeAddress = new MaskedTextBox();
            TxtEmployeeStreetnumber = new MaskedTextBox();
            TxtTitleEmployeeRegistration = new TextBox();
            btnSaveEmpoloyeRegistration = new Button();
            TblLayoutCostumer = new TableLayoutPanel();
            maskedTextBox1 = new MaskedTextBox();
            DtpEmployeeEnddate = new DateTimePicker();
            LblEmployeeRole = new Label();
            LblEmployeeEnddate = new Label();
            LblEmployeeFirstname = new Label();
            LblEmployeeLastname = new Label();
            LblEmployeeStreet = new Label();
            TxtCostumerMobilenumber = new MaskedTextBox();
            LblEmployeeHousenumber = new Label();
            TxtCostumerPhonenumber = new MaskedTextBox();
            LblEmployeeZIPcode = new Label();
            TxtCostumerSex = new MaskedTextBox();
            LblEmployeePlace = new Label();
            TxtCostumerPlace = new MaskedTextBox();
            LblEmployeeSex = new Label();
            TxtCostumerZIPcode = new MaskedTextBox();
            LblEmployeePhonenumber = new Label();
            TxtCostumerStreetnumber = new MaskedTextBox();
            LblEmployeeMobilenumber = new Label();
            TxtCostumerStreet = new MaskedTextBox();
            LblEmployeeEmail = new Label();
            TxtCostumerLastname = new MaskedTextBox();
            TxtCostumerFirstname = new MaskedTextBox();
            TxtCostumerEmail = new MaskedTextBox();
            LblEmployeeDepartement = new Label();
            LblEmployeeStartdate = new Label();
            ChkEmployeeTrainee = new CheckBox();
            LblEmployeeLevel = new Label();
            DtpEmployeeStartdate = new DateTimePicker();
            TxtEmployeeLevel = new ComboBox();
            CmbEmployeeDepartement = new ComboBox();
            label3 = new Label();
            LblEmployeeTrainigyear = new Label();
            TxtEmployeeTrainigyear = new MaskedTextBox();
            TblLayoutCostumer.SuspendLayout();
            SuspendLayout();
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
            // TxtEmployeeLastname
            // 
            TxtEmployeeLastname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeLastname.Location = new Point(102, 56);
            TxtEmployeeLastname.Margin = new Padding(1);
            TxtEmployeeLastname.Name = "TxtEmployeeLastname";
            TxtEmployeeLastname.Size = new Size(175, 23);
            TxtEmployeeLastname.TabIndex = 13;
            // 
            // TxtEmployeeAddress
            // 
            TxtEmployeeAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeAddress.Location = new Point(102, 83);
            TxtEmployeeAddress.Margin = new Padding(1);
            TxtEmployeeAddress.Name = "TxtEmployeeAddress";
            TxtEmployeeAddress.Size = new Size(175, 23);
            TxtEmployeeAddress.TabIndex = 14;
            // 
            // TxtEmployeeStreetnumber
            // 
            TxtEmployeeStreetnumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeStreetnumber.Location = new Point(102, 110);
            TxtEmployeeStreetnumber.Margin = new Padding(1);
            TxtEmployeeStreetnumber.Name = "TxtEmployeeStreetnumber";
            TxtEmployeeStreetnumber.Size = new Size(175, 23);
            TxtEmployeeStreetnumber.TabIndex = 15;
            // 
            // TxtTitleEmployeeRegistration
            // 
            TxtTitleEmployeeRegistration.Font = new Font("Segoe UI", 15F);
            TxtTitleEmployeeRegistration.Location = new Point(10, 10);
            TxtTitleEmployeeRegistration.Margin = new Padding(1);
            TxtTitleEmployeeRegistration.Multiline = true;
            TxtTitleEmployeeRegistration.Name = "TxtTitleEmployeeRegistration";
            TxtTitleEmployeeRegistration.Size = new Size(274, 35);
            TxtTitleEmployeeRegistration.TabIndex = 22;
            TxtTitleEmployeeRegistration.TabStop = false;
            TxtTitleEmployeeRegistration.Text = "MITARBEITER ERFASSUNG";
            // 
            // btnSaveEmpoloyeRegistration
            // 
            btnSaveEmpoloyeRegistration.Location = new Point(334, 480);
            btnSaveEmpoloyeRegistration.Margin = new Padding(1);
            btnSaveEmpoloyeRegistration.Name = "btnSaveEmpoloyeRegistration";
            btnSaveEmpoloyeRegistration.Size = new Size(103, 30);
            btnSaveEmpoloyeRegistration.TabIndex = 24;
            btnSaveEmpoloyeRegistration.Text = "Speichern";
            btnSaveEmpoloyeRegistration.UseVisualStyleBackColor = true;
            btnSaveEmpoloyeRegistration.Click += btnSaveEmpoloyeRegistration_Click_1;
            // 
            // TblLayoutCostumer
            // 
            TblLayoutCostumer.ColumnCount = 2;
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            TblLayoutCostumer.Controls.Add(TxtEmployeeTrainigyear, 1, 16);
            TblLayoutCostumer.Controls.Add(maskedTextBox1, 1, 14);
            TblLayoutCostumer.Controls.Add(DtpEmployeeEnddate, 1, 13);
            TblLayoutCostumer.Controls.Add(LblEmployeeRole, 0, 14);
            TblLayoutCostumer.Controls.Add(LblEmployeeEnddate, 0, 13);
            TblLayoutCostumer.Controls.Add(LblEmployeeFirstname, 0, 1);
            TblLayoutCostumer.Controls.Add(LblEmployeeLastname, 0, 2);
            TblLayoutCostumer.Controls.Add(LblEmployeeStreet, 0, 3);
            TblLayoutCostumer.Controls.Add(TxtCostumerMobilenumber, 1, 9);
            TblLayoutCostumer.Controls.Add(LblEmployeeHousenumber, 0, 4);
            TblLayoutCostumer.Controls.Add(TxtCostumerPhonenumber, 1, 8);
            TblLayoutCostumer.Controls.Add(LblEmployeeZIPcode, 0, 5);
            TblLayoutCostumer.Controls.Add(TxtCostumerSex, 1, 7);
            TblLayoutCostumer.Controls.Add(LblEmployeePlace, 0, 6);
            TblLayoutCostumer.Controls.Add(TxtCostumerPlace, 1, 6);
            TblLayoutCostumer.Controls.Add(LblEmployeeSex, 0, 7);
            TblLayoutCostumer.Controls.Add(TxtCostumerZIPcode, 1, 5);
            TblLayoutCostumer.Controls.Add(LblEmployeePhonenumber, 0, 8);
            TblLayoutCostumer.Controls.Add(TxtCostumerStreetnumber, 1, 4);
            TblLayoutCostumer.Controls.Add(LblEmployeeMobilenumber, 0, 9);
            TblLayoutCostumer.Controls.Add(TxtCostumerStreet, 1, 3);
            TblLayoutCostumer.Controls.Add(LblEmployeeEmail, 0, 10);
            TblLayoutCostumer.Controls.Add(TxtCostumerLastname, 1, 2);
            TblLayoutCostumer.Controls.Add(TxtCostumerFirstname, 1, 1);
            TblLayoutCostumer.Controls.Add(TxtCostumerEmail, 1, 10);
            TblLayoutCostumer.Controls.Add(LblEmployeeDepartement, 0, 11);
            TblLayoutCostumer.Controls.Add(LblEmployeeStartdate, 0, 12);
            TblLayoutCostumer.Controls.Add(ChkEmployeeTrainee, 0, 0);
            TblLayoutCostumer.Controls.Add(LblEmployeeLevel, 0, 15);
            TblLayoutCostumer.Controls.Add(LblEmployeeTrainigyear, 0, 16);
            TblLayoutCostumer.Controls.Add(DtpEmployeeStartdate, 1, 12);
            TblLayoutCostumer.Controls.Add(TxtEmployeeLevel, 1, 15);
            TblLayoutCostumer.Controls.Add(CmbEmployeeDepartement, 1, 11);
            TblLayoutCostumer.Location = new Point(6, 83);
            TblLayoutCostumer.Margin = new Padding(2);
            TblLayoutCostumer.Name = "TblLayoutCostumer";
            TblLayoutCostumer.RowCount = 18;
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TblLayoutCostumer.Size = new Size(278, 427);
            TblLayoutCostumer.TabIndex = 45;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox1.Location = new Point(101, 351);
            maskedTextBox1.Margin = new Padding(1);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(177, 23);
            maskedTextBox1.TabIndex = 62;
            // 
            // DtpEmployeeEnddate
            // 
            DtpEmployeeEnddate.Location = new Point(101, 326);
            DtpEmployeeEnddate.Margin = new Padding(1);
            DtpEmployeeEnddate.Name = "DtpEmployeeEnddate";
            DtpEmployeeEnddate.Size = new Size(198, 23);
            DtpEmployeeEnddate.TabIndex = 59;
            // 
            // LblEmployeeRole
            // 
            LblEmployeeRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeRole.AutoSize = true;
            LblEmployeeRole.Location = new Point(1, 350);
            LblEmployeeRole.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeRole.Name = "LblEmployeeRole";
            LblEmployeeRole.Size = new Size(98, 25);
            LblEmployeeRole.TabIndex = 54;
            LblEmployeeRole.Text = "Rolle";
            LblEmployeeRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeEnddate
            // 
            LblEmployeeEnddate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeEnddate.AutoSize = true;
            LblEmployeeEnddate.Location = new Point(1, 325);
            LblEmployeeEnddate.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeEnddate.Name = "LblEmployeeEnddate";
            LblEmployeeEnddate.Size = new Size(98, 25);
            LblEmployeeEnddate.TabIndex = 51;
            LblEmployeeEnddate.Text = "Enddatum";
            LblEmployeeEnddate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeFirstname
            // 
            LblEmployeeFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeFirstname.AutoSize = true;
            LblEmployeeFirstname.Location = new Point(1, 25);
            LblEmployeeFirstname.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeFirstname.Name = "LblEmployeeFirstname";
            LblEmployeeFirstname.Size = new Size(98, 25);
            LblEmployeeFirstname.TabIndex = 22;
            LblEmployeeFirstname.Text = "Vorname";
            LblEmployeeFirstname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeLastname
            // 
            LblEmployeeLastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeLastname.AutoSize = true;
            LblEmployeeLastname.Location = new Point(1, 50);
            LblEmployeeLastname.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeLastname.Name = "LblEmployeeLastname";
            LblEmployeeLastname.Size = new Size(98, 25);
            LblEmployeeLastname.TabIndex = 23;
            LblEmployeeLastname.Text = "Nachname";
            LblEmployeeLastname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeStreet
            // 
            LblEmployeeStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeStreet.AutoSize = true;
            LblEmployeeStreet.Location = new Point(1, 75);
            LblEmployeeStreet.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeStreet.Name = "LblEmployeeStreet";
            LblEmployeeStreet.Size = new Size(98, 25);
            LblEmployeeStreet.TabIndex = 24;
            LblEmployeeStreet.Text = "Strasse";
            LblEmployeeStreet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerMobilenumber
            // 
            TxtCostumerMobilenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerMobilenumber.Location = new Point(101, 226);
            TxtCostumerMobilenumber.Margin = new Padding(1);
            TxtCostumerMobilenumber.Name = "TxtCostumerMobilenumber";
            TxtCostumerMobilenumber.Size = new Size(198, 23);
            TxtCostumerMobilenumber.TabIndex = 40;
            // 
            // LblEmployeeHousenumber
            // 
            LblEmployeeHousenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeHousenumber.AutoSize = true;
            LblEmployeeHousenumber.Location = new Point(1, 100);
            LblEmployeeHousenumber.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeHousenumber.Name = "LblEmployeeHousenumber";
            LblEmployeeHousenumber.Size = new Size(98, 25);
            LblEmployeeHousenumber.TabIndex = 25;
            LblEmployeeHousenumber.Text = "Hausnummer";
            LblEmployeeHousenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerPhonenumber
            // 
            TxtCostumerPhonenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerPhonenumber.Location = new Point(101, 201);
            TxtCostumerPhonenumber.Margin = new Padding(1);
            TxtCostumerPhonenumber.Name = "TxtCostumerPhonenumber";
            TxtCostumerPhonenumber.Size = new Size(198, 23);
            TxtCostumerPhonenumber.TabIndex = 39;
            // 
            // LblEmployeeZIPcode
            // 
            LblEmployeeZIPcode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeZIPcode.AutoSize = true;
            LblEmployeeZIPcode.Location = new Point(1, 125);
            LblEmployeeZIPcode.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeZIPcode.Name = "LblEmployeeZIPcode";
            LblEmployeeZIPcode.Size = new Size(98, 25);
            LblEmployeeZIPcode.TabIndex = 26;
            LblEmployeeZIPcode.Text = "PLZ";
            LblEmployeeZIPcode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerSex
            // 
            TxtCostumerSex.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerSex.Location = new Point(101, 176);
            TxtCostumerSex.Margin = new Padding(1);
            TxtCostumerSex.Name = "TxtCostumerSex";
            TxtCostumerSex.Size = new Size(198, 23);
            TxtCostumerSex.TabIndex = 38;
            // 
            // LblEmployeePlace
            // 
            LblEmployeePlace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeePlace.AutoSize = true;
            LblEmployeePlace.Location = new Point(1, 150);
            LblEmployeePlace.Margin = new Padding(1, 0, 1, 0);
            LblEmployeePlace.Name = "LblEmployeePlace";
            LblEmployeePlace.Size = new Size(98, 25);
            LblEmployeePlace.TabIndex = 27;
            LblEmployeePlace.Text = "Ort";
            LblEmployeePlace.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerPlace
            // 
            TxtCostumerPlace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerPlace.Location = new Point(101, 151);
            TxtCostumerPlace.Margin = new Padding(1);
            TxtCostumerPlace.Name = "TxtCostumerPlace";
            TxtCostumerPlace.Size = new Size(198, 23);
            TxtCostumerPlace.TabIndex = 37;
            // 
            // LblEmployeeSex
            // 
            LblEmployeeSex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeSex.AutoSize = true;
            LblEmployeeSex.Location = new Point(1, 175);
            LblEmployeeSex.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeSex.Name = "LblEmployeeSex";
            LblEmployeeSex.Size = new Size(98, 25);
            LblEmployeeSex.TabIndex = 28;
            LblEmployeeSex.Text = "Geschlecht";
            LblEmployeeSex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerZIPcode
            // 
            TxtCostumerZIPcode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerZIPcode.Location = new Point(101, 126);
            TxtCostumerZIPcode.Margin = new Padding(1);
            TxtCostumerZIPcode.Name = "TxtCostumerZIPcode";
            TxtCostumerZIPcode.Size = new Size(198, 23);
            TxtCostumerZIPcode.TabIndex = 36;
            // 
            // LblEmployeePhonenumber
            // 
            LblEmployeePhonenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeePhonenumber.AutoSize = true;
            LblEmployeePhonenumber.Location = new Point(1, 200);
            LblEmployeePhonenumber.Margin = new Padding(1, 0, 1, 0);
            LblEmployeePhonenumber.Name = "LblEmployeePhonenumber";
            LblEmployeePhonenumber.Size = new Size(98, 25);
            LblEmployeePhonenumber.TabIndex = 29;
            LblEmployeePhonenumber.Text = "Telefonummer";
            LblEmployeePhonenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerStreetnumber
            // 
            TxtCostumerStreetnumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerStreetnumber.Location = new Point(101, 101);
            TxtCostumerStreetnumber.Margin = new Padding(1);
            TxtCostumerStreetnumber.Name = "TxtCostumerStreetnumber";
            TxtCostumerStreetnumber.Size = new Size(198, 23);
            TxtCostumerStreetnumber.TabIndex = 35;
            // 
            // LblEmployeeMobilenumber
            // 
            LblEmployeeMobilenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeMobilenumber.AutoSize = true;
            LblEmployeeMobilenumber.Location = new Point(1, 225);
            LblEmployeeMobilenumber.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeMobilenumber.Name = "LblEmployeeMobilenumber";
            LblEmployeeMobilenumber.Size = new Size(98, 25);
            LblEmployeeMobilenumber.TabIndex = 30;
            LblEmployeeMobilenumber.Text = "Mobilnummer";
            LblEmployeeMobilenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerStreet
            // 
            TxtCostumerStreet.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerStreet.Location = new Point(101, 76);
            TxtCostumerStreet.Margin = new Padding(1);
            TxtCostumerStreet.Name = "TxtCostumerStreet";
            TxtCostumerStreet.Size = new Size(198, 23);
            TxtCostumerStreet.TabIndex = 34;
            // 
            // LblEmployeeEmail
            // 
            LblEmployeeEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeEmail.AutoSize = true;
            LblEmployeeEmail.Location = new Point(1, 250);
            LblEmployeeEmail.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeEmail.Name = "LblEmployeeEmail";
            LblEmployeeEmail.Size = new Size(98, 25);
            LblEmployeeEmail.TabIndex = 31;
            LblEmployeeEmail.Text = "Email-Adresse";
            LblEmployeeEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerLastname
            // 
            TxtCostumerLastname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerLastname.Location = new Point(101, 51);
            TxtCostumerLastname.Margin = new Padding(1);
            TxtCostumerLastname.Name = "TxtCostumerLastname";
            TxtCostumerLastname.Size = new Size(198, 23);
            TxtCostumerLastname.TabIndex = 33;
            // 
            // TxtCostumerFirstname
            // 
            TxtCostumerFirstname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerFirstname.Location = new Point(101, 26);
            TxtCostumerFirstname.Margin = new Padding(1);
            TxtCostumerFirstname.Name = "TxtCostumerFirstname";
            TxtCostumerFirstname.Size = new Size(198, 23);
            TxtCostumerFirstname.TabIndex = 32;
            // 
            // TxtCostumerEmail
            // 
            TxtCostumerEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerEmail.Location = new Point(101, 251);
            TxtCostumerEmail.Margin = new Padding(1);
            TxtCostumerEmail.Name = "TxtCostumerEmail";
            TxtCostumerEmail.Size = new Size(198, 23);
            TxtCostumerEmail.TabIndex = 41;
            // 
            // LblEmployeeDepartement
            // 
            LblEmployeeDepartement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeDepartement.AutoSize = true;
            LblEmployeeDepartement.Location = new Point(1, 275);
            LblEmployeeDepartement.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeDepartement.Name = "LblEmployeeDepartement";
            LblEmployeeDepartement.Size = new Size(98, 25);
            LblEmployeeDepartement.TabIndex = 43;
            LblEmployeeDepartement.Text = "Abteilung";
            LblEmployeeDepartement.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeStartdate
            // 
            LblEmployeeStartdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeStartdate.AutoSize = true;
            LblEmployeeStartdate.Location = new Point(1, 300);
            LblEmployeeStartdate.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeStartdate.Name = "LblEmployeeStartdate";
            LblEmployeeStartdate.Size = new Size(98, 25);
            LblEmployeeStartdate.TabIndex = 47;
            LblEmployeeStartdate.Text = "Startdatum";
            LblEmployeeStartdate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChkEmployeeTrainee
            // 
            ChkEmployeeTrainee.AutoSize = true;
            ChkEmployeeTrainee.Location = new Point(3, 3);
            ChkEmployeeTrainee.Name = "ChkEmployeeTrainee";
            ChkEmployeeTrainee.Size = new Size(69, 19);
            ChkEmployeeTrainee.TabIndex = 52;
            ChkEmployeeTrainee.Text = "Lehrling";
            ChkEmployeeTrainee.UseVisualStyleBackColor = true;
            ChkEmployeeTrainee.CheckedChanged += ChkEmployeeTrainee_CheckedChanged;
            // 
            // LblEmployeeLevel
            // 
            LblEmployeeLevel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeLevel.AutoSize = true;
            LblEmployeeLevel.Location = new Point(1, 375);
            LblEmployeeLevel.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeLevel.Name = "LblEmployeeLevel";
            LblEmployeeLevel.Size = new Size(98, 25);
            LblEmployeeLevel.TabIndex = 55;
            LblEmployeeLevel.Text = "Kaderstufe";
            LblEmployeeLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DtpEmployeeStartdate
            // 
            DtpEmployeeStartdate.Location = new Point(101, 301);
            DtpEmployeeStartdate.Margin = new Padding(1);
            DtpEmployeeStartdate.Name = "DtpEmployeeStartdate";
            DtpEmployeeStartdate.Size = new Size(198, 23);
            DtpEmployeeStartdate.TabIndex = 57;
            // 
            // TxtEmployeeLevel
            // 
            TxtEmployeeLevel.FormattingEnabled = true;
            TxtEmployeeLevel.Location = new Point(101, 376);
            TxtEmployeeLevel.Margin = new Padding(1);
            TxtEmployeeLevel.Name = "TxtEmployeeLevel";
            TxtEmployeeLevel.Size = new Size(198, 23);
            TxtEmployeeLevel.TabIndex = 61;
            // 
            // CmbEmployeeDepartement
            // 
            CmbEmployeeDepartement.FormattingEnabled = true;
            CmbEmployeeDepartement.Location = new Point(101, 276);
            CmbEmployeeDepartement.Margin = new Padding(1);
            CmbEmployeeDepartement.Name = "CmbEmployeeDepartement";
            CmbEmployeeDepartement.Size = new Size(177, 23);
            CmbEmployeeDepartement.TabIndex = 58;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 273);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 46;
            label3.Text = "Email-Adresse";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeTrainigyear
            // 
            LblEmployeeTrainigyear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeTrainigyear.AutoSize = true;
            LblEmployeeTrainigyear.Location = new Point(1, 400);
            LblEmployeeTrainigyear.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeTrainigyear.Name = "LblEmployeeTrainigyear";
            LblEmployeeTrainigyear.Size = new Size(98, 25);
            LblEmployeeTrainigyear.TabIndex = 56;
            LblEmployeeTrainigyear.Text = "Ausbildungsjahr";
            LblEmployeeTrainigyear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeTrainigyear
            // 
            TxtEmployeeTrainigyear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeTrainigyear.Location = new Point(101, 401);
            TxtEmployeeTrainigyear.Margin = new Padding(1);
            TxtEmployeeTrainigyear.Name = "TxtEmployeeTrainigyear";
            TxtEmployeeTrainigyear.Size = new Size(198, 23);
            TxtEmployeeTrainigyear.TabIndex = 63;
            // 
            // UserRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(502, 530);
            Controls.Add(TblLayoutCostumer);
            Controls.Add(label3);
            Controls.Add(btnSaveEmpoloyeRegistration);
            Controls.Add(TxtTitleEmployeeRegistration);
            Margin = new Padding(1);
            Name = "UserRegistration";
            Text = "Mitarbeitererfassung";
            Load += UserRegistration_Load;
            TblLayoutCostumer.ResumeLayout(false);
            TblLayoutCostumer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TxtEmployeePhonenumber;
        private Label TxtEmployeeMobilenumber;
        private MaskedTextBox TxtEmployeeLastname;
        private MaskedTextBox TxtEmployeeAddress;
        private MaskedTextBox TxtEmployeeStreetnumber;
        private TextBox TxtTitleEmployeeRegistration;
        private Button btnSaveEmpoloyeRegistration;
        private TableLayoutPanel TblLayoutCostumer;
        private Label LblEmployeeEnddate;
        private Label LblEmployeeFirstname;
        private Label LblEmployeeLastname;
        private Label LblEmployeeStreet;
        private MaskedTextBox TxtCostumerMobilenumber;
        private Label LblEmployeeHousenumber;
        private MaskedTextBox TxtCostumerPhonenumber;
        private Label LblEmployeeZIPcode;
        private MaskedTextBox TxtCostumerSex;
        private Label LblEmployeePlace;
        private MaskedTextBox TxtCostumerPlace;
        private Label LblEmployeeSex;
        private MaskedTextBox TxtCostumerZIPcode;
        private Label LblEmployeePhonenumber;
        private MaskedTextBox TxtCostumerStreetnumber;
        private Label LblEmployeeMobilenumber;
        private MaskedTextBox TxtCostumerStreet;
        private Label LblEmployeeEmail;
        private MaskedTextBox TxtCostumerLastname;
        private MaskedTextBox TxtCostumerFirstname;
        private MaskedTextBox TxtCostumerEmail;
        private Label LblEmployeeDepartement;
        private Label LblEmployeeStartdate;
        private Label label3;
        private CheckBox ChkEmployeeTrainee;
        private MaskedTextBox maskedTextBox1;
        private ComboBox TxtEmployeeLevel;
        private DateTimePicker DtpEmployeeEnddate;
        private Label LblEmployeeRole;
        private Label LblEmployeeLevel;
        private DateTimePicker DtpEmployeeStartdate;
        private ComboBox CmbEmployeeDepartement;
        private MaskedTextBox TxtEmployeeTrainigyear;
        private Label LblEmployeeTrainigyear;
    }
}