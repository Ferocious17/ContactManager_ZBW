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
        TxtSearchbar = new TextBox();
        CmdSearch = new Button();
        LblSearchTitle = new TextBox();
        TxtOutgrid = new DataGridView();
        BtnEdit = new Button();
        BtnAcivateDeactive = new Button();
        BtnDelete = new Button();
        ((System.ComponentModel.ISupportInitialize)TxtOutgrid).BeginInit();
        SuspendLayout();
        // 
        // TxtSearchbar
        // 
        TxtSearchbar.Location = new Point(62, 76);
        TxtSearchbar.Margin = new Padding(1);
        TxtSearchbar.Name = "TxtSearchbar";
        TxtSearchbar.Size = new Size(242, 23);
        TxtSearchbar.TabIndex = 0;
        // 
        // CmdSearch
        // 
        CmdSearch.Location = new Point(315, 74);
        CmdSearch.Margin = new Padding(1);
        CmdSearch.Name = "CmdSearch";
        CmdSearch.Size = new Size(77, 21);
        CmdSearch.TabIndex = 1;
        CmdSearch.Text = "Suche";
        CmdSearch.UseVisualStyleBackColor = true;
        CmdSearch.Click += btnSearch_Click;
        // 
        // LblSearchTitle
        // 
        LblSearchTitle.Font = new Font("Segoe UI", 15F);
        LblSearchTitle.Location = new Point(62, 32);
        LblSearchTitle.Margin = new Padding(1);
        LblSearchTitle.Multiline = true;
        LblSearchTitle.Name = "LblSearchTitle";
        LblSearchTitle.Size = new Size(109, 29);
        LblSearchTitle.TabIndex = 3;
        LblSearchTitle.Text = "SUCHE";
        LblSearchTitle.TextChanged += txtBoxTitelSearch_TextChanged;
        // 
        // TxtOutgrid
        // 
        TxtOutgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        TxtOutgrid.Location = new Point(62, 131);
        TxtOutgrid.Margin = new Padding(2);
        TxtOutgrid.Name = "TxtOutgrid";
        TxtOutgrid.RowHeadersWidth = 51;
        TxtOutgrid.Size = new Size(267, 238);
        TxtOutgrid.TabIndex = 4;
        TxtOutgrid.CellDoubleClick += TxtOutgrid_CellDoubleClick;
        // 
        // BtnEdit
        // 
        BtnEdit.Location = new Point(375, 131);
        BtnEdit.Margin = new Padding(1);
        BtnEdit.Name = "BtnEdit";
        BtnEdit.Size = new Size(77, 21);
        BtnEdit.TabIndex = 5;
        BtnEdit.Text = "Editieren";
        BtnEdit.UseVisualStyleBackColor = true;
        // 
        // BtnAcivateDeactive
        // 
        BtnAcivateDeactive.Location = new Point(375, 154);
        BtnAcivateDeactive.Margin = new Padding(1);
        BtnAcivateDeactive.Name = "BtnAcivateDeactive";
        BtnAcivateDeactive.Size = new Size(77, 19);
        BtnAcivateDeactive.TabIndex = 6;
        BtnAcivateDeactive.Text = "Aktivieren";
        BtnAcivateDeactive.UseVisualStyleBackColor = true;
        // 
        // BtnDelete
        // 
        BtnDelete.Location = new Point(375, 176);
        BtnDelete.Margin = new Padding(1);
        BtnDelete.Name = "BtnDelete";
        BtnDelete.Size = new Size(77, 21);
        BtnDelete.TabIndex = 8;
        BtnDelete.Text = "Löschen";
        BtnDelete.UseVisualStyleBackColor = true;
        // 
        // Search
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(502, 388);
        Controls.Add(BtnDelete);
        Controls.Add(BtnAcivateDeactive);
        Controls.Add(BtnEdit);
        Controls.Add(TxtOutgrid);
        Controls.Add(LblSearchTitle);
        Controls.Add(CmdSearch);
        Controls.Add(TxtSearchbar);
        Margin = new Padding(1);
        Name = "Search";
        Text = "Suche";
        Load += Search_Load;
        ((System.ComponentModel.ISupportInitialize)TxtOutgrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox TxtSearchbar;
        private Button CmdSearch;
        private TextBox LblSearchTitle;
    private DataGridView TxtOutgrid;
    private Button BtnEdit;
    private Button BtnAcivateDeactive;
    private Button BtnDelete;
}