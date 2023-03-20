namespace PasswordGenerator
{
    partial class Form1
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.PassLengthLabel = new System.Windows.Forms.Label();
            this.passwordLengthSlider = new System.Windows.Forms.TrackBar();
            this.CopyPassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openPass = new System.Windows.Forms.Button();
            this.clPwd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(229, 54);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(337, 93);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "label1";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassLengthLabel
            // 
            this.PassLengthLabel.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLengthLabel.Location = new System.Drawing.Point(229, 206);
            this.PassLengthLabel.Name = "PassLengthLabel";
            this.PassLengthLabel.Size = new System.Drawing.Size(337, 93);
            this.PassLengthLabel.TabIndex = 1;
            this.PassLengthLabel.Text = "Password Length: 5";
            this.PassLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLengthSlider
            // 
            this.passwordLengthSlider.Location = new System.Drawing.Point(246, 302);
            this.passwordLengthSlider.Name = "passwordLengthSlider";
            this.passwordLengthSlider.Size = new System.Drawing.Size(320, 45);
            this.passwordLengthSlider.TabIndex = 2;
            this.passwordLengthSlider.Scroll += new System.EventHandler(this.passwordLengthSlider_Scroll);
            // 
            // CopyPassword
            // 
            this.CopyPassword.BackColor = System.Drawing.Color.White;
            this.CopyPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.CopyPassword.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyPassword.Location = new System.Drawing.Point(41, 352);
            this.CopyPassword.Name = "CopyPassword";
            this.CopyPassword.Size = new System.Drawing.Size(168, 61);
            this.CopyPassword.TabIndex = 3;
            this.CopyPassword.Text = "Copy Password";
            this.CopyPassword.UseVisualStyleBackColor = false;
            this.CopyPassword.Click += new System.EventHandler(this.CopyPassword_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openPass
            // 
            this.openPass.BackColor = System.Drawing.Color.White;
            this.openPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.openPass.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPass.Location = new System.Drawing.Point(431, 353);
            this.openPass.Name = "openPass";
            this.openPass.Size = new System.Drawing.Size(168, 61);
            this.openPass.TabIndex = 5;
            this.openPass.Text = "Open Saved Passwords";
            this.openPass.UseVisualStyleBackColor = false;
            this.openPass.Click += new System.EventHandler(this.openPass_Click);
            // 
            // clPwd
            // 
            this.clPwd.BackColor = System.Drawing.Color.White;
            this.clPwd.Cursor = System.Windows.Forms.Cursors.Default;
            this.clPwd.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clPwd.Location = new System.Drawing.Point(620, 354);
            this.clPwd.Name = "clPwd";
            this.clPwd.Size = new System.Drawing.Size(168, 61);
            this.clPwd.TabIndex = 6;
            this.clPwd.Text = "Clear Saved Passwords";
            this.clPwd.UseVisualStyleBackColor = false;
            this.clPwd.Click += new System.EventHandler(this.clPwd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clPwd);
            this.Controls.Add(this.openPass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CopyPassword);
            this.Controls.Add(this.passwordLengthSlider);
            this.Controls.Add(this.PassLengthLabel);
            this.Controls.Add(this.passwordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "PasswordGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label PassLengthLabel;
        private System.Windows.Forms.TrackBar passwordLengthSlider;
        private System.Windows.Forms.Button CopyPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button openPass;
        private System.Windows.Forms.Button clPwd;
    }
}

