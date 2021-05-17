
namespace WoW.Forms
{
    partial class RegisterForm
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
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.cmdTestAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(72, 58);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(100, 13);
            this.lblDisplayName.TabIndex = 0;
            this.lblDisplayName.Text = "Enter Display Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(72, 90);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Enter Password";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(72, 120);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(101, 13);
            this.lblEmailAddress.TabIndex = 2;
            this.lblEmailAddress.Text = "Enter Email Address";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(183, 55);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(260, 20);
            this.txtDisplayName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(183, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(260, 20);
            this.txtPassword.TabIndex = 4;
            
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(183, 117);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(260, 20);
            this.txtEmailAddress.TabIndex = 5;
            // 
            // cmdReturn
            // 
            this.cmdReturn.Location = new System.Drawing.Point(402, 202);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.Size = new System.Drawing.Size(119, 35);
            this.cmdReturn.TabIndex = 6;
            this.cmdReturn.Text = "Close";
            this.cmdReturn.UseVisualStyleBackColor = true;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // cmdRegister
            // 
            this.cmdRegister.Location = new System.Drawing.Point(183, 202);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(119, 35);
            this.cmdRegister.TabIndex = 7;
            this.cmdRegister.Text = "Register Account";
            this.cmdRegister.UseVisualStyleBackColor = true;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // cmdTestAll
            // 
            this.cmdTestAll.Location = new System.Drawing.Point(49, 203);
            this.cmdTestAll.Name = "cmdTestAll";
            this.cmdTestAll.Size = new System.Drawing.Size(92, 33);
            this.cmdTestAll.TabIndex = 8;
            this.cmdTestAll.Text = "Test Get All";
            this.cmdTestAll.UseVisualStyleBackColor = true;
            this.cmdTestAll.Click += new System.EventHandler(this.cmdTestAll_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 294);
            this.Controls.Add(this.cmdTestAll);
            this.Controls.Add(this.cmdRegister);
            this.Controls.Add(this.cmdReturn);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblDisplayName);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Button cmdReturn;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.Button cmdTestAll;
    }
}