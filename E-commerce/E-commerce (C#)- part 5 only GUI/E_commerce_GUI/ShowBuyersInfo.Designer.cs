namespace E_commerce
{
    partial class ShowBuyersInfo
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
            this.Exit = new System.Windows.Forms.Button();
            this.BuyersRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 93);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buyers Information";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(12, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 58);
            this.Exit.TabIndex = 22;
            this.Exit.Text = "Back";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.ExitButton);
            // 
            // BuyersRTB
            // 
            this.BuyersRTB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyersRTB.Location = new System.Drawing.Point(50, 118);
            this.BuyersRTB.Name = "BuyersRTB";
            this.BuyersRTB.Size = new System.Drawing.Size(1177, 349);
            this.BuyersRTB.TabIndex = 26;
            this.BuyersRTB.Text = "";
            this.BuyersRTB.Click += new System.EventHandler(this.BuyersInfoRTB);
            this.BuyersRTB.TextChanged += new System.EventHandler(this.BuyersInfoRTB);
            // 
            // ShowBuyersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1274, 510);
            this.Controls.Add(this.BuyersRTB);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Name = "ShowBuyersInfo";
            this.Text = "ShowBuyersInfo";
            this.Load += new System.EventHandler(this.ShowBuyersInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RichTextBox BuyersRTB;
    }
}