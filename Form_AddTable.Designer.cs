namespace Lister {
    partial class Form_AddTable {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddTable));
            this.LabelP_TableName = new System.Windows.Forms.Label();
            this.TextBox_TableName = new System.Windows.Forms.TextBox();
            this.Button_Confirm = new System.Windows.Forms.Button();
            this.Label_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelP_TableName
            // 
            this.LabelP_TableName.AutoSize = true;
            this.LabelP_TableName.Location = new System.Drawing.Point(12, 50);
            this.LabelP_TableName.Name = "LabelP_TableName";
            this.LabelP_TableName.Size = new System.Drawing.Size(38, 13);
            this.LabelP_TableName.TabIndex = 0;
            this.LabelP_TableName.Text = "Nome:";
            // 
            // TextBox_TableName
            // 
            this.TextBox_TableName.Location = new System.Drawing.Point(56, 47);
            this.TextBox_TableName.Name = "TextBox_TableName";
            this.TextBox_TableName.Size = new System.Drawing.Size(115, 20);
            this.TextBox_TableName.TabIndex = 1;
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.Location = new System.Drawing.Point(177, 46);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Size = new System.Drawing.Size(75, 20);
            this.Button_Confirm.TabIndex = 2;
            this.Button_Confirm.Text = "Confirmar";
            this.Button_Confirm.UseVisualStyleBackColor = true;
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // Label_Error
            // 
            this.Label_Error.AutoSize = true;
            this.Label_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.Label_Error.Location = new System.Drawing.Point(53, 31);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(0, 13);
            this.Label_Error.TabIndex = 3;
            // 
            // Form_AddTable
            // 
            this.ClientSize = new System.Drawing.Size(264, 121);
            this.Controls.Add(this.Label_Error);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.TextBox_TableName);
            this.Controls.Add(this.LabelP_TableName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_AddTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Label LabelP_Error;
        private System.Windows.Forms.Label LabelP_Name;
        private System.Windows.Forms.Label LabelP_TableName;
        private System.Windows.Forms.TextBox TextBox_TableName;
        private System.Windows.Forms.Button Button_Confirm;
        private System.Windows.Forms.Label Label_Error;
    }
}