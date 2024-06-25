namespace ContactManager.Forms;
    partial class Search
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
            txtBoxSearchBar = new TextBox();
            btnSearch = new Button();
            txtBoxOutGrid = new TextBox();
            txtBoxTitelSearch = new TextBox();
            SuspendLayout();
            // 
            // txtBoxSearchBar
            // 
            txtBoxSearchBar.Location = new Point(151, 207);
            txtBoxSearchBar.Name = "txtBoxSearchBar";
            txtBoxSearchBar.Size = new Size(581, 47);
            txtBoxSearchBar.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(767, 196);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(188, 58);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Suche";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBoxOutGrid
            // 
            txtBoxOutGrid.Location = new Point(151, 348);
            txtBoxOutGrid.Multiline = true;
            txtBoxOutGrid.Name = "txtBoxOutGrid";
            txtBoxOutGrid.Size = new Size(787, 858);
            txtBoxOutGrid.TabIndex = 2;
            // 
            // txtBoxTitelSearch
            // 
            txtBoxTitelSearch.Font = new Font("Segoe UI", 15F);
            txtBoxTitelSearch.Location = new Point(151, 89);
            txtBoxTitelSearch.Multiline = true;
            txtBoxTitelSearch.Name = "txtBoxTitelSearch";
            txtBoxTitelSearch.Size = new Size(250, 71);
            txtBoxTitelSearch.TabIndex = 3;
            txtBoxTitelSearch.Text = "SUCHE";
            txtBoxTitelSearch.TextChanged += txtBoxTitelSearch_TextChanged;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1564, 1492);
            Controls.Add(txtBoxTitelSearch);
            Controls.Add(txtBoxOutGrid);
            Controls.Add(btnSearch);
            Controls.Add(txtBoxSearchBar);
            Name = "Search";
            Text = "Search";
            Load += Search_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxSearchBar;
        private Button btnSearch;
        private TextBox txtBoxOutGrid;
        private TextBox txtBoxTitelSearch;
    }