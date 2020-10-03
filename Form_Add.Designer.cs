namespace Lister {
    partial class Form_Add {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add));
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.ComboBox_Status = new System.Windows.Forms.ComboBox();
            this.LabelP_Error = new System.Windows.Forms.Label();
            this.LabelP_Nome = new System.Windows.Forms.Label();
            this.LabelP_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(58, 36);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(194, 20);
            this.TextBox_Name.TabIndex = 0;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(190, 62);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(62, 21);
            this.Button_Add.TabIndex = 1;
            this.Button_Add.Text = "Adicionar";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // ComboBox_Status
            // 
            this.ComboBox_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Status.FormattingEnabled = true;
            this.ComboBox_Status.Location = new System.Drawing.Point(95, 63);
            this.ComboBox_Status.Name = "ComboBox_Status";
            this.ComboBox_Status.Size = new System.Drawing.Size(89, 21);
            this.ComboBox_Status.TabIndex = 7;
            // 
            // LabelP_Error
            // 
            this.LabelP_Error.AutoSize = true;
            this.LabelP_Error.Location = new System.Drawing.Point(48, 20);
            this.LabelP_Error.Name = "LabelP_Error";
            this.LabelP_Error.Size = new System.Drawing.Size(204, 13);
            this.LabelP_Error.TabIndex = 8;
            this.LabelP_Error.Text = "Por favor, preencha o nome corretamente";
            this.LabelP_Error.Visible = false;
            // 
            // LabelP_Nome
            // 
            this.LabelP_Nome.AutoSize = true;
            this.LabelP_Nome.Location = new System.Drawing.Point(14, 39);
            this.LabelP_Nome.Name = "LabelP_Nome";
            this.LabelP_Nome.Size = new System.Drawing.Size(38, 13);
            this.LabelP_Nome.TabIndex = 9;
            this.LabelP_Nome.Text = "Nome:";
            // 
            // LabelP_Status
            // 
            this.LabelP_Status.AutoSize = true;
            this.LabelP_Status.Location = new System.Drawing.Point(49, 66);
            this.LabelP_Status.Name = "LabelP_Status";
            this.LabelP_Status.Size = new System.Drawing.Size(40, 13);
            this.LabelP_Status.TabIndex = 10;
            this.LabelP_Status.Text = "Status:";
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 121);
            this.Controls.Add(this.LabelP_Status);
            this.Controls.Add(this.LabelP_Nome);
            this.Controls.Add(this.LabelP_Error);
            this.Controls.Add(this.ComboBox_Status);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.TextBox_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar obra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.ComboBox ComboBox_Status;
        private System.Windows.Forms.Label LabelP_Error;
        private System.Windows.Forms.Label LabelP_Nome;
        private System.Windows.Forms.Label LabelP_Status;
    }
}