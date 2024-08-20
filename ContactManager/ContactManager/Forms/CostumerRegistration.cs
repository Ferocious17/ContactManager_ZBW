namespace ContactManager.Forms
{
    public partial class CustumerRegistration : Form
    {
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
    }
}
