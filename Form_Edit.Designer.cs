namespace Lister {
    partial class Form_Edit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Edit));
            this.TextBox_WorkName = new System.Windows.Forms.TextBox();
            this.Button_Confirm = new System.Windows.Forms.Button();
            this.LabelP_WorkName = new System.Windows.Forms.Label();
            this.LabelP_Status = new System.Windows.Forms.Label();
            this.ComboBox_Status = new System.Windows.Forms.ComboBox();
            this.Label_Error = new System.Windows.Forms.Label();
            this.DataGrid_Show = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBox_Search = new System.Windows.Forms.TextBox();
            this.LabelP_Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_WorkName
            // 
            this.TextBox_WorkName.Location = new System.Drawing.Point(12, 117);
            this.TextBox_WorkName.Name = "TextBox_WorkName";
            this.TextBox_WorkName.Size = new System.Drawing.Size(184, 20);
            this.TextBox_WorkName.TabIndex = 1;
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.Location = new System.Drawing.Point(46, 278);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Size = new System.Drawing.Size(100, 23);
            this.Button_Confirm.TabIndex = 3;
            this.Button_Confirm.Text = "Confirmar";
            this.Button_Confirm.UseVisualStyleBackColor = true;
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // LabelP_WorkName
            // 
            this.LabelP_WorkName.AutoSize = true;
            this.LabelP_WorkName.Location = new System.Drawing.Point(59, 101);
            this.LabelP_WorkName.Name = "LabelP_WorkName";
            this.LabelP_WorkName.Size = new System.Drawing.Size(79, 13);
            this.LabelP_WorkName.TabIndex = 4;
            this.LabelP_WorkName.Text = "Nome da Obra:";
            // 
            // LabelP_Status
            // 
            this.LabelP_Status.AutoSize = true;
            this.LabelP_Status.Location = new System.Drawing.Point(50, 146);
            this.LabelP_Status.Name = "LabelP_Status";
            this.LabelP_Status.Size = new System.Drawing.Size(40, 13);
            this.LabelP_Status.TabIndex = 5;
            this.LabelP_Status.Text = "Status:";
            // 
            // ComboBox_Status
            // 
            this.ComboBox_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Status.FormattingEnabled = true;
            this.ComboBox_Status.Location = new System.Drawing.Point(96, 143);
            this.ComboBox_Status.Name = "ComboBox_Status";
            this.ComboBox_Status.Size = new System.Drawing.Size(100, 21);
            this.ComboBox_Status.TabIndex = 6;
            // 
            // Label_Error
            // 
            this.Label_Error.AutoSize = true;
            this.Label_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.Label_Error.Location = new System.Drawing.Point(33, 262);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(10, 13);
            this.Label_Error.TabIndex = 7;
            this.Label_Error.Text = " ";
            // 
            // DataGrid_Show
            // 
            this.DataGrid_Show.AllowUserToAddRows = false;
            this.DataGrid_Show.AllowUserToDeleteRows = false;
            this.DataGrid_Show.AllowUserToResizeRows = false;
            this.DataGrid_Show.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.WorkName,
            this.WorkStatus});
            this.DataGrid_Show.Location = new System.Drawing.Point(202, 12);
            this.DataGrid_Show.Name = "DataGrid_Show";
            this.DataGrid_Show.ReadOnly = true;
            this.DataGrid_Show.RowHeadersVisible = false;
            this.DataGrid_Show.Size = new System.Drawing.Size(421, 289);
            this.DataGrid_Show.TabIndex = 9;
            this.DataGrid_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Show_CellClick);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Number.DataPropertyName = "Key";
            this.Number.HeaderText = "Nº";
            this.Number.MinimumWidth = 50;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 50;
            // 
            // WorkName
            // 
            this.WorkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.WorkName.DataPropertyName = "WorkName";
            this.WorkName.HeaderText = "Nome da Obra";
            this.WorkName.MinimumWidth = 250;
            this.WorkName.Name = "WorkName";
            this.WorkName.ReadOnly = true;
            this.WorkName.Width = 250;
            // 
            // WorkStatus
            // 
            this.WorkStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WorkStatus.DataPropertyName = "Status";
            this.WorkStatus.HeaderText = "Status";
            this.WorkStatus.MinimumWidth = 40;
            this.WorkStatus.Name = "WorkStatus";
            this.WorkStatus.ReadOnly = true;
            // 
            // TextBox_Search
            // 
            this.TextBox_Search.Location = new System.Drawing.Point(96, 12);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Search.TabIndex = 10;
            this.TextBox_Search.TextChanged += new System.EventHandler(this.TextBox_Search_TextChanged);
            // 
            // LabelP_Search
            // 
            this.LabelP_Search.AutoSize = true;
            this.LabelP_Search.Location = new System.Drawing.Point(9, 15);
            this.LabelP_Search.Name = "LabelP_Search";
            this.LabelP_Search.Size = new System.Drawing.Size(85, 13);
            this.LabelP_Search.TabIndex = 11;
            this.LabelP_Search.Text = "Pesquisar nome:";
            // 
            // Form_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 313);
            this.Controls.Add(this.LabelP_Search);
            this.Controls.Add(this.TextBox_Search);
            this.Controls.Add(this.DataGrid_Show);
            this.Controls.Add(this.Label_Error);
            this.Controls.Add(this.ComboBox_Status);
            this.Controls.Add(this.LabelP_Status);
            this.Controls.Add(this.LabelP_WorkName);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.TextBox_WorkName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Informações de uma obra";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_WorkName;
        private System.Windows.Forms.Button Button_Confirm;
        private System.Windows.Forms.Label LabelP_WorkName;
        private System.Windows.Forms.Label LabelP_Status;
        private System.Windows.Forms.ComboBox ComboBox_Status;
        private System.Windows.Forms.Label Label_Error;
        private System.Windows.Forms.DataGridView DataGrid_Show;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkStatus;
        private System.Windows.Forms.TextBox TextBox_Search;
        private System.Windows.Forms.Label LabelP_Search;
    }
}