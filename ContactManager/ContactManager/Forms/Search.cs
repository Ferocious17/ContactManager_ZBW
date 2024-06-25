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
            txtBoxTitelSearch.Font = new Font(txtBoxTitelSearch.Font, FontStyle.Bold);
            txtBoxTitelSearch.ForeColor = Color.Black;
            txtBoxTitelSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            txtBoxTitelSearch.BorderStyle = BorderStyle.None;

            //Buttons Design
            btnSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0; // Set button border size to 0
            btnSearch.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 5, 5)); // Create rounded rectangle region




        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
        }


        // Helper method to create a rounded rectangle region
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    }
}
