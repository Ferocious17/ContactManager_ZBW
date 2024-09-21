using ContactManager.DB;
using ContactManager.Enums;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Text;

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
            LblEmployeeRegistration userRegistration = new LblEmployeeRegistration()
            {
                StartPosition = FormStartPosition.CenterParent,
                Location = this.Location
            };

            userRegistration.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search()
            {
                StartPosition = FormStartPosition.CenterParent,
                Location = this.Location
            };

            search.ShowDialog();
        }

        private void btnClientRegistration_Click(object sender, EventArgs e)
        {
            CustumerRegistration clientRegistration = new CustumerRegistration()
            {
                StartPosition = FormStartPosition.CenterParent,
                Location = this.Location
            };

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

        private void CmdStartImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Import CSV file"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            using ContactManagerContext context = new();
            var csvContent = File.ReadAllLines(openFileDialog.FileName);
            Person[] people = new Person[csvContent.Length];
            try
            {
                for (int i = 0; i < csvContent.Length; i++)
                    people[i] = ParseCSV(csvContent[i]);
            }
            catch
            {
                MessageBox.Show("Data import failed. Please check your CSV content", "Import failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var person in people)
                context.Add(person);

            context.SaveChanges();
            MessageBox.Show("File data was imported into database", "Import successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Person ParseCSV(string csv)
        {
            var values = csv.Split(';');
            return values[0] switch
            {
                nameof(Employee) => new Employee(bool.Parse(values[1]), values[2], values[3], values[4], DateTime.Parse(values[5]), values[6], new(values[7], values[8], values[9], values[10]), new(values[11], values[12], int.Parse(values[13]), values[14]), bool.Parse(values[15]), values[16], Guid.Parse(values[17]), new Department("test"), DateTime.Parse(values[19]), DateTime.Parse(values[20]), int.Parse(values[21]), values[22], (CadreLevel)Enum.Parse(typeof(CadreLevel), values[23])),
                nameof(Customer) => new Customer(bool.Parse(values[1]), values[2], values[3], values[4], DateTime.Parse(values[5]), values[6], new(values[7], values[8], values[9], values[10]), new(values[11], values[12], int.Parse(values[13]), values[14]), bool.Parse(values[15]), values[16], values[17], (CustomerType)Enum.Parse(typeof(CustomerType), values[18]), values[19]),
                nameof(Trainee) => new Trainee(bool.Parse(values[1]), values[2], values[3], values[4], DateTime.Parse(values[5]), values[6], new(values[7], values[8], values[9], values[10]), new(values[11], values[12], int.Parse(values[13]), values[14]), bool.Parse(values[15]), values[16], Guid.Parse(values[17]), new Department("test"), DateTime.Parse(values[19]), DateTime.Parse(values[20]), int.Parse(values[21]), values[22], (CadreLevel)Enum.Parse(typeof(CadreLevel), values[23]), int.Parse(values[24]), int.Parse(values[25])),
                _ => throw new ArgumentException("Invalid CSV content"),
            };
        }

        private void CmdStartExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Export CSV file",
                FileName = "export.csv"
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            StringBuilder result = new();
            ContactManagerContext context = new();
            foreach (var person in context.People)
                result.AppendLine(person.GetCSV());

            File.WriteAllText(saveFileDialog.FileName, result.ToString());
            MessageBox.Show("Data was exported to CSV file", "Export successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
