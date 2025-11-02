namespace E_commerce
{
    partial class LogIn
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
            this.UserLogIn = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.BackB = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLogIn
            // 
            this.UserLogIn.AutoSize = true;
            this.UserLogIn.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogIn.Location = new System.Drawing.Point(362, 9);
            this.UserLogIn.Name = "UserLogIn";
            this.UserLogIn.Size = new System.Drawing.Size(258, 93);
            this.UserLogIn.TabIndex = 0;
            this.UserLogIn.Text = "LogIn";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(378, 221);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(536, 34);
            this.PasswordTB.TabIndex = 14;
            this.PasswordTB.Click += new System.EventHandler(this.PasswordTextBox);
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTextBox);
            // 
            // UsernameTB
            // 
            this.UsernameTB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.Location = new System.Drawing.Point(378, 162);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(536, 34);
            this.UsernameTB.TabIndex = 13;
            this.UsernameTB.Click += new System.EventHandler(this.UsernameTextBox);
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(115, 163);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(194, 40);
            this.Username.TabIndex = 11;
            this.Username.Text = "Username:";
            // 
            // BackB
            // 
            this.BackB.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackB.Location = new System.Drawing.Point(12, 12);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(118, 58);
            this.BackB.TabIndex = 22;
            this.BackB.Text = "Back";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Click += new System.EventHandler(this.ExitButton);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(651, 303);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(263, 47);
            this.Submit.TabIndex = 33;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.SubmitButton);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 362);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.BackB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.UserLogIn);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLogIn;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.Button Submit;
    }
}