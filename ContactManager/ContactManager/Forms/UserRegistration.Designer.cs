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
            txtBoxPreNameEmp = new MaskedTextBox();
            txtBoxSurNameEmp = new MaskedTextBox();
            txtBoxAdressEmp = new MaskedTextBox();
            txtBoxHouseNumberEmp = new MaskedTextBox();
            txtBoxPhoneNumberEmp = new MaskedTextBox();
            txtBoxSexEmp = new MaskedTextBox();
            txtBoxPlaceEmp = new MaskedTextBox();
            txtBoxPLZEmp = new MaskedTextBox();
            txtBoxEmailAdressEmp = new MaskedTextBox();
            txtBoxMobileNumberEmp = new MaskedTextBox();
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
            checkBoxTrainee.Margin = new Padding(2);
            checkBoxTrainee.Name = "checkBoxTrainee";
            checkBoxTrainee.Size = new Size(243, 70);
            checkBoxTrainee.TabIndex = 0;
            checkBoxTrainee.Text = "Trainee";
            checkBoxTrainee.UseVisualStyleBackColor = true;
            checkBoxTrainee.CheckedChanged += checkBoxTrainee_CheckedChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(2, 74);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(243, 74);
            label2.TabIndex = 2;
            label2.Text = "Vorname";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(2, 148);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(243, 74);
            label3.TabIndex = 3;
            label3.Text = "Nachname";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(2, 222);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(243, 74);
            label4.TabIndex = 4;
            label4.Text = "Adresse";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(2, 296);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(243, 74);
            label5.TabIndex = 5;
            label5.Text = "Hausnummer";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(2, 370);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(243, 74);
            label6.TabIndex = 6;
            label6.Text = "PLZ";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(2, 444);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(243, 74);
            label7.TabIndex = 7;
            label7.Text = "Ort";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(2, 518);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(243, 74);
            label8.TabIndex = 8;
            label8.Text = "Geschlecht";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(2, 592);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(243, 74);
            label9.TabIndex = 9;
            label9.Text = "Telefonummer";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(2, 666);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(243, 74);
            label10.TabIndex = 10;
            label10.Text = "Mobilnummer";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(2, 740);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(243, 77);
            label11.TabIndex = 11;
            label11.Text = "Email-Adresse";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxPreNameEmp
            // 
            txtBoxPreNameEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPreNameEmp.Location = new Point(249, 87);
            txtBoxPreNameEmp.Margin = new Padding(2);
            txtBoxPreNameEmp.Name = "txtBoxPreNameEmp";
            txtBoxPreNameEmp.Size = new Size(424, 47);
            txtBoxPreNameEmp.TabIndex = 12;
            // 
            // txtBoxSurNameEmp
            // 
            txtBoxSurNameEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxSurNameEmp.Location = new Point(249, 161);
            txtBoxSurNameEmp.Margin = new Padding(2);
            txtBoxSurNameEmp.Name = "txtBoxSurNameEmp";
            txtBoxSurNameEmp.Size = new Size(424, 47);
            txtBoxSurNameEmp.TabIndex = 13;
            // 
            // txtBoxAdressEmp
            // 
            txtBoxAdressEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxAdressEmp.Location = new Point(249, 235);
            txtBoxAdressEmp.Margin = new Padding(2);
            txtBoxAdressEmp.Name = "txtBoxAdressEmp";
            txtBoxAdressEmp.Size = new Size(424, 47);
            txtBoxAdressEmp.TabIndex = 14;
            // 
            // txtBoxHouseNumberEmp
            // 
            txtBoxHouseNumberEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxHouseNumberEmp.Location = new Point(249, 309);
            txtBoxHouseNumberEmp.Margin = new Padding(2);
            txtBoxHouseNumberEmp.Name = "txtBoxHouseNumberEmp";
            txtBoxHouseNumberEmp.Size = new Size(424, 47);
            txtBoxHouseNumberEmp.TabIndex = 15;
            // 
            // txtBoxPhoneNumberEmp
            // 
            txtBoxPhoneNumberEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPhoneNumberEmp.Location = new Point(249, 605);
            txtBoxPhoneNumberEmp.Margin = new Padding(2);
            txtBoxPhoneNumberEmp.Name = "txtBoxPhoneNumberEmp";
            txtBoxPhoneNumberEmp.Size = new Size(424, 47);
            txtBoxPhoneNumberEmp.TabIndex = 19;
            // 
            // txtBoxSexEmp
            // 
            txtBoxSexEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxSexEmp.Location = new Point(249, 531);
            txtBoxSexEmp.Margin = new Padding(2);
            txtBoxSexEmp.Name = "txtBoxSexEmp";
            txtBoxSexEmp.Size = new Size(424, 47);
            txtBoxSexEmp.TabIndex = 18;
            // 
            // txtBoxPlaceEmp
            // 
            txtBoxPlaceEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPlaceEmp.Location = new Point(249, 457);
            txtBoxPlaceEmp.Margin = new Padding(2);
            txtBoxPlaceEmp.Name = "txtBoxPlaceEmp";
            txtBoxPlaceEmp.Size = new Size(424, 47);
            txtBoxPlaceEmp.TabIndex = 17;
            // 
            // txtBoxPLZEmp
            // 
            txtBoxPLZEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPLZEmp.Location = new Point(249, 383);
            txtBoxPLZEmp.Margin = new Padding(2);
            txtBoxPLZEmp.Name = "txtBoxPLZEmp";
            txtBoxPLZEmp.Size = new Size(424, 47);
            txtBoxPLZEmp.TabIndex = 16;
            // 
            // txtBoxEmailAdressEmp
            // 
            txtBoxEmailAdressEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxEmailAdressEmp.Location = new Point(249, 755);
            txtBoxEmailAdressEmp.Margin = new Padding(2);
            txtBoxEmailAdressEmp.Name = "txtBoxEmailAdressEmp";
            txtBoxEmailAdressEmp.Size = new Size(424, 47);
            txtBoxEmailAdressEmp.TabIndex = 21;
            // 
            // txtBoxMobileNumberEmp
            // 
            txtBoxMobileNumberEmp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxMobileNumberEmp.Location = new Point(249, 679);
            txtBoxMobileNumberEmp.Margin = new Padding(2);
            txtBoxMobileNumberEmp.Name = "txtBoxMobileNumberEmp";
            txtBoxMobileNumberEmp.Size = new Size(424, 47);
            txtBoxMobileNumberEmp.TabIndex = 20;
            // 
            // txtBoxErfassungTitel
            // 
            txtBoxErfassungTitel.Font = new Font("Segoe UI", 15F);
            txtBoxErfassungTitel.Location = new Point(51, 59);
            txtBoxErfassungTitel.Margin = new Padding(2);
            txtBoxErfassungTitel.Multiline = true;
            txtBoxErfassungTitel.Name = "txtBoxErfassungTitel";
            txtBoxErfassungTitel.Size = new Size(682, 88);
            txtBoxErfassungTitel.TabIndex = 22;
            txtBoxErfassungTitel.TabStop = false;
            txtBoxErfassungTitel.Text = "MITARBEITER ERFASSUNG";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.6442947F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.3557053F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(checkBoxTrainee, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBoxEmailAdressEmp, 1, 10);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(txtBoxMobileNumberEmp, 1, 9);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(txtBoxPhoneNumberEmp, 1, 8);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txtBoxSexEmp, 1, 7);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(txtBoxPlaceEmp, 1, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(txtBoxPLZEmp, 1, 5);
            tableLayoutPanel1.Controls.Add(label9, 0, 8);
            tableLayoutPanel1.Controls.Add(txtBoxHouseNumberEmp, 1, 4);
            tableLayoutPanel1.Controls.Add(label10, 0, 9);
            tableLayoutPanel1.Controls.Add(txtBoxAdressEmp, 1, 3);
            tableLayoutPanel1.Controls.Add(txtBoxSurNameEmp, 1, 2);
            tableLayoutPanel1.Controls.Add(txtBoxPreNameEmp, 1, 1);
            tableLayoutPanel1.Controls.Add(label11, 0, 10);
            tableLayoutPanel1.Location = new Point(58, 199);
            tableLayoutPanel1.Margin = new Padding(6);
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
            tableLayoutPanel1.Size = new Size(675, 817);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // btnSaveEmpoloyeRegistration
            // 
            btnSaveEmpoloyeRegistration.Location = new Point(802, 954);
            btnSaveEmpoloyeRegistration.Name = "btnSaveEmpoloyeRegistration";
            btnSaveEmpoloyeRegistration.Size = new Size(250, 47);
            btnSaveEmpoloyeRegistration.TabIndex = 24;
            btnSaveEmpoloyeRegistration.Text = "Speichern";
            btnSaveEmpoloyeRegistration.UseVisualStyleBackColor = true;
            // 
            // UserRegistration
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1218, 1062);
            Controls.Add(btnSaveEmpoloyeRegistration);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtBoxErfassungTitel);
            Margin = new Padding(2);
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
        private MaskedTextBox txtBoxPreNameEmp;
        private MaskedTextBox txtBoxSurNameEmp;
        private MaskedTextBox txtBoxAdressEmp;
        private MaskedTextBox txtBoxHouseNumberEmp;
        private MaskedTextBox txtBoxPhoneNumberEmp;
        private MaskedTextBox txtBoxSexEmp;
        private MaskedTextBox txtBoxPlaceEmp;
        private MaskedTextBox txtBoxPLZEmp;
        private MaskedTextBox txtBoxEmailAdressEmp;
        private MaskedTextBox txtBoxMobileNumberEmp;
        private TextBox txtBoxErfassungTitel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSaveEmpoloyeRegistration;
    }
}