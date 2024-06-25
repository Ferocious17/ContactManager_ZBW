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
            txtBoxErfassungTitel.Font = new Font(txtBoxErfassungTitel.Font, FontStyle.Bold);
            txtBoxErfassungTitel.ForeColor = Color.Black;
            txtBoxErfassungTitel.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            txtBoxErfassungTitel.BorderStyle = BorderStyle.None;


        }

        private void checkBoxTrainee_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
