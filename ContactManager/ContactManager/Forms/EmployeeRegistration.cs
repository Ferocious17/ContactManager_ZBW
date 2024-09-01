using ContactManager.DB;
using ContactManager.Enums;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace ContactManager.Forms
{
    public partial class LblEmployeeRegistration : Form
    {
        private Button CmdEmployeeCancel;
        private Label LblEmployeeFirstName;
        private Label LblEmployeeLastName;
        private Label LblEmployeeGender;

        private Label LblEmployeeAdress;
        private Label LblEmployeeZipCode;
        private Employee? _employee = null;
        private readonly ContactManagerContext _context = new();



        public LblEmployeeRegistration()
        {
            InitializeComponent();
        }

        public LblEmployeeRegistration(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            _context.Update(_employee);

            TxtEmployeeFirstname.Text = employee.FirstName;
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

            LblEmployeeTrainigyear.Enabled = ChkEmployeeTrainee.Checked;
        }

        private void checkBoxTrainee_CheckedChanged(object sender, EventArgs e)
        {
            // Code hier einfügen, um die gewünschten Aktionen auszuführen,
            // wenn die Checkbox geändert wird.
            // Beispiel: Ein Textfeld ein- oder ausschalten
            LblEmployeeTrainigyear.Enabled = ChkEmployeeTrainee.Checked;
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
            TxtEmployeeTrainigyear = new MaskedTextBox();
            LblEmployeeTrainigyear = new Label();
            GrpEmployeeSex = new GroupBox();
            RadEmployeeFemale = new RadioButton();
            RadEmployeeMale = new RadioButton();
            LblEmployeeSSN = new Label();
            TxtEmployeeTitle = new MaskedTextBox();
            TxtEmployeeRole = new MaskedTextBox();
            LblEmployeeLastname = new Label();
            LblEmployeeFirstname = new Label();
            LblEmployeeZIPcode = new Label();
            LblEmployeeRole = new Label();
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
            TxtEmployeeLastname = new MaskedTextBox();
            TxtEmployeeFirstname = new MaskedTextBox();
            ChkEmployeeTrainee = new CheckBox();
            LblEmployeeLevel = new Label();
            LblEmployeeTitle = new Label();
            TxtEmployeeDateofBirth = new MaskedTextBox();
            LblEmployeeDateofBirth = new Label();
            label5 = new Label();
            TxtEmployeeSSN = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            LblEmployeeEnddate = new Label();
            DtpEmployeeEnddate = new DateTimePicker();
            DtpEmployeeStartdate = new DateTimePicker();
            LblEmployeeStartdate = new Label();
            LblEmployeeDepartement = new Label();
            LblEmployeeEmail = new Label();
            TxtEmployeeEmail = new MaskedTextBox();
            LblEmployeeBusinessnumber = new Label();
            TxtEmployeeBusinessnumber = new MaskedTextBox();
            CmbEmployeeDepartement = new ComboBox();
            CmbEmployeeRegistration = new ComboBox();
            btnSaveEmpoloyeRegistration = new Button();
            TxtTitleEmployeeRegistration = new TextBox();
            CmdEmployeeSave = new Button();
            TblLayoutCostumer.SuspendLayout();
            GrpEmployeeSex.SuspendLayout();
            SuspendLayout();
            // 
            // TblLayoutCostumer
            // 
            TblLayoutCostumer.ColumnCount = 2;
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            TblLayoutCostumer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 377F));
            TblLayoutCostumer.Controls.Add(TxtEmployeeTrainigyear, 1, 21);
            TblLayoutCostumer.Controls.Add(LblEmployeeTrainigyear, 0, 21);
            TblLayoutCostumer.Controls.Add(GrpEmployeeSex, 1, 11);
            TblLayoutCostumer.Controls.Add(LblEmployeeSSN, 0, 9);
            TblLayoutCostumer.Controls.Add(TxtEmployeeTitle, 1, 1);
            TblLayoutCostumer.Controls.Add(TxtEmployeeRole, 1, 19);
            TblLayoutCostumer.Controls.Add(LblEmployeeLastname, 0, 4);
            TblLayoutCostumer.Controls.Add(LblEmployeeFirstname, 0, 2);
            TblLayoutCostumer.Controls.Add(LblEmployeeZIPcode, 0, 7);
            TblLayoutCostumer.Controls.Add(LblEmployeeRole, 0, 19);
            TblLayoutCostumer.Controls.Add(LblEmployeeStreet, 0, 5);
            TblLayoutCostumer.Controls.Add(TxtEmployeeMobilenumber, 1, 13);
            TblLayoutCostumer.Controls.Add(LblEmployeeHousenumber, 0, 6);
            TblLayoutCostumer.Controls.Add(TxtEmployeePhonenumber, 1, 12);
            TblLayoutCostumer.Controls.Add(LblEmployeePlace, 0, 8);
            TblLayoutCostumer.Controls.Add(TxtEmployeePlace, 1, 8);
            TblLayoutCostumer.Controls.Add(LblEmployeeSex, 0, 11);
            TblLayoutCostumer.Controls.Add(TxtEmployeeZIPcode, 1, 7);
            TblLayoutCostumer.Controls.Add(LblEmployeePhonenumber, 0, 12);
            TblLayoutCostumer.Controls.Add(TxtEmployeeHousenumber, 1, 6);
            TblLayoutCostumer.Controls.Add(LblEmployeeMobilenumber, 0, 13);
            TblLayoutCostumer.Controls.Add(TxtEmployeeStreet, 1, 5);
            TblLayoutCostumer.Controls.Add(TxtEmployeeLastname, 1, 4);
            TblLayoutCostumer.Controls.Add(TxtEmployeeFirstname, 1, 2);
            TblLayoutCostumer.Controls.Add(ChkEmployeeTrainee, 0, 0);
            TblLayoutCostumer.Controls.Add(LblEmployeeLevel, 0, 20);
            TblLayoutCostumer.Controls.Add(LblEmployeeTitle, 0, 1);
            TblLayoutCostumer.Controls.Add(TxtEmployeeDateofBirth, 1, 3);
            TblLayoutCostumer.Controls.Add(LblEmployeeDateofBirth, 0, 3);
            TblLayoutCostumer.Controls.Add(label5, 0, 10);
            TblLayoutCostumer.Controls.Add(TxtEmployeeSSN, 1, 9);
            TblLayoutCostumer.Controls.Add(maskedTextBox3, 1, 10);
            TblLayoutCostumer.Controls.Add(LblEmployeeEnddate, 0, 18);
            TblLayoutCostumer.Controls.Add(DtpEmployeeEnddate, 1, 18);
            TblLayoutCostumer.Controls.Add(DtpEmployeeStartdate, 1, 17);
            TblLayoutCostumer.Controls.Add(LblEmployeeStartdate, 0, 17);
            TblLayoutCostumer.Controls.Add(LblEmployeeDepartement, 0, 16);
            TblLayoutCostumer.Controls.Add(LblEmployeeEmail, 0, 15);
            TblLayoutCostumer.Controls.Add(TxtEmployeeEmail, 1, 15);
            TblLayoutCostumer.Controls.Add(LblEmployeeBusinessnumber, 0, 14);
            TblLayoutCostumer.Controls.Add(TxtEmployeeBusinessnumber, 1, 14);
            TblLayoutCostumer.Controls.Add(CmbEmployeeDepartement, 1, 16);
            TblLayoutCostumer.Controls.Add(CmbEmployeeRegistration, 1, 20);
            TblLayoutCostumer.Location = new Point(36, 98);
            TblLayoutCostumer.Margin = new Padding(5);
            TblLayoutCostumer.Name = "TblLayoutCostumer";
            TblLayoutCostumer.RowCount = 22;
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
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            TblLayoutCostumer.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            TblLayoutCostumer.Size = new Size(425, 568);
            TblLayoutCostumer.TabIndex = 48;
            TblLayoutCostumer.Paint += TblLayoutCostumer_Paint;
            // 
            // TxtEmployeeTrainigyear
            // 
            TxtEmployeeTrainigyear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeTrainigyear.Location = new Point(140, 535);
            TxtEmployeeTrainigyear.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeTrainigyear.Name = "TxtEmployeeTrainigyear";
            TxtEmployeeTrainigyear.Size = new Size(373, 23);
            TxtEmployeeTrainigyear.TabIndex = 85;
            TxtEmployeeTrainigyear.MaskInputRejected += maskedTextBox1_MaskInputRejected_1;
            // 
            // LblEmployeeTrainigyear
            // 
            LblEmployeeTrainigyear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeTrainigyear.AutoSize = true;
            LblEmployeeTrainigyear.Location = new Point(2, 525);
            LblEmployeeTrainigyear.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeTrainigyear.Name = "LblEmployeeTrainigyear";
            LblEmployeeTrainigyear.Size = new Size(134, 43);
            LblEmployeeTrainigyear.TabIndex = 84;
            LblEmployeeTrainigyear.Text = "Ausbildungsjahr";
            LblEmployeeTrainigyear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GrpEmployeeSex
            // 
            GrpEmployeeSex.Controls.Add(RadEmployeeFemale);
            GrpEmployeeSex.Controls.Add(RadEmployeeMale);
            GrpEmployeeSex.Location = new Point(139, 271);
            GrpEmployeeSex.Margin = new Padding(1);
            GrpEmployeeSex.Name = "GrpEmployeeSex";
            GrpEmployeeSex.Padding = new Padding(1);
            GrpEmployeeSex.Size = new Size(246, 27);
            GrpEmployeeSex.TabIndex = 65;
            GrpEmployeeSex.TabStop = false;
            // 
            // RadEmployeeFemale
            // 
            RadEmployeeFemale.AutoSize = true;
            RadEmployeeFemale.Location = new Point(135, 5);
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
            RadEmployeeMale.Location = new Point(19, 5);
            RadEmployeeMale.Name = "RadEmployeeMale";
            RadEmployeeMale.Size = new Size(75, 19);
            RadEmployeeMale.TabIndex = 0;
            RadEmployeeMale.TabStop = true;
            RadEmployeeMale.Text = "Männlich";
            RadEmployeeMale.UseVisualStyleBackColor = true;
            // 
            // LblEmployeeSSN
            // 
            LblEmployeeSSN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeSSN.AutoSize = true;
            LblEmployeeSSN.Location = new Point(2, 225);
            LblEmployeeSSN.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeSSN.Name = "LblEmployeeSSN";
            LblEmployeeSSN.Size = new Size(134, 25);
            LblEmployeeSSN.TabIndex = 65;
            LblEmployeeSSN.Text = "AHV-Nummer";
            LblEmployeeSSN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeTitle
            // 
            TxtEmployeeTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeTitle.Location = new Point(140, 28);
            TxtEmployeeTitle.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeTitle.Name = "TxtEmployeeTitle";
            TxtEmployeeTitle.Size = new Size(373, 23);
            TxtEmployeeTitle.TabIndex = 72;
            // 
            // TxtEmployeeRole
            // 
            TxtEmployeeRole.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeRole.Location = new Point(140, 478);
            TxtEmployeeRole.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeRole.Name = "TxtEmployeeRole";
            TxtEmployeeRole.Size = new Size(373, 23);
            TxtEmployeeRole.TabIndex = 62;
            // 
            // LblEmployeeLastname
            // 
            LblEmployeeLastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeLastname.AutoSize = true;
            LblEmployeeLastname.Location = new Point(2, 100);
            LblEmployeeLastname.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeLastname.Name = "LblEmployeeLastname";
            LblEmployeeLastname.Size = new Size(134, 25);
            LblEmployeeLastname.TabIndex = 66;
            LblEmployeeLastname.Text = "Nachname";
            LblEmployeeLastname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeFirstname
            // 
            LblEmployeeFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeFirstname.AutoSize = true;
            LblEmployeeFirstname.Location = new Point(1, 50);
            LblEmployeeFirstname.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeFirstname.Name = "LblEmployeeFirstname";
            LblEmployeeFirstname.Size = new Size(136, 25);
            LblEmployeeFirstname.TabIndex = 65;
            LblEmployeeFirstname.Text = "Vorname";
            LblEmployeeFirstname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeZIPcode
            // 
            LblEmployeeZIPcode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeZIPcode.AutoSize = true;
            LblEmployeeZIPcode.Location = new Point(2, 175);
            LblEmployeeZIPcode.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeZIPcode.Name = "LblEmployeeZIPcode";
            LblEmployeeZIPcode.Size = new Size(134, 25);
            LblEmployeeZIPcode.TabIndex = 69;
            LblEmployeeZIPcode.Text = "PLZ";
            LblEmployeeZIPcode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeRole
            // 
            LblEmployeeRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeRole.AutoSize = true;
            LblEmployeeRole.Location = new Point(2, 475);
            LblEmployeeRole.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeRole.Name = "LblEmployeeRole";
            LblEmployeeRole.Size = new Size(134, 25);
            LblEmployeeRole.TabIndex = 54;
            LblEmployeeRole.Text = "Rolle";
            LblEmployeeRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeStreet
            // 
            LblEmployeeStreet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeStreet.AutoSize = true;
            LblEmployeeStreet.Location = new Point(2, 125);
            LblEmployeeStreet.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeStreet.Name = "LblEmployeeStreet";
            LblEmployeeStreet.Size = new Size(134, 25);
            LblEmployeeStreet.TabIndex = 24;
            LblEmployeeStreet.Text = "Strasse";
            LblEmployeeStreet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeMobilenumber
            // 
            TxtEmployeeMobilenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeMobilenumber.Location = new Point(140, 328);
            TxtEmployeeMobilenumber.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeMobilenumber.Name = "TxtEmployeeMobilenumber";
            TxtEmployeeMobilenumber.Size = new Size(373, 23);
            TxtEmployeeMobilenumber.TabIndex = 40;
            // 
            // LblEmployeeHousenumber
            // 
            LblEmployeeHousenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeHousenumber.AutoSize = true;
            LblEmployeeHousenumber.Location = new Point(2, 150);
            LblEmployeeHousenumber.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeHousenumber.Name = "LblEmployeeHousenumber";
            LblEmployeeHousenumber.Size = new Size(134, 25);
            LblEmployeeHousenumber.TabIndex = 25;
            LblEmployeeHousenumber.Text = "Hausnummer";
            LblEmployeeHousenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeePhonenumber
            // 
            TxtEmployeePhonenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeePhonenumber.Location = new Point(140, 302);
            TxtEmployeePhonenumber.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeePhonenumber.Name = "TxtEmployeePhonenumber";
            TxtEmployeePhonenumber.Size = new Size(373, 23);
            TxtEmployeePhonenumber.TabIndex = 39;
            // 
            // LblEmployeePlace
            // 
            LblEmployeePlace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeePlace.AutoSize = true;
            LblEmployeePlace.Location = new Point(2, 200);
            LblEmployeePlace.Margin = new Padding(2, 0, 2, 0);
            LblEmployeePlace.Name = "LblEmployeePlace";
            LblEmployeePlace.Size = new Size(134, 25);
            LblEmployeePlace.TabIndex = 27;
            LblEmployeePlace.Text = "Ort";
            LblEmployeePlace.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeePlace
            // 
            TxtEmployeePlace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeePlace.Location = new Point(140, 203);
            TxtEmployeePlace.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeePlace.Name = "TxtEmployeePlace";
            TxtEmployeePlace.Size = new Size(373, 23);
            TxtEmployeePlace.TabIndex = 37;
            // 
            // LblEmployeeSex
            // 
            LblEmployeeSex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeSex.AutoSize = true;
            LblEmployeeSex.Location = new Point(2, 270);
            LblEmployeeSex.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeSex.Name = "LblEmployeeSex";
            LblEmployeeSex.Size = new Size(134, 29);
            LblEmployeeSex.TabIndex = 28;
            LblEmployeeSex.Text = "Geschlecht";
            LblEmployeeSex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeZIPcode
            // 
            TxtEmployeeZIPcode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeZIPcode.Location = new Point(140, 178);
            TxtEmployeeZIPcode.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeZIPcode.Name = "TxtEmployeeZIPcode";
            TxtEmployeeZIPcode.Size = new Size(373, 23);
            TxtEmployeeZIPcode.TabIndex = 36;
            // 
            // LblEmployeePhonenumber
            // 
            LblEmployeePhonenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeePhonenumber.AutoSize = true;
            LblEmployeePhonenumber.Location = new Point(2, 299);
            LblEmployeePhonenumber.Margin = new Padding(2, 0, 2, 0);
            LblEmployeePhonenumber.Name = "LblEmployeePhonenumber";
            LblEmployeePhonenumber.Size = new Size(134, 26);
            LblEmployeePhonenumber.TabIndex = 29;
            LblEmployeePhonenumber.Text = "Telefonummer";
            LblEmployeePhonenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeHousenumber
            // 
            TxtEmployeeHousenumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeHousenumber.Location = new Point(140, 153);
            TxtEmployeeHousenumber.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeHousenumber.Name = "TxtEmployeeHousenumber";
            TxtEmployeeHousenumber.Size = new Size(373, 23);
            TxtEmployeeHousenumber.TabIndex = 35;
            // 
            // LblEmployeeMobilenumber
            // 
            LblEmployeeMobilenumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeMobilenumber.AutoSize = true;
            LblEmployeeMobilenumber.Location = new Point(2, 325);
            LblEmployeeMobilenumber.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeMobilenumber.Name = "LblEmployeeMobilenumber";
            LblEmployeeMobilenumber.Size = new Size(134, 25);
            LblEmployeeMobilenumber.TabIndex = 30;
            LblEmployeeMobilenumber.Text = "Mobilnummer";
            LblEmployeeMobilenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeStreet
            // 
            TxtEmployeeStreet.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeStreet.Location = new Point(140, 128);
            TxtEmployeeStreet.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeStreet.Name = "TxtEmployeeStreet";
            TxtEmployeeStreet.Size = new Size(373, 23);
            TxtEmployeeStreet.TabIndex = 34;
            // 
            // TxtEmployeeLastname
            // 
            TxtEmployeeLastname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeLastname.Location = new Point(140, 103);
            TxtEmployeeLastname.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeLastname.Name = "TxtEmployeeLastname";
            TxtEmployeeLastname.Size = new Size(373, 23);
            TxtEmployeeLastname.TabIndex = 33;
            // 
            // TxtEmployeeFirstname
            // 
            TxtEmployeeFirstname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeFirstname.Location = new Point(140, 53);
            TxtEmployeeFirstname.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeFirstname.Name = "TxtEmployeeFirstname";
            TxtEmployeeFirstname.Size = new Size(373, 23);
            TxtEmployeeFirstname.TabIndex = 32;
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
            LblEmployeeLevel.Location = new Point(2, 500);
            LblEmployeeLevel.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeLevel.Name = "LblEmployeeLevel";
            LblEmployeeLevel.Size = new Size(134, 25);
            LblEmployeeLevel.TabIndex = 55;
            LblEmployeeLevel.Text = "Kaderstufe";
            LblEmployeeLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeTitle
            // 
            LblEmployeeTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeTitle.AutoSize = true;
            LblEmployeeTitle.Location = new Point(1, 25);
            LblEmployeeTitle.Margin = new Padding(1, 0, 1, 0);
            LblEmployeeTitle.Name = "LblEmployeeTitle";
            LblEmployeeTitle.Size = new Size(136, 25);
            LblEmployeeTitle.TabIndex = 73;
            LblEmployeeTitle.Text = "Titel";
            LblEmployeeTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeDateofBirth
            // 
            TxtEmployeeDateofBirth.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeDateofBirth.Location = new Point(140, 78);
            TxtEmployeeDateofBirth.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeDateofBirth.Name = "TxtEmployeeDateofBirth";
            TxtEmployeeDateofBirth.Size = new Size(373, 23);
            TxtEmployeeDateofBirth.TabIndex = 74;
            // 
            // LblEmployeeDateofBirth
            // 
            LblEmployeeDateofBirth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeDateofBirth.AutoSize = true;
            LblEmployeeDateofBirth.Location = new Point(2, 75);
            LblEmployeeDateofBirth.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeDateofBirth.Name = "LblEmployeeDateofBirth";
            LblEmployeeDateofBirth.Size = new Size(134, 25);
            LblEmployeeDateofBirth.TabIndex = 75;
            LblEmployeeDateofBirth.Text = "Geburtsdatum";
            LblEmployeeDateofBirth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(2, 250);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 78;
            label5.Text = "Ort";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeSSN
            // 
            TxtEmployeeSSN.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeSSN.Location = new Point(140, 228);
            TxtEmployeeSSN.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeSSN.Name = "TxtEmployeeSSN";
            TxtEmployeeSSN.Size = new Size(373, 23);
            TxtEmployeeSSN.TabIndex = 79;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox3.Location = new Point(140, 253);
            maskedTextBox3.Margin = new Padding(2, 3, 2, 3);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(373, 23);
            maskedTextBox3.TabIndex = 81;
            // 
            // LblEmployeeEnddate
            // 
            LblEmployeeEnddate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeEnddate.AutoSize = true;
            LblEmployeeEnddate.Location = new Point(2, 450);
            LblEmployeeEnddate.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeEnddate.Name = "LblEmployeeEnddate";
            LblEmployeeEnddate.Size = new Size(134, 25);
            LblEmployeeEnddate.TabIndex = 51;
            LblEmployeeEnddate.Text = "Enddatum";
            LblEmployeeEnddate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DtpEmployeeEnddate
            // 
            DtpEmployeeEnddate.Location = new Point(145, 458);
            DtpEmployeeEnddate.Margin = new Padding(7, 8, 7, 8);
            DtpEmployeeEnddate.Name = "DtpEmployeeEnddate";
            DtpEmployeeEnddate.Size = new Size(363, 23);
            DtpEmployeeEnddate.TabIndex = 59;
            // 
            // DtpEmployeeStartdate
            // 
            DtpEmployeeStartdate.Location = new Point(145, 433);
            DtpEmployeeStartdate.Margin = new Padding(7, 8, 7, 8);
            DtpEmployeeStartdate.Name = "DtpEmployeeStartdate";
            DtpEmployeeStartdate.Size = new Size(363, 23);
            DtpEmployeeStartdate.TabIndex = 57;
            // 
            // LblEmployeeStartdate
            // 
            LblEmployeeStartdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeStartdate.AutoSize = true;
            LblEmployeeStartdate.Location = new Point(2, 425);
            LblEmployeeStartdate.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeStartdate.Name = "LblEmployeeStartdate";
            LblEmployeeStartdate.Size = new Size(134, 25);
            LblEmployeeStartdate.TabIndex = 47;
            LblEmployeeStartdate.Text = "Startdatum";
            LblEmployeeStartdate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeDepartement
            // 
            LblEmployeeDepartement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeDepartement.AutoSize = true;
            LblEmployeeDepartement.Location = new Point(2, 400);
            LblEmployeeDepartement.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeDepartement.Name = "LblEmployeeDepartement";
            LblEmployeeDepartement.Size = new Size(134, 25);
            LblEmployeeDepartement.TabIndex = 43;
            LblEmployeeDepartement.Text = "Abteilung";
            LblEmployeeDepartement.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblEmployeeEmail
            // 
            LblEmployeeEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeEmail.AutoSize = true;
            LblEmployeeEmail.Location = new Point(2, 375);
            LblEmployeeEmail.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeEmail.Name = "LblEmployeeEmail";
            LblEmployeeEmail.Size = new Size(134, 25);
            LblEmployeeEmail.TabIndex = 31;
            LblEmployeeEmail.Text = "Email-Adresse";
            LblEmployeeEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeEmail
            // 
            TxtEmployeeEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeEmail.Location = new Point(140, 378);
            TxtEmployeeEmail.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeEmail.Name = "TxtEmployeeEmail";
            TxtEmployeeEmail.Size = new Size(373, 23);
            TxtEmployeeEmail.TabIndex = 41;
            // 
            // LblEmployeeBusinessnumber
            // 
            LblEmployeeBusinessnumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblEmployeeBusinessnumber.AutoSize = true;
            LblEmployeeBusinessnumber.Location = new Point(2, 350);
            LblEmployeeBusinessnumber.Margin = new Padding(2, 0, 2, 0);
            LblEmployeeBusinessnumber.Name = "LblEmployeeBusinessnumber";
            LblEmployeeBusinessnumber.Size = new Size(134, 25);
            LblEmployeeBusinessnumber.TabIndex = 82;
            LblEmployeeBusinessnumber.Text = "Geschäftsnummer";
            LblEmployeeBusinessnumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtEmployeeBusinessnumber
            // 
            TxtEmployeeBusinessnumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxtEmployeeBusinessnumber.Location = new Point(140, 353);
            TxtEmployeeBusinessnumber.Margin = new Padding(2, 3, 2, 3);
            TxtEmployeeBusinessnumber.Name = "TxtEmployeeBusinessnumber";
            TxtEmployeeBusinessnumber.Size = new Size(373, 23);
            TxtEmployeeBusinessnumber.TabIndex = 83;
            TxtEmployeeBusinessnumber.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // CmbEmployeeDepartement
            // 
            CmbEmployeeDepartement.FormattingEnabled = true;
            CmbEmployeeDepartement.Location = new Point(145, 408);
            CmbEmployeeDepartement.Margin = new Padding(7, 8, 7, 8);
            CmbEmployeeDepartement.Name = "CmbEmployeeDepartement";
            CmbEmployeeDepartement.Size = new Size(282, 23);
            CmbEmployeeDepartement.TabIndex = 58;
            // 
            // CmbEmployeeRegistration
            // 
            CmbEmployeeRegistration.DataSource = new CadreLevel[]
    {
    CadreLevel.Zero,
    CadreLevel.One,
    CadreLevel.Two,
    CadreLevel.Three,
    CadreLevel.Four,
    CadreLevel.Five
    };
            CmbEmployeeRegistration.FormattingEnabled = true;
            CmbEmployeeRegistration.Items.AddRange(new object[] { CadreLevel.Zero, CadreLevel.One, CadreLevel.Two, CadreLevel.Three, CadreLevel.Four, CadreLevel.Five });
            CmbEmployeeRegistration.Location = new Point(145, 508);
            CmbEmployeeRegistration.Margin = new Padding(7, 8, 7, 8);
            CmbEmployeeRegistration.Name = "CmbEmployeeRegistration";
            CmbEmployeeRegistration.Size = new Size(280, 23);
            CmbEmployeeRegistration.TabIndex = 71;
            // 
            // btnSaveEmpoloyeRegistration
            // 
            btnSaveEmpoloyeRegistration.Location = new Point(846, 1402);
            btnSaveEmpoloyeRegistration.Margin = new Padding(2, 3, 2, 3);
            btnSaveEmpoloyeRegistration.Name = "btnSaveEmpoloyeRegistration";
            btnSaveEmpoloyeRegistration.Size = new Size(250, 82);
            btnSaveEmpoloyeRegistration.TabIndex = 47;
            btnSaveEmpoloyeRegistration.Text = "Speichern";
            btnSaveEmpoloyeRegistration.UseVisualStyleBackColor = true;
            // 
            // TxtTitleEmployeeRegistration
            // 
            TxtTitleEmployeeRegistration.Font = new Font("Segoe UI", 15F);
            TxtTitleEmployeeRegistration.Location = new Point(36, 27);
            TxtTitleEmployeeRegistration.Margin = new Padding(2, 3, 2, 3);
            TxtTitleEmployeeRegistration.Multiline = true;
            TxtTitleEmployeeRegistration.Name = "TxtTitleEmployeeRegistration";
            TxtTitleEmployeeRegistration.Size = new Size(360, 43);
            TxtTitleEmployeeRegistration.TabIndex = 64;
            TxtTitleEmployeeRegistration.TabStop = false;
            TxtTitleEmployeeRegistration.Text = "MITARBEITER ERFASSUNG";
            // 
            // CmdEmployeeSave
            // 
            CmdEmployeeSave.Location = new Point(515, 612);
            CmdEmployeeSave.Margin = new Padding(1);
            CmdEmployeeSave.Name = "CmdEmployeeSave";
            CmdEmployeeSave.Size = new Size(103, 30);
            CmdEmployeeSave.TabIndex = 65;
            CmdEmployeeSave.Text = "Speichern";
            CmdEmployeeSave.UseVisualStyleBackColor = true;
            CmdEmployeeSave.Click += CmdEmployeeSave_Click;
            // 
            // LblEmployeeRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 771);
            Controls.Add(CmdEmployeeSave);
            Controls.Add(TxtTitleEmployeeRegistration);
            Controls.Add(TblLayoutCostumer);
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
        private DateTimePicker DtpEmployeeStartdate;
        private ComboBox CmbEmployeeDepartement;
        private Button btnSaveEmpoloyeRegistration;
        private TextBox TxtTitleEmployeeRegistration;
        private Label LblEmployeeLastname;
        private Label LblEmployeeFirstname;
        private Label LblEmployeeZIPcode;
        private RadioButton RadEmployeeFemale;
        private RadioButton RadEmployeeMale;
        private ComboBox CmbEmployeeRegistration;
        private MaskedTextBox TxtEmployeeTitle;

        private void TblLayoutCostumer_Paint(object sender, PaintEventArgs e)
        {

        }

        private Label LblEmployeeTitle;
        private MaskedTextBox TxtEmployeeDateofBirth;
        private Label LblEmployeeDateofBirth;
        private MaskedTextBox TxtEmployeeBusinessnumber;
        private Label LblEmployeeSSN;
        private Label label5;
        private MaskedTextBox TxtEmployeeSSN;
        private MaskedTextBox maskedTextBox3;
        private Label LblEmployeeBusinessnumber;

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GrpEmployeeSex_Enter(object sender, EventArgs e)
        {

        }

        private GroupBox GrpEmployeeSex;
        private Label LblEmployeeTrainigyear;
        private MaskedTextBox TxtEmployeeTrainigyear;

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private Button CmdEmployeeSave;

        private void CmdEmployeeSave_Click(object sender, EventArgs e)
        {
            CommuncationInfo communcationInfo = new(TxtEmployeePhonenumber.Text, TxtEmployeeMobilenumber.Text, TxtEmployeeBusinessnumber.Text, TxtEmployeeEmail.Text);
            Address address = new(TxtEmployeeStreet.Text, TxtEmployeeHousenumber.Text, Convert.ToInt32(TxtEmployeeZIPcode.Text), TxtEmployeePlace.Text);
            _ = DateTime.TryParse(TxtEmployeeDateofBirth.Text, out DateTime dateOfBrith);
            //Department department = context.Departments.First(d => d.Name.Equals(CmbEmployeeDepartement.SelectedText, StringComparison.CurrentCultureIgnoreCase));
            Department department = new("test");

            if(_employee is null)
            {
                if (ChkEmployeeTrainee.Checked)
                {

                    Trainee trainee = new(RadEmployeeMale.Checked, TxtEmployeeTitle.Text, TxtEmployeeFirstname.Text, TxtEmployeeLastname.Text, dateOfBrith, TxtEmployeeSSN.Text, communcationInfo, address, true, string.Empty, Guid.NewGuid(), department, DtpEmployeeStartdate.Value, DtpEmployeeEnddate.Value, 0, TxtEmployeeRole.Text, Enum.Parse<CadreLevel>(LblEmployeeLevel.Text), Convert.ToInt32(TxtEmployeeTrainigyear.Text), 1);
                    _context.Add(trainee);
                }
                else
                {
                    Employee employee = new(RadEmployeeMale.Checked, TxtEmployeeTitle.Text, TxtEmployeeFirstname.Text, TxtEmployeeLastname.Text, dateOfBrith, TxtEmployeeSSN.Text, communcationInfo, address, true, string.Empty, Guid.NewGuid(), department, DtpEmployeeStartdate.Value, DtpEmployeeEnddate.Value, 0, TxtEmployeeRole.Text, Enum.Parse<CadreLevel>(CmbEmployeeRegistration.SelectedItem.ToString()));
                    _context.Add(employee);
                }
            }

            _context.SaveChanges();
        }

        public EventHandler ChkEmployeeTrainee_CheckedChanged { get; private set; }
    }
}
