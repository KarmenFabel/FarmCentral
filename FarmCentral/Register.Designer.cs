
namespace FarmCentral
{
    partial class Register
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
            this.radioBtnEmp = new System.Windows.Forms.RadioButton();
            this.radioBtnFarm = new System.Windows.Forms.RadioButton();
            this.LblEmployee = new System.Windows.Forms.Label();
            this.LblFarmer = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUName = new System.Windows.Forms.TextBox();
            this.LblUName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBtnEmp
            // 
            this.radioBtnEmp.AutoSize = true;
            this.radioBtnEmp.Location = new System.Drawing.Point(506, 198);
            this.radioBtnEmp.Name = "radioBtnEmp";
            this.radioBtnEmp.Size = new System.Drawing.Size(14, 13);
            this.radioBtnEmp.TabIndex = 12;
            this.radioBtnEmp.TabStop = true;
            this.radioBtnEmp.UseVisualStyleBackColor = true;
            // 
            // radioBtnFarm
            // 
            this.radioBtnFarm.AutoSize = true;
            this.radioBtnFarm.Location = new System.Drawing.Point(352, 198);
            this.radioBtnFarm.Name = "radioBtnFarm";
            this.radioBtnFarm.Size = new System.Drawing.Size(14, 13);
            this.radioBtnFarm.TabIndex = 11;
            this.radioBtnFarm.TabStop = true;
            this.radioBtnFarm.UseVisualStyleBackColor = true;
            // 
            // LblEmployee
            // 
            this.LblEmployee.AutoSize = true;
            this.LblEmployee.Location = new System.Drawing.Point(430, 198);
            this.LblEmployee.Name = "LblEmployee";
            this.LblEmployee.Size = new System.Drawing.Size(53, 13);
            this.LblEmployee.TabIndex = 10;
            this.LblEmployee.Text = "Employee";
            // 
            // LblFarmer
            // 
            this.LblFarmer.AutoSize = true;
            this.LblFarmer.Location = new System.Drawing.Point(283, 198);
            this.LblFarmer.Name = "LblFarmer";
            this.LblFarmer.Size = new System.Drawing.Size(39, 13);
            this.LblFarmer.TabIndex = 9;
            this.LblFarmer.Text = "Farmer";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(381, 143);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(118, 20);
            this.txtBoxPassword.TabIndex = 16;
            // 
            // txtBoxUName
            // 
            this.txtBoxUName.Location = new System.Drawing.Point(381, 78);
            this.txtBoxUName.Name = "txtBoxUName";
            this.txtBoxUName.Size = new System.Drawing.Size(118, 20);
            this.txtBoxUName.TabIndex = 15;
            // 
            // LblUName
            // 
            this.LblUName.AutoSize = true;
            this.LblUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUName.Location = new System.Drawing.Point(283, 77);
            this.LblUName.Name = "LblUName";
            this.LblUName.Size = new System.Drawing.Size(77, 18);
            this.LblUName.TabIndex = 14;
            this.LblUName.Text = "Username";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(283, 142);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(75, 18);
            this.LblPassword.TabIndex = 13;
            this.LblPassword.Text = "Password";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(145, 9);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Padding = new System.Windows.Forms.Padding(175, 0, 0, 0);
            this.lblRegister.Size = new System.Drawing.Size(317, 37);
            this.lblRegister.TabIndex = 17;
            this.lblRegister.Text = "Register";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(283, 250);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(216, 23);
            this.btnLog.TabIndex = 18;
            this.btnLog.Text = "Back to Login Page";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUName);
            this.Controls.Add(this.LblUName);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.radioBtnEmp);
            this.Controls.Add(this.radioBtnFarm);
            this.Controls.Add(this.LblEmployee);
            this.Controls.Add(this.LblFarmer);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnEmp;
        private System.Windows.Forms.RadioButton radioBtnFarm;
        private System.Windows.Forms.Label LblEmployee;
        private System.Windows.Forms.Label LblFarmer;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUName;
        private System.Windows.Forms.Label LblUName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnLog;
    }
}