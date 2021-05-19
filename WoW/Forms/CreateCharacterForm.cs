using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoW.Core.Models;
using WoW.Core.Services;
using WoW.Core.Models.Enums;
using WoW.Factories;

namespace WoW.Forms
{
    public partial class CreateCharacterForm : Form
    {
        MainMenuForm mainMenuForm;
        
        private readonly ICharacterService _characterService;
        private readonly IAccountService _accountService;
        private readonly IRaceService _raceService;
        public CreateCharacterForm(MainMenuForm _mainMenuForm, ICharacterService characterService, IAccountService accountService, IRaceService raceService)
        {
            
            InitializeComponent();
            Shown += CreateCharacterForm_Shown;
            _raceService = raceService;
            mainMenuForm = _mainMenuForm;
            mainMenuForm.Hide();
        }

        private async void CreateCharacterForm_Shown(object sender, EventArgs e)
        {
            
            cboFaction.DataSource = Enum.GetValues(typeof(Faction));
            cboGender.DataSource = Enum.GetValues(typeof(Gender));
            var raceSource = await _raceService.PopulateComboBoxFromDatabase();
            cboRace.DataSource = raceSource;
            cboRace.DisplayMember = "Name";
            cboRace.ValueMember = "RaceId";
        }

        private void cmdReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenuForm.Show();
        }

        private void cmdCreateCharacter_Click(object sender, EventArgs e)
        {
            //string[] selectedCharacter = { cboFaction.SelectedItem.ToString(), cboGender.SelectedItem.ToString(), cboRace.SelectedItem.ToString(), cboClass.SelectedItem.ToString() };
            

            
            Character characterToCreate = new Character();
            characterToCreate.AccountUId = LoggedInToken.LoggedInId;
            characterToCreate.Name = txtCharacterName.Text;
            characterToCreate.Faction = (Faction)Enum.Parse(typeof(Faction), cboFaction.SelectedValue.ToString());
            characterToCreate.Gender = (Gender)Enum.Parse(typeof(Gender), cboGender.SelectedValue.ToString());
            characterToCreate.Race = cboRace.SelectedIndex;
            MessageBox.Show(cboRace.SelectedValue.ToString());
            
        }
    }
}
