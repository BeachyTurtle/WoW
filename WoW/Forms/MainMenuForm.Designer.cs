
namespace WoW.Forms
{
    partial class MainMenuForm
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
            this.cmdCreateCharacter = new System.Windows.Forms.Button();
            this.cmdSelectCharacter = new System.Windows.Forms.Button();
            this.cmdLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCreateCharacter
            // 
            this.cmdCreateCharacter.Location = new System.Drawing.Point(185, 126);
            this.cmdCreateCharacter.Name = "cmdCreateCharacter";
            this.cmdCreateCharacter.Size = new System.Drawing.Size(177, 45);
            this.cmdCreateCharacter.TabIndex = 0;
            this.cmdCreateCharacter.Text = "Create New Character";
            this.cmdCreateCharacter.UseVisualStyleBackColor = true;
            this.cmdCreateCharacter.Click += new System.EventHandler(this.cmdCreateCharacter_Click);
            // 
            // cmdSelectCharacter
            // 
            this.cmdSelectCharacter.Location = new System.Drawing.Point(185, 191);
            this.cmdSelectCharacter.Name = "cmdSelectCharacter";
            this.cmdSelectCharacter.Size = new System.Drawing.Size(177, 45);
            this.cmdSelectCharacter.TabIndex = 1;
            this.cmdSelectCharacter.Text = "Select Character";
            this.cmdSelectCharacter.UseVisualStyleBackColor = true;
            this.cmdSelectCharacter.Click += new System.EventHandler(this.cmdSelectCharacter_Click);
            // 
            // cmdLogout
            // 
            this.cmdLogout.Location = new System.Drawing.Point(624, 374);
            this.cmdLogout.Name = "cmdLogout";
            this.cmdLogout.Size = new System.Drawing.Size(153, 43);
            this.cmdLogout.TabIndex = 2;
            this.cmdLogout.Text = "Logout";
            this.cmdLogout.UseVisualStyleBackColor = true;
            this.cmdLogout.Click += new System.EventHandler(this.cmdLogout_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 481);
            this.Controls.Add(this.cmdLogout);
            this.Controls.Add(this.cmdSelectCharacter);
            this.Controls.Add(this.cmdCreateCharacter);
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCreateCharacter;
        private System.Windows.Forms.Button cmdSelectCharacter;
        private System.Windows.Forms.Button cmdLogout;
    }
}