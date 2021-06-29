
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
            this.lvwCharacters = new System.Windows.Forms.ListView();
            this.lvwSelectedCharacter = new System.Windows.Forms.ListView();
            this.txtSelectedCharacterName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdSelectCharacter = new System.Windows.Forms.Button();
            this.txtSelectedCharacterRace = new System.Windows.Forms.TextBox();
            this.txtSelectedCharacterClass = new System.Windows.Forms.TextBox();
            this.txtSelectedCharacterGender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSelectedCharacterLevel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIntellect = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtAgility = new System.Windows.Forms.TextBox();
            this.txtStamina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVersatility = new System.Windows.Forms.TextBox();
            this.txtMastery = new System.Windows.Forms.TextBox();
            this.txtHaste = new System.Windows.Forms.TextBox();
            this.txtCrit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(482, 394);
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
            this.dgvCharacters.Location = new System.Drawing.Point(962, 22);
            this.dgvCharacters.Name = "dgvCharacters";
            this.dgvCharacters.Size = new System.Drawing.Size(534, 341);
            this.dgvCharacters.TabIndex = 1;
            // 
            // cmdDisplayAccountUId
            // 
            this.cmdDisplayAccountUId.Location = new System.Drawing.Point(386, 317);
            this.cmdDisplayAccountUId.Name = "cmdDisplayAccountUId";
            this.cmdDisplayAccountUId.Size = new System.Drawing.Size(171, 32);
            this.cmdDisplayAccountUId.TabIndex = 2;
            this.cmdDisplayAccountUId.Text = "Current Account UId";
            this.cmdDisplayAccountUId.UseVisualStyleBackColor = true;
            this.cmdDisplayAccountUId.Click += new System.EventHandler(this.cmdDisplayAccountUId_Click);
            // 
            // lvwCharacters
            // 
            this.lvwCharacters.HideSelection = false;
            this.lvwCharacters.Location = new System.Drawing.Point(22, 22);
            this.lvwCharacters.Name = "lvwCharacters";
            this.lvwCharacters.Size = new System.Drawing.Size(215, 341);
            this.lvwCharacters.TabIndex = 3;
            this.lvwCharacters.UseCompatibleStateImageBehavior = false;
            this.lvwCharacters.Click += new System.EventHandler(this.lvwCharacters_Click);
            // 
            // lvwSelectedCharacter
            // 
            this.lvwSelectedCharacter.HideSelection = false;
            this.lvwSelectedCharacter.Location = new System.Drawing.Point(569, 22);
            this.lvwSelectedCharacter.Name = "lvwSelectedCharacter";
            this.lvwSelectedCharacter.Size = new System.Drawing.Size(398, 341);
            this.lvwSelectedCharacter.TabIndex = 4;
            this.lvwSelectedCharacter.UseCompatibleStateImageBehavior = false;
            // 
            // txtSelectedCharacterName
            // 
            this.txtSelectedCharacterName.Location = new System.Drawing.Point(306, 23);
            this.txtSelectedCharacterName.Name = "txtSelectedCharacterName";
            this.txtSelectedCharacterName.Size = new System.Drawing.Size(165, 20);
            this.txtSelectedCharacterName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "PLAY THE GAME DICKHEAD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmdSelectCharacter
            // 
            this.cmdSelectCharacter.Location = new System.Drawing.Point(22, 376);
            this.cmdSelectCharacter.Name = "cmdSelectCharacter";
            this.cmdSelectCharacter.Size = new System.Drawing.Size(180, 43);
            this.cmdSelectCharacter.TabIndex = 7;
            this.cmdSelectCharacter.UseVisualStyleBackColor = true;
            this.cmdSelectCharacter.Visible = false;
            this.cmdSelectCharacter.Click += new System.EventHandler(this.cmdSelectCharacter_Click);
            // 
            // txtSelectedCharacterRace
            // 
            this.txtSelectedCharacterRace.Location = new System.Drawing.Point(306, 48);
            this.txtSelectedCharacterRace.Name = "txtSelectedCharacterRace";
            this.txtSelectedCharacterRace.Size = new System.Drawing.Size(165, 20);
            this.txtSelectedCharacterRace.TabIndex = 8;
            // 
            // txtSelectedCharacterClass
            // 
            this.txtSelectedCharacterClass.Location = new System.Drawing.Point(306, 74);
            this.txtSelectedCharacterClass.Name = "txtSelectedCharacterClass";
            this.txtSelectedCharacterClass.Size = new System.Drawing.Size(165, 20);
            this.txtSelectedCharacterClass.TabIndex = 9;
            // 
            // txtSelectedCharacterGender
            // 
            this.txtSelectedCharacterGender.Location = new System.Drawing.Point(306, 100);
            this.txtSelectedCharacterGender.Name = "txtSelectedCharacterGender";
            this.txtSelectedCharacterGender.Size = new System.Drawing.Size(165, 20);
            this.txtSelectedCharacterGender.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender";
            // 
            // txtSelectedCharacterLevel
            // 
            this.txtSelectedCharacterLevel.Location = new System.Drawing.Point(306, 126);
            this.txtSelectedCharacterLevel.Name = "txtSelectedCharacterLevel";
            this.txtSelectedCharacterLevel.Size = new System.Drawing.Size(165, 20);
            this.txtSelectedCharacterLevel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Level";
            // 
            // txtIntellect
            // 
            this.txtIntellect.Location = new System.Drawing.Point(306, 225);
            this.txtIntellect.Name = "txtIntellect";
            this.txtIntellect.Size = new System.Drawing.Size(51, 20);
            this.txtIntellect.TabIndex = 17;
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(306, 173);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(51, 20);
            this.txtStrength.TabIndex = 18;
            // 
            // txtAgility
            // 
            this.txtAgility.Location = new System.Drawing.Point(306, 199);
            this.txtAgility.Name = "txtAgility";
            this.txtAgility.Size = new System.Drawing.Size(51, 20);
            this.txtAgility.TabIndex = 19;
            // 
            // txtStamina
            // 
            this.txtStamina.Location = new System.Drawing.Point(306, 251);
            this.txtStamina.Name = "txtStamina";
            this.txtStamina.Size = new System.Drawing.Size(51, 20);
            this.txtStamina.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Strength";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Stamina";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Intellect";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Agility";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Versatility";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Mastery";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Haste";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(363, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Crit";
            // 
            // txtVersatility
            // 
            this.txtVersatility.Location = new System.Drawing.Point(420, 251);
            this.txtVersatility.Name = "txtVersatility";
            this.txtVersatility.Size = new System.Drawing.Size(51, 20);
            this.txtVersatility.TabIndex = 29;
            // 
            // txtMastery
            // 
            this.txtMastery.Location = new System.Drawing.Point(420, 225);
            this.txtMastery.Name = "txtMastery";
            this.txtMastery.Size = new System.Drawing.Size(51, 20);
            this.txtMastery.TabIndex = 30;
            // 
            // txtHaste
            // 
            this.txtHaste.Location = new System.Drawing.Point(420, 199);
            this.txtHaste.Name = "txtHaste";
            this.txtHaste.Size = new System.Drawing.Size(51, 20);
            this.txtHaste.TabIndex = 31;
            // 
            // txtCrit
            // 
            this.txtCrit.Location = new System.Drawing.Point(420, 173);
            this.txtCrit.Name = "txtCrit";
            this.txtCrit.Size = new System.Drawing.Size(51, 20);
            this.txtCrit.TabIndex = 32;
            // 
            // CharactersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 431);
            this.Controls.Add(this.txtCrit);
            this.Controls.Add(this.txtHaste);
            this.Controls.Add(this.txtMastery);
            this.Controls.Add(this.txtVersatility);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStamina);
            this.Controls.Add(this.txtAgility);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.txtIntellect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSelectedCharacterLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSelectedCharacterGender);
            this.Controls.Add(this.txtSelectedCharacterClass);
            this.Controls.Add(this.txtSelectedCharacterRace);
            this.Controls.Add(this.cmdSelectCharacter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSelectedCharacterName);
            this.Controls.Add(this.lvwSelectedCharacter);
            this.Controls.Add(this.lvwCharacters);
            this.Controls.Add(this.cmdDisplayAccountUId);
            this.Controls.Add(this.dgvCharacters);
            this.Controls.Add(this.cmdBack);
            this.Name = "CharactersForm";
            this.Text = "CharactersForm";
            this.Load += new System.EventHandler(this.CharacterList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.DataGridView dgvCharacters;
        private System.Windows.Forms.Button cmdDisplayAccountUId;
        private System.Windows.Forms.ListView lvwCharacters;
        private System.Windows.Forms.ListView lvwSelectedCharacter;
        private System.Windows.Forms.TextBox txtSelectedCharacterName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdSelectCharacter;
        private System.Windows.Forms.TextBox txtSelectedCharacterRace;
        private System.Windows.Forms.TextBox txtSelectedCharacterClass;
        private System.Windows.Forms.TextBox txtSelectedCharacterGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSelectedCharacterLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIntellect;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtAgility;
        private System.Windows.Forms.TextBox txtStamina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVersatility;
        private System.Windows.Forms.TextBox txtMastery;
        private System.Windows.Forms.TextBox txtHaste;
        private System.Windows.Forms.TextBox txtCrit;
    }
}