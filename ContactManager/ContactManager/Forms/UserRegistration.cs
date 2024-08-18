using ContactManager.DB;
using ContactManager.Models;

namespace ContactManager.Forms
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
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

        }

        private void checkBoxTrainee_CheckedChanged(object sender, EventArgs e)
        {

        }


        // Helper method to create a rounded rectangle region
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveEmpoloyeRegistration_Click_1(object sender, EventArgs e)
        {
            ContactManagerContext context = new ContactManagerContext();

            CommuncationInfo info = new("PRIVATE", "mobile", "business", "email");
            Address address = new("street", "streetNumber", 9500, "St. Gallen");
            Department dep = null;

            if(context.Departments.Any(x => x.Name == "dep1"))
            {
                dep = context.Departments.First(x => x.Name == "dep1");
            }
            else
            {
                dep = new("department");
            }

            //Person person1 = new Person(true, "title", "firstName", "lastName", DateTime.Now, "socialSecurityNumber", info, address, true, "CH");

            Trainee trainee = new Trainee(true, "title", "firstName", "lastName", DateTime.Now, "socialSecurityNumber", info, address, true, "CH", Guid.NewGuid(), dep, DateTime.Now, DateTime.Now.AddDays(1), 1, "test", Enums.CadreLevel.Two, 2, 1);

            context.Add(trainee);
            context.SaveChanges();
        }

        private void s_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblBoxAdressEmp_Click(object sender, EventArgs e)
        {

        }
    }
}
