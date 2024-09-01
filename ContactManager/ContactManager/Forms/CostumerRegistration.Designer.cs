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
            BtnSaveNote = new Button();
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
            LblEmployeeContactperson = new Label();
            TblLayoutCostumer = new TableLayoutPanel();
            LblCostumerDateofBirth = new Label();
            TxtCostumerDateofBirth = new MaskedTextBox();
            groupBox.SuspendLayout();
            GrpCostumerSex.SuspendLayout();
            TblLayoutCostumer.SuspendLayout();
            SuspendLayout();
            // 
            // LblCostumerRegistration
            // 
            LblCostumerRegistration.Font = new Font("Segoe UI", 15F);
            LblCostumerRegistration.Location = new Point(21, 22);
            LblCostumerRegistration.Margin = new Padding(1);
            LblCostumerRegistration.Multiline = true;
            LblCostumerRegistration.Name = "LblCostumerRegistration";
            LblCostumerRegistration.Size = new Size(283, 35);
            LblCostumerRegistration.TabIndex = 42;
            LblCostumerRegistration.TabStop = false;
            LblCostumerRegistration.Text = "KUNDEN ERFASSUNG";
            LblCostumerRegistration.TextChanged += txtBoxKundenErfassungTitel_TextChanged;
            // 
            // CmdCostumerSave
            // 
            CmdCostumerSave.Location = new Point(362, 465);
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
            TxtNotes.Location = new Point(21, 489);
            TxtNotes.Margin = new Padding(1);
            TxtNotes.Multiline = true;
            TxtNotes.Name = "TxtNotes";
            TxtNotes.Size = new Size(279, 109);
            TxtNotes.TabIndex = 45;
            // 
            // LblNotes
            // 
            LblNotes.AutoSize = true;
            LblNotes.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            LblNotes.Location = new Point(21, 465);
            LblNotes.Margin = new Padding(1, 0, 1, 0);
            LblNotes.Name = "LblNotes";
            LblNotes.Size = new Size(51, 15);
            LblNotes.TabIndex = 46;
            LblNotes.Text = "Notizen:";
            // 
            // BtnSaveNote
            // 
            BtnSaveNote.Location = new Point(362, 576);
            BtnSaveNote.Margin = new Padding(1);
            BtnSaveNote.Name = "BtnSaveNote";
            BtnSaveNote.Size = new Size(103, 19);
            BtnSaveNote.TabIndex = 47;
            BtnSaveNote.Text = "Notiz speichern";
            BtnSaveNote.UseVisualStyleBackColor = true;
            BtnSaveNote.Click += BtnSaveNote_Click;
            // 
            // TxtCostumerTitle
            // 
            TxtCostumerTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerTitle.Location = new Point(101, 1);
            TxtCostumerTitle.Margin = new Padding(1);
            TxtCostumerTitle.Name = "TxtCostumerTitle";
            TxtCostumerTitle.Size = new Size(229, 23);
            TxtCostumerTitle.TabIndex = 54;
            // 
            // LblCostumerTitle
            // 
            LblCostumerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerTitle.AutoSize = true;
            LblCostumerTitle.Location = new Point(1, 0);
            LblCostumerTitle.Margin = new Padding(1, 0, 1, 0);
            LblCostumerTitle.Name = "LblCostumerTitle";
            LblCostumerTitle.Size = new Size(98, 25);
            LblCostumerTitle.TabIndex = 53;
            LblCostumerTitle.Text = "Titel";
            LblCostumerTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GrpCostumerSex
            // 
            GrpCostumerSex.Controls.Add(RadCostumerFemale);
            GrpCostumerSex.Controls.Add(RadCostumerMale);
            GrpCostumerSex.Location = new Point(103, 202);
            GrpCostumerSex.Name = "GrpCostumerSex";
            GrpCostumerSex.Size = new Size(164, 19);
            GrpCostumerSex.TabIndex = 52;
            GrpCostumerSex.TabStop = false;
            // 
            // RadCostumerFemale
            // 
            RadCostumerFemale.AutoSize = true;
            RadCostumerFemale.Location = new Point(81, 3);
            RadCostumerFemale.Name = "RadCostumerFemale";
            RadCostumerFemale.Size = new Size(71, 19);
            RadCostumerFemale.TabIndex = 1;
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
            RadCostumerMale.TabIndex = 0;
            RadCostumerMale.TabStop = true;
            RadCostumerMale.Text = "Männlich";
            RadCostumerMale.UseVisualStyleBackColor = true;
            // 
            // TxtCostumerContactperson
            // 
            TxtCostumerContactperson.Location = new Point(103, 352);
            TxtCostumerContactperson.Name = "TxtCostumerContactperson";
            TxtCostumerContactperson.Size = new Size(225, 23);
            TxtCostumerContactperson.TabIndex = 50;
            // 
            // CmbCostumerCostumertype
            // 
            CmbCostumerCostumertype.FormattingEnabled = true;
            CmbCostumerCostumertype.Location = new Point(103, 327);
            CmbCostumerCostumertype.Name = "CmbCostumerCostumertype";
            CmbCostumerCostumertype.Size = new Size(225, 23);
            CmbCostumerCostumertype.TabIndex = 49;
            // 
            // TxtCostumerCompany
            // 
            TxtCostumerCompany.Location = new Point(103, 302);
            TxtCostumerCompany.Name = "TxtCostumerCompany";
            TxtCostumerCompany.Size = new Size(225, 23);
            TxtCostumerCompany.TabIndex = 48;
            // 
            // LblCostumerCostumertype
            // 
            LblCostumerCostumertype.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerCostumertype.AutoSize = true;
            LblCostumerCostumertype.Location = new Point(1, 324);
            LblCostumerCostumertype.Margin = new Padding(1, 0, 1, 0);
            LblCostumerCostumertype.Name = "LblCostumerCostumertype";
            LblCostumerCostumertype.Size = new Size(98, 25);
            LblCostumerCostumertype.TabIndex = 47;
            LblCostumerCostumertype.Text = "Kundentyp";
            LblCostumerCostumertype.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCostumerCompany
            // 
            LblCostumerCompany.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerCompany.AutoSize = true;
            LblCostumerCompany.Location = new Point(1, 299);
            LblCostumerCompany.Margin = new Padding(1, 0, 1, 0);
            LblCostumerCompany.Name = "LblCostumerCompany";
            LblCostumerCompany.Size = new Size(98, 25);
            LblCostumerCompany.TabIndex = 43;
            LblCostumerCompany.Text = "Firma";
            LblCostumerCompany.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerEmail
            // 
            TxtCostumerEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerEmail.Location = new Point(101, 275);
            TxtCostumerEmail.Margin = new Padding(1);
            TxtCostumerEmail.Name = "TxtCostumerEmail";
            TxtCostumerEmail.Size = new Size(229, 23);
            TxtCostumerEmail.TabIndex = 41;
            // 
            // TxtCostumerFirstname
            // 
            TxtCostumerFirstname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerFirstname.Location = new Point(101, 26);
            TxtCostumerFirstname.Margin = new Padding(1);
            TxtCostumerFirstname.Name = "TxtCostumerFirstname";
            TxtCostumerFirstname.Size = new Size(229, 23);
            TxtCostumerFirstname.TabIndex = 32;
            // 
            // TxtCostumerLastname
            // 
            TxtCostumerLastname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerLastname.Location = new Point(101, 52);
            TxtCostumerLastname.Margin = new Padding(1);
            TxtCostumerLastname.Name = "TxtCostumerLastname";
            TxtCostumerLastname.Size = new Size(229, 23);
            TxtCostumerLastname.TabIndex = 33;
            // 
            // LblCostumerEmail
            // 
            LblCostumerEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerEmail.AutoSize = true;
            LblCostumerEmail.Location = new Point(1, 274);
            LblCostumerEmail.Margin = new Padding(1, 0, 1, 0);
            LblCostumerEmail.Name = "LblCostumerEmail";
            LblCostumerEmail.Size = new Size(98, 25);
            LblCostumerEmail.TabIndex = 31;
            LblCostumerEmail.Text = "Email-Adresse";
            LblCostumerEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerStreet
            // 
            TxtCostumerStreet.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerStreet.Location = new Point(101, 100);
            TxtCostumerStreet.Margin = new Padding(1);
            TxtCostumerStreet.Name = "TxtCostumerStreet";
            TxtCostumerStreet.Size = new Size(229, 23);
            TxtCostumerStreet.TabIndex = 34;
            // 
            // LblCostumerMobilenumber
            // 
            LblCostumerMobilenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerMobilenumber.AutoSize = true;
            LblCostumerMobilenumber.Location = new Point(1, 249);
            LblCostumerMobilenumber.Margin = new Padding(1, 0, 1, 0);
            LblCostumerMobilenumber.Name = "LblCostumerMobilenumber";
            LblCostumerMobilenumber.Size = new Size(98, 25);
            LblCostumerMobilenumber.TabIndex = 30;
            LblCostumerMobilenumber.Text = "Mobilnummer";
            LblCostumerMobilenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerStreetnumber
            // 
            TxtCostumerStreetnumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerStreetnumber.Location = new Point(101, 125);
            TxtCostumerStreetnumber.Margin = new Padding(1);
            TxtCostumerStreetnumber.Name = "TxtCostumerStreetnumber";
            TxtCostumerStreetnumber.Size = new Size(229, 23);
            TxtCostumerStreetnumber.TabIndex = 35;
            // 
            // LblCostumerPhonenumber
            // 
            LblCostumerPhonenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerPhonenumber.AutoSize = true;
            LblCostumerPhonenumber.Location = new Point(1, 224);
            LblCostumerPhonenumber.Margin = new Padding(1, 0, 1, 0);
            LblCostumerPhonenumber.Name = "LblCostumerPhonenumber";
            LblCostumerPhonenumber.Size = new Size(98, 25);
            LblCostumerPhonenumber.TabIndex = 29;
            LblCostumerPhonenumber.Text = "Telefonummer";
            LblCostumerPhonenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerZIPcode
            // 
            TxtCostumerZIPcode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerZIPcode.Location = new Point(101, 150);
            TxtCostumerZIPcode.Margin = new Padding(1);
            TxtCostumerZIPcode.Name = "TxtCostumerZIPcode";
            TxtCostumerZIPcode.Size = new Size(229, 23);
            TxtCostumerZIPcode.TabIndex = 36;
            // 
            // LblCostumerSex
            // 
            LblCostumerSex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerSex.AutoSize = true;
            LblCostumerSex.Location = new Point(1, 199);
            LblCostumerSex.Margin = new Padding(1, 0, 1, 0);
            LblCostumerSex.Name = "LblCostumerSex";
            LblCostumerSex.Size = new Size(98, 25);
            LblCostumerSex.TabIndex = 28;
            LblCostumerSex.Text = "Geschlecht";
            LblCostumerSex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerPlace
            // 
            TxtCostumerPlace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerPlace.Location = new Point(101, 175);
            TxtCostumerPlace.Margin = new Padding(1);
            TxtCostumerPlace.Name = "TxtCostumerPlace";
            TxtCostumerPlace.Size = new Size(229, 23);
            TxtCostumerPlace.TabIndex = 37;
            // 
            // LblCostumerPlace
            // 
            LblCostumerPlace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerPlace.AutoSize = true;
            LblCostumerPlace.Location = new Point(1, 174);
            LblCostumerPlace.Margin = new Padding(1, 0, 1, 0);
            LblCostumerPlace.Name = "LblCostumerPlace";
            LblCostumerPlace.Size = new Size(98, 25);
            LblCostumerPlace.TabIndex = 27;
            LblCostumerPlace.Text = "Ort";
            LblCostumerPlace.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCostumerZIPcode
            // 
            LblCostumerZIPcode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerZIPcode.AutoSize = true;
            LblCostumerZIPcode.Location = new Point(1, 149);
            LblCostumerZIPcode.Margin = new Padding(1, 0, 1, 0);
            LblCostumerZIPcode.Name = "LblCostumerZIPcode";
            LblCostumerZIPcode.Size = new Size(98, 25);
            LblCostumerZIPcode.TabIndex = 26;
            LblCostumerZIPcode.Text = "PLZ";
            LblCostumerZIPcode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerPhonenumber
            // 
            TxtCostumerPhonenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerPhonenumber.Location = new Point(101, 225);
            TxtCostumerPhonenumber.Margin = new Padding(1);
            TxtCostumerPhonenumber.Name = "TxtCostumerPhonenumber";
            TxtCostumerPhonenumber.Size = new Size(229, 23);
            TxtCostumerPhonenumber.TabIndex = 39;
            // 
            // LblCostumerStreetnumber
            // 
            LblCostumerStreetnumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerStreetnumber.AutoSize = true;
            LblCostumerStreetnumber.Location = new Point(1, 124);
            LblCostumerStreetnumber.Margin = new Padding(1, 0, 1, 0);
            LblCostumerStreetnumber.Name = "LblCostumerStreetnumber";
            LblCostumerStreetnumber.Size = new Size(98, 25);
            LblCostumerStreetnumber.TabIndex = 25;
            LblCostumerStreetnumber.Text = "Hausnummer";
            LblCostumerStreetnumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerMobilenumber
            // 
            TxtCostumerMobilenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerMobilenumber.Location = new Point(101, 250);
            TxtCostumerMobilenumber.Margin = new Padding(1);
            TxtCostumerMobilenumber.Name = "TxtCostumerMobilenumber";
            TxtCostumerMobilenumber.Size = new Size(229, 23);
            TxtCostumerMobilenumber.TabIndex = 40;
            // 
            // LblCostumerStreet
            // 
            LblCostumerStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerStreet.AutoSize = true;
            LblCostumerStreet.Location = new Point(1, 99);
            LblCostumerStreet.Margin = new Padding(1, 0, 1, 0);
            LblCostumerStreet.Name = "LblCostumerStreet";
            LblCostumerStreet.Size = new Size(98, 25);
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
            LblCostumerLastname.Size = new Size(98, 27);
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
            LblCostumerFirstname.Size = new Size(98, 25);
            LblCostumerFirstname.TabIndex = 22;
            LblCostumerFirstname.Text = "Vorname";
            LblCostumerFirstname.TextAlign = ContentAlignment.MiddleLeft;
            LblCostumerFirstname.Click += LblCostumerFirstname_Click;
            // 
            // LblEmployeeContactperson
            // 
            LblEmployeeContactperson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeContactperson.AutoSize = true;
            LblEmployeeContactperson.Location = new Point(1, 349);
            LblEmployeeContactperson.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeContactperson.Name = "LblEmployeeContactperson";
            LblEmployeeContactperson.Size = new Size(98, 25);
            LblEmployeeContactperson.TabIndex = 51;
            LblEmployeeContactperson.Text = "Konaktperson";
            LblEmployeeContactperson.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TblLayoutCostumer
            // 
            TblLayoutCostumer.ColumnCount = 2;
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 231F));
            TblLayoutCostumer.Controls.Add(LblCostumerDateofBirth, 0, 3);
            TblLayoutCostumer.Controls.Add(LblEmployeeContactperson, 0, 14);
            TblLayoutCostumer.Controls.Add(LblCostumerFirstname, 0, 1);
            TblLayoutCostumer.Controls.Add(LblCostumerStreet, 0, 4);
            TblLayoutCostumer.Controls.Add(TxtCostumerMobilenumber, 1, 10);
            TblLayoutCostumer.Controls.Add(LblCostumerStreetnumber, 0, 5);
            TblLayoutCostumer.Controls.Add(TxtCostumerPhonenumber, 1, 9);
            TblLayoutCostumer.Controls.Add(LblCostumerZIPcode, 0, 6);
            TblLayoutCostumer.Controls.Add(LblCostumerPlace, 0, 7);
            TblLayoutCostumer.Controls.Add(TxtCostumerPlace, 1, 7);
            TblLayoutCostumer.Controls.Add(LblCostumerSex, 0, 8);
            TblLayoutCostumer.Controls.Add(TxtCostumerZIPcode, 1, 6);
            TblLayoutCostumer.Controls.Add(LblCostumerPhonenumber, 0, 9);
            TblLayoutCostumer.Controls.Add(TxtCostumerStreetnumber, 1, 5);
            TblLayoutCostumer.Controls.Add(LblCostumerMobilenumber, 0, 10);
            TblLayoutCostumer.Controls.Add(TxtCostumerStreet, 1, 4);
            TblLayoutCostumer.Controls.Add(LblCostumerEmail, 0, 11);
            TblLayoutCostumer.Controls.Add(TxtCostumerLastname, 1, 2);
            TblLayoutCostumer.Controls.Add(TxtCostumerFirstname, 1, 1);
            TblLayoutCostumer.Controls.Add(TxtCostumerEmail, 1, 11);
            TblLayoutCostumer.Controls.Add(LblCostumerCompany, 0, 12);
            TblLayoutCostumer.Controls.Add(LblCostumerCostumertype, 0, 13);
            TblLayoutCostumer.Controls.Add(TxtCostumerCompany, 1, 12);
            TblLayoutCostumer.Controls.Add(CmbCostumerCostumertype, 1, 13);
            TblLayoutCostumer.Controls.Add(TxtCostumerContactperson, 1, 14);
            TblLayoutCostumer.Controls.Add(GrpCostumerSex, 1, 8);
            TblLayoutCostumer.Controls.Add(LblCostumerTitle, 0, 0);
            TblLayoutCostumer.Controls.Add(TxtCostumerTitle, 1, 0);
            TblLayoutCostumer.Controls.Add(LblCostumerLastname, 0, 2);
            TblLayoutCostumer.Controls.Add(TxtCostumerDateofBirth, 1, 3);
            TblLayoutCostumer.Location = new Point(24, 42);
            TblLayoutCostumer.Margin = new Padding(2);
            TblLayoutCostumer.Name = "TblLayoutCostumer";
            TblLayoutCostumer.RowCount = 16;
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
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
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            TblLayoutCostumer.Size = new Size(331, 398);
            TblLayoutCostumer.TabIndex = 48;
            TblLayoutCostumer.Paint += TblLayoutCostumer_Paint;
            // 
            // LblCostumerDateofBirth
            // 
            LblCostumerDateofBirth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerDateofBirth.AutoSize = true;
            LblCostumerDateofBirth.Location = new Point(1, 77);
            LblCostumerDateofBirth.Margin = new Padding(1, 0, 1, 0);
            LblCostumerDateofBirth.Name = "LblCostumerDateofBirth";
            LblCostumerDateofBirth.Size = new Size(98, 22);
            LblCostumerDateofBirth.TabIndex = 60;
            LblCostumerDateofBirth.Text = "Geburtsdatum";
            LblCostumerDateofBirth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerDateofBirth
            // 
            TxtCostumerDateofBirth.Location = new Point(101, 78);
            TxtCostumerDateofBirth.Margin = new Padding(1);
            TxtCostumerDateofBirth.Name = "TxtCostumerDateofBirth";
            TxtCostumerDateofBirth.Size = new Size(229, 23);
            TxtCostumerDateofBirth.TabIndex = 59;
            // 
            // CustumerRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 619);
            Controls.Add(BtnSaveNote);
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
        private Button BtnSaveNote;
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
        private Label LblEmployeeContactperson;
        private TableLayoutPanel TblLayoutCostumer;
        private Label LblCostumerDateofBirth;
        private MaskedTextBox TxtCostumerDateofBirth;
    }
}