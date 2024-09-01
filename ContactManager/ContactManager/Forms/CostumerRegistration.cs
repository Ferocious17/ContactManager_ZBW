using ContactManager.DB;
using ContactManager.Enums;
using ContactManager.Models;

namespace ContactManager.Forms
{
    public partial class CustumerRegistration : Form
    {
        private Customer? _customer = null;

        public CustumerRegistration()
        {
            InitializeComponent();
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
            Enum.TryParse(CmbCostumerCostumertype.Text, out CustomerType selectedCostomerType);
            DateTime.TryParse(TxtCostumerDateofBirth.Text, out DateTime dateOfBirth);

            CommuncationInfo communicationInfo = new(TxtCostumerMobilenumber.Text, TxtCostumerPhonenumber.Text, TxtCostumerPhonenumber.Text, TxtCostumerEmail.Text);
            Address address = new(TxtCostumerStreet.Text, TxtCostumerStreetnumber.Text, Convert.ToInt32(TxtCostumerZIPcode.Text), TxtCostumerPlace.Text);
            Customer newCustomer = new(RadCostumerMale.Checked, TxtCostumerTitle.Text, TxtCostumerFirstname.Text, TxtCostumerLastname.Text, dateOfBirth, string.Empty, communicationInfo, address, true, string.Empty, TxtCostumerCompany.Text, selectedCostomerType, TxtCostumerContactperson.Text);

            ContactManagerContext context = new();

            context.Add(newCustomer);
            context.SaveChanges();

            _customer = context.Customers.FirstOrDefault(c => c.Id == newCustomer.Id);
        }

        private void BtnSaveNote_Click(object sender, EventArgs e)
        {
            if(_customer != null && !string.IsNullOrEmpty(TxtNotes.Text))
            {
                ContactManagerContext context = new();
                _customer.Notes.Add(new Note(TxtNotes.Text, DateTime.Now));
                context.Add(_customer);
                context.SaveChanges();
            }
        }
    }
}
