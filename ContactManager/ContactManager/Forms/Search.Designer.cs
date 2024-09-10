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
        TxtSearchbar.Location = new Point(71, 101);
        TxtSearchbar.Margin = new Padding(1);
        TxtSearchbar.Name = "TxtSearchbar";
        TxtSearchbar.Size = new Size(276, 27);
        TxtSearchbar.TabIndex = 0;
        // 
        // CmdSearch
        // 
        CmdSearch.Location = new Point(360, 99);
        CmdSearch.Margin = new Padding(1);
        CmdSearch.Name = "CmdSearch";
        CmdSearch.Size = new Size(88, 28);
        CmdSearch.TabIndex = 1;
        CmdSearch.Text = "Suche";
        CmdSearch.UseVisualStyleBackColor = true;
        CmdSearch.Click += btnSearch_Click;
        // 
        // LblSearchTitle
        // 
        LblSearchTitle.Font = new Font("Segoe UI", 15F);
        LblSearchTitle.Location = new Point(71, 43);
        LblSearchTitle.Margin = new Padding(1);
        LblSearchTitle.Multiline = true;
        LblSearchTitle.Name = "LblSearchTitle";
        LblSearchTitle.Size = new Size(124, 37);
        LblSearchTitle.TabIndex = 3;
        LblSearchTitle.Text = "SUCHE";
        LblSearchTitle.TextChanged += txtBoxTitelSearch_TextChanged;
        // 
        // TxtOutgrid
        // 
        TxtOutgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        TxtOutgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        TxtOutgrid.Location = new Point(71, 175);
        TxtOutgrid.Margin = new Padding(2, 3, 2, 3);
        TxtOutgrid.MultiSelect = false;
        TxtOutgrid.Name = "TxtOutgrid";
        TxtOutgrid.RowHeadersWidth = 51;
        TxtOutgrid.Size = new Size(810, 317);
        TxtOutgrid.TabIndex = 4;
        TxtOutgrid.CellDoubleClick += TxtOutgrid_CellDoubleClick;
        // 
        // BtnEdit
        // 
        BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        BtnEdit.Location = new Point(900, 175);
        BtnEdit.Margin = new Padding(1);
        BtnEdit.Name = "BtnEdit";
        BtnEdit.Size = new Size(88, 28);
        BtnEdit.TabIndex = 5;
        BtnEdit.Text = "Editieren";
        BtnEdit.UseVisualStyleBackColor = true;
        BtnEdit.Click += BtnEdit_Click;
        // 
        // BtnAcivateDeactive
        // 
        BtnAcivateDeactive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        BtnAcivateDeactive.Location = new Point(900, 206);
        BtnAcivateDeactive.Margin = new Padding(1);
        BtnAcivateDeactive.Name = "BtnAcivateDeactive";
        BtnAcivateDeactive.Size = new Size(88, 25);
        BtnAcivateDeactive.TabIndex = 6;
        BtnAcivateDeactive.Text = "Aktivieren";
        BtnAcivateDeactive.UseVisualStyleBackColor = true;
        BtnAcivateDeactive.Click += BtnAcivateDeactive_Click;
        // 
        // BtnDelete
        // 
        BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        BtnDelete.Location = new Point(900, 235);
        BtnDelete.Margin = new Padding(1);
        BtnDelete.Name = "BtnDelete";
        BtnDelete.Size = new Size(88, 28);
        BtnDelete.TabIndex = 8;
        BtnDelete.Text = "Löschen";
        BtnDelete.UseVisualStyleBackColor = true;
        BtnDelete.Click += BtnDelete_Click;
        // 
        // Search
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1024, 517);
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