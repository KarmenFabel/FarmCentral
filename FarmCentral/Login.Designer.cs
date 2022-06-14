
namespace FarmCentral
{
    partial class Login
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
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUName = new System.Windows.Forms.Label();
            this.txtBoxUName = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.BtnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.Location = new System.Drawing.Point(0, 0);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Padding = new System.Windows.Forms.Padding(175, 0, 0, 0);
            this.WelcomeLbl.Size = new System.Drawing.Size(581, 37);
            this.WelcomeLbl.TabIndex = 0;
            this.WelcomeLbl.Text = "Welcome to Farm Central";
            this.WelcomeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(258, 186);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(75, 18);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            // 
            // LblUName
            // 
            this.LblUName.AutoSize = true;
            this.LblUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUName.Location = new System.Drawing.Point(258, 121);
            this.LblUName.Name = "LblUName";
            this.LblUName.Size = new System.Drawing.Size(77, 18);
            this.LblUName.TabIndex = 2;
            this.LblUName.Text = "Username";
            // 
            // txtBoxUName
            // 
            this.txtBoxUName.Location = new System.Drawing.Point(356, 122);
            this.txtBoxUName.Name = "txtBoxUName";
            this.txtBoxUName.Size = new System.Drawing.Size(118, 20);
            this.txtBoxUName.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(356, 187);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(118, 20);
            this.txtBoxPassword.TabIndex = 4;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(261, 250);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 9;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(408, 250);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(75, 23);
            this.BtnReg.TabIndex = 10;
            this.BtnReg.Text = "Register";
            this.BtnReg.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 445);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUName);
            this.Controls.Add(this.LblUName);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.WelcomeLbl);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUName;
        private System.Windows.Forms.TextBox txtBoxUName;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button BtnReg;
    }
}

