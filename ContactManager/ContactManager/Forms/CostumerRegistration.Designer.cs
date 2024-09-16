namespace ContactManager.Forms
{
    partial class CustumerRegistration
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
            LblCostumerRegistration = new TextBox();
            CmdCostumerSave = new Button();
            groupBox = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            TxtNotes = new TextBox();
            LblNotes = new Label();
            CmdSaveNote = new Button();
            TxtCostumerTitle = new MaskedTextBox();
            LblCostumerTitle = new Label();
            GrpCostumerSex = new GroupBox();
            RadCostumerFemale = new RadioButton();
            RadCostumerMale = new RadioButton();
            TxtCostumerContactperson = new MaskedTextBox();
            CmbCostumerCostumertype = new ComboBox();
            TxtCostumerCompany = new MaskedTextBox();
            LblCostumerCostumertype = new Label();
            LblCostumerCompany = new Label();
            TxtCostumerEmail = new MaskedTextBox();
            TxtCostumerFirstname = new MaskedTextBox();
            TxtCostumerLastname = new MaskedTextBox();
            LblCostumerEmail = new Label();
            TxtCostumerStreet = new MaskedTextBox();
            LblCostumerMobilenumber = new Label();
            TxtCostumerStreetnumber = new MaskedTextBox();
            LblCostumerPhonenumber = new Label();
            TxtCostumerZIPcode = new MaskedTextBox();
            LblCostumerSex = new Label();
            TxtCostumerPlace = new MaskedTextBox();
            LblCostumerPlace = new Label();
            LblCostumerZIPcode = new Label();
            TxtCostumerPhonenumber = new MaskedTextBox();
            LblCostumerStreetnumber = new Label();
            TxtCostumerMobilenumber = new MaskedTextBox();
            LblCostumerStreet = new Label();
            LblCostumerLastname = new Label();
            LblCostumerFirstname = new Label();
            LblCostumerContactperson = new Label();
            TblLayoutCostumer = new TableLayoutPanel();
            TxtCostumerBusinessnumber = new MaskedTextBox();
            LblCostumerBusinessnumber = new Label();
            TxtCostumerNationality = new MaskedTextBox();
            LblCostumerNationality = new Label();
            LblCostumerDateofBirth = new Label();
            DtpCostumerDateofBirth = new DateTimePicker();
            TxtOutGridNotes = new TextBox();
            LblOutGridNotes = new Label();
            groupBox.SuspendLayout();
            GrpCostumerSex.SuspendLayout();
            TblLayoutCostumer.SuspendLayout();
            SuspendLayout();
            // 
            // LblCostumerRegistration
            // 
            LblCostumerRegistration.Font = new Font("Segoe UI", 15F);
            LblCostumerRegistration.Location = new Point(21, 10);
            LblCostumerRegistration.Margin = new Padding(1);
            LblCostumerRegistration.Multiline = true;
            LblCostumerRegistration.Name = "LblCostumerRegistration";
            LblCostumerRegistration.Size = new Size(283, 47);
            LblCostumerRegistration.TabIndex = 42;
            LblCostumerRegistration.TabStop = false;
            LblCostumerRegistration.Text = "KUNDEN ERFASSUNG";
            LblCostumerRegistration.TextChanged += txtBoxKundenErfassungTitel_TextChanged;
            // 
            // CmdCostumerSave
            // 
            CmdCostumerSave.Location = new Point(616, 491);
            CmdCostumerSave.Margin = new Padding(1);
            CmdCostumerSave.Name = "CmdCostumerSave";
            CmdCostumerSave.Size = new Size(103, 30);
            CmdCostumerSave.TabIndex = 44;
            CmdCostumerSave.Text = "Speichern";
            CmdCostumerSave.UseVisualStyleBackColor = true;
            CmdCostumerSave.Click += CmdCostumerSave_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(radioButton1);
            groupBox.Controls.Add(radioButton2);
            groupBox.Location = new Point(10, 10);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(200, 100);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Options";
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(10, 20);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 24);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Option 1";
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(10, 50);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Option 2";
            // 
            // TxtNotes
            // 
            TxtNotes.Location = new Point(24, 576);
            TxtNotes.Margin = new Padding(1);
            TxtNotes.Multiline = true;
            TxtNotes.Name = "TxtNotes";
            TxtNotes.Size = new Size(551, 109);
            TxtNotes.TabIndex = 45;
            // 
            // LblNotes
            // 
            LblNotes.AutoSize = true;
            LblNotes.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            LblNotes.Location = new Point(25, 560);
            LblNotes.Margin = new Padding(1, 0, 1, 0);
            LblNotes.Name = "LblNotes";
            LblNotes.Size = new Size(97, 15);
            LblNotes.TabIndex = 46;
            LblNotes.Text = "Notizen erfassen:";
            // 
            // CmdSaveNote
            // 
            CmdSaveNote.Location = new Point(616, 656);
            CmdSaveNote.Margin = new Padding(1);
            CmdSaveNote.Name = "CmdSaveNote";
            CmdSaveNote.Size = new Size(103, 29);
            CmdSaveNote.TabIndex = 47;
            CmdSaveNote.Text = "Notiz speichern";
            CmdSaveNote.UseVisualStyleBackColor = true;
            CmdSaveNote.Click += BtnSaveNote_Click;
            // 
            // TxtCostumerTitle
            // 
            TxtCostumerTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerTitle.Location = new Point(140, 1);
            TxtCostumerTitle.Margin = new Padding(0);
            TxtCostumerTitle.Name = "TxtCostumerTitle";
            TxtCostumerTitle.Size = new Size(411, 23);
            TxtCostumerTitle.TabIndex = 1;
            // 
            // LblCostumerTitle
            // 
            LblCostumerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerTitle.AutoSize = true;
            LblCostumerTitle.Location = new Point(1, 0);
            LblCostumerTitle.Margin = new Padding(1, 0, 1, 0);
            LblCostumerTitle.Name = "LblCostumerTitle";
            LblCostumerTitle.Size = new Size(138, 25);
            LblCostumerTitle.TabIndex = 53;
            LblCostumerTitle.Text = "Titel";
            LblCostumerTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GrpCostumerSex
            // 
            GrpCostumerSex.Controls.Add(RadCostumerFemale);
            GrpCostumerSex.Controls.Add(RadCostumerMale);
            GrpCostumerSex.Location = new Point(143, 228);
            GrpCostumerSex.Name = "GrpCostumerSex";
            GrpCostumerSex.Size = new Size(164, 19);
            GrpCostumerSex.TabIndex = 0;
            GrpCostumerSex.TabStop = false;
            // 
            // RadCostumerFemale
            // 
            RadCostumerFemale.AutoSize = true;
            RadCostumerFemale.Location = new Point(81, 3);
            RadCostumerFemale.Name = "RadCostumerFemale";
            RadCostumerFemale.Size = new Size(71, 19);
            RadCostumerFemale.TabIndex = 10;
            RadCostumerFemale.Text = "Weiblich";
            RadCostumerFemale.UseVisualStyleBackColor = true;
            // 
            // RadCostumerMale
            // 
            RadCostumerMale.AutoSize = true;
            RadCostumerMale.Checked = true;
            RadCostumerMale.Location = new Point(0, 3);
            RadCostumerMale.Name = "RadCostumerMale";
            RadCostumerMale.Size = new Size(75, 19);
            RadCostumerMale.TabIndex = 9;
            RadCostumerMale.TabStop = true;
            RadCostumerMale.Text = "Männlich";
            RadCostumerMale.UseVisualStyleBackColor = true;
            // 
            // TxtCostumerContactperson
            // 
            TxtCostumerContactperson.Location = new Point(140, 400);
            TxtCostumerContactperson.Margin = new Padding(0);
            TxtCostumerContactperson.Name = "TxtCostumerContactperson";
            TxtCostumerContactperson.Size = new Size(411, 23);
            TxtCostumerContactperson.TabIndex = 16;
            // 
            // CmbCostumerCostumertype
            // 
            CmbCostumerCostumertype.FormattingEnabled = true;
            CmbCostumerCostumertype.Location = new Point(140, 375);
            CmbCostumerCostumertype.Margin = new Padding(0);
            CmbCostumerCostumertype.Name = "CmbCostumerCostumertype";
            CmbCostumerCostumertype.Size = new Size(411, 23);
            CmbCostumerCostumertype.TabIndex = 15;
            // 
            // TxtCostumerCompany
            // 
            TxtCostumerCompany.Location = new Point(140, 350);
            TxtCostumerCompany.Margin = new Padding(0);
            TxtCostumerCompany.Name = "TxtCostumerCompany";
            TxtCostumerCompany.Size = new Size(411, 23);
            TxtCostumerCompany.TabIndex = 14;
            // 
            // LblCostumerCostumertype
            // 
            LblCostumerCostumertype.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerCostumertype.AutoSize = true;
            LblCostumerCostumertype.Location = new Point(1, 375);
            LblCostumerCostumertype.Margin = new Padding(1, 0, 1, 0);
            LblCostumerCostumertype.Name = "LblCostumerCostumertype";
            LblCostumerCostumertype.Size = new Size(138, 25);
            LblCostumerCostumertype.TabIndex = 47;
            LblCostumerCostumertype.Text = "Kundentyp";
            LblCostumerCostumertype.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCostumerCompany
            // 
            LblCostumerCompany.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerCompany.AutoSize = true;
            LblCostumerCompany.Location = new Point(1, 350);
            LblCostumerCompany.Margin = new Padding(1, 0, 1, 0);
            LblCostumerCompany.Name = "LblCostumerCompany";
            LblCostumerCompany.Size = new Size(138, 25);
            LblCostumerCompany.TabIndex = 43;
            LblCostumerCompany.Text = "Firma";
            LblCostumerCompany.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerEmail
            // 
            TxtCostumerEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerEmail.Location = new Point(140, 326);
            TxtCostumerEmail.Margin = new Padding(0);
            TxtCostumerEmail.Name = "TxtCostumerEmail";
            TxtCostumerEmail.Size = new Size(411, 23);
            TxtCostumerEmail.TabIndex = 13;
            // 
            // TxtCostumerFirstname
            // 
            TxtCostumerFirstname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerFirstname.Location = new Point(140, 26);
            TxtCostumerFirstname.Margin = new Padding(0);
            TxtCostumerFirstname.Name = "TxtCostumerFirstname";
            TxtCostumerFirstname.Size = new Size(411, 23);
            TxtCostumerFirstname.TabIndex = 2;
            // 
            // TxtCostumerLastname
            // 
            TxtCostumerLastname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerLastname.Location = new Point(140, 51);
            TxtCostumerLastname.Margin = new Padding(0);
            TxtCostumerLastname.Name = "TxtCostumerLastname";
            TxtCostumerLastname.Size = new Size(411, 23);
            TxtCostumerLastname.TabIndex = 3;
            // 
            // LblCostumerEmail
            // 
            LblCostumerEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerEmail.AutoSize = true;
            LblCostumerEmail.Location = new Point(1, 325);
            LblCostumerEmail.Margin = new Padding(1, 0, 1, 0);
            LblCostumerEmail.Name = "LblCostumerEmail";
            LblCostumerEmail.Size = new Size(138, 25);
            LblCostumerEmail.TabIndex = 31;
            LblCostumerEmail.Text = "Email-Adresse";
            LblCostumerEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerStreet
            // 
            TxtCostumerStreet.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerStreet.Location = new Point(140, 101);
            TxtCostumerStreet.Margin = new Padding(0);
            TxtCostumerStreet.Name = "TxtCostumerStreet";
            TxtCostumerStreet.Size = new Size(411, 23);
            TxtCostumerStreet.TabIndex = 5;
            // 
            // LblCostumerMobilenumber
            // 
            LblCostumerMobilenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerMobilenumber.AutoSize = true;
            LblCostumerMobilenumber.Location = new Point(1, 275);
            LblCostumerMobilenumber.Margin = new Padding(1, 0, 1, 0);
            LblCostumerMobilenumber.Name = "LblCostumerMobilenumber";
            LblCostumerMobilenumber.Size = new Size(138, 25);
            LblCostumerMobilenumber.TabIndex = 30;
            LblCostumerMobilenumber.Text = "Mobilnummer";
            LblCostumerMobilenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerStreetnumber
            // 
            TxtCostumerStreetnumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerStreetnumber.Location = new Point(140, 126);
            TxtCostumerStreetnumber.Margin = new Padding(0);
            TxtCostumerStreetnumber.Name = "TxtCostumerStreetnumber";
            TxtCostumerStreetnumber.Size = new Size(411, 23);
            TxtCostumerStreetnumber.TabIndex = 6;
            // 
            // LblCostumerPhonenumber
            // 
            LblCostumerPhonenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerPhonenumber.AutoSize = true;
            LblCostumerPhonenumber.Location = new Point(1, 250);
            LblCostumerPhonenumber.Margin = new Padding(1, 0, 1, 0);
            LblCostumerPhonenumber.Name = "LblCostumerPhonenumber";
            LblCostumerPhonenumber.Size = new Size(138, 25);
            LblCostumerPhonenumber.TabIndex = 29;
            LblCostumerPhonenumber.Text = "Telefonummer";
            LblCostumerPhonenumber.TextAlign = ContentAlignment.MiddleLeft;
            LblCostumerPhonenumber.Click += LblCostumerPhonenumber_Click;
            // 
            // TxtCostumerZIPcode
            // 
            TxtCostumerZIPcode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerZIPcode.Location = new Point(140, 151);
            TxtCostumerZIPcode.Margin = new Padding(0);
            TxtCostumerZIPcode.Name = "TxtCostumerZIPcode";
            TxtCostumerZIPcode.Size = new Size(411, 23);
            TxtCostumerZIPcode.TabIndex = 7;
            // 
            // LblCostumerSex
            // 
            LblCostumerSex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerSex.AutoSize = true;
            LblCostumerSex.Location = new Point(1, 225);
            LblCostumerSex.Margin = new Padding(1, 0, 1, 0);
            LblCostumerSex.Name = "LblCostumerSex";
            LblCostumerSex.Size = new Size(138, 25);
            LblCostumerSex.TabIndex = 28;
            LblCostumerSex.Text = "Geschlecht";
            LblCostumerSex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerPlace
            // 
            TxtCostumerPlace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerPlace.Location = new Point(140, 176);
            TxtCostumerPlace.Margin = new Padding(0);
            TxtCostumerPlace.Name = "TxtCostumerPlace";
            TxtCostumerPlace.Size = new Size(411, 23);
            TxtCostumerPlace.TabIndex = 8;
            // 
            // LblCostumerPlace
            // 
            LblCostumerPlace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerPlace.AutoSize = true;
            LblCostumerPlace.Location = new Point(1, 175);
            LblCostumerPlace.Margin = new Padding(1, 0, 1, 0);
            LblCostumerPlace.Name = "LblCostumerPlace";
            LblCostumerPlace.Size = new Size(138, 25);
            LblCostumerPlace.TabIndex = 27;
            LblCostumerPlace.Text = "Ort";
            LblCostumerPlace.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCostumerZIPcode
            // 
            LblCostumerZIPcode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerZIPcode.AutoSize = true;
            LblCostumerZIPcode.Location = new Point(1, 150);
            LblCostumerZIPcode.Margin = new Padding(1, 0, 1, 0);
            LblCostumerZIPcode.Name = "LblCostumerZIPcode";
            LblCostumerZIPcode.Size = new Size(138, 25);
            LblCostumerZIPcode.TabIndex = 26;
            LblCostumerZIPcode.Text = "PLZ";
            LblCostumerZIPcode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerPhonenumber
            // 
            TxtCostumerPhonenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerPhonenumber.Location = new Point(140, 251);
            TxtCostumerPhonenumber.Margin = new Padding(0);
            TxtCostumerPhonenumber.Name = "TxtCostumerPhonenumber";
            TxtCostumerPhonenumber.Size = new Size(411, 23);
            TxtCostumerPhonenumber.TabIndex = 10;
            // 
            // LblCostumerStreetnumber
            // 
            LblCostumerStreetnumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerStreetnumber.AutoSize = true;
            LblCostumerStreetnumber.Location = new Point(1, 125);
            LblCostumerStreetnumber.Margin = new Padding(1, 0, 1, 0);
            LblCostumerStreetnumber.Name = "LblCostumerStreetnumber";
            LblCostumerStreetnumber.Size = new Size(138, 25);
            LblCostumerStreetnumber.TabIndex = 25;
            LblCostumerStreetnumber.Text = "Hausnummer";
            LblCostumerStreetnumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerMobilenumber
            // 
            TxtCostumerMobilenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerMobilenumber.Location = new Point(140, 276);
            TxtCostumerMobilenumber.Margin = new Padding(0);
            TxtCostumerMobilenumber.Name = "TxtCostumerMobilenumber";
            TxtCostumerMobilenumber.Size = new Size(411, 23);
            TxtCostumerMobilenumber.TabIndex = 11;
            // 
            // LblCostumerStreet
            // 
            LblCostumerStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerStreet.AutoSize = true;
            LblCostumerStreet.Location = new Point(1, 100);
            LblCostumerStreet.Margin = new Padding(1, 0, 1, 0);
            LblCostumerStreet.Name = "LblCostumerStreet";
            LblCostumerStreet.Size = new Size(138, 25);
            LblCostumerStreet.TabIndex = 24;
            LblCostumerStreet.Text = "Strasse";
            LblCostumerStreet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCostumerLastname
            // 
            LblCostumerLastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerLastname.AutoSize = true;
            LblCostumerLastname.Location = new Point(1, 50);
            LblCostumerLastname.Margin = new Padding(1, 0, 1, 0);
            LblCostumerLastname.Name = "LblCostumerLastname";
            LblCostumerLastname.Size = new Size(138, 25);
            LblCostumerLastname.TabIndex = 23;
            LblCostumerLastname.Text = "Nachname";
            LblCostumerLastname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCostumerFirstname
            // 
            LblCostumerFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerFirstname.AutoSize = true;
            LblCostumerFirstname.Location = new Point(1, 25);
            LblCostumerFirstname.Margin = new Padding(1, 0, 1, 0);
            LblCostumerFirstname.Name = "LblCostumerFirstname";
            LblCostumerFirstname.Size = new Size(138, 25);
            LblCostumerFirstname.TabIndex = 22;
            LblCostumerFirstname.Text = "Vorname";
            LblCostumerFirstname.TextAlign = ContentAlignment.MiddleLeft;
            LblCostumerFirstname.Click += LblCostumerFirstname_Click;
            // 
            // LblCostumerContactperson
            // 
            LblCostumerContactperson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerContactperson.AutoSize = true;
            LblCostumerContactperson.Location = new Point(1, 400);
            LblCostumerContactperson.Margin = new Padding(1, 0, 1, 0);
            LblCostumerContactperson.Name = "LblCostumerContactperson";
            LblCostumerContactperson.Size = new Size(138, 25);
            LblCostumerContactperson.TabIndex = 51;
            LblCostumerContactperson.Text = "Kontaktperson";
            LblCostumerContactperson.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TblLayoutCostumer
            // 
            TblLayoutCostumer.ColumnCount = 2;
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 411F));
            TblLayoutCostumer.Controls.Add(TxtCostumerBusinessnumber, 1, 12);
            TblLayoutCostumer.Controls.Add(LblCostumerBusinessnumber, 0, 12);
            TblLayoutCostumer.Controls.Add(TxtCostumerNationality, 1, 8);
            TblLayoutCostumer.Controls.Add(LblCostumerNationality, 0, 8);
            TblLayoutCostumer.Controls.Add(LblCostumerDateofBirth, 0, 3);
            TblLayoutCostumer.Controls.Add(LblCostumerContactperson, 0, 16);
            TblLayoutCostumer.Controls.Add(LblCostumerFirstname, 0, 1);
            TblLayoutCostumer.Controls.Add(LblCostumerStreet, 0, 4);
            TblLayoutCostumer.Controls.Add(LblCostumerStreetnumber, 0, 5);
            TblLayoutCostumer.Controls.Add(LblCostumerZIPcode, 0, 6);
            TblLayoutCostumer.Controls.Add(LblCostumerPlace, 0, 7);
            TblLayoutCostumer.Controls.Add(TxtCostumerPlace, 1, 7);
            TblLayoutCostumer.Controls.Add(LblCostumerSex, 0, 9);
            TblLayoutCostumer.Controls.Add(TxtCostumerZIPcode, 1, 6);
            TblLayoutCostumer.Controls.Add(TxtCostumerStreetnumber, 1, 5);
            TblLayoutCostumer.Controls.Add(TxtCostumerStreet, 1, 4);
            TblLayoutCostumer.Controls.Add(LblCostumerEmail, 0, 13);
            TblLayoutCostumer.Controls.Add(TxtCostumerLastname, 1, 2);
            TblLayoutCostumer.Controls.Add(TxtCostumerFirstname, 1, 1);
            TblLayoutCostumer.Controls.Add(TxtCostumerEmail, 1, 13);
            TblLayoutCostumer.Controls.Add(LblCostumerCompany, 0, 14);
            TblLayoutCostumer.Controls.Add(LblCostumerCostumertype, 0, 15);
            TblLayoutCostumer.Controls.Add(TxtCostumerCompany, 1, 14);
            TblLayoutCostumer.Controls.Add(CmbCostumerCostumertype, 1, 15);
            TblLayoutCostumer.Controls.Add(TxtCostumerContactperson, 1, 16);
            TblLayoutCostumer.Controls.Add(GrpCostumerSex, 1, 9);
            TblLayoutCostumer.Controls.Add(LblCostumerTitle, 0, 0);
            TblLayoutCostumer.Controls.Add(TxtCostumerTitle, 1, 0);
            TblLayoutCostumer.Controls.Add(LblCostumerLastname, 0, 2);
            TblLayoutCostumer.Controls.Add(TxtCostumerPhonenumber, 1, 10);
            TblLayoutCostumer.Controls.Add(LblCostumerPhonenumber, 0, 10);
            TblLayoutCostumer.Controls.Add(LblCostumerMobilenumber, 0, 11);
            TblLayoutCostumer.Controls.Add(TxtCostumerMobilenumber, 1, 11);
            TblLayoutCostumer.Controls.Add(DtpCostumerDateofBirth, 1, 3);
            TblLayoutCostumer.Location = new Point(24, 93);
            TblLayoutCostumer.Margin = new Padding(2, 2, 2, 2);
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
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.Size = new Size(551, 428);
            TblLayoutCostumer.TabIndex = 48;
            TblLayoutCostumer.Paint += TblLayoutCostumer_Paint;
            // 
            // TxtCostumerBusinessnumber
            // 
            TxtCostumerBusinessnumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerBusinessnumber.Location = new Point(140, 301);
            TxtCostumerBusinessnumber.Margin = new Padding(0);
            TxtCostumerBusinessnumber.Name = "TxtCostumerBusinessnumber";
            TxtCostumerBusinessnumber.Size = new Size(411, 23);
            TxtCostumerBusinessnumber.TabIndex = 12;
            // 
            // LblCostumerBusinessnumber
            // 
            LblCostumerBusinessnumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerBusinessnumber.AutoSize = true;
            LblCostumerBusinessnumber.Location = new Point(1, 300);
            LblCostumerBusinessnumber.Margin = new Padding(1, 0, 1, 0);
            LblCostumerBusinessnumber.Name = "LblCostumerBusinessnumber";
            LblCostumerBusinessnumber.Size = new Size(138, 25);
            LblCostumerBusinessnumber.TabIndex = 49;
            LblCostumerBusinessnumber.Text = "Gechäftsnummer";
            LblCostumerBusinessnumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerNationality
            // 
            TxtCostumerNationality.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerNationality.Location = new Point(140, 201);
            TxtCostumerNationality.Margin = new Padding(0);
            TxtCostumerNationality.Name = "TxtCostumerNationality";
            TxtCostumerNationality.Size = new Size(411, 23);
            TxtCostumerNationality.TabIndex = 9;
            // 
            // LblCostumerNationality
            // 
            LblCostumerNationality.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerNationality.AutoSize = true;
            LblCostumerNationality.Location = new Point(1, 200);
            LblCostumerNationality.Margin = new Padding(1, 0, 1, 0);
            LblCostumerNationality.Name = "LblCostumerNationality";
            LblCostumerNationality.Size = new Size(138, 25);
            LblCostumerNationality.TabIndex = 49;
            LblCostumerNationality.Text = "Nationalität";
            LblCostumerNationality.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCostumerDateofBirth
            // 
            LblCostumerDateofBirth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerDateofBirth.AutoSize = true;
            LblCostumerDateofBirth.Location = new Point(1, 75);
            LblCostumerDateofBirth.Margin = new Padding(1, 0, 1, 0);
            LblCostumerDateofBirth.Name = "LblCostumerDateofBirth";
            LblCostumerDateofBirth.Size = new Size(138, 25);
            LblCostumerDateofBirth.TabIndex = 60;
            LblCostumerDateofBirth.Text = "Geburtsdatum";
            LblCostumerDateofBirth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DtpCostumerDateofBirth
            // 
            DtpCostumerDateofBirth.Location = new Point(140, 75);
            DtpCostumerDateofBirth.Margin = new Padding(0);
            DtpCostumerDateofBirth.Name = "DtpCostumerDateofBirth";
            DtpCostumerDateofBirth.Size = new Size(411, 23);
            DtpCostumerDateofBirth.TabIndex = 4;
            // 
            // TxtOutGridNotes
            // 
            TxtOutGridNotes.Location = new Point(24, 710);
            TxtOutGridNotes.Margin = new Padding(1);
            TxtOutGridNotes.Multiline = true;
            TxtOutGridNotes.Name = "TxtOutGridNotes";
            TxtOutGridNotes.Size = new Size(551, 109);
            TxtOutGridNotes.TabIndex = 49;
            // 
            // LblOutGridNotes
            // 
            LblOutGridNotes.AutoSize = true;
            LblOutGridNotes.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            LblOutGridNotes.Location = new Point(25, 694);
            LblOutGridNotes.Margin = new Padding(1, 0, 1, 0);
            LblOutGridNotes.Name = "LblOutGridNotes";
            LblOutGridNotes.Size = new Size(115, 15);
            LblOutGridNotes.TabIndex = 50;
            LblOutGridNotes.Text = "Bestehende Notizen:";
            LblOutGridNotes.Click += label1_Click_1;
            // 
            // CustumerRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 791);
            Controls.Add(LblOutGridNotes);
            Controls.Add(TxtOutGridNotes);
            Controls.Add(CmdSaveNote);
            Controls.Add(LblNotes);
            Controls.Add(TxtNotes);
            Controls.Add(CmdCostumerSave);
            Controls.Add(TblLayoutCostumer);
            Controls.Add(LblCostumerRegistration);
            Margin = new Padding(1);
            Name = "CustumerRegistration";
            Text = "Kundenerfassung";
            Load += CostumerRegistration_Load;
            groupBox.ResumeLayout(false);
            GrpCostumerSex.ResumeLayout(false);
            GrpCostumerSex.PerformLayout();
            TblLayoutCostumer.ResumeLayout(false);
            TblLayoutCostumer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox LblCostumerRegistration;
        private Button CmdCostumerSave;
        private GroupBox groupBox;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox TxtNotes;
        private Label LblNotes;
        private Button CmdSaveNote;
        private MaskedTextBox TxtCostumerTitle;
        private Label LblCostumerTitle;
        private GroupBox GrpCostumerSex;
        private RadioButton RadCostumerFemale;
        private RadioButton RadCostumerMale;
        private MaskedTextBox TxtCostumerContactperson;
        private ComboBox CmbCostumerCostumertype;
        private MaskedTextBox TxtCostumerCompany;
        private Label LblCostumerCostumertype;
        private Label LblCostumerCompany;
        private MaskedTextBox TxtCostumerEmail;
        private MaskedTextBox TxtCostumerFirstname;
        private MaskedTextBox TxtCostumerLastname;
        private Label LblCostumerEmail;
        private MaskedTextBox TxtCostumerStreet;
        private Label LblCostumerMobilenumber;
        private MaskedTextBox TxtCostumerStreetnumber;
        private Label LblCostumerPhonenumber;
        private MaskedTextBox TxtCostumerZIPcode;
        private Label LblCostumerSex;
        private MaskedTextBox TxtCostumerPlace;
        private Label LblCostumerPlace;
        private Label LblCostumerZIPcode;
        private MaskedTextBox TxtCostumerPhonenumber;
        private Label LblCostumerStreetnumber;
        private MaskedTextBox TxtCostumerMobilenumber;
        private Label LblCostumerStreet;
        private Label LblCostumerLastname;
        private Label LblCostumerFirstname;
        private Label LblCostumerContactperson;
        private TableLayoutPanel TblLayoutCostumer;
        private Label LblCostumerDateofBirth;
        private MaskedTextBox TxtCostumerNationality;
        private Label LblCostumerNationality;
        private Label LblCostumerBusinessnumber;
        private MaskedTextBox TxtCostumerBusinessnumber;
        private TextBox TxtOutGridNotes;
        private Label LblOutGridNotes;
        private DateTimePicker DtpCostumerDateofBirth;
    }
}