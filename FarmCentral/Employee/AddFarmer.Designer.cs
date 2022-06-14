
namespace FarmCentral
{
    partial class AddFarmer
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
            this.lblAddFarmer = new System.Windows.Forms.Label();
            this.lblFarmName = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxFrName = new System.Windows.Forms.TextBox();
            this.txtBoxFarmN = new System.Windows.Forms.TextBox();
            this.txtBoxFrSurname = new System.Windows.Forms.TextBox();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.listBoxSelectedProducts = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnAddFarm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddFarmer
            // 
            this.lblAddFarmer.AutoSize = true;
            this.lblAddFarmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFarmer.Location = new System.Drawing.Point(247, 18);
            this.lblAddFarmer.Name = "lblAddFarmer";
            this.lblAddFarmer.Size = new System.Drawing.Size(298, 37);
            this.lblAddFarmer.TabIndex = 0;
            this.lblAddFarmer.Text = "Add a new Farmer";
            // 
            // lblFarmName
            // 
            this.lblFarmName.AutoSize = true;
            this.lblFarmName.Location = new System.Drawing.Point(118, 183);
            this.lblFarmName.Name = "lblFarmName";
            this.lblFarmName.Size = new System.Drawing.Size(61, 13);
            this.lblFarmName.TabIndex = 5;
            this.lblFarmName.Text = "Farm Name";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Location = new System.Drawing.Point(95, 130);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(84, 13);
            this.lblsurname.TabIndex = 6;
            this.lblsurname.Text = "Farmer Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(109, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Farmer Name";
            // 
            // txtBoxFrName
            // 
            this.txtBoxFrName.Location = new System.Drawing.Point(206, 81);
            this.txtBoxFrName.Name = "txtBoxFrName";
            this.txtBoxFrName.Size = new System.Drawing.Size(121, 20);
            this.txtBoxFrName.TabIndex = 8;
            // 
            // txtBoxFarmN
            // 
            this.txtBoxFarmN.Location = new System.Drawing.Point(206, 180);
            this.txtBoxFarmN.Name = "txtBoxFarmN";
            this.txtBoxFarmN.Size = new System.Drawing.Size(121, 20);
            this.txtBoxFarmN.TabIndex = 9;
            // 
            // txtBoxFrSurname
            // 
            this.txtBoxFrSurname.Location = new System.Drawing.Point(206, 130);
            this.txtBoxFrSurname.Name = "txtBoxFrSurname";
            this.txtBoxFrSurname.Size = new System.Drawing.Size(121, 20);
            this.txtBoxFrSurname.TabIndex = 10;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(206, 229);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProducts.TabIndex = 11;
            // 
            // listBoxSelectedProducts
            // 
            this.listBoxSelectedProducts.FormattingEnabled = true;
            this.listBoxSelectedProducts.Location = new System.Drawing.Point(372, 81);
            this.listBoxSelectedProducts.Name = "listBoxSelectedProducts";
            this.listBoxSelectedProducts.Size = new System.Drawing.Size(299, 238);
            this.listBoxSelectedProducts.TabIndex = 12;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(104, 237);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(75, 13);
            this.lblProducts.TabIndex = 13;
            this.lblProducts.Text = "Farm Products";
            // 
            // btnAddFarm
            // 
            this.btnAddFarm.Location = new System.Drawing.Point(107, 327);
            this.btnAddFarm.Name = "btnAddFarm";
            this.btnAddFarm.Size = new System.Drawing.Size(75, 23);
            this.btnAddFarm.TabIndex = 14;
            this.btnAddFarm.Text = "Add Farmer";
            this.btnAddFarm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(252, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddFarmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddFarm);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.listBoxSelectedProducts);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.txtBoxFrSurname);
            this.Controls.Add(this.txtBoxFarmN);
            this.Controls.Add(this.txtBoxFrName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.lblFarmName);
            this.Controls.Add(this.lblAddFarmer);
            this.Name = "AddFarmer";
            this.Text = "AddFarmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddFarmer;
        private System.Windows.Forms.Label lblFarmName;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxFrName;
        private System.Windows.Forms.TextBox txtBoxFarmN;
        private System.Windows.Forms.TextBox txtBoxFrSurname;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.ListBox listBoxSelectedProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnAddFarm;
        private System.Windows.Forms.Button btnCancel;
    }
}