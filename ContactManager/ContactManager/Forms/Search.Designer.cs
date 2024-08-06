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
        txtBoxTitelSearch = new TextBox();
        txtOutgrid = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)txtOutgrid).BeginInit();
        SuspendLayout();
        // 
        // txtBoxSearchBar
        // 
        txtBoxSearchBar.Location = new Point(151, 207);
        txtBoxSearchBar.Margin = new Padding(2);
        txtBoxSearchBar.Name = "txtBoxSearchBar";
        txtBoxSearchBar.Size = new Size(582, 47);
        txtBoxSearchBar.TabIndex = 0;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(766, 202);
        btnSearch.Margin = new Padding(2);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(187, 57);
        btnSearch.TabIndex = 1;
        btnSearch.Text = "Suche";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // txtBoxTitelSearch
        // 
        txtBoxTitelSearch.Font = new Font("Segoe UI", 15F);
        txtBoxTitelSearch.Location = new Point(151, 88);
        txtBoxTitelSearch.Margin = new Padding(2);
        txtBoxTitelSearch.Multiline = true;
        txtBoxTitelSearch.Name = "txtBoxTitelSearch";
        txtBoxTitelSearch.Size = new Size(258, 72);
        txtBoxTitelSearch.TabIndex = 3;
        txtBoxTitelSearch.Text = "SUCHE";
        txtBoxTitelSearch.TextChanged += txtBoxTitelSearch_TextChanged;
        // 
        // txtOutgrid
        // 
        txtOutgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        txtOutgrid.Location = new Point(151, 357);
        txtOutgrid.Margin = new Padding(6);
        txtOutgrid.Name = "txtOutgrid";
        txtOutgrid.RowHeadersWidth = 51;
        txtOutgrid.Size = new Size(649, 650);
        txtOutgrid.TabIndex = 4;
        // 
        // Search
        // 
        AutoScaleDimensions = new SizeF(17F, 41F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1218, 1062);
        Controls.Add(txtOutgrid);
        Controls.Add(txtBoxTitelSearch);
        Controls.Add(btnSearch);
        Controls.Add(txtBoxSearchBar);
        Margin = new Padding(2);
        Name = "Search";
        Text = "Suche";
        Load += Search_Load;
        ((System.ComponentModel.ISupportInitialize)txtOutgrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtBoxSearchBar;
        private Button btnSearch;
        private TextBox txtBoxTitelSearch;
    private DataGridView txtOutgrid;
}