
namespace WoW.Forms
{
    partial class CreateCharacterForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblFaction = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.cboFaction = new System.Windows.Forms.ComboBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboRace = new System.Windows.Forms.ComboBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cmdCreateCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Character Name:";
            // 
            // lblFaction
            // 
            this.lblFaction.AutoSize = true;
            this.lblFaction.Location = new System.Drawing.Point(43, 93);
            this.lblFaction.Name = "lblFaction";
            this.lblFaction.Size = new System.Drawing.Size(84, 13);
            this.lblFaction.TabIndex = 1;
            this.lblFaction.Text = "Choose Faction:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(43, 134);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(84, 13);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Choose Gender:";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(43, 174);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(75, 13);
            this.lblRace.TabIndex = 3;
            this.lblRace.Text = "Choose Race:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(43, 214);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(74, 13);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Choose Class:";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(136, 49);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(286, 20);
            this.txtCharacterName.TabIndex = 5;
            // 
            // cmdReturn
            // 
            this.cmdReturn.Location = new System.Drawing.Point(279, 275);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.Size = new System.Drawing.Size(184, 54);
            this.cmdReturn.TabIndex = 8;
            this.cmdReturn.Text = "Return to Main Menu";
            this.cmdReturn.UseVisualStyleBackColor = true;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // cboFaction
            // 
            this.cboFaction.FormattingEnabled = true;
            this.cboFaction.Items.AddRange(new object[] {
            "Horde",
            "Alliance"});
            this.cboFaction.Location = new System.Drawing.Point(136, 90);
            this.cboFaction.Name = "cboFaction";
            this.cboFaction.Size = new System.Drawing.Size(286, 21);
            this.cboFaction.TabIndex = 11;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-Binary"});
            this.cboGender.Location = new System.Drawing.Point(136, 131);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(286, 21);
            this.cboGender.TabIndex = 12;
            // 
            // cboRace
            // 
            this.cboRace.FormattingEnabled = true;
            this.cboRace.Items.AddRange(new object[] {
            "Human",
            "Night Elf",
            "Dwarf",
            "Gnome",
            "Orc",
            "Troll",
            "Tauren",
            "Undead"});
            this.cboRace.Location = new System.Drawing.Point(136, 171);
            this.cboRace.Name = "cboRace";
            this.cboRace.Size = new System.Drawing.Size(286, 21);
            this.cboRace.TabIndex = 13;
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "Warrior",
            "Paladin",
            "Priest",
            "Mage",
            "Hunter",
            "Warlock",
            "Druid",
            "Shaman",
            "Rogue"});
            this.cboClass.Location = new System.Drawing.Point(136, 211);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(286, 21);
            this.cboClass.TabIndex = 14;
            // 
            // cmdCreateCharacter
            // 
            this.cmdCreateCharacter.Location = new System.Drawing.Point(46, 275);
            this.cmdCreateCharacter.Name = "cmdCreateCharacter";
            this.cmdCreateCharacter.Size = new System.Drawing.Size(184, 54);
            this.cmdCreateCharacter.TabIndex = 15;
            this.cmdCreateCharacter.Text = "Create Character";
            this.cmdCreateCharacter.UseVisualStyleBackColor = true;
            this.cmdCreateCharacter.Click += new System.EventHandler(this.cmdCreateCharacter_Click);
            // 
            // CreateCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 410);
            this.Controls.Add(this.cmdCreateCharacter);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.cboRace);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.cboFaction);
            this.Controls.Add(this.cmdReturn);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblFaction);
            this.Controls.Add(this.lblName);
            this.Name = "CreateCharacterForm";
            this.Text = "CreateCharacterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFaction;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Button cmdReturn;
        private System.Windows.Forms.ComboBox cboFaction;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboRace;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Button cmdCreateCharacter;
    }
}