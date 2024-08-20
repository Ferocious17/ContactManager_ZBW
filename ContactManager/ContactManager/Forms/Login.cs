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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Login Design
            BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            TxtLoginTitle.Font = new Font(TxtLoginTitle.Font, FontStyle.Bold);
            TxtLoginTitle.ForeColor = Color.Black;
            TxtLoginTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            TxtLoginTitle.BorderStyle = BorderStyle.None;

            //Buttons Design

            BtnLoginSave.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            BtnLoginSave.ForeColor = Color.White;
            BtnLoginSave.FlatStyle = FlatStyle.Flat;
            BtnLoginSave.FlatAppearance.BorderSize = 0; // Set button border size to 0
            BtnLoginSave.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnLoginSave.Width, BtnLoginSave.Height, 5, 5)); // Create rounded rectangle region

        }

        // Helper method to create a rounded rectangle region
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void LblCostumerTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLoginSave_Click(object sender, EventArgs e)
        {
          
            {

                if 
                    (TxtLoginUsername.Text == "admin" && TxtLoginPassword.Text == "admin")
                {
                    StartWindow startWindow = new StartWindow();
                    this.Hide();
                    startWindow.ShowDialog();
                    
                    
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
                

            }
        }
    }
}
