namespace E_commerce
{
    partial class AddBuyer
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
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.StreetTB = new System.Windows.Forms.TextBox();
            this.CityTB = new System.Windows.Forms.TextBox();
            this.StateTB = new System.Windows.Forms.TextBox();
            this.HouseNumber = new System.Windows.Forms.NumericUpDown();
            this.Submit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HouseNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 93);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Buyer";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(49, 115);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(194, 40);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Street:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "House number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 39);
            this.label7.TabIndex = 8;
            this.label7.Text = "State:";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.Location = new System.Drawing.Point(312, 119);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(536, 38);
            this.UsernameTB.TabIndex = 9;
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTextBox);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(312, 173);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(536, 38);
            this.PasswordTB.TabIndex = 10;
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTextBox);
            // 
            // StreetTB
            // 
            this.StreetTB.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetTB.Location = new System.Drawing.Point(312, 277);
            this.StreetTB.Name = "StreetTB";
            this.StreetTB.Size = new System.Drawing.Size(536, 38);
            this.StreetTB.TabIndex = 11;
            this.StreetTB.TextChanged += new System.EventHandler(this.StreetTextBox);
            // 
            // CityTB
            // 
            this.CityTB.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityTB.Location = new System.Drawing.Point(312, 378);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(536, 38);
            this.CityTB.TabIndex = 13;
            this.CityTB.TextChanged += new System.EventHandler(this.CityTextBox);
            // 
            // StateTB
            // 
            this.StateTB.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateTB.Location = new System.Drawing.Point(312, 426);
            this.StateTB.Name = "StateTB";
            this.StateTB.Size = new System.Drawing.Size(536, 38);
            this.StateTB.TabIndex = 14;
            this.StateTB.TextChanged += new System.EventHandler(this.StateTextBox);
            // 
            // HouseNumber
            // 
            this.HouseNumber.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseNumber.Location = new System.Drawing.Point(312, 331);
            this.HouseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HouseNumber.Name = "HouseNumber";
            this.HouseNumber.Size = new System.Drawing.Size(86, 38);
            this.HouseNumber.TabIndex = 15;
            this.HouseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HouseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HouseNumber.ValueChanged += new System.EventHandler(this.HouseNumberNumericUpDown);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(585, 486);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(263, 47);
            this.Submit.TabIndex = 16;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.SubmitButton);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 47);
            this.button2.TabIndex = 17;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BackButton);
            // 
            // AddBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(926, 545);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.HouseNumber);
            this.Controls.Add(this.StateTB);
            this.Controls.Add(this.CityTB);
            this.Controls.Add(this.StreetTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Name = "AddBuyer";
            this.Text = "AddBuyer";
            ((System.ComponentModel.ISupportInitialize)(this.HouseNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox StreetTB;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.TextBox StateTB;
        private System.Windows.Forms.NumericUpDown HouseNumber;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button2;
    }
}