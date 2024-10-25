namespace PasswordGeneratorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtPasswordOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            
            // btnGeneratePassword
            this.btnGeneratePassword.Location = new System.Drawing.Point(90, 30);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(150, 30);
            this.btnGeneratePassword.TabIndex = 0;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);

            // txtPasswordOutput
            this.txtPasswordOutput.Location = new System.Drawing.Point(40, 80);
            this.txtPasswordOutput.Multiline = true;
            this.txtPasswordOutput.Name = "txtPasswordOutput";
            this.txtPasswordOutput.ReadOnly = true;
            this.txtPasswordOutput.Size = new System.Drawing.Size(250, 30);
            this.txtPasswordOutput.TabIndex = 1;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 150);
            this.Controls.Add(this.txtPasswordOutput);
            this.Controls.Add(this.btnGeneratePassword);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.TextBox txtPasswordOutput;
    }
}
