
namespace FarmCentral
{
    partial class EmployeeHomePage
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
            this.lblHomePage = new System.Windows.Forms.Label();
            this.btnAddFarmer = new System.Windows.Forms.Button();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePage.Location = new System.Drawing.Point(0, 0);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(352, 37);
            this.lblHomePage.TabIndex = 0;
            this.lblHomePage.Text = "Employee Home Page";
            // 
            // btnAddFarmer
            // 
            this.btnAddFarmer.Location = new System.Drawing.Point(31, 69);
            this.btnAddFarmer.Name = "btnAddFarmer";
            this.btnAddFarmer.Size = new System.Drawing.Size(137, 25);
            this.btnAddFarmer.TabIndex = 1;
            this.btnAddFarmer.Text = "Add a New Farmer";
            this.btnAddFarmer.UseVisualStyleBackColor = true;
            this.btnAddFarmer.Click += new System.EventHandler(this.btnAddFarmer_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Location = new System.Drawing.Point(31, 120);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(137, 26);
            this.btnViewProducts.TabIndex = 2;
            this.btnViewProducts.Text = "View Farmer products";
            this.btnViewProducts.UseVisualStyleBackColor = true;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // EmployeeHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.btnAddFarmer);
            this.Controls.Add(this.lblHomePage);
            this.Name = "EmployeeHomePage";
            this.Text = "EmployeeHomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.Button btnAddFarmer;
        private System.Windows.Forms.Button btnViewProducts;
    }
}