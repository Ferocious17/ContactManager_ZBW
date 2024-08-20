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
            TxtEmployeeTitle = new MaskedTextBox();
            LblEmployeeLastname = new Label();
            LblEmployeeFirstname = new Label();
            LblEmployeeZIPcode = new Label();
            TxtEmployeeTrainigyear = new MaskedTextBox();
            DtpEmployeeEnddate = new DateTimePicker();
            LblEmployeeRole = new Label();
            LblEmployeeEnddate = new Label();
            LblEmployeeStreet = new Label();
            TxtEmployeeMobilenumber = new MaskedTextBox();
            LblEmployeeHousenumber = new Label();
            TxtEmployeePhonenumber = new MaskedTextBox();
            LblEmployeePlace = new Label();
            TxtEmployeePlace = new MaskedTextBox();
            LblEmployeeSex = new Label();
            TxtEmployeeZIPcode = new MaskedTextBox();
            LblEmployeePhonenumber = new Label();
            TxtEmployeeHousenumber = new MaskedTextBox();
            LblEmployeeMobilenumber = new Label();
            TxtEmployeeStreet = new MaskedTextBox();
            LblEmployeeEmail = new Label();
            TxtEmployeeLastname = new MaskedTextBox();
            TxtEmployeeFirstname = new MaskedTextBox();
            TxtEmployeeEmail = new MaskedTextBox();
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
            TxtEmployeeRole = new MaskedTextBox();
            CmbEmployeeRegistration = new ComboBox();
            LblEmployeeTitle = new Label();
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
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243F));
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 486F));
            TblLayoutCostumer.Controls.Add(TxtEmployeeTitle, 1, 1);
            TblLayoutCostumer.Controls.Add(LblEmployeeLastname, 0, 3);
            TblLayoutCostumer.Controls.Add(LblEmployeeFirstname, 0, 2);
            TblLayoutCostumer.Controls.Add(LblEmployeeZIPcode, 0, 6);
            TblLayoutCostumer.Controls.Add(TxtEmployeeTrainigyear, 1, 17);
            TblLayoutCostumer.Controls.Add(DtpEmployeeEnddate, 1, 14);
            TblLayoutCostumer.Controls.Add(LblEmployeeRole, 0, 15);
            TblLayoutCostumer.Controls.Add(LblEmployeeEnddate, 0, 14);
            TblLayoutCostumer.Controls.Add(LblEmployeeStreet, 0, 4);
            TblLayoutCostumer.Controls.Add(TxtEmployeeMobilenumber, 1, 10);
            TblLayoutCostumer.Controls.Add(LblEmployeeHousenumber, 0, 5);
            TblLayoutCostumer.Controls.Add(TxtEmployeePhonenumber, 1, 9);
            TblLayoutCostumer.Controls.Add(LblEmployeePlace, 0, 7);
            TblLayoutCostumer.Controls.Add(TxtEmployeePlace, 1, 7);
            TblLayoutCostumer.Controls.Add(LblEmployeeSex, 0, 8);
            TblLayoutCostumer.Controls.Add(TxtEmployeeZIPcode, 1, 6);
            TblLayoutCostumer.Controls.Add(LblEmployeePhonenumber, 0, 9);
            TblLayoutCostumer.Controls.Add(TxtEmployeeHousenumber, 1, 5);
            TblLayoutCostumer.Controls.Add(LblEmployeeMobilenumber, 0, 10);
            TblLayoutCostumer.Controls.Add(TxtEmployeeStreet, 1, 4);
            TblLayoutCostumer.Controls.Add(LblEmployeeEmail, 0, 11);
            TblLayoutCostumer.Controls.Add(TxtEmployeeLastname, 1, 3);
            TblLayoutCostumer.Controls.Add(TxtEmployeeFirstname, 1, 2);
            TblLayoutCostumer.Controls.Add(TxtEmployeeEmail, 1, 11);
            TblLayoutCostumer.Controls.Add(LblEmployeeDepartement, 0, 12);
            TblLayoutCostumer.Controls.Add(LblEmployeeStartdate, 0, 13);
            TblLayoutCostumer.Controls.Add(ChkEmployeeTrainee, 0, 0);
            TblLayoutCostumer.Controls.Add(LblEmployeeLevel, 0, 16);
            TblLayoutCostumer.Controls.Add(LblEmployeeTrainigyear, 0, 17);
            TblLayoutCostumer.Controls.Add(DtpEmployeeStartdate, 1, 13);
            TblLayoutCostumer.Controls.Add(CmbEmployeeDepartement, 1, 12);
            TblLayoutCostumer.Controls.Add(GrpEmployeeSex, 1, 8);
            TblLayoutCostumer.Controls.Add(TxtEmployeeRole, 1, 15);
            TblLayoutCostumer.Controls.Add(CmbEmployeeRegistration, 1, 16);
            TblLayoutCostumer.Controls.Add(LblEmployeeTitle, 0, 1);
            TblLayoutCostumer.Location = new Point(36, 192);
            TblLayoutCostumer.Margin = new Padding(5);
            TblLayoutCostumer.Name = "TblLayoutCostumer";
            TblLayoutCostumer.RowCount = 19;
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
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            TblLayoutCostumer.Size = new Size(780, 1232);
            TblLayoutCostumer.TabIndex = 48;
            TblLayoutCostumer.Paint += TblLayoutCostumer_Paint;
            // 
            // TxtEmployeeTitle
            // 
            TxtEmployeeTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeTitle.Location = new Point(245, 78);
            TxtEmployeeTitle.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeTitle.Name = "TxtEmployeeTitle";
            TxtEmployeeTitle.Size = new Size(725, 47);
            TxtEmployeeTitle.TabIndex = 72;
            // 
            // LblEmployeeLastname
            // 
            LblEmployeeLastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeLastname.AutoSize = true;
            LblEmployeeLastname.Location = new Point(2, 204);
            LblEmployeeLastname.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeLastname.Name = "LblEmployeeLastname";
            LblEmployeeLastname.Size = new Size(239, 68);
            LblEmployeeLastname.TabIndex = 66;
            LblEmployeeLastname.Text = "Nachname";
            LblEmployeeLastname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeFirstname
            // 
            LblEmployeeFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeFirstname.AutoSize = true;
            LblEmployeeFirstname.Location = new Point(2, 136);
            LblEmployeeFirstname.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeFirstname.Name = "LblEmployeeFirstname";
            LblEmployeeFirstname.Size = new Size(239, 68);
            LblEmployeeFirstname.TabIndex = 65;
            LblEmployeeFirstname.Text = "Vorname";
            LblEmployeeFirstname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeZIPcode
            // 
            LblEmployeeZIPcode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeZIPcode.AutoSize = true;
            LblEmployeeZIPcode.Location = new Point(2, 408);
            LblEmployeeZIPcode.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeZIPcode.Name = "LblEmployeeZIPcode";
            LblEmployeeZIPcode.Size = new Size(239, 68);
            LblEmployeeZIPcode.TabIndex = 69;
            LblEmployeeZIPcode.Text = "PLZ";
            LblEmployeeZIPcode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeTrainigyear
            // 
            TxtEmployeeTrainigyear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeTrainigyear.Location = new Point(245, 1166);
            TxtEmployeeTrainigyear.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeTrainigyear.Name = "TxtEmployeeTrainigyear";
            TxtEmployeeTrainigyear.Size = new Size(725, 47);
            TxtEmployeeTrainigyear.TabIndex = 63;
            // 
            // DtpEmployeeEnddate
            // 
            DtpEmployeeEnddate.Location = new Point(250, 960);
            DtpEmployeeEnddate.Margin = new Padding(7, 8, 7, 8);
            DtpEmployeeEnddate.Name = "DtpEmployeeEnddate";
            DtpEmployeeEnddate.Size = new Size(530, 47);
            DtpEmployeeEnddate.TabIndex = 59;
            // 
            // LblEmployeeRole
            // 
            LblEmployeeRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeRole.AutoSize = true;
            LblEmployeeRole.Location = new Point(2, 1020);
            LblEmployeeRole.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeRole.Name = "LblEmployeeRole";
            LblEmployeeRole.Size = new Size(239, 68);
            LblEmployeeRole.TabIndex = 54;
            LblEmployeeRole.Text = "Rolle";
            LblEmployeeRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeEnddate
            // 
            LblEmployeeEnddate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeEnddate.AutoSize = true;
            LblEmployeeEnddate.Location = new Point(2, 952);
            LblEmployeeEnddate.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeEnddate.Name = "LblEmployeeEnddate";
            LblEmployeeEnddate.Size = new Size(239, 68);
            LblEmployeeEnddate.TabIndex = 51;
            LblEmployeeEnddate.Text = "Enddatum";
            LblEmployeeEnddate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeStreet
            // 
            LblEmployeeStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeStreet.AutoSize = true;
            LblEmployeeStreet.Location = new Point(2, 272);
            LblEmployeeStreet.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeStreet.Name = "LblEmployeeStreet";
            LblEmployeeStreet.Size = new Size(239, 68);
            LblEmployeeStreet.TabIndex = 24;
            LblEmployeeStreet.Text = "Strasse";
            LblEmployeeStreet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeMobilenumber
            // 
            TxtEmployeeMobilenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeMobilenumber.Location = new Point(245, 690);
            TxtEmployeeMobilenumber.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeMobilenumber.Name = "TxtEmployeeMobilenumber";
            TxtEmployeeMobilenumber.Size = new Size(725, 47);
            TxtEmployeeMobilenumber.TabIndex = 40;
            // 
            // LblEmployeeHousenumber
            // 
            LblEmployeeHousenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeHousenumber.AutoSize = true;
            LblEmployeeHousenumber.Location = new Point(2, 340);
            LblEmployeeHousenumber.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeHousenumber.Name = "LblEmployeeHousenumber";
            LblEmployeeHousenumber.Size = new Size(239, 68);
            LblEmployeeHousenumber.TabIndex = 25;
            LblEmployeeHousenumber.Text = "Hausnummer";
            LblEmployeeHousenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeePhonenumber
            // 
            TxtEmployeePhonenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeePhonenumber.Location = new Point(245, 622);
            TxtEmployeePhonenumber.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeePhonenumber.Name = "TxtEmployeePhonenumber";
            TxtEmployeePhonenumber.Size = new Size(725, 47);
            TxtEmployeePhonenumber.TabIndex = 39;
            // 
            // LblEmployeePlace
            // 
            LblEmployeePlace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeePlace.AutoSize = true;
            LblEmployeePlace.Location = new Point(2, 476);
            LblEmployeePlace.Margin = new Padding(2, 0, 2, 0);
            LblEmployeePlace.Name = "LblEmployeePlace";
            LblEmployeePlace.Size = new Size(239, 68);
            LblEmployeePlace.TabIndex = 27;
            LblEmployeePlace.Text = "Ort";
            LblEmployeePlace.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeePlace
            // 
            TxtEmployeePlace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeePlace.Location = new Point(245, 486);
            TxtEmployeePlace.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeePlace.Name = "TxtEmployeePlace";
            TxtEmployeePlace.Size = new Size(725, 47);
            TxtEmployeePlace.TabIndex = 37;
            // 
            // LblEmployeeSex
            // 
            LblEmployeeSex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeSex.AutoSize = true;
            LblEmployeeSex.Location = new Point(2, 544);
            LblEmployeeSex.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeSex.Name = "LblEmployeeSex";
            LblEmployeeSex.Size = new Size(239, 68);
            LblEmployeeSex.TabIndex = 28;
            LblEmployeeSex.Text = "Geschlecht";
            LblEmployeeSex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeZIPcode
            // 
            TxtEmployeeZIPcode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeZIPcode.Location = new Point(245, 418);
            TxtEmployeeZIPcode.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeZIPcode.Name = "TxtEmployeeZIPcode";
            TxtEmployeeZIPcode.Size = new Size(725, 47);
            TxtEmployeeZIPcode.TabIndex = 36;
            // 
            // LblEmployeePhonenumber
            // 
            LblEmployeePhonenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeePhonenumber.AutoSize = true;
            LblEmployeePhonenumber.Location = new Point(2, 612);
            LblEmployeePhonenumber.Margin = new Padding(2, 0, 2, 0);
            LblEmployeePhonenumber.Name = "LblEmployeePhonenumber";
            LblEmployeePhonenumber.Size = new Size(239, 68);
            LblEmployeePhonenumber.TabIndex = 29;
            LblEmployeePhonenumber.Text = "Telefonummer";
            LblEmployeePhonenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeHousenumber
            // 
            TxtEmployeeHousenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeHousenumber.Location = new Point(245, 350);
            TxtEmployeeHousenumber.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeHousenumber.Name = "TxtEmployeeHousenumber";
            TxtEmployeeHousenumber.Size = new Size(725, 47);
            TxtEmployeeHousenumber.TabIndex = 35;
            // 
            // LblEmployeeMobilenumber
            // 
            LblEmployeeMobilenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeMobilenumber.AutoSize = true;
            LblEmployeeMobilenumber.Location = new Point(2, 680);
            LblEmployeeMobilenumber.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeMobilenumber.Name = "LblEmployeeMobilenumber";
            LblEmployeeMobilenumber.Size = new Size(239, 68);
            LblEmployeeMobilenumber.TabIndex = 30;
            LblEmployeeMobilenumber.Text = "Mobilnummer";
            LblEmployeeMobilenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeStreet
            // 
            TxtEmployeeStreet.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeStreet.Location = new Point(245, 282);
            TxtEmployeeStreet.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeStreet.Name = "TxtEmployeeStreet";
            TxtEmployeeStreet.Size = new Size(725, 47);
            TxtEmployeeStreet.TabIndex = 34;
            // 
            // LblEmployeeEmail
            // 
            LblEmployeeEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeEmail.AutoSize = true;
            LblEmployeeEmail.Location = new Point(2, 748);
            LblEmployeeEmail.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeEmail.Name = "LblEmployeeEmail";
            LblEmployeeEmail.Size = new Size(239, 68);
            LblEmployeeEmail.TabIndex = 31;
            LblEmployeeEmail.Text = "Email-Adresse";
            LblEmployeeEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeLastname
            // 
            TxtEmployeeLastname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeLastname.Location = new Point(245, 214);
            TxtEmployeeLastname.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeLastname.Name = "TxtEmployeeLastname";
            TxtEmployeeLastname.Size = new Size(725, 47);
            TxtEmployeeLastname.TabIndex = 33;
            // 
            // TxtEmployeeFirstname
            // 
            TxtEmployeeFirstname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeFirstname.Location = new Point(245, 146);
            TxtEmployeeFirstname.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeFirstname.Name = "TxtEmployeeFirstname";
            TxtEmployeeFirstname.Size = new Size(725, 47);
            TxtEmployeeFirstname.TabIndex = 32;
            // 
            // TxtEmployeeEmail
            // 
            TxtEmployeeEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeEmail.Location = new Point(245, 758);
            TxtEmployeeEmail.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeEmail.Name = "TxtEmployeeEmail";
            TxtEmployeeEmail.Size = new Size(725, 47);
            TxtEmployeeEmail.TabIndex = 41;
            // 
            // LblEmployeeDepartement
            // 
            LblEmployeeDepartement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeDepartement.AutoSize = true;
            LblEmployeeDepartement.Location = new Point(2, 816);
            LblEmployeeDepartement.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeDepartement.Name = "LblEmployeeDepartement";
            LblEmployeeDepartement.Size = new Size(239, 68);
            LblEmployeeDepartement.TabIndex = 43;
            LblEmployeeDepartement.Text = "Abteilung";
            LblEmployeeDepartement.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeStartdate
            // 
            LblEmployeeStartdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeStartdate.AutoSize = true;
            LblEmployeeStartdate.Location = new Point(2, 884);
            LblEmployeeStartdate.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeStartdate.Name = "LblEmployeeStartdate";
            LblEmployeeStartdate.Size = new Size(239, 68);
            LblEmployeeStartdate.TabIndex = 47;
            LblEmployeeStartdate.Text = "Startdatum";
            LblEmployeeStartdate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChkEmployeeTrainee
            // 
            ChkEmployeeTrainee.AutoSize = true;
            ChkEmployeeTrainee.Location = new Point(7, 8);
            ChkEmployeeTrainee.Margin = new Padding(7, 8, 7, 8);
            ChkEmployeeTrainee.Name = "ChkEmployeeTrainee";
            ChkEmployeeTrainee.Size = new Size(162, 45);
            ChkEmployeeTrainee.TabIndex = 52;
            ChkEmployeeTrainee.Text = "Lehrling";
            ChkEmployeeTrainee.UseVisualStyleBackColor = true;
            ChkEmployeeTrainee.CheckedChanged += checkBoxTrainee_CheckedChanged;
            // 
            // LblEmployeeLevel
            // 
            LblEmployeeLevel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeLevel.AutoSize = true;
            LblEmployeeLevel.Location = new Point(2, 1088);
            LblEmployeeLevel.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeLevel.Name = "LblEmployeeLevel";
            LblEmployeeLevel.Size = new Size(239, 68);
            LblEmployeeLevel.TabIndex = 55;
            LblEmployeeLevel.Text = "Kaderstufe";
            LblEmployeeLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeTrainigyear
            // 
            LblEmployeeTrainigyear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeTrainigyear.AutoSize = true;
            LblEmployeeTrainigyear.Location = new Point(2, 1156);
            LblEmployeeTrainigyear.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeTrainigyear.Name = "LblEmployeeTrainigyear";
            LblEmployeeTrainigyear.Size = new Size(239, 68);
            LblEmployeeTrainigyear.TabIndex = 56;
            LblEmployeeTrainigyear.Text = "Ausbildungsjahr";
            LblEmployeeTrainigyear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DtpEmployeeStartdate
            // 
            DtpEmployeeStartdate.Location = new Point(250, 892);
            DtpEmployeeStartdate.Margin = new Padding(7, 8, 7, 8);
            DtpEmployeeStartdate.Name = "DtpEmployeeStartdate";
            DtpEmployeeStartdate.Size = new Size(530, 47);
            DtpEmployeeStartdate.TabIndex = 57;
            // 
            // CmbEmployeeDepartement
            // 
            CmbEmployeeDepartement.FormattingEnabled = true;
            CmbEmployeeDepartement.Location = new Point(250, 824);
            CmbEmployeeDepartement.Margin = new Padding(7, 8, 7, 8);
            CmbEmployeeDepartement.Name = "CmbEmployeeDepartement";
            CmbEmployeeDepartement.Size = new Size(530, 49);
            CmbEmployeeDepartement.TabIndex = 58;
            // 
            // GrpEmployeeSex
            // 
            GrpEmployeeSex.Controls.Add(RadEmployeeFemale);
            GrpEmployeeSex.Controls.Add(RadEmployeeMale);
            GrpEmployeeSex.Location = new Point(250, 552);
            GrpEmployeeSex.Margin = new Padding(7, 8, 7, 8);
            GrpEmployeeSex.Name = "GrpEmployeeSex";
            GrpEmployeeSex.Padding = new Padding(7, 8, 7, 8);
            GrpEmployeeSex.Size = new Size(530, 52);
            GrpEmployeeSex.TabIndex = 70;
            GrpEmployeeSex.TabStop = false;
            // 
            // RadEmployeeFemale
            // 
            RadEmployeeFemale.AutoSize = true;
            RadEmployeeFemale.Location = new Point(328, 0);
            RadEmployeeFemale.Margin = new Padding(7, 8, 7, 8);
            RadEmployeeFemale.Name = "RadEmployeeFemale";
            RadEmployeeFemale.Size = new Size(168, 45);
            RadEmployeeFemale.TabIndex = 1;
            RadEmployeeFemale.TabStop = true;
            RadEmployeeFemale.Text = "Weiblich";
            RadEmployeeFemale.UseVisualStyleBackColor = true;
            // 
            // RadEmployeeMale
            // 
            RadEmployeeMale.AutoSize = true;
            RadEmployeeMale.Location = new Point(0, 0);
            RadEmployeeMale.Margin = new Padding(7, 8, 7, 8);
            RadEmployeeMale.Name = "RadEmployeeMale";
            RadEmployeeMale.Size = new Size(176, 45);
            RadEmployeeMale.TabIndex = 0;
            RadEmployeeMale.TabStop = true;
            RadEmployeeMale.Text = "Männlich";
            RadEmployeeMale.UseVisualStyleBackColor = true;
            // 
            // TxtEmployeeRole
            // 
            TxtEmployeeRole.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeRole.Location = new Point(245, 1030);
            TxtEmployeeRole.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeRole.Name = "TxtEmployeeRole";
            TxtEmployeeRole.Size = new Size(725, 47);
            TxtEmployeeRole.TabIndex = 62;
            // 
            // CmbEmployeeRegistration
            // 
            CmbEmployeeRegistration.FormattingEnabled = true;
            CmbEmployeeRegistration.Location = new Point(250, 1096);
            CmbEmployeeRegistration.Margin = new Padding(7, 8, 7, 8);
            CmbEmployeeRegistration.Name = "CmbEmployeeRegistration";
            CmbEmployeeRegistration.Size = new Size(530, 49);
            CmbEmployeeRegistration.TabIndex = 71;
            // 
            // LblEmployeeTitle
            // 
            LblEmployeeTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeTitle.AutoSize = true;
            LblEmployeeTitle.Location = new Point(2, 68);
            LblEmployeeTitle.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeTitle.Name = "LblEmployeeTitle";
            LblEmployeeTitle.Size = new Size(239, 68);
            LblEmployeeTitle.TabIndex = 73;
            LblEmployeeTitle.Text = "Titel";
            LblEmployeeTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(425, 549);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(205, 41);
            label3.TabIndex = 49;
            label3.Text = "Email-Adresse";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSaveEmpoloyeRegistration
            // 
            btnSaveEmpoloyeRegistration.Location = new Point(823, 1249);
            btnSaveEmpoloyeRegistration.Margin = new Padding(2, 3, 2, 3);
            btnSaveEmpoloyeRegistration.Name = "btnSaveEmpoloyeRegistration";
            btnSaveEmpoloyeRegistration.Size = new Size(250, 82);
            btnSaveEmpoloyeRegistration.TabIndex = 47;
            btnSaveEmpoloyeRegistration.Text = "Speichern";
            btnSaveEmpoloyeRegistration.UseVisualStyleBackColor = true;
            btnSaveEmpoloyeRegistration.Click += btnSaveEmpoloyeRegistration_Click;
            // 
            // TxtTitleEmployeeRegistration
            // 
            TxtTitleEmployeeRegistration.Font = new Font("Segoe UI", 15F);
            TxtTitleEmployeeRegistration.Location = new Point(36, 27);
            TxtTitleEmployeeRegistration.Margin = new Padding(2, 3, 2, 3);
            TxtTitleEmployeeRegistration.Multiline = true;
            TxtTitleEmployeeRegistration.Name = "TxtTitleEmployeeRegistration";
            TxtTitleEmployeeRegistration.Size = new Size(672, 89);
            TxtTitleEmployeeRegistration.TabIndex = 64;
            TxtTitleEmployeeRegistration.TabStop = false;
            TxtTitleEmployeeRegistration.Text = "MITARBEITER ERFASSUNG";
            // 
            // LblEmployeeRegistration
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 1555);
            Controls.Add(TxtTitleEmployeeRegistration);
            Controls.Add(TblLayoutCostumer);
            Controls.Add(label3);
            Controls.Add(btnSaveEmpoloyeRegistration);
            Margin = new Padding(7, 8, 7, 8);
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
        private MaskedTextBox TxtEmployeeRole;
        private DateTimePicker DtpEmployeeEnddate;
        private Label LblEmployeeRole;
        private Label LblEmployeeEnddate;
        private Label LblEmployeeStreet;
        private MaskedTextBox TxtEmployeeMobilenumber;
        private Label LblEmployeeHousenumber;
        private MaskedTextBox TxtEmployeePhonenumber;
        private Label LblEmployeePlace;
        private MaskedTextBox TxtEmployeePlace;
        private Label LblEmployeeSex;
        private MaskedTextBox TxtEmployeeZIPcode;
        private Label LblEmployeePhonenumber;
        private MaskedTextBox TxtEmployeeHousenumber;
        private Label LblEmployeeMobilenumber;
        private MaskedTextBox TxtEmployeeStreet;
        private Label LblEmployeeEmail;
        private MaskedTextBox TxtEmployeeLastname;
        private MaskedTextBox TxtEmployeeFirstname;
        private MaskedTextBox TxtEmployeeEmail;
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
        private MaskedTextBox TxtEmployeeTitle;

        private void TblLayoutCostumer_Paint(object sender, PaintEventArgs e)
        {

        }

        private Label LblEmployeeTitle;

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
