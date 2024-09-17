using ContactManager.DB;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Common;
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
        private readonly BindingList<Person> _searchResults = [];
        private readonly ContactManagerContext _context = new();

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
            
            foreach (var person in _context.People)
                _searchResults.Add(person);

            TxtOutgrid.DataSource = _searchResults;
            TxtOutgrid.AutoGenerateColumns = true;
            TxtOutgrid.SelectionChanged += TxtOutgrid_SelectionChanged;
            TxtOutgrid.CellFormatting += TxtOutgrid_CellFormatting;

            TxtSearchbar.KeyDown += TxtSearchbar_KeyDown;
        }

        private void TxtOutgrid_SelectionChanged(object? sender, EventArgs e)
        {
            if (TxtOutgrid.CurrentRow == null)
            {
                BtnAcivateDeactive.Enabled = false;
                return;
            }

            if (TxtOutgrid.CurrentRow.DataBoundItem is not Person person)
                return;

            BtnAcivateDeactive.Enabled = true;
            BtnAcivateDeactive.Text = person.Status ? "Deactivate" : "Activate";
        }

        private void TxtOutgrid_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = TxtOutgrid.Rows[e.RowIndex];
            if (row.DataBoundItem is not Person person)
                return;

            row.ReadOnly = person.Status;
            row.DefaultCellStyle.BackColor = person.Status ? Color.White : Color.LightGray;
            row.DefaultCellStyle.ForeColor = person.Status ? Color.Black : Color.DarkGray;
        }

        private void TxtSearchbar_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _searchResults.Clear();
            TxtOutgrid.Refresh();

            if (sender is null && e is null)
            {
                foreach (var person in _context.People)
                    _searchResults.Add(person);
            }

            if (!string.IsNullOrWhiteSpace(TxtSearchbar.Text))
            {
                string searchText = TxtSearchbar.Text.Trim();
                bool dateConverted = DateTime.TryParse(searchText, out DateTime date);

                ContactManagerContext context = new();
                if (dateConverted)
                {
                    //searchResults.AddRange(context.People.Where(p => p.DateOfBirth == date));
                    foreach (var person in context.People.Where(p => p.DateOfBirth == date))
                        _searchResults.Add(person);
                }
                else
                {
                    foreach (var person in context.People.Where(p => p.FirstName == searchText || p.LastName == searchText))
                        _searchResults.Add(person);
                }
            }

            TxtOutgrid.Refresh();
        }


        // Helper method to create a rounded rectangle region
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void TxtOutgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => EditElement(TxtOutgrid.Rows[e.RowIndex]);

        private void BtnEdit_Click(object sender, EventArgs e) => EditElement(TxtOutgrid.CurrentRow);

        private void EditElement(DataGridViewRow currentRow)
        {
            if (currentRow.DataBoundItem is not Person person)
                return;

            ContactManagerContext context = new();
            Person selectedPerson = context.People.Single(p => p.Id == person.Id);

            if (context.Employees.Any(e => e.Id == selectedPerson.Id))
            {
                LblEmployeeRegistration employeeRegistration = new(context.Employees.Include(e => e.Department).First(e => e.Id == selectedPerson.Id));
                employeeRegistration.ShowDialog();
            }
            else
            {
                CustumerRegistration custumerRegistration = new(context.Customers.First(e => e.Id == selectedPerson.Id));
                custumerRegistration.ShowDialog();
            }
        }

        private void BtnAcivateDeactive_Click(object sender, EventArgs e)
        {
            if (TxtOutgrid.CurrentRow.DataBoundItem is not Person person)
                return;

            Person selectedPerson = _context.People.Single(p => p.Id == person.Id);
            selectedPerson.Status = !selectedPerson.Status;

            _context.Update(selectedPerson);
            _context.SaveChanges();

            btnSearch_Click(null, null);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtOutgrid.CurrentRow.DataBoundItem is not Person person)
                return;

            Person selectedPerson = _context.People.Single(p => p.Id == person.Id);
            
            _context.People.Remove(selectedPerson);
            _context.SaveChanges();

            if (!string.IsNullOrWhiteSpace(TxtSearchbar.Text))
                btnSearch_Click(null, null);

            _searchResults.Clear();
            foreach (var p in _context.People)
                _searchResults.Add(p);
        }
    }
}
