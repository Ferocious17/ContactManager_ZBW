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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void txtBoxTitelSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

            //Genal Design wie in StartWindow.cs
            BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            LblSearchTitle.Font = new Font(LblSearchTitle.Font, FontStyle.Bold);
            LblSearchTitle.ForeColor = Color.Black;
            LblSearchTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            LblSearchTitle.BorderStyle = BorderStyle.None;

            //Buttons Design
            CmdSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            CmdSearch.ForeColor = Color.White;
            CmdSearch.FlatStyle = FlatStyle.Flat;
            CmdSearch.FlatAppearance.BorderSize = 0; // Set button border size to 0
            CmdSearch.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, CmdSearch.Width, CmdSearch.Height, 5, 5)); // Create rounded rectangle region




        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
        }


        // Helper method to create a rounded rectangle region
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    }
}
