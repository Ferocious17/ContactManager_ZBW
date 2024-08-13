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

            userRegistration.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();

            search.ShowDialog();
        }

        private void btnClientRegistration_Click(object sender, EventArgs e)
        {
            ClientRegistration clientRegistration = new ClientRegistration();

            clientRegistration.ShowDialog();
        }

        private void StartWindow_Load(object sender, EventArgs e)
        {

            //StartWindow Design
            BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            LblStartTitle.Font = new Font(LblStartTitle.Font, FontStyle.Bold);
            LblStartTitle.ForeColor = Color.Black;
            LblStartTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            LblStartTitle.BorderStyle = BorderStyle.None;

            //Buttons Design
            LblStartEmployeeRegistration.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            LblStartEmployeeRegistration.ForeColor = Color.White;
            LblStartEmployeeRegistration.FlatStyle = FlatStyle.Flat;
            LblStartEmployeeRegistration.FlatAppearance.BorderSize = 0; // Set button border size to 0
            LblStartEmployeeRegistration.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, LblStartEmployeeRegistration.Width, LblStartEmployeeRegistration.Height, 5, 5)); // Create rounded rectangle region

            LblStartCostumerRegistration.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            LblStartCostumerRegistration.ForeColor = Color.White;
            LblStartCostumerRegistration.FlatStyle = FlatStyle.Flat;
            LblStartCostumerRegistration.FlatAppearance.BorderSize = 0; // Set button border size to 0
            LblStartCostumerRegistration.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, LblStartCostumerRegistration.Width, LblStartCostumerRegistration.Height, 5, 5)); // Create rounded rectangle region

            LblStartSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            LblStartSearch.ForeColor = Color.White;
            LblStartSearch.FlatStyle = FlatStyle.Flat;
            LblStartSearch.FlatAppearance.BorderSize = 0; // Set button border size to 0
            LblStartSearch.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, LblStartSearch.Width, LblStartSearch.Height, 5, 5)); // Create rounded rectangle region


            CmdStartImport.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            CmdStartImport.ForeColor = Color.White;
            CmdStartImport.FlatStyle = FlatStyle.Flat;
            CmdStartImport.FlatAppearance.BorderSize = 0; // Set button border size to 0
            CmdStartImport.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, LblStartEmployeeRegistration.Width, LblStartEmployeeRegistration.Height, 5, 5)); // Create rounded rectangle region

            CmdStartExport.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            CmdStartExport.ForeColor = Color.White;
            CmdStartExport.FlatStyle = FlatStyle.Flat;
            CmdStartExport.FlatAppearance.BorderSize = 0; // Set button border size to 0
            CmdStartExport.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, LblStartEmployeeRegistration.Width, LblStartEmployeeRegistration.Height, 5, 5)); // Create rounded rectangle region

        }




        private void txtBoxTitel_TextChanged(object sender, EventArgs e)
        {

        }

        
        // Helper method to create a rounded rectangle region
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
     
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        
    }
}
