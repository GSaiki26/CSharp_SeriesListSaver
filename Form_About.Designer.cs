namespace Anime_Lister {
    partial class Form_About {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.labelP_Email = new System.Windows.Forms.Label();
            this.LabelP_Happyface = new System.Windows.Forms.Label();
            this.LabelP_Version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelP_Email
            // 
            this.labelP_Email.AutoSize = true;
            this.labelP_Email.Location = new System.Drawing.Point(12, 9);
            this.labelP_Email.Name = "labelP_Email";
            this.labelP_Email.Size = new System.Drawing.Size(139, 13);
            this.labelP_Email.TabIndex = 0;
            this.labelP_Email.Text = "Email: GSaiki26@gmail.com";
            // 
            // LabelP_Happyface
            // 
            this.LabelP_Happyface.AutoSize = true;
            this.LabelP_Happyface.Location = new System.Drawing.Point(12, 22);
            this.LabelP_Happyface.Name = "LabelP_Happyface";
            this.LabelP_Happyface.Size = new System.Drawing.Size(16, 13);
            this.LabelP_Happyface.TabIndex = 1;
            this.LabelP_Happyface.Text = ":))";
            // 
            // LabelP_Version
            // 
            this.LabelP_Version.AutoSize = true;
            this.LabelP_Version.Location = new System.Drawing.Point(12, 35);
            this.LabelP_Version.Name = "LabelP_Version";
            this.LabelP_Version.Size = new System.Drawing.Size(130, 13);
            this.LabelP_Version.TabIndex = 2;
            this.LabelP_Version.Text = "Versão do programa: V1.6";
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 76);
            this.Controls.Add(this.LabelP_Version);
            this.Controls.Add(this.LabelP_Happyface);
            this.Controls.Add(this.labelP_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre :)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelP_Email;
        private System.Windows.Forms.Label LabelP_Happyface;
        private System.Windows.Forms.Label LabelP_Version;
    }
}