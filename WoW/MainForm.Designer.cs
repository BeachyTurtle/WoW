
namespace WoW
{
    partial class MainForm
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
            this.cmdSeeCharacters = new System.Windows.Forms.Button();
            this.cmdBegin = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSeeCharacters
            // 
            this.cmdSeeCharacters.Location = new System.Drawing.Point(316, 136);
            this.cmdSeeCharacters.Name = "cmdSeeCharacters";
            this.cmdSeeCharacters.Size = new System.Drawing.Size(121, 51);
            this.cmdSeeCharacters.TabIndex = 0;
            this.cmdSeeCharacters.Text = "See Characters";
            this.cmdSeeCharacters.UseVisualStyleBackColor = true;
            this.cmdSeeCharacters.Click += new System.EventHandler(this.cmdSeeCharacters_Click);
            // 
            // cmdBegin
            // 
            this.cmdBegin.Location = new System.Drawing.Point(316, 212);
            this.cmdBegin.Name = "cmdBegin";
            this.cmdBegin.Size = new System.Drawing.Size(121, 51);
            this.cmdBegin.TabIndex = 1;
            this.cmdBegin.Text = "Begin...";
            this.cmdBegin.UseVisualStyleBackColor = true;
            this.cmdBegin.Click += new System.EventHandler(this.cmdBegin_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(316, 295);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(121, 51);
            this.cmdExit.TabIndex = 2;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdBegin);
            this.Controls.Add(this.cmdSeeCharacters);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSeeCharacters;
        private System.Windows.Forms.Button cmdBegin;
        private System.Windows.Forms.Button cmdExit;
    }
}