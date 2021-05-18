using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoW.Core.Services;
using WoW.Factories;

namespace WoW.Forms
{
    public partial class CreateCharacterForm : Form
    {
        
        private readonly ICharacterService _characterService;
        private readonly IAccountService _accountService;
        public CreateCharacterForm(MainMenuForm MainMenuForm, ICharacterService characterService, IAccountService accountService)
        {
           
            InitializeComponent();
            
        }

        private void cmdReturn_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdCreateCharacter_Click(object sender, EventArgs e)
        {
            var message = string.Join(txtCharacterName.Text, cboFaction.Text.ToString(), cboGender.Text.ToString(), cboRace.Text.ToString(), cboClass.Text.ToString());
            MessageBox.Show(message);
        }
    }
}
