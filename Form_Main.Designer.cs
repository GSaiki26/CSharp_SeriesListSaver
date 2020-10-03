namespace Lister {
    partial class Form_Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.DataGrid_Show = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Works = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarTabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox_Search = new System.Windows.Forms.TextBox();
            this.LabelP_Search = new System.Windows.Forms.Label();
            this.Label_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Show)).BeginInit();
            this.MenuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid_Show
            // 
            this.DataGrid_Show.AllowUserToAddRows = false;
            this.DataGrid_Show.AllowUserToDeleteRows = false;
            this.DataGrid_Show.AllowUserToResizeRows = false;
            this.DataGrid_Show.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.AnimesName,
            this.Status});
            this.DataGrid_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_Show.Location = new System.Drawing.Point(0, 24);
            this.DataGrid_Show.MultiSelect = false;
            this.DataGrid_Show.Name = "DataGrid_Show";
            this.DataGrid_Show.ReadOnly = true;
            this.DataGrid_Show.RowHeadersVisible = false;
            this.DataGrid_Show.Size = new System.Drawing.Size(444, 320);
            this.DataGrid_Show.TabIndex = 1;
            // 
            // Key
            // 
            this.Key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Key.DataPropertyName = "Key";
            this.Key.HeaderText = "Nº";
            this.Key.MinimumWidth = 20;
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Width = 44;
            // 
            // AnimesName
            // 
            this.AnimesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AnimesName.DataPropertyName = "WorkName";
            this.AnimesName.HeaderText = "Nome das Obras";
            this.AnimesName.MinimumWidth = 250;
            this.AnimesName.Name = "AnimesName";
            this.AnimesName.ReadOnly = true;
            this.AnimesName.Width = 250;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 70;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Works,
            this.sobreToolStripMenuItem});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(444, 24);
            this.MenuStrip_Main.TabIndex = 2;
            // 
            // ToolStripMenuItem_Works
            // 
            this.ToolStripMenuItem_Works.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Add,
            this.ToolStripMenuItem_Edit,
            this.gerenciarTabelasToolStripMenuItem});
            this.ToolStripMenuItem_Works.Name = "ToolStripMenuItem_Works";
            this.ToolStripMenuItem_Works.Size = new System.Drawing.Size(50, 20);
            this.ToolStripMenuItem_Works.Text = "Obras";
            // 
            // ToolStripMenuItem_Add
            // 
            this.ToolStripMenuItem_Add.Name = "ToolStripMenuItem_Add";
            this.ToolStripMenuItem_Add.Size = new System.Drawing.Size(153, 22);
            this.ToolStripMenuItem_Add.Text = "Adicionar obra";
            this.ToolStripMenuItem_Add.Click += new System.EventHandler(this.ToolStripMenuItem_Add_Click);
            // 
            // ToolStripMenuItem_Edit
            // 
            this.ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            this.ToolStripMenuItem_Edit.Size = new System.Drawing.Size(153, 22);
            this.ToolStripMenuItem_Edit.Text = "Editar obra";
            this.ToolStripMenuItem_Edit.Click += new System.EventHandler(this.ToolStripMenuItem_Edit_Click);
            // 
            // gerenciarTabelasToolStripMenuItem
            // 
            this.gerenciarTabelasToolStripMenuItem.Name = "gerenciarTabelasToolStripMenuItem";
            this.gerenciarTabelasToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.gerenciarTabelasToolStripMenuItem.Text = "Gerenciar listas";
            this.gerenciarTabelasToolStripMenuItem.Click += new System.EventHandler(this.gerenciarTabelasToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // TextBox_Search
            // 
            this.TextBox_Search.Location = new System.Drawing.Point(332, 2);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Search.TabIndex = 3;
            this.TextBox_Search.TextChanged += new System.EventHandler(this.TextBox_Search_TextChanged);
            // 
            // LabelP_Search
            // 
            this.LabelP_Search.AutoSize = true;
            this.LabelP_Search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LabelP_Search.Location = new System.Drawing.Point(247, 5);
            this.LabelP_Search.Name = "LabelP_Search";
            this.LabelP_Search.Size = new System.Drawing.Size(85, 13);
            this.LabelP_Search.TabIndex = 4;
            this.LabelP_Search.Text = "Pesquisar nome:";
            // 
            // Label_Error
            // 
            this.Label_Error.AutoSize = true;
            this.Label_Error.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.Label_Error.Location = new System.Drawing.Point(122, 5);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(0, 13);
            this.Label_Error.TabIndex = 5;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 344);
            this.Controls.Add(this.Label_Error);
            this.Controls.Add(this.LabelP_Search);
            this.Controls.Add(this.TextBox_Search);
            this.Controls.Add(this.DataGrid_Show);
            this.Controls.Add(this.MenuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lister";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Show)).EndInit();
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGrid_Show;
        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Works;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBox_Search;
        private System.Windows.Forms.Label LabelP_Search;
        private System.Windows.Forms.Label Label_Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripMenuItem gerenciarTabelasToolStripMenuItem;
    }
}