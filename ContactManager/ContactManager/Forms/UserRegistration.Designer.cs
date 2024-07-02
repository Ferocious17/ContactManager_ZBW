namespace ContactManager.Forms
{
    partial class UserRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxTrainee = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtBoxPreName = new MaskedTextBox();
            txtBoxSurName = new MaskedTextBox();
            txtBoxAdress = new MaskedTextBox();
            txtBoxHouseNumber = new MaskedTextBox();
            txtBoxPhoneNumber = new MaskedTextBox();
            txtBoxSex = new MaskedTextBox();
            txtBoxPlace = new MaskedTextBox();
            txtBoxPLZ = new MaskedTextBox();
            txtBoxEmailAdress = new MaskedTextBox();
            txtBoxMobileNumber = new MaskedTextBox();
            txtBoxErfassungTitel = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSaveEmpoloyeRegistration = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxTrainee
            // 
            checkBoxTrainee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxTrainee.AutoSize = true;
            checkBoxTrainee.Location = new Point(2, 2);
            checkBoxTrainee.Margin = new Padding(2, 2, 2, 2);
            checkBoxTrainee.Name = "checkBoxTrainee";
            checkBoxTrainee.Size = new Size(276, 56);
            checkBoxTrainee.TabIndex = 0;
            checkBoxTrainee.Text = "Trainee";
            checkBoxTrainee.UseVisualStyleBackColor = true;
            checkBoxTrainee.CheckedChanged += checkBoxTrainee_CheckedChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(2, 60);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(276, 60);
            label2.TabIndex = 2;
            label2.Text = "Vorname";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(2, 120);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(276, 60);
            label3.TabIndex = 3;
            label3.Text = "Nachname";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(2, 180);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(276, 60);
            label4.TabIndex = 4;
            label4.Text = "Adresse";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(2, 240);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(276, 60);
            label5.TabIndex = 5;
            label5.Text = "Hausnummer";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(2, 300);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(276, 60);
            label6.TabIndex = 6;
            label6.Text = "PLZ";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(2, 360);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(276, 60);
            label7.TabIndex = 7;
            label7.Text = "Ort";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(2, 420);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(276, 60);
            label8.TabIndex = 8;
            label8.Text = "Geschlecht";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(2, 480);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(276, 60);
            label9.TabIndex = 9;
            label9.Text = "Telefonummer";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(2, 540);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(276, 60);
            label10.TabIndex = 10;
            label10.Text = "Mobilnummer";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(2, 600);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(276, 70);
            label11.TabIndex = 11;
            label11.Text = "Email-Adresse";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxPreName
            // 
            txtBoxPreName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPreName.Location = new Point(282, 66);
            txtBoxPreName.Margin = new Padding(2, 2, 2, 2);
            txtBoxPreName.Name = "txtBoxPreName";
            txtBoxPreName.Size = new Size(332, 47);
            txtBoxPreName.TabIndex = 12;
            // 
            // txtBoxSurName
            // 
            txtBoxSurName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxSurName.Location = new Point(282, 126);
            txtBoxSurName.Margin = new Padding(2, 2, 2, 2);
            txtBoxSurName.Name = "txtBoxSurName";
            txtBoxSurName.Size = new Size(332, 47);
            txtBoxSurName.TabIndex = 13;
            // 
            // txtBoxAdress
            // 
            txtBoxAdress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxAdress.Location = new Point(282, 186);
            txtBoxAdress.Margin = new Padding(2, 2, 2, 2);
            txtBoxAdress.Name = "txtBoxAdress";
            txtBoxAdress.Size = new Size(332, 47);
            txtBoxAdress.TabIndex = 14;
            // 
            // txtBoxHouseNumber
            // 
            txtBoxHouseNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxHouseNumber.Location = new Point(282, 246);
            txtBoxHouseNumber.Margin = new Padding(2, 2, 2, 2);
            txtBoxHouseNumber.Name = "txtBoxHouseNumber";
            txtBoxHouseNumber.Size = new Size(332, 47);
            txtBoxHouseNumber.TabIndex = 15;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPhoneNumber.Location = new Point(282, 486);
            txtBoxPhoneNumber.Margin = new Padding(2, 2, 2, 2);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(332, 47);
            txtBoxPhoneNumber.TabIndex = 19;
            // 
            // txtBoxSex
            // 
            txtBoxSex.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxSex.Location = new Point(282, 426);
            txtBoxSex.Margin = new Padding(2, 2, 2, 2);
            txtBoxSex.Name = "txtBoxSex";
            txtBoxSex.Size = new Size(332, 47);
            txtBoxSex.TabIndex = 18;
            // 
            // txtBoxPlace
            // 
            txtBoxPlace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPlace.Location = new Point(282, 366);
            txtBoxPlace.Margin = new Padding(2, 2, 2, 2);
            txtBoxPlace.Name = "txtBoxPlace";
            txtBoxPlace.Size = new Size(332, 47);
            txtBoxPlace.TabIndex = 17;
            // 
            // txtBoxPLZ
            // 
            txtBoxPLZ.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPLZ.Location = new Point(282, 306);
            txtBoxPLZ.Margin = new Padding(2, 2, 2, 2);
            txtBoxPLZ.Name = "txtBoxPLZ";
            txtBoxPLZ.Size = new Size(332, 47);
            txtBoxPLZ.TabIndex = 16;
            // 
            // txtBoxEmailAdress
            // 
            txtBoxEmailAdress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxEmailAdress.Location = new Point(282, 611);
            txtBoxEmailAdress.Margin = new Padding(2, 2, 2, 2);
            txtBoxEmailAdress.Name = "txtBoxEmailAdress";
            txtBoxEmailAdress.Size = new Size(332, 47);
            txtBoxEmailAdress.TabIndex = 21;
            // 
            // txtBoxMobileNumber
            // 
            txtBoxMobileNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxMobileNumber.Location = new Point(282, 546);
            txtBoxMobileNumber.Margin = new Padding(2, 2, 2, 2);
            txtBoxMobileNumber.Name = "txtBoxMobileNumber";
            txtBoxMobileNumber.Size = new Size(332, 47);
            txtBoxMobileNumber.TabIndex = 20;
            // 
            // txtBoxErfassungTitel
            // 
            txtBoxErfassungTitel.Font = new Font("Segoe UI", 15F);
            txtBoxErfassungTitel.Location = new Point(134, 131);
            txtBoxErfassungTitel.Margin = new Padding(2, 2, 2, 2);
            txtBoxErfassungTitel.Multiline = true;
            txtBoxErfassungTitel.Name = "txtBoxErfassungTitel";
            txtBoxErfassungTitel.Size = new Size(716, 94);
            txtBoxErfassungTitel.TabIndex = 22;
            txtBoxErfassungTitel.TabStop = false;
            txtBoxErfassungTitel.Text = "MITARBEITER ERFASSUNG";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.5172424F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.4827576F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(checkBoxTrainee, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBoxEmailAdress, 1, 10);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(txtBoxMobileNumber, 1, 9);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(txtBoxPhoneNumber, 1, 8);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txtBoxSex, 1, 7);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(txtBoxPlace, 1, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(txtBoxPLZ, 1, 5);
            tableLayoutPanel1.Controls.Add(label9, 0, 8);
            tableLayoutPanel1.Controls.Add(txtBoxHouseNumber, 1, 4);
            tableLayoutPanel1.Controls.Add(label10, 0, 9);
            tableLayoutPanel1.Controls.Add(txtBoxAdress, 1, 3);
            tableLayoutPanel1.Controls.Add(txtBoxSurName, 1, 2);
            tableLayoutPanel1.Controls.Add(txtBoxPreName, 1, 1);
            tableLayoutPanel1.Controls.Add(label11, 0, 10);
            tableLayoutPanel1.Location = new Point(134, 293);
            tableLayoutPanel1.Margin = new Padding(6, 6, 6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09091F));
            tableLayoutPanel1.Size = new Size(616, 670);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // btnSaveEmpoloyeRegistration
            // 
            btnSaveEmpoloyeRegistration.Location = new Point(871, 902);
            btnSaveEmpoloyeRegistration.Name = "btnSaveEmpoloyeRegistration";
            btnSaveEmpoloyeRegistration.Size = new Size(291, 52);
            btnSaveEmpoloyeRegistration.TabIndex = 24;
            btnSaveEmpoloyeRegistration.Text = "Speichern";
            btnSaveEmpoloyeRegistration.UseVisualStyleBackColor = true;
            // 
            // UserRegistration
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1222, 1056);
            Controls.Add(btnSaveEmpoloyeRegistration);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtBoxErfassungTitel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UserRegistration";
            Text = "Mitarbeitererfassung";
            Load += UserRegistration_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxTrainee;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private MaskedTextBox txtBoxPreName;
        private MaskedTextBox txtBoxSurName;
        private MaskedTextBox txtBoxAdress;
        private MaskedTextBox txtBoxHouseNumber;
        private MaskedTextBox txtBoxPhoneNumber;
        private MaskedTextBox txtBoxSex;
        private MaskedTextBox txtBoxPlace;
        private MaskedTextBox txtBoxPLZ;
        private MaskedTextBox txtBoxEmailAdress;
        private MaskedTextBox txtBoxMobileNumber;
        private TextBox txtBoxErfassungTitel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSaveEmpoloyeRegistration;
    }
}