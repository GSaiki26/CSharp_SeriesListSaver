namespace Lister {
    partial class Form_RemoveTable {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RemoveTable));
            this.ComboBox_Tables = new System.Windows.Forms.ComboBox();
            this.Button_Confirm = new System.Windows.Forms.Button();
            this.LabelP_Table = new System.Windows.Forms.Label();
            this.Label_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBox_Tables
            // 
            this.ComboBox_Tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Tables.FormattingEnabled = true;
            this.ComboBox_Tables.Location = new System.Drawing.Point(80, 54);
            this.ComboBox_Tables.Name = "ComboBox_Tables";
            this.ComboBox_Tables.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Tables.TabIndex = 0;
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.Location = new System.Drawing.Point(207, 52);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Button_Confirm.TabIndex = 1;
            this.Button_Confirm.Text = "Confirmar";
            this.Button_Confirm.UseVisualStyleBackColor = true;
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // LabelP_Table
            // 
            this.LabelP_Table.AutoSize = true;
            this.LabelP_Table.Location = new System.Drawing.Point(31, 57);
            this.LabelP_Table.Name = "LabelP_Table";
            this.LabelP_Table.Size = new System.Drawing.Size(32, 13);
            this.LabelP_Table.TabIndex = 2;
            this.LabelP_Table.Text = "Lista:";
            // 
            // Label_Error
            // 
            this.Label_Error.AutoSize = true;
            this.Label_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.Label_Error.Location = new System.Drawing.Point(52, 36);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(0, 13);
            this.Label_Error.TabIndex = 3;
            // 
            // Form_RemoveTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 122);
            this.Controls.Add(this.Label_Error);
            this.Controls.Add(this.LabelP_Table);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.ComboBox_Tables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_RemoveTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remover lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_Tables;
        private System.Windows.Forms.Button Button_Confirm;
        private System.Windows.Forms.Label LabelP_Table;
        private System.Windows.Forms.Label Label_Error;
    }
}