
namespace FarmCentral.Farmer
{
    partial class FarmerHome
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
            this.lblFHome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAddNew = new System.Windows.Forms.Label();
            this.txtboxAddProduct = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFHome
            // 
            this.lblFHome.AutoSize = true;
            this.lblFHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFHome.Location = new System.Drawing.Point(239, 9);
            this.lblFHome.Name = "lblFHome";
            this.lblFHome.Size = new System.Drawing.Size(314, 37);
            this.lblFHome.TabIndex = 0;
            this.lblFHome.Text = "Farmer Home Page";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblAddNew
            // 
            this.lblAddNew.AutoSize = true;
            this.lblAddNew.Location = new System.Drawing.Point(379, 93);
            this.lblAddNew.Name = "lblAddNew";
            this.lblAddNew.Size = new System.Drawing.Size(88, 13);
            this.lblAddNew.TabIndex = 2;
            this.lblAddNew.Text = "Add new product";
            // 
            // txtboxAddProduct
            // 
            this.txtboxAddProduct.Location = new System.Drawing.Point(483, 93);
            this.txtboxAddProduct.Name = "txtboxAddProduct";
            this.txtboxAddProduct.Size = new System.Drawing.Size(100, 20);
            this.txtboxAddProduct.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(483, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // FarmerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxAddProduct);
            this.Controls.Add(this.lblAddNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFHome);
            this.Name = "FarmerHome";
            this.Text = "FarmerHome";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAddNew;
        private System.Windows.Forms.TextBox txtboxAddProduct;
        private System.Windows.Forms.Button btnAdd;
    }
}