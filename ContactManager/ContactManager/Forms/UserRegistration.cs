﻿namespace ContactManager.Forms
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

    }
}
