namespace E_commerce
{
    partial class AddProductToCart
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
            this.AddPTC = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ProductLRTB = new System.Windows.Forms.RichTextBox();
            this.Username = new System.Windows.Forms.Label();
            this.ProductNTB = new System.Windows.Forms.TextBox();
            this.SearchB = new System.Windows.Forms.Button();
            this.ProductIdL = new System.Windows.Forms.Label();
            this.ProductIdN = new System.Windows.Forms.NumericUpDown();
            this.SubmitB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductIdN)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPTC
            // 
            this.AddPTC.AutoSize = true;
            this.AddPTC.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPTC.Location = new System.Drawing.Point(281, 9);
            this.AddPTC.Name = "AddPTC";
            this.AddPTC.Size = new System.Drawing.Size(813, 93);
            this.AddPTC.TabIndex = 1;
            this.AddPTC.Text = "Add Product To Cart";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(118, 58);
            this.BackButton.TabIndex = 23;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.ExitButton);
            // 
            // ProductLRTB
            // 
            this.ProductLRTB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLRTB.Location = new System.Drawing.Point(69, 212);
            this.ProductLRTB.Name = "ProductLRTB";
            this.ProductLRTB.Size = new System.Drawing.Size(1120, 181);
            this.ProductLRTB.TabIndex = 24;
            this.ProductLRTB.Text = "";
            this.ProductLRTB.Click += new System.EventHandler(this.ProductListRichTextBox);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(62, 142);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(299, 40);
            this.Username.TabIndex = 25;
            this.Username.Text = "Name of product:";
            // 
            // ProductNTB
            // 
            this.ProductNTB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNTB.Location = new System.Drawing.Point(380, 142);
            this.ProductNTB.Name = "ProductNTB";
            this.ProductNTB.Size = new System.Drawing.Size(591, 34);
            this.ProductNTB.TabIndex = 26;
            this.ProductNTB.Click += new System.EventHandler(this.ProductNameTextBox);
            this.ProductNTB.TextChanged += new System.EventHandler(this.ProductNTB_TextChanged);
            // 
            // SearchB
            // 
            this.SearchB.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchB.Location = new System.Drawing.Point(1015, 142);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(174, 46);
            this.SearchB.TabIndex = 27;
            this.SearchB.Text = "Search";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.SearchButton);
            // 
            // ProductIdL
            // 
            this.ProductIdL.AutoSize = true;
            this.ProductIdL.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdL.Location = new System.Drawing.Point(62, 418);
            this.ProductIdL.Name = "ProductIdL";
            this.ProductIdL.Size = new System.Drawing.Size(403, 40);
            this.ProductIdL.TabIndex = 28;
            this.ProductIdL.Text = "Please enter product id:";
            // 
            // ProductIdN
            // 
            this.ProductIdN.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdN.Location = new System.Drawing.Point(492, 412);
            this.ProductIdN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProductIdN.Name = "ProductIdN";
            this.ProductIdN.Size = new System.Drawing.Size(104, 46);
            this.ProductIdN.TabIndex = 29;
            this.ProductIdN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductIdN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProductIdN.ValueChanged += new System.EventHandler(this.ProductIdN_ValueChanged);
            this.ProductIdN.Click += new System.EventHandler(this.ProductIdNumericUpDown);
            // 
            // SubmitB
            // 
            this.SubmitB.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitB.Location = new System.Drawing.Point(971, 469);
            this.SubmitB.Name = "SubmitB";
            this.SubmitB.Size = new System.Drawing.Size(263, 47);
            this.SubmitB.TabIndex = 33;
            this.SubmitB.Text = "Submit";
            this.SubmitB.UseVisualStyleBackColor = true;
            this.SubmitB.Click += new System.EventHandler(this.SubmitButton);
            // 
            // AddProductToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1246, 528);
            this.Controls.Add(this.SubmitB);
            this.Controls.Add(this.ProductIdN);
            this.Controls.Add(this.ProductIdL);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.ProductNTB);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.ProductLRTB);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddPTC);
            this.Name = "AddProductToCart";
            this.Text = "AddProductToCart";
            ((System.ComponentModel.ISupportInitialize)(this.ProductIdN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPTC;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.RichTextBox ProductLRTB;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox ProductNTB;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Label ProductIdL;
        private System.Windows.Forms.NumericUpDown ProductIdN;
        private System.Windows.Forms.Button SubmitB;
    }
}