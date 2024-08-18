using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

class EmployeeRegistration : Form
{
    private System.ComponentModel.IContainer components;
    private TextBox LblEmployeeTitle;
    private Button CmdEmployeeSave;
    private Label LblEmployeeRole;
    private Label LblEmployeeEnddate;
    private Label LblEmployeeStartdate;
    private MaskedTextBox TxtEmployeeFirstname;
    private Label LblEmployeeEmail;
    private MaskedTextBox TxtEmployeeLastname;
    private MaskedTextBox TxtEmployeeStreet;
    private Label LblEmployeeMobilenumber;
    private MaskedTextBox TxtEmployeeHousenumber;
    private Label LblEmployeePhonenumber;
    private MaskedTextBox TxtEmployeeZIPcode;
    private Label LblEmployeeSex;
    private MaskedTextBox TxtEmployeePlace;
    private Label LblEmployeePlace;
    private Label LblEmployeeZIPcode;
    private MaskedTextBox TxtEmployeePhonenumber;
    private Label LblEmployeeHousenumber;
    private MaskedTextBox TxtEmployeeMobilenumber;
    private Label LblEmployeeStreet;
    private MaskedTextBox TxtEmployeeEmail;
    private CheckBox ChkEmployeeTrainee;
    private Label LblEmployeeLastname;
    private Label LblEmployeeFirstname;
    private Label LblEmployeeTrainigyear;
    private Label LblEmployeeDepartement;
    private Label LblEmployeeLevel;
    private TableLayoutPanel TblLayoutEmployee;
    private ComboBox CmbEmployeeDepartement;
    private DateTimePicker DtpEmployeeStartdate;
    private DateTimePicker DtpEmployeeEnddate;
    private ComboBox CmbEmployeeLevel;
    private ComboBox CmbEmployeeRole;
    private MaskedTextBox TxtEmployeeTrainigyear;
    private RadioButton RedEmployeeMale;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private GroupBox GrpEmployeeSex;
    private RadioButton RedEmployeeFemale;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.LblEmployeeTitle = new TextBox();
        this.CmdEmployeeSave = new Button();
        this.LblEmployeeRole = new Label();
        this.LblEmployeeEnddate = new Label();
        this.LblEmployeeStartdate = new Label();
        this.TxtEmployeeFirstname = new MaskedTextBox();
        this.LblEmployeeEmail = new Label();
        this.TxtEmployeeLastname = new MaskedTextBox();
        this.TxtEmployeeStreet = new MaskedTextBox();
        this.LblEmployeeMobilenumber = new Label();
        this.TxtEmployeeHousenumber = new MaskedTextBox();
        this.LblEmployeePhonenumber = new Label();
        this.TxtEmployeeZIPcode = new MaskedTextBox();
        this.LblEmployeeSex = new Label();
        this.TxtEmployeePlace = new MaskedTextBox();
        this.LblEmployeePlace = new Label();
        this.LblEmployeeZIPcode = new Label();
        this.TxtEmployeePhonenumber = new MaskedTextBox();
        this.LblEmployeeHousenumber = new Label();
        this.TxtEmployeeMobilenumber = new MaskedTextBox();
        this.LblEmployeeStreet = new Label();
        this.TxtEmployeeEmail = new MaskedTextBox();
        this.ChkEmployeeTrainee = new CheckBox();
        this.LblEmployeeLastname = new Label();
        this.LblEmployeeFirstname = new Label();
        this.LblEmployeeTrainigyear = new Label();
        this.LblEmployeeDepartement = new Label();
        this.LblEmployeeLevel = new Label();
        this.TblLayoutEmployee = new TableLayoutPanel();
        this.CmbEmployeeDepartement = new ComboBox();
        this.DtpEmployeeStartdate = new DateTimePicker();
        this.DtpEmployeeEnddate = new DateTimePicker();
        this.CmbEmployeeLevel = new ComboBox();
        this.CmbEmployeeRole = new ComboBox();
        this.TxtEmployeeTrainigyear = new MaskedTextBox();
        this.RedEmployeeMale = new RadioButton();
        this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        this.GrpEmployeeSex = new GroupBox();
        this.RedEmployeeFemale = new RadioButton();

        // Event handlers
        this.ChkEmployeeTrainee.CheckedChanged += new EventHandler(this.ChkEmployeeTrainee_CheckedChanged);
        this.LblEmployeeTrainigyear.Click += new EventHandler(this.label2_Click);
        this.Load += new EventHandler(this.EmployeeRegistration_Load);

        // Form properties
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = SystemColors.Control;
        this.ClientSize = new Size(502, 526);
        this.Controls.Add(this.CmdEmployeeSave);
        this.Controls.Add(this.TblLayoutEmployee);
        this.Controls.Add(this.LblEmployeeTitle);
        this.Margin = new Padding(1);
        this.Name = "EmployeeRegistration";
        this.Text = "Mitarbeitererfassung";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private void ChkEmployeeTrainee_CheckedChanged(object sender, EventArgs e)
    {
        // Event handler logic
    }

    private void label2_Click(object sender, EventArgs e)
    {
        // Event handler logic
    }

    private void EmployeeRegistration_Load(object sender, EventArgs e)
    {
        // Event handler logic
    }
}
