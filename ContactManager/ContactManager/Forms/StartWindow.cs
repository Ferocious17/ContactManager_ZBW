namespace ContactManager.Forms
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void btnUserRegistration_Click(object sender, EventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();

            userRegistration.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();

            search.Show();

        }

        private void btnClientRegistration_Click(object sender, EventArgs e)
        {
            ClientRegistration clientRegistration = new ClientRegistration();

            clientRegistration.Show();
        }

        private void StartWindow_Load(object sender, EventArgs e)
        {

            //StartWindow Design
            BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            txtBoxTitel.Font = new Font(txtBoxTitel.Font, FontStyle.Bold);
            txtBoxTitel.ForeColor = Color.Black;
            txtBoxTitel.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            txtBoxTitel.BorderStyle = BorderStyle.None;

            //Buttons Design
            btnUserRegistration.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            btnUserRegistration.ForeColor = Color.White;
            btnUserRegistration.FlatStyle = FlatStyle.Flat;
            btnUserRegistration.FlatAppearance.BorderSize = 0; // Set button border size to 0
            btnUserRegistration.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUserRegistration.Width, btnUserRegistration.Height, 5, 5)); // Create rounded rectangle region

            btnClientRegistration.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            btnClientRegistration.ForeColor = Color.White;
            btnClientRegistration.FlatStyle = FlatStyle.Flat;
            btnClientRegistration.FlatAppearance.BorderSize = 0; // Set button border size to 0
            btnClientRegistration.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClientRegistration.Width, btnClientRegistration.Height, 5, 5)); // Create rounded rectangle region

            btnSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0; // Set button border size to 0
            btnSearch.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 5, 5)); // Create rounded rectangle region
        }

        private void txtBoxTitel_TextChanged(object sender, EventArgs e)
        {

        }

        
        // Helper method to create a rounded rectangle region
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
     
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        
    }
}
