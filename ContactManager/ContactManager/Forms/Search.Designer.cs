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
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // txtBoxSearchBar
        // 
        txtBoxSearchBar.Location = new Point(71, 101);
        txtBoxSearchBar.Margin = new Padding(1);
        txtBoxSearchBar.Name = "txtBoxSearchBar";
        txtBoxSearchBar.Size = new Size(276, 27);
        txtBoxSearchBar.TabIndex = 0;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(361, 96);
        btnSearch.Margin = new Padding(1);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(88, 28);
        btnSearch.TabIndex = 1;
        btnSearch.Text = "Suche";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // txtBoxTitelSearch
        // 
        txtBoxTitelSearch.Font = new Font("Segoe UI", 15F);
        txtBoxTitelSearch.Location = new Point(71, 43);
        txtBoxTitelSearch.Margin = new Padding(1);
        txtBoxTitelSearch.Multiline = true;
        txtBoxTitelSearch.Name = "txtBoxTitelSearch";
        txtBoxTitelSearch.Size = new Size(120, 37);
        txtBoxTitelSearch.TabIndex = 3;
        txtBoxTitelSearch.Text = "SUCHE";
        txtBoxTitelSearch.TextChanged += txtBoxTitelSearch_TextChanged;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(76, 174);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(300, 188);
        dataGridView1.TabIndex = 4;
        // 
        // Search
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(736, 515);
        Controls.Add(dataGridView1);
        Controls.Add(txtBoxTitelSearch);
        Controls.Add(btnSearch);
        Controls.Add(txtBoxSearchBar);
        Margin = new Padding(1);
        Name = "Search";
        Text = "Suche";
        Load += Search_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtBoxSearchBar;
        private Button btnSearch;
        private TextBox txtBoxTitelSearch;
    private DataGridView dataGridView1;
}