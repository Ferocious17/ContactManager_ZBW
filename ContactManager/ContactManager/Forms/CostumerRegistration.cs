using ContactManager.DB;
using ContactManager.Enums;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Forms
{
    public partial class CustumerRegistration : Form
    {
        private Customer? _customer = new() { DateOfBirth = DateTime.Today };
        private readonly ContactManagerContext _context = new();

        public CustumerRegistration()
        {
            InitializeComponent();
        }

        public CustumerRegistration(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            _context.Update(_customer);
        }

        private void CostumerRegistration_Load(object sender, EventArgs e)
        {
            //StartWindow Design
            BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            LblCostumerRegistration.Font = new Font(LblCostumerRegistration.Font, FontStyle.Bold);
            LblCostumerRegistration.ForeColor = Color.Black;
            LblCostumerRegistration.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            LblCostumerRegistration.BorderStyle = BorderStyle.None;

            //Buttons Design
            CmdCostumerSave.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            CmdCostumerSave.ForeColor = Color.White;
            CmdCostumerSave.FlatStyle = FlatStyle.Flat;
            CmdCostumerSave.FlatAppearance.BorderSize = 0; // Set button border size to 0
            CmdCostumerSave.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, CmdCostumerSave.Width, CmdCostumerSave.Height, 5, 5)); // Create rounded rectangle region

            CmdSaveNote.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            CmdSaveNote.ForeColor = Color.White;
            CmdSaveNote.FlatStyle = FlatStyle.Flat;
            CmdSaveNote.FlatAppearance.BorderSize = 0; // Set button border size to 0
            CmdSaveNote.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, CmdSaveNote.Width, CmdSaveNote.Height, 5, 5)); // Create rounded rectangle region

            CmbCostumerCostumertype.DataSource = Enum.GetValues(typeof(CustomerType));

            TxtCostumerStreetnumber.KeyPress += Numeric_KeyPress;
            TxtCostumerZIPcode.KeyPress += Numeric_KeyPress;

            TxtCostumerTitle.DataBindings.Add("Text", _customer, nameof(Customer.Title));
            TxtCostumerFirstname.DataBindings.Add("Text", _customer, nameof(Customer.FirstName));
            TxtCostumerLastname.DataBindings.Add("Text", _customer, nameof(Customer.LastName));
            TxtCostumerNationality.DataBindings.Add("Text", _customer, nameof(Customer.Nationality));
            DtpCostumerDateofBirth.DataBindings.Add("Text", _customer, nameof(Customer.DateOfBirth));
            TxtCostumerStreet.DataBindings.Add("Text", _customer.Address, nameof(Customer.Address.Street));
            TxtCostumerStreetnumber.DataBindings.Add("Text", _customer.Address, nameof(Customer.Address.StreetNumber));
            TxtCostumerZIPcode.DataBindings.Add("Text", _customer.Address, nameof(Customer.Address.ZipCode));
            TxtCostumerPlace.DataBindings.Add("Text", _customer.Address, nameof(Customer.Address.City));

            RadCostumerFemale.DataBindings.Add("Checked", _customer, nameof(Customer.Gender));
            RadCostumerFemale.DataBindings[0].Format += (s, e) => e.Value = !(bool)e.Value;
            RadCostumerFemale.DataBindings[0].Parse += (s, e) => e.Value = !(bool)e.Value;
            RadCostumerMale.DataBindings.Add("Checked", _customer, nameof(Customer.Gender));

            TxtCostumerPhonenumber.DataBindings.Add("Text", _customer.CommunicationInfo, nameof(Customer.CommunicationInfo.PhoneNumberPrivate));
            TxtCostumerMobilenumber.DataBindings.Add("Text", _customer.CommunicationInfo, nameof(Customer.CommunicationInfo.PhoneNumberMobile));
            TxtCostumerBusinessnumber.DataBindings.Add("Text", _customer.CommunicationInfo, nameof(Customer.CommunicationInfo.PhoneNumberBusiness));
            TxtCostumerEmail.DataBindings.Add("Text", _customer.CommunicationInfo, nameof(Customer.CommunicationInfo.Email));
            TxtCostumerCompany.DataBindings.Add("Text", _customer, nameof(Customer.CompanyName));
            CmbCostumerCostumertype.DataBindings.Add("", _customer, nameof(Customer.CustomerType));
            TxtCostumerContactperson.DataBindings.Add("Text", _customer, nameof(Customer.CompanyContact));

        }

        private void CustumerRegistration_Parse(object? sender, ConvertEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtBoxKundenErfassungTitel_TextChanged(object sender, EventArgs e)
        {

        }

        // Helper method to create a rounded rectangle region
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void LblCostumerContactperson_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblCostumerFirstname_Click(object sender, EventArgs e)
        {

        }

        private void TblLayoutCostumer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Numeric_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void CmdCostumerSave_Click(object sender, EventArgs e)
        {
            if (_customer.Id == 0)
            {
                _customer.SocialSecurityNumber = string.Empty;
                _customer.Status = true;
                _context.Add(_customer);
            }
            else
            {
                _context.Update(_customer);
            }

            _context.SaveChanges();
            Close();
        }

        private void BtnSaveNote_Click(object sender, EventArgs e)
        {
            if (_customer != null && !string.IsNullOrEmpty(TxtNotes.Text))
            {
                _context.Update(_customer);
                _customer.Notes.Add(new Note(TxtNotes.Text, DateTime.Now));
                _context.SaveChanges();
            }
        }

        private void LblCostumerPhonenumber_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
