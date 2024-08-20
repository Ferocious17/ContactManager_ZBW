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
            RadCostumerMale = new RadioButton();
            RadCostumerFemale = new RadioButton();
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
            TxtCostumerDateofBirth = new MaskedTextBox();
            LblCostumerDateofBirth = new Label();
            groupBox.SuspendLayout();
            GrpCostumerSex.SuspendLayout();
            TblLayoutCostumer.SuspendLayout();
            SuspendLayout();
            // 
            // LblCostumerRegistration
            // 
            LblCostumerRegistration.Font = new Font("Segoe UI", 15F);
            LblCostumerRegistration.Location = new Point(51, 60);
            LblCostumerRegistration.Margin = new Padding(2, 3, 2, 3);
            LblCostumerRegistration.Multiline = true;
            LblCostumerRegistration.Name = "LblCostumerRegistration";
            LblCostumerRegistration.Size = new Size(682, 89);
            LblCostumerRegistration.TabIndex = 42;
            LblCostumerRegistration.TabStop = false;
            LblCostumerRegistration.Text = "KUNDEN ERFASSUNG";
            LblCostumerRegistration.TextChanged += txtBoxKundenErfassungTitel_TextChanged;
            // 
            // CmdCostumerSave
            // 
            CmdCostumerSave.Location = new Point(879, 1271);
            CmdCostumerSave.Margin = new Padding(2, 3, 2, 3);
            CmdCostumerSave.Name = "CmdCostumerSave";
            CmdCostumerSave.Size = new Size(250, 82);
            CmdCostumerSave.TabIndex = 44;
            CmdCostumerSave.Text = "Speichern";
            CmdCostumerSave.UseVisualStyleBackColor = true;
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
            TxtNotes.Location = new Point(51, 1336);
            TxtNotes.Multiline = true;
            TxtNotes.Name = "TxtNotes";
            TxtNotes.Size = new Size(672, 290);
            TxtNotes.TabIndex = 45;
            // 
            // LblNotes
            // 
            LblNotes.AutoSize = true;
            LblNotes.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            LblNotes.Location = new Point(51, 1271);
            LblNotes.Name = "LblNotes";
            LblNotes.Size = new Size(129, 41);
            LblNotes.TabIndex = 46;
            LblNotes.Text = "Notizen:";
            // 
            // BtnSaveNote
            // 
            BtnSaveNote.Location = new Point(879, 1574);
            BtnSaveNote.Margin = new Padding(2, 3, 2, 3);
            BtnSaveNote.Name = "BtnSaveNote";
            BtnSaveNote.Size = new Size(250, 52);
            BtnSaveNote.TabIndex = 47;
            BtnSaveNote.Text = "Notiz speichern";
            BtnSaveNote.UseVisualStyleBackColor = true;
            // 
            // TxtCostumerTitle
            // 
            TxtCostumerTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerTitle.Location = new Point(245, 10);
            TxtCostumerTitle.Margin = new Padding(2, 3, 2, 3);
            TxtCostumerTitle.Name = "TxtCostumerTitle";
            TxtCostumerTitle.Size = new Size(557, 47);
            TxtCostumerTitle.TabIndex = 54;
            // 
            // LblCostumerTitle
            // 
            LblCostumerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerTitle.AutoSize = true;
            LblCostumerTitle.Location = new Point(2, 0);
            LblCostumerTitle.Margin = new Padding(2, 0, 2, 0);
            LblCostumerTitle.Name = "LblCostumerTitle";
            LblCostumerTitle.Size = new Size(239, 68);
            LblCostumerTitle.TabIndex = 53;
            LblCostumerTitle.Text = "Titel";
            LblCostumerTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GrpCostumerSex
            // 
            GrpCostumerSex.Controls.Add(RadCostumerFemale);
            GrpCostumerSex.Controls.Add(RadCostumerMale);
            GrpCostumerSex.Location = new Point(250, 552);
            GrpCostumerSex.Margin = new Padding(7, 8, 7, 8);
            GrpCostumerSex.Name = "GrpCostumerSex";
            GrpCostumerSex.Padding = new Padding(7, 8, 7, 8);
            GrpCostumerSex.Size = new Size(398, 52);
            GrpCostumerSex.TabIndex = 52;
            GrpCostumerSex.TabStop = false;
            // 
            // RadCostumerMale
            // 
            RadCostumerMale.AutoSize = true;
            RadCostumerMale.Checked = true;
            RadCostumerMale.Location = new Point(0, 8);
            RadCostumerMale.Margin = new Padding(7, 8, 7, 8);
            RadCostumerMale.Name = "RadCostumerMale";
            RadCostumerMale.Size = new Size(176, 45);
            RadCostumerMale.TabIndex = 0;
            RadCostumerMale.TabStop = true;
            RadCostumerMale.Text = "Männlich";
            RadCostumerMale.UseVisualStyleBackColor = true;
            // 
            // RadCostumerFemale
            // 
            RadCostumerFemale.AutoSize = true;
            RadCostumerFemale.Location = new Point(197, 8);
            RadCostumerFemale.Margin = new Padding(7, 8, 7, 8);
            RadCostumerFemale.Name = "RadCostumerFemale";
            RadCostumerFemale.Size = new Size(168, 45);
            RadCostumerFemale.TabIndex = 1;
            RadCostumerFemale.Text = "Weiblich";
            RadCostumerFemale.UseVisualStyleBackColor = true;
            // 
            // TxtCostumerContactperson
            // 
            TxtCostumerContactperson.Location = new Point(250, 960);
            TxtCostumerContactperson.Margin = new Padding(7, 8, 7, 8);
            TxtCostumerContactperson.Name = "TxtCostumerContactperson";
            TxtCostumerContactperson.Size = new Size(547, 47);
            TxtCostumerContactperson.TabIndex = 50;
            // 
            // CmbCostumerCostumertype
            // 
            CmbCostumerCostumertype.FormattingEnabled = true;
            CmbCostumerCostumertype.Location = new Point(250, 892);
            CmbCostumerCostumertype.Margin = new Padding(7, 8, 7, 8);
            CmbCostumerCostumertype.Name = "CmbCostumerCostumertype";
            CmbCostumerCostumertype.Size = new Size(547, 49);
            CmbCostumerCostumertype.TabIndex = 49;
            // 
            // TxtCostumerCompany
            // 
            TxtCostumerCompany.Location = new Point(250, 824);
            TxtCostumerCompany.Margin = new Padding(7, 8, 7, 8);
            TxtCostumerCompany.Name = "TxtCostumerCompany";
            TxtCostumerCompany.Size = new Size(547, 47);
            TxtCostumerCompany.TabIndex = 48;
            // 
            // LblCostumerCostumertype
            // 
            LblCostumerCostumertype.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerCostumertype.AutoSize = true;
            LblCostumerCostumertype.Location = new Point(2, 884);
            LblCostumerCostumertype.Margin = new Padding(2, 0, 2, 0);
            LblCostumerCostumertype.Name = "LblCostumerCostumertype";
            LblCostumerCostumertype.Size = new Size(239, 68);
            LblCostumerCostumertype.TabIndex = 47;
            LblCostumerCostumertype.Text = "Kundentyp";
            LblCostumerCostumertype.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCostumerCompany
            // 
            LblCostumerCompany.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerCompany.AutoSize = true;
            LblCostumerCompany.Location = new Point(2, 816);
            LblCostumerCompany.Margin = new Padding(2, 0, 2, 0);
            LblCostumerCompany.Name = "LblCostumerCompany";
            LblCostumerCompany.Size = new Size(239, 68);
            LblCostumerCompany.TabIndex = 43;
            LblCostumerCompany.Text = "Firma";
            LblCostumerCompany.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerEmail
            // 
            TxtCostumerEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerEmail.Location = new Point(245, 758);
            TxtCostumerEmail.Margin = new Padding(2, 3, 2, 3);
            TxtCostumerEmail.Name = "TxtCostumerEmail";
            TxtCostumerEmail.Size = new Size(557, 47);
            TxtCostumerEmail.TabIndex = 41;
            // 
            // TxtCostumerFirstname
            // 
            TxtCostumerFirstname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerFirstname.Location = new Point(245, 78);
            TxtCostumerFirstname.Margin = new Padding(2, 3, 2, 3);
            TxtCostumerFirstname.Name = "TxtCostumerFirstname";
            TxtCostumerFirstname.Size = new Size(557, 47);
            TxtCostumerFirstname.TabIndex = 32;
            // 
            // TxtCostumerLastname
            // 
            TxtCostumerLastname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerLastname.Location = new Point(245, 150);
            TxtCostumerLastname.Margin = new Padding(2, 3, 2, 3);
            TxtCostumerLastname.Name = "TxtCostumerLastname";
            TxtCostumerLastname.Size = new Size(557, 47);
            TxtCostumerLastname.TabIndex = 33;
            // 
            // LblCostumerEmail
            // 
            LblCostumerEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerEmail.AutoSize = true;
            LblCostumerEmail.Location = new Point(2, 748);
            LblCostumerEmail.Margin = new Padding(2, 0, 2, 0);
            LblCostumerEmail.Name = "LblCostumerEmail";
            LblCostumerEmail.Size = new Size(239, 68);
            LblCostumerEmail.TabIndex = 31;
            LblCostumerEmail.Text = "Email-Adresse";
            LblCostumerEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerStreet
            // 
            TxtCostumerStreet.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerStreet.Location = new Point(245, 282);
            TxtCostumerStreet.Margin = new Padding(2, 3, 2, 3);
            TxtCostumerStreet.Name = "TxtCostumerStreet";
            TxtCostumerStreet.Size = new Size(557, 47);
            TxtCostumerStreet.TabIndex = 34;
            // 
            // LblCostumerMobilenumber
            // 
            LblCostumerMobilenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerMobilenumber.AutoSize = true;
            LblCostumerMobilenumber.Location = new Point(2, 680);
            LblCostumerMobilenumber.Margin = new Padding(2, 0, 2, 0);
            LblCostumerMobilenumber.Name = "LblCostumerMobilenumber";
            LblCostumerMobilenumber.Size = new Size(239, 68);
            LblCostumerMobilenumber.TabIndex = 30;
            LblCostumerMobilenumber.Text = "Mobilnummer";
            LblCostumerMobilenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerStreetnumber
            // 
            TxtCostumerStreetnumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerStreetnumber.Location = new Point(245, 350);
            TxtCostumerStreetnumber.Margin = new Padding(2, 3, 2, 3);
            TxtCostumerStreetnumber.Name = "TxtCostumerStreetnumber";
            TxtCostumerStreetnumber.Size = new Size(557, 47);
            TxtCostumerStreetnumber.TabIndex = 35;
            // 
            // LblCostumerPhonenumber
            // 
            LblCostumerPhonenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerPhonenumber.AutoSize = true;
            LblCostumerPhonenumber.Location = new Point(2, 612);
            LblCostumerPhonenumber.Margin = new Padding(2, 0, 2, 0);
            LblCostumerPhonenumber.Name = "LblCostumerPhonenumber";
            LblCostumerPhonenumber.Size = new Size(239, 68);
            LblCostumerPhonenumber.TabIndex = 29;
            LblCostumerPhonenumber.Text = "Telefonummer";
            LblCostumerPhonenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerZIPcode
            // 
            TxtCostumerZIPcode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerZIPcode.Location = new Point(245, 418);
            TxtCostumerZIPcode.Margin = new Padding(2, 3, 2, 3);
            TxtCostumerZIPcode.Name = "TxtCostumerZIPcode";
            TxtCostumerZIPcode.Size = new Size(557, 47);
            TxtCostumerZIPcode.TabIndex = 36;
            // 
            // LblCostumerSex
            // 
            LblCostumerSex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerSex.AutoSize = true;
            LblCostumerSex.Location = new Point(2, 544);
            LblCostumerSex.Margin = new Padding(2, 0, 2, 0);
            LblCostumerSex.Name = "LblCostumerSex";
            LblCostumerSex.Size = new Size(239, 68);
            LblCostumerSex.TabIndex = 28;
            LblCostumerSex.Text = "Geschlecht";
            LblCostumerSex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerPlace
            // 
            TxtCostumerPlace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerPlace.Location = new Point(245, 486);
            TxtCostumerPlace.Margin = new Padding(2, 3, 2, 3);
            TxtCostumerPlace.Name = "TxtCostumerPlace";
            TxtCostumerPlace.Size = new Size(557, 47);
            TxtCostumerPlace.TabIndex = 37;
            // 
            // LblCostumerPlace
            // 
            LblCostumerPlace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerPlace.AutoSize = true;
            LblCostumerPlace.Location = new Point(2, 476);
            LblCostumerPlace.Margin = new Padding(2, 0, 2, 0);
            LblCostumerPlace.Name = "LblCostumerPlace";
            LblCostumerPlace.Size = new Size(239, 68);
            LblCostumerPlace.TabIndex = 27;
            LblCostumerPlace.Text = "Ort";
            LblCostumerPlace.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCostumerZIPcode
            // 
            LblCostumerZIPcode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerZIPcode.AutoSize = true;
            LblCostumerZIPcode.Location = new Point(2, 408);
            LblCostumerZIPcode.Margin = new Padding(2, 0, 2, 0);
            LblCostumerZIPcode.Name = "LblCostumerZIPcode";
            LblCostumerZIPcode.Size = new Size(239, 68);
            LblCostumerZIPcode.TabIndex = 26;
            LblCostumerZIPcode.Text = "PLZ";
            LblCostumerZIPcode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerPhonenumber
            // 
            TxtCostumerPhonenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerPhonenumber.Location = new Point(245, 622);
            TxtCostumerPhonenumber.Margin = new Padding(2, 3, 2, 3);
            TxtCostumerPhonenumber.Name = "TxtCostumerPhonenumber";
            TxtCostumerPhonenumber.Size = new Size(557, 47);
            TxtCostumerPhonenumber.TabIndex = 39;
            // 
            // LblCostumerStreetnumber
            // 
            LblCostumerStreetnumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerStreetnumber.AutoSize = true;
            LblCostumerStreetnumber.Location = new Point(2, 340);
            LblCostumerStreetnumber.Margin = new Padding(2, 0, 2, 0);
            LblCostumerStreetnumber.Name = "LblCostumerStreetnumber";
            LblCostumerStreetnumber.Size = new Size(239, 68);
            LblCostumerStreetnumber.TabIndex = 25;
            LblCostumerStreetnumber.Text = "Hausnummer";
            LblCostumerStreetnumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCostumerMobilenumber
            // 
            TxtCostumerMobilenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerMobilenumber.Location = new Point(245, 690);
            TxtCostumerMobilenumber.Margin = new Padding(2, 3, 2, 3);
            TxtCostumerMobilenumber.Name = "TxtCostumerMobilenumber";
            TxtCostumerMobilenumber.Size = new Size(557, 47);
            TxtCostumerMobilenumber.TabIndex = 40;
            // 
            // LblCostumerStreet
            // 
            LblCostumerStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerStreet.AutoSize = true;
            LblCostumerStreet.Location = new Point(2, 272);
            LblCostumerStreet.Margin = new Padding(2, 0, 2, 0);
            LblCostumerStreet.Name = "LblCostumerStreet";
            LblCostumerStreet.Size = new Size(239, 68);
            LblCostumerStreet.TabIndex = 24;
            LblCostumerStreet.Text = "Strasse";
            LblCostumerStreet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCostumerLastname
            // 
            LblCostumerLastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerLastname.AutoSize = true;
            LblCostumerLastname.Location = new Point(2, 136);
            LblCostumerLastname.Margin = new Padding(2, 0, 2, 0);
            LblCostumerLastname.Name = "LblCostumerLastname";
            LblCostumerLastname.Size = new Size(239, 75);
            LblCostumerLastname.TabIndex = 23;
            LblCostumerLastname.Text = "Nachname";
            LblCostumerLastname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblCostumerFirstname
            // 
            LblCostumerFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerFirstname.AutoSize = true;
            LblCostumerFirstname.Location = new Point(2, 68);
            LblCostumerFirstname.Margin = new Padding(2, 0, 2, 0);
            LblCostumerFirstname.Name = "LblCostumerFirstname";
            LblCostumerFirstname.Size = new Size(239, 68);
            LblCostumerFirstname.TabIndex = 22;
            LblCostumerFirstname.Text = "Vorname";
            LblCostumerFirstname.TextAlign = ContentAlignment.MiddleLeft;
            LblCostumerFirstname.Click += LblCostumerFirstname_Click;
            // 
            // LblEmployeeContactperson
            // 
            LblEmployeeContactperson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeContactperson.AutoSize = true;
            LblEmployeeContactperson.Location = new Point(2, 952);
            LblEmployeeContactperson.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeContactperson.Name = "LblEmployeeContactperson";
            LblEmployeeContactperson.Size = new Size(239, 68);
            LblEmployeeContactperson.TabIndex = 51;
            LblEmployeeContactperson.Text = "Konaktperson";
            LblEmployeeContactperson.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TblLayoutCostumer
            // 
            TblLayoutCostumer.ColumnCount = 2;
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243F));
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 486F));
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
            TblLayoutCostumer.Location = new Point(58, 116);
            TblLayoutCostumer.Margin = new Padding(5);
            TblLayoutCostumer.Name = "TblLayoutCostumer";
            TblLayoutCostumer.RowCount = 16;
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TblLayoutCostumer.Size = new Size(804, 1087);
            TblLayoutCostumer.TabIndex = 48;
            TblLayoutCostumer.Paint += TblLayoutCostumer_Paint;
            // 
            // TxtCostumerDateofBirth
            // 
            TxtCostumerDateofBirth.Location = new Point(245, 214);
            TxtCostumerDateofBirth.Margin = new Padding(2, 3, 2, 3);
            TxtCostumerDateofBirth.Name = "TxtCostumerDateofBirth";
            TxtCostumerDateofBirth.Size = new Size(557, 47);
            TxtCostumerDateofBirth.TabIndex = 59;
            // 
            // LblCostumerDateofBirth
            // 
            LblCostumerDateofBirth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblCostumerDateofBirth.AutoSize = true;
            LblCostumerDateofBirth.Location = new Point(2, 211);
            LblCostumerDateofBirth.Margin = new Padding(2, 0, 2, 0);
            LblCostumerDateofBirth.Name = "LblCostumerDateofBirth";
            LblCostumerDateofBirth.Size = new Size(239, 61);
            LblCostumerDateofBirth.TabIndex = 60;
            LblCostumerDateofBirth.Text = "Geburtsdatum";
            LblCostumerDateofBirth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustumerRegistration
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 1692);
            Controls.Add(BtnSaveNote);
            Controls.Add(LblNotes);
            Controls.Add(TxtNotes);
            Controls.Add(CmdCostumerSave);
            Controls.Add(TblLayoutCostumer);
            Controls.Add(LblCostumerRegistration);
            Margin = new Padding(2, 3, 2, 3);
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