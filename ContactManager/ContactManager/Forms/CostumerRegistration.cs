using ContactManager.DB;
using ContactManager.Enums;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Forms
{
    public partial class CustumerRegistration : Form
    {
        private Customer? _customer = null;
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

            TxtCostumerFirstname.Text = _customer.FirstName;
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

        private void CmdCostumerSave_Click(object sender, EventArgs e)
        {
            _ = Enum.TryParse(CmbCostumerCostumertype.Text, out CustomerType selectedCostomerType);
            _ = DateTime.TryParse(TxtCostumerDateofBirth.Text, out DateTime dateOfBirth);

            CommuncationInfo communicationInfo = new(TxtCostumerMobilenumber.Text, TxtCostumerPhonenumber.Text, TxtCostumerPhonenumber.Text, TxtCostumerEmail.Text);
            Address address = new(TxtCostumerStreet.Text, TxtCostumerStreetnumber.Text, Convert.ToInt32(TxtCostumerZIPcode.Text), TxtCostumerPlace.Text);

            if(_customer is null)
            {
                Customer newCustomer = new(RadCostumerMale.Checked, TxtCostumerTitle.Text, TxtCostumerFirstname.Text, TxtCostumerLastname.Text, dateOfBirth, string.Empty, communicationInfo, address, true, string.Empty, TxtCostumerCompany.Text, selectedCostomerType, TxtCostumerContactperson.Text);

                _context.Add(newCustomer);
                _customer = _context.Customers.FirstOrDefault(c => c.Id == newCustomer.Id);
            }

            _context.SaveChanges();
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
    }
}
