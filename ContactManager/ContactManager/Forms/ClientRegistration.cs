using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.Forms
{
    public partial class ClientRegistration : Form
    {
        public ClientRegistration()
        {
            InitializeComponent();
        }

        private void ClientRegistration_Load(object sender, EventArgs e)
        {
            //StartWindow Design
            BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            txtBoxKundenErfassungTitel.Font = new Font(txtBoxKundenErfassungTitel.Font, FontStyle.Bold);
            txtBoxKundenErfassungTitel.ForeColor = Color.Black;
            txtBoxKundenErfassungTitel.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            txtBoxKundenErfassungTitel.BorderStyle = BorderStyle.None;

            //Buttons Design
            btnSaveClientRegistration.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            btnSaveClientRegistration.ForeColor = Color.White;
            btnSaveClientRegistration.FlatStyle = FlatStyle.Flat;
            btnSaveClientRegistration.FlatAppearance.BorderSize = 0; // Set button border size to 0
            btnSaveClientRegistration.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSaveClientRegistration.Width, btnSaveClientRegistration.Height, 5, 5)); // Create rounded rectangle region

        }

        private void txtBoxKundenErfassungTitel_TextChanged(object sender, EventArgs e)
        {

        }

        // Helper method to create a rounded rectangle region
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
