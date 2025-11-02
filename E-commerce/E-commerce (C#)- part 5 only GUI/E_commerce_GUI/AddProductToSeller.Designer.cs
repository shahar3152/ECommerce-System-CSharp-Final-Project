namespace E_commerce
{
    partial class AddProductToSeller
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
            this.AddPTS = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ProductNL = new System.Windows.Forms.Label();
            this.ProductPL = new System.Windows.Forms.Label();
            this.CategoryL = new System.Windows.Forms.Label();
            this.IsSpL = new System.Windows.Forms.Label();
            this.YesRB = new System.Windows.Forms.RadioButton();
            this.NoRB = new System.Windows.Forms.RadioButton();
            this.PackPriceL = new System.Windows.Forms.Label();
            this.KidsRB = new System.Windows.Forms.RadioButton();
            this.ElectRB = new System.Windows.Forms.RadioButton();
            this.OfficeRB = new System.Windows.Forms.RadioButton();
            this.ClothingRB = new System.Windows.Forms.RadioButton();
            this.ProductNTB = new System.Windows.Forms.TextBox();
            this.ProductPN = new System.Windows.Forms.NumericUpDown();
            this.PackagePN = new System.Windows.Forms.NumericUpDown();
            this.CategoryGB = new System.Windows.Forms.GroupBox();
            this.IsSpecialGB = new System.Windows.Forms.GroupBox();
            this.SubmitB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackagePN)).BeginInit();
            this.CategoryGB.SuspendLayout();
            this.IsSpecialGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPTS
            // 
            this.AddPTS.AutoSize = true;
            this.AddPTS.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPTS.Location = new System.Drawing.Point(319, 9);
            this.AddPTS.Name = "AddPTS";
            this.AddPTS.Size = new System.Drawing.Size(869, 93);
            this.AddPTS.TabIndex = 0;
            this.AddPTS.Text = "Add Product To Seller";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(12, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(141, 47);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "Back";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.BackButton);
            // 
            // ProductNL
            // 
            this.ProductNL.AutoSize = true;
            this.ProductNL.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNL.Location = new System.Drawing.Point(169, 144);
            this.ProductNL.Name = "ProductNL";
            this.ProductNL.Size = new System.Drawing.Size(260, 40);
            this.ProductNL.TabIndex = 19;
            this.ProductNL.Text = "Product Name:";
            // 
            // ProductPL
            // 
            this.ProductPL.AutoSize = true;
            this.ProductPL.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPL.Location = new System.Drawing.Point(179, 205);
            this.ProductPL.Name = "ProductPL";
            this.ProductPL.Size = new System.Drawing.Size(250, 40);
            this.ProductPL.TabIndex = 20;
            this.ProductPL.Text = "Product Price:";
            // 
            // CategoryL
            // 
            this.CategoryL.AutoSize = true;
            this.CategoryL.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryL.Location = new System.Drawing.Point(251, 274);
            this.CategoryL.Name = "CategoryL";
            this.CategoryL.Size = new System.Drawing.Size(178, 40);
            this.CategoryL.TabIndex = 21;
            this.CategoryL.Text = "Category:";
            // 
            // IsSpL
            // 
            this.IsSpL.AutoSize = true;
            this.IsSpL.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsSpL.Location = new System.Drawing.Point(27, 346);
            this.IsSpL.Name = "IsSpL";
            this.IsSpL.Size = new System.Drawing.Size(402, 40);
            this.IsSpL.TabIndex = 22;
            this.IsSpL.Text = "Has special packaging?";
            // 
            // YesRB
            // 
            this.YesRB.AutoSize = true;
            this.YesRB.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesRB.Location = new System.Drawing.Point(7, 15);
            this.YesRB.Name = "YesRB";
            this.YesRB.Size = new System.Drawing.Size(97, 44);
            this.YesRB.TabIndex = 23;
            this.YesRB.TabStop = true;
            this.YesRB.Text = "Yes";
            this.YesRB.UseVisualStyleBackColor = true;
            this.YesRB.Click += new System.EventHandler(this.YesRadioButton);
            // 
            // NoRB
            // 
            this.NoRB.AutoSize = true;
            this.NoRB.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRB.Location = new System.Drawing.Point(148, 15);
            this.NoRB.Name = "NoRB";
            this.NoRB.Size = new System.Drawing.Size(84, 44);
            this.NoRB.TabIndex = 24;
            this.NoRB.TabStop = true;
            this.NoRB.Text = "No";
            this.NoRB.UseVisualStyleBackColor = true;
            this.NoRB.Click += new System.EventHandler(this.NoRadioButton);
            // 
            // PackPriceL
            // 
            this.PackPriceL.AutoSize = true;
            this.PackPriceL.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackPriceL.Location = new System.Drawing.Point(171, 406);
            this.PackPriceL.Name = "PackPriceL";
            this.PackPriceL.Size = new System.Drawing.Size(258, 40);
            this.PackPriceL.TabIndex = 25;
            this.PackPriceL.Text = "Package price:";
            // 
            // KidsRB
            // 
            this.KidsRB.AutoSize = true;
            this.KidsRB.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KidsRB.Location = new System.Drawing.Point(6, 19);
            this.KidsRB.Name = "KidsRB";
            this.KidsRB.Size = new System.Drawing.Size(112, 44);
            this.KidsRB.TabIndex = 26;
            this.KidsRB.TabStop = true;
            this.KidsRB.Text = "Kids";
            this.KidsRB.UseVisualStyleBackColor = true;
            this.KidsRB.Click += new System.EventHandler(this.KidsRadioButton);
            // 
            // ElectRB
            // 
            this.ElectRB.AutoSize = true;
            this.ElectRB.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElectRB.Location = new System.Drawing.Point(148, 19);
            this.ElectRB.Name = "ElectRB";
            this.ElectRB.Size = new System.Drawing.Size(221, 44);
            this.ElectRB.TabIndex = 27;
            this.ElectRB.TabStop = true;
            this.ElectRB.Text = "Electronics";
            this.ElectRB.UseVisualStyleBackColor = true;
            this.ElectRB.Click += new System.EventHandler(this.ElectronicsRadioButton);
            // 
            // OfficeRB
            // 
            this.OfficeRB.AutoSize = true;
            this.OfficeRB.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficeRB.Location = new System.Drawing.Point(390, 17);
            this.OfficeRB.Name = "OfficeRB";
            this.OfficeRB.Size = new System.Drawing.Size(133, 44);
            this.OfficeRB.TabIndex = 28;
            this.OfficeRB.TabStop = true;
            this.OfficeRB.Text = "Office";
            this.OfficeRB.UseVisualStyleBackColor = true;
            this.OfficeRB.CheckedChanged += new System.EventHandler(this.OfficeRB_CheckedChanged);
            this.OfficeRB.Click += new System.EventHandler(this.OfficeRadioButton);
            // 
            // ClothingRB
            // 
            this.ClothingRB.AutoSize = true;
            this.ClothingRB.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClothingRB.Location = new System.Drawing.Point(550, 17);
            this.ClothingRB.Name = "ClothingRB";
            this.ClothingRB.Size = new System.Drawing.Size(174, 44);
            this.ClothingRB.TabIndex = 29;
            this.ClothingRB.TabStop = true;
            this.ClothingRB.Text = "Clothing";
            this.ClothingRB.UseVisualStyleBackColor = true;
            this.ClothingRB.CheckedChanged += new System.EventHandler(this.ClothingRB_CheckedChanged);
            this.ClothingRB.Click += new System.EventHandler(this.ClothingRadioButton);
            // 
            // ProductNTB
            // 
            this.ProductNTB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNTB.Location = new System.Drawing.Point(468, 141);
            this.ProductNTB.Name = "ProductNTB";
            this.ProductNTB.Size = new System.Drawing.Size(696, 34);
            this.ProductNTB.TabIndex = 30;
            this.ProductNTB.Click += new System.EventHandler(this.ProductNameTextBox);
            this.ProductNTB.TextChanged += new System.EventHandler(this.ProductNameTextBox);
            // 
            // ProductPN
            // 
            this.ProductPN.DecimalPlaces = 2;
            this.ProductPN.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPN.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ProductPN.Location = new System.Drawing.Point(468, 203);
            this.ProductPN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ProductPN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ProductPN.Name = "ProductPN";
            this.ProductPN.Size = new System.Drawing.Size(104, 46);
            this.ProductPN.TabIndex = 31;
            this.ProductPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductPN.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ProductPN.ValueChanged += new System.EventHandler(this.ProductPN_ValueChanged);
            this.ProductPN.Click += new System.EventHandler(this.ProductPriceNumericUpDown);
            // 
            // PackagePN
            // 
            this.PackagePN.DecimalPlaces = 2;
            this.PackagePN.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackagePN.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PackagePN.Location = new System.Drawing.Point(468, 402);
            this.PackagePN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PackagePN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PackagePN.Name = "PackagePN";
            this.PackagePN.Size = new System.Drawing.Size(104, 46);
            this.PackagePN.TabIndex = 32;
            this.PackagePN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PackagePN.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PackagePN.Click += new System.EventHandler(this.PackagePriceNumericUpDown);
            // 
            // CategoryGB
            // 
            this.CategoryGB.BackColor = System.Drawing.Color.Transparent;
            this.CategoryGB.Controls.Add(this.ClothingRB);
            this.CategoryGB.Controls.Add(this.KidsRB);
            this.CategoryGB.Controls.Add(this.ElectRB);
            this.CategoryGB.Controls.Add(this.OfficeRB);
            this.CategoryGB.Location = new System.Drawing.Point(468, 255);
            this.CategoryGB.Name = "CategoryGB";
            this.CategoryGB.Size = new System.Drawing.Size(749, 76);
            this.CategoryGB.TabIndex = 33;
            this.CategoryGB.TabStop = false;
            this.CategoryGB.Enter += new System.EventHandler(this.CategoryGB_Enter);
            // 
            // IsSpecialGB
            // 
            this.IsSpecialGB.Controls.Add(this.NoRB);
            this.IsSpecialGB.Controls.Add(this.YesRB);
            this.IsSpecialGB.Location = new System.Drawing.Point(468, 331);
            this.IsSpecialGB.Name = "IsSpecialGB";
            this.IsSpecialGB.Size = new System.Drawing.Size(258, 65);
            this.IsSpecialGB.TabIndex = 34;
            this.IsSpecialGB.TabStop = false;
            this.IsSpecialGB.Enter += new System.EventHandler(this.IsSpecialGB_Enter);
            // 
            // SubmitB
            // 
            this.SubmitB.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitB.Location = new System.Drawing.Point(1158, 413);
            this.SubmitB.Name = "SubmitB";
            this.SubmitB.Size = new System.Drawing.Size(263, 47);
            this.SubmitB.TabIndex = 35;
            this.SubmitB.Text = "Submit";
            this.SubmitB.UseVisualStyleBackColor = true;
            this.SubmitB.Click += new System.EventHandler(this.SubmitButton);
            // 
            // AddProductToSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1433, 472);
            this.Controls.Add(this.SubmitB);
            this.Controls.Add(this.IsSpecialGB);
            this.Controls.Add(this.CategoryGB);
            this.Controls.Add(this.PackagePN);
            this.Controls.Add(this.ProductPN);
            this.Controls.Add(this.ProductNTB);
            this.Controls.Add(this.PackPriceL);
            this.Controls.Add(this.IsSpL);
            this.Controls.Add(this.CategoryL);
            this.Controls.Add(this.ProductPL);
            this.Controls.Add(this.ProductNL);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddPTS);
            this.Name = "AddProductToSeller";
            this.Text = "AddProductToSeller";
            ((System.ComponentModel.ISupportInitialize)(this.ProductPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackagePN)).EndInit();
            this.CategoryGB.ResumeLayout(false);
            this.CategoryGB.PerformLayout();
            this.IsSpecialGB.ResumeLayout(false);
            this.IsSpecialGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPTS;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ProductNL;
        private System.Windows.Forms.Label ProductPL;
        private System.Windows.Forms.Label CategoryL;
        private System.Windows.Forms.Label IsSpL;
        private System.Windows.Forms.RadioButton YesRB;
        private System.Windows.Forms.RadioButton NoRB;
        private System.Windows.Forms.Label PackPriceL;
        private System.Windows.Forms.RadioButton KidsRB;
        private System.Windows.Forms.RadioButton ElectRB;
        private System.Windows.Forms.RadioButton OfficeRB;
        private System.Windows.Forms.RadioButton ClothingRB;
        private System.Windows.Forms.TextBox ProductNTB;
        private System.Windows.Forms.NumericUpDown ProductPN;
        private System.Windows.Forms.NumericUpDown PackagePN;
        private System.Windows.Forms.GroupBox CategoryGB;
        private System.Windows.Forms.GroupBox IsSpecialGB;
        private System.Windows.Forms.Button SubmitB;
    }
}