
namespace WoW.Forms
{
    partial class CharactersForm
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
            this.cmdBack = new System.Windows.Forms.Button();
            this.dgvCharacters = new System.Windows.Forms.DataGridView();
            this.cmdDisplayAccountUId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(699, 404);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(75, 23);
            this.cmdBack.TabIndex = 0;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // dgvCharacters
            // 
            this.dgvCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharacters.Location = new System.Drawing.Point(27, 41);
            this.dgvCharacters.Name = "dgvCharacters";
            this.dgvCharacters.Size = new System.Drawing.Size(747, 341);
            this.dgvCharacters.TabIndex = 1;
            // 
            // cmdDisplayAccountUId
            // 
            this.cmdDisplayAccountUId.Location = new System.Drawing.Point(35, 394);
            this.cmdDisplayAccountUId.Name = "cmdDisplayAccountUId";
            this.cmdDisplayAccountUId.Size = new System.Drawing.Size(171, 32);
            this.cmdDisplayAccountUId.TabIndex = 2;
            this.cmdDisplayAccountUId.Text = "Current Account UId";
            this.cmdDisplayAccountUId.UseVisualStyleBackColor = true;
            this.cmdDisplayAccountUId.Click += new System.EventHandler(this.cmdDisplayAccountUId_Click);
            // 
            // CharactersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdDisplayAccountUId);
            this.Controls.Add(this.dgvCharacters);
            this.Controls.Add(this.cmdBack);
            this.Name = "CharactersForm";
            this.Text = "CharactersForm";
            this.Load += new System.EventHandler(this.CharactersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.DataGridView dgvCharacters;
        private System.Windows.Forms.Button cmdDisplayAccountUId;
    }
}