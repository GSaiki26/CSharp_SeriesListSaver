namespace Anime_Lister {
    partial class Form_Success {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Success));
            this.Button_Ok = new System.Windows.Forms.Button();
            this.LabelP_Success = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Ok
            // 
            this.Button_Ok.Location = new System.Drawing.Point(81, 55);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(75, 23);
            this.Button_Ok.TabIndex = 0;
            this.Button_Ok.Text = "Ok";
            this.Button_Ok.UseVisualStyleBackColor = true;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // LabelP_Success
            // 
            this.LabelP_Success.AutoSize = true;
            this.LabelP_Success.Location = new System.Drawing.Point(55, 24);
            this.LabelP_Success.Name = "LabelP_Success";
            this.LabelP_Success.Size = new System.Drawing.Size(128, 13);
            this.LabelP_Success.TabIndex = 1;
            this.LabelP_Success.Text = "Sucesso ao editar a obra!";
            // 
            // Form_Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 90);
            this.Controls.Add(this.LabelP_Success);
            this.Controls.Add(this.Button_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Success";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucesso!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Ok;
        private System.Windows.Forms.Label LabelP_Success;
    }
}