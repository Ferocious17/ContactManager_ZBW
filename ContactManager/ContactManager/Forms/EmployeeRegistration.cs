using ContactManager.Models;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace ContactManager.Forms
{
    public partial class LblEmployeeRegistration : Form
    {
        private Button CmdEmployeeCancel;
        private Label LblEmployeeFirstName;
        private Label LblEmployeeLastName;
        private Label LblEmployeeGender;
        private Label LblEmployeeDateOfBirth;
        private Label LblEmployeeAdress;
        private Label LblEmployeeZipCode;




        public LblEmployeeRegistration()
        {
            InitializeComponent();
        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {

            //StartWindow Design
            BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            TxtTitleEmployeeRegistration.Font = new Font(TxtTitleEmployeeRegistration.Font, FontStyle.Bold);
            TxtTitleEmployeeRegistration.ForeColor = Color.Black;
            TxtTitleEmployeeRegistration.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            TxtTitleEmployeeRegistration.BorderStyle = BorderStyle.None;

            //Buttons Design

            btnSaveEmpoloyeRegistration.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            btnSaveEmpoloyeRegistration.ForeColor = Color.White;
            btnSaveEmpoloyeRegistration.FlatStyle = FlatStyle.Flat;
            btnSaveEmpoloyeRegistration.FlatAppearance.BorderSize = 0; // Set button border size to 0
            btnSaveEmpoloyeRegistration.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSaveEmpoloyeRegistration.Width, btnSaveEmpoloyeRegistration.Height, 5, 5)); // Create rounded rectangle region

            TxtEmployeeTrainigyear.Enabled = ChkEmployeeTrainee.Checked;
        }

        private void checkBoxTrainee_CheckedChanged(object sender, EventArgs e)
        {
            // Code hier einfügen, um die gewünschten Aktionen auszuführen,
            // wenn die Checkbox geändert wird.
            // Beispiel: Ein Textfeld ein- oder ausschalten
            TxtEmployeeTrainigyear.Enabled = ChkEmployeeTrainee.Checked;
        }

        // Helper method to create a rounded rectangle region
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void label11_Click(object sender, EventArgs e)
        {
            // Event handler logic
        }

        private void lblBoxAdressEmp_Click(object sender, EventArgs e)
        {
            // Event handler logic
        }

        private void TblLayoutEmployee_Paint(object sender, PaintEventArgs e)
        {
            // Event handler logic
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Event handler logic
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Event handler logic
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Event handler logic
        }

        private void InitializeComponent()
        {
            TblLayoutCostumer = new TableLayoutPanel();
            LblEmployeeLastname = new Label();
            LblEmployeeFirstname = new Label();
            LblEmployeeZIPcode = new Label();
            TxtEmployeeTrainigyear = new MaskedTextBox();
            DtpEmployeeEnddate = new DateTimePicker();
            LblEmployeeRole = new Label();
            LblEmployeeEnddate = new Label();
            LblEmployeeStreet = new Label();
            TxtCostumerMobilenumber = new MaskedTextBox();
            LblEmployeeHousenumber = new Label();
            TxtCostumerPhonenumber = new MaskedTextBox();
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
            LblEmployeeTrainigyear = new Label();
            DtpEmployeeStartdate = new DateTimePicker();
            CmbEmployeeDepartement = new ComboBox();
            GrpEmployeeSex = new GroupBox();
            RadEmployeeFemale = new RadioButton();
            RadEmployeeMale = new RadioButton();
            maskedTextBox1 = new MaskedTextBox();
            CmbEmployeeRegistration = new ComboBox();
            label3 = new Label();
            btnSaveEmpoloyeRegistration = new Button();
            TxtTitleEmployeeRegistration = new TextBox();
            TblLayoutCostumer.SuspendLayout();
            GrpEmployeeSex.SuspendLayout();
            SuspendLayout();
            // 
            // TblLayoutCostumer
            // 
            TblLayoutCostumer.ColumnCount = 2;
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            TblLayoutCostumer.Controls.Add(LblEmployeeLastname, 0, 2);
            TblLayoutCostumer.Controls.Add(LblEmployeeFirstname, 0, 1);
            TblLayoutCostumer.Controls.Add(LblEmployeeZIPcode, 0, 5);
            TblLayoutCostumer.Controls.Add(TxtEmployeeTrainigyear, 1, 16);
            TblLayoutCostumer.Controls.Add(DtpEmployeeEnddate, 1, 13);
            TblLayoutCostumer.Controls.Add(LblEmployeeRole, 0, 14);
            TblLayoutCostumer.Controls.Add(LblEmployeeEnddate, 0, 13);
            TblLayoutCostumer.Controls.Add(LblEmployeeStreet, 0, 3);
            TblLayoutCostumer.Controls.Add(TxtCostumerMobilenumber, 1, 9);
            TblLayoutCostumer.Controls.Add(LblEmployeeHousenumber, 0, 4);
            TblLayoutCostumer.Controls.Add(TxtCostumerPhonenumber, 1, 8);
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
            TblLayoutCostumer.Controls.Add(CmbEmployeeDepartement, 1, 11);
            TblLayoutCostumer.Controls.Add(GrpEmployeeSex, 1, 7);
            TblLayoutCostumer.Controls.Add(maskedTextBox1, 1, 14);
            TblLayoutCostumer.Controls.Add(CmbEmployeeRegistration, 1, 15);
            TblLayoutCostumer.Location = new Point(11, 60);
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
            TblLayoutCostumer.Size = new Size(299, 428);
            TblLayoutCostumer.TabIndex = 48;
            // 
            // LblEmployeeLastname
            // 
            LblEmployeeLastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeLastname.AutoSize = true;
            LblEmployeeLastname.Location = new Point(1, 50);
            LblEmployeeLastname.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeLastname.Name = "LblEmployeeLastname";
            LblEmployeeLastname.Size = new Size(98, 25);
            LblEmployeeLastname.TabIndex = 66;
            LblEmployeeLastname.Text = "Nachname";
            LblEmployeeLastname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeFirstname
            // 
            LblEmployeeFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeFirstname.AutoSize = true;
            LblEmployeeFirstname.Location = new Point(1, 25);
            LblEmployeeFirstname.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeFirstname.Name = "LblEmployeeFirstname";
            LblEmployeeFirstname.Size = new Size(98, 25);
            LblEmployeeFirstname.TabIndex = 65;
            LblEmployeeFirstname.Text = "Vorname";
            LblEmployeeFirstname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeZIPcode
            // 
            LblEmployeeZIPcode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeZIPcode.AutoSize = true;
            LblEmployeeZIPcode.Location = new Point(1, 125);
            LblEmployeeZIPcode.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeZIPcode.Name = "LblEmployeeZIPcode";
            LblEmployeeZIPcode.Size = new Size(98, 25);
            LblEmployeeZIPcode.TabIndex = 69;
            LblEmployeeZIPcode.Text = "PLZ";
            LblEmployeeZIPcode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeTrainigyear
            // 
            TxtEmployeeTrainigyear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeTrainigyear.Location = new Point(101, 401);
            TxtEmployeeTrainigyear.Margin = new Padding(1);
            TxtEmployeeTrainigyear.Name = "TxtEmployeeTrainigyear";
            TxtEmployeeTrainigyear.Size = new Size(298, 23);
            TxtEmployeeTrainigyear.TabIndex = 63;
            // 
            // DtpEmployeeEnddate
            // 
            DtpEmployeeEnddate.Location = new Point(103, 328);
            DtpEmployeeEnddate.Name = "DtpEmployeeEnddate";
            DtpEmployeeEnddate.Size = new Size(194, 23);
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
            TxtCostumerMobilenumber.Size = new Size(298, 23);
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
            TxtCostumerPhonenumber.Size = new Size(298, 23);
            TxtCostumerPhonenumber.TabIndex = 39;
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
            TxtCostumerPlace.Size = new Size(298, 23);
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
            TxtCostumerZIPcode.Size = new Size(298, 23);
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
            TxtCostumerStreetnumber.Size = new Size(298, 23);
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
            TxtCostumerStreet.Size = new Size(298, 23);
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
            TxtCostumerLastname.Size = new Size(298, 23);
            TxtCostumerLastname.TabIndex = 33;
            // 
            // TxtCostumerFirstname
            // 
            TxtCostumerFirstname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerFirstname.Location = new Point(101, 26);
            TxtCostumerFirstname.Margin = new Padding(1);
            TxtCostumerFirstname.Name = "TxtCostumerFirstname";
            TxtCostumerFirstname.Size = new Size(298, 23);
            TxtCostumerFirstname.TabIndex = 32;
            // 
            // TxtCostumerEmail
            // 
            TxtCostumerEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtCostumerEmail.Location = new Point(101, 251);
            TxtCostumerEmail.Margin = new Padding(1);
            TxtCostumerEmail.Name = "TxtCostumerEmail";
            TxtCostumerEmail.Size = new Size(298, 23);
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
            ChkEmployeeTrainee.CheckedChanged += checkBoxTrainee_CheckedChanged;
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
            // DtpEmployeeStartdate
            // 
            DtpEmployeeStartdate.Location = new Point(103, 303);
            DtpEmployeeStartdate.Name = "DtpEmployeeStartdate";
            DtpEmployeeStartdate.Size = new Size(196, 23);
            DtpEmployeeStartdate.TabIndex = 57;
            // 
            // CmbEmployeeDepartement
            // 
            CmbEmployeeDepartement.FormattingEnabled = true;
            CmbEmployeeDepartement.Location = new Point(103, 278);
            CmbEmployeeDepartement.Name = "CmbEmployeeDepartement";
            CmbEmployeeDepartement.Size = new Size(196, 23);
            CmbEmployeeDepartement.TabIndex = 58;
            // 
            // GrpEmployeeSex
            // 
            GrpEmployeeSex.Controls.Add(RadEmployeeFemale);
            GrpEmployeeSex.Controls.Add(RadEmployeeMale);
            GrpEmployeeSex.Location = new Point(103, 178);
            GrpEmployeeSex.Name = "GrpEmployeeSex";
            GrpEmployeeSex.Size = new Size(194, 19);
            GrpEmployeeSex.TabIndex = 70;
            GrpEmployeeSex.TabStop = false;
            // 
            // RadEmployeeFemale
            // 
            RadEmployeeFemale.AutoSize = true;
            RadEmployeeFemale.Location = new Point(81, 0);
            RadEmployeeFemale.Name = "RadEmployeeFemale";
            RadEmployeeFemale.Size = new Size(71, 19);
            RadEmployeeFemale.TabIndex = 1;
            RadEmployeeFemale.TabStop = true;
            RadEmployeeFemale.Text = "Weiblich";
            RadEmployeeFemale.UseVisualStyleBackColor = true;
            // 
            // RadEmployeeMale
            // 
            RadEmployeeMale.AutoSize = true;
            RadEmployeeMale.Location = new Point(0, 0);
            RadEmployeeMale.Name = "RadEmployeeMale";
            RadEmployeeMale.Size = new Size(75, 19);
            RadEmployeeMale.TabIndex = 0;
            RadEmployeeMale.TabStop = true;
            RadEmployeeMale.Text = "Männlich";
            RadEmployeeMale.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox1.Location = new Point(101, 351);
            maskedTextBox1.Margin = new Padding(1);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(298, 23);
            maskedTextBox1.TabIndex = 62;
            // 
            // CmbEmployeeRegistration
            // 
            CmbEmployeeRegistration.FormattingEnabled = true;
            CmbEmployeeRegistration.Location = new Point(103, 378);
            CmbEmployeeRegistration.Name = "CmbEmployeeRegistration";
            CmbEmployeeRegistration.Size = new Size(198, 23);
            CmbEmployeeRegistration.TabIndex = 71;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(175, 201);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 49;
            label3.Text = "Email-Adresse";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSaveEmpoloyeRegistration
            // 
            btnSaveEmpoloyeRegistration.Location = new Point(339, 457);
            btnSaveEmpoloyeRegistration.Margin = new Padding(1);
            btnSaveEmpoloyeRegistration.Name = "btnSaveEmpoloyeRegistration";
            btnSaveEmpoloyeRegistration.Size = new Size(103, 30);
            btnSaveEmpoloyeRegistration.TabIndex = 47;
            btnSaveEmpoloyeRegistration.Text = "Speichern";
            btnSaveEmpoloyeRegistration.UseVisualStyleBackColor = true;
            btnSaveEmpoloyeRegistration.Click += btnSaveEmpoloyeRegistration_Click;
            // 
            // TxtTitleEmployeeRegistration
            // 
            TxtTitleEmployeeRegistration.Font = new Font("Segoe UI", 15F);
            TxtTitleEmployeeRegistration.Location = new Point(15, 10);
            TxtTitleEmployeeRegistration.Margin = new Padding(1);
            TxtTitleEmployeeRegistration.Multiline = true;
            TxtTitleEmployeeRegistration.Name = "TxtTitleEmployeeRegistration";
            TxtTitleEmployeeRegistration.Size = new Size(251, 35);
            TxtTitleEmployeeRegistration.TabIndex = 64;
            TxtTitleEmployeeRegistration.TabStop = false;
            TxtTitleEmployeeRegistration.Text = "MITARBEITER ERFASSUNG";
            // 
            // LblEmployeeRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 518);
            Controls.Add(TxtTitleEmployeeRegistration);
            Controls.Add(TblLayoutCostumer);
            Controls.Add(label3);
            Controls.Add(btnSaveEmpoloyeRegistration);
            Name = "LblEmployeeRegistration";
            Text = "Employee Registration";
            Load += EmployeeRegistration_Load;
            TblLayoutCostumer.ResumeLayout(false);
            TblLayoutCostumer.PerformLayout();
            GrpEmployeeSex.ResumeLayout(false);
            GrpEmployeeSex.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TableLayoutPanel TblLayoutCostumer;
        private MaskedTextBox TxtEmployeeTrainigyear;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker DtpEmployeeEnddate;
        private Label LblEmployeeRole;
        private Label LblEmployeeEnddate;
        private Label LblEmployeeStreet;
        private MaskedTextBox TxtCostumerMobilenumber;
        private Label LblEmployeeHousenumber;
        private MaskedTextBox TxtCostumerPhonenumber;
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
        private CheckBox ChkEmployeeTrainee;
        private Label LblEmployeeLevel;
        private Label LblEmployeeTrainigyear;
        private DateTimePicker DtpEmployeeStartdate;
        private ComboBox CmbEmployeeDepartement;
        private Label label3;
        private Button btnSaveEmpoloyeRegistration;
        private TextBox TxtTitleEmployeeRegistration;
        private Label LblEmployeeLastname;
        private Label LblEmployeeFirstname;
        private Label LblEmployeeZIPcode;
        private GroupBox GrpEmployeeSex;
        private RadioButton RadEmployeeFemale;
        private RadioButton RadEmployeeMale;
        private ComboBox CmbEmployeeRegistration;

        private void btnSaveEmpoloyeRegistration_Click(object sender, EventArgs e)
        {
            if(ChkEmployeeTrainee.Checked)
            {
                //Trainee trainee = new Trainee(RadEmployeeMale.Checked ? true : false, "title-Placeholder", Txt);
            }
        }

        public EventHandler ChkEmployeeTrainee_CheckedChanged { get; private set; }
    }
}
