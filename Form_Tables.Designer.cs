namespace Lister {
    partial class Form_Tables {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Tables));
            this.DataGrid_Show = new System.Windows.Forms.DataGridView();
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.MenuStripItem_MainManager = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripItem_MainAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripItem_MainRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.Button_Confirm = new System.Windows.Forms.Button();
            this.LabelP_Name = new System.Windows.Forms.Label();
            this.Label_Error = new System.Windows.Forms.Label();
            this.CheckBox_Define = new System.Windows.Forms.CheckBox();
            this.TablesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rootpage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sql = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.TablesName,
            this.rootpage,
            this.sql,
            this.tbl_name,
            this.type});
            this.DataGrid_Show.Dock = System.Windows.Forms.DockStyle.Right;
            this.DataGrid_Show.Location = new System.Drawing.Point(214, 0);
            this.DataGrid_Show.MultiSelect = false;
            this.DataGrid_Show.Name = "DataGrid_Show";
            this.DataGrid_Show.ReadOnly = true;
            this.DataGrid_Show.RowHeadersVisible = false;
            this.DataGrid_Show.Size = new System.Drawing.Size(421, 313);
            this.DataGrid_Show.TabIndex = 0;
            this.DataGrid_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Show_CellClick);
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripItem_MainManager});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(214, 24);
            this.MenuStrip_Main.TabIndex = 2;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // MenuStripItem_MainManager
            // 
            this.MenuStripItem_MainManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripItem_MainAdd,
            this.MenuStripItem_MainRemove});
            this.MenuStripItem_MainManager.Name = "MenuStripItem_MainManager";
            this.MenuStripItem_MainManager.Size = new System.Drawing.Size(69, 20);
            this.MenuStripItem_MainManager.Text = "Gerenciar";
            // 
            // MenuStripItem_MainAdd
            // 
            this.MenuStripItem_MainAdd.Name = "MenuStripItem_MainAdd";
            this.MenuStripItem_MainAdd.Size = new System.Drawing.Size(180, 22);
            this.MenuStripItem_MainAdd.Text = "Adicionar lista";
            this.MenuStripItem_MainAdd.Click += new System.EventHandler(this.MenuStripItem_MainAdd_Click);
            // 
            // MenuStripItem_MainRemove
            // 
            this.MenuStripItem_MainRemove.Name = "MenuStripItem_MainRemove";
            this.MenuStripItem_MainRemove.Size = new System.Drawing.Size(180, 22);
            this.MenuStripItem_MainRemove.Text = "Remover lista";
            this.MenuStripItem_MainRemove.Click += new System.EventHandler(this.MenuStripItem_MainRemove_Click);
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(58, 117);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Name.TabIndex = 3;
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.Location = new System.Drawing.Point(56, 169);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Size = new System.Drawing.Size(73, 20);
            this.Button_Confirm.TabIndex = 4;
            this.Button_Confirm.Text = "Confirmar";
            this.Button_Confirm.UseVisualStyleBackColor = true;
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // LabelP_Name
            // 
            this.LabelP_Name.AutoSize = true;
            this.LabelP_Name.Location = new System.Drawing.Point(14, 120);
            this.LabelP_Name.Name = "LabelP_Name";
            this.LabelP_Name.Size = new System.Drawing.Size(38, 13);
            this.LabelP_Name.TabIndex = 5;
            this.LabelP_Name.Text = "Nome:";
            // 
            // Label_Error
            // 
            this.Label_Error.AutoSize = true;
            this.Label_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.Label_Error.Location = new System.Drawing.Point(19, 192);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(0, 13);
            this.Label_Error.TabIndex = 6;
            // 
            // CheckBox_Define
            // 
            this.CheckBox_Define.AutoSize = true;
            this.CheckBox_Define.Location = new System.Drawing.Point(31, 146);
            this.CheckBox_Define.Name = "CheckBox_Define";
            this.CheckBox_Define.Size = new System.Drawing.Size(127, 17);
            this.CheckBox_Define.TabIndex = 7;
            this.CheckBox_Define.Text = "Definir como principal";
            this.CheckBox_Define.UseVisualStyleBackColor = true;
            // 
            // TablesName
            // 
            this.TablesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TablesName.DataPropertyName = "name";
            this.TablesName.HeaderText = "Nome das Listas";
            this.TablesName.Name = "TablesName";
            this.TablesName.ReadOnly = true;
            // 
            // rootpage
            // 
            this.rootpage.DataPropertyName = "rootpage";
            this.rootpage.HeaderText = "rootpage";
            this.rootpage.Name = "rootpage";
            this.rootpage.ReadOnly = true;
            this.rootpage.Visible = false;
            // 
            // sql
            // 
            this.sql.DataPropertyName = "sql";
            this.sql.HeaderText = "sql";
            this.sql.Name = "sql";
            this.sql.ReadOnly = true;
            this.sql.Visible = false;
            // 
            // tbl_name
            // 
            this.tbl_name.DataPropertyName = "tbl_name";
            this.tbl_name.HeaderText = "tbl_name";
            this.tbl_name.Name = "tbl_name";
            this.tbl_name.ReadOnly = true;
            this.tbl_name.Visible = false;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Visible = false;
            // 
            // Form_Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 313);
            this.Controls.Add(this.CheckBox_Define);
            this.Controls.Add(this.Label_Error);
            this.Controls.Add(this.LabelP_Name);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.MenuStrip_Main);
            this.Controls.Add(this.DataGrid_Show);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "Form_Tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Listas";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Show)).EndInit();
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Show;
        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem MenuStripItem_MainManager;
        private System.Windows.Forms.ToolStripMenuItem MenuStripItem_MainAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuStripItem_MainRemove;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Button Button_Confirm;
        private System.Windows.Forms.Label LabelP_Name;
        private System.Windows.Forms.Label Label_Error;
        private System.Windows.Forms.CheckBox CheckBox_Define;
        private System.Windows.Forms.DataGridViewTextBoxColumn TablesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rootpage;
        private System.Windows.Forms.DataGridViewTextBoxColumn sql;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}