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

        }

        private void txtBoxKundenErfassungTitel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
