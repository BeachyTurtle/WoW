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
        private readonly IClassService _classService;
        public CreateCharacterForm(MainMenuForm _mainMenuForm, ICharacterService characterService, IAccountService accountService, IRaceService raceService, IClassService classService)
        {
            
            InitializeComponent();
            InitializeComboBoxFaction();
            InitializeComboBoxRace();
            InitializeComboBoxClass();
            Shown += CreateCharacterForm_Shown;
            _raceService = raceService;
            _classService = classService;
            _characterService = characterService;
            mainMenuForm = _mainMenuForm;
            mainMenuForm.Hide();
        }

        private void CreateCharacterForm_Shown(object sender, EventArgs e)
        {
            cboFaction.DataSource = Enum.GetValues(typeof(Faction));
            cboGender.DataSource = Enum.GetValues(typeof(Gender));
            
        }

        private void InitializeComboBoxFaction()
        {
            cboFaction.SelectedIndexChanged += new EventHandler(ComboBoxFaction_SelectedIndexChanged);
        }
        private void InitializeComboBoxRace()
        {
            cboFaction.SelectedIndexChanged += new EventHandler(ComboBoxFaction_SelectedIndexChanged);
        }
        private void InitializeComboBoxClass()
        {
            cboRace.SelectedIndexChanged += new EventHandler(ComboBoxRace_SelectedIndexChanged);
        }

        private async void ComboBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            var classes = await _classService.GetAllClassRaceCombos();
            int raceId = Int32.Parse(cboRace.SelectedValue.ToString());
            var filteredClasses = classes.Where(x => x.RaceId == raceId)
                                        .Select(x => new { x.ClassName, x.ClassId });
            cboClass.DataSource = filteredClasses.ToList();
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassId";
        }

        private async void ComboBoxFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if(cboFaction.Text == "Horde")
            {
                var classSource = await _classService.PopulateClassComboBoxFromDatabaseForHorde();
                cboClass.DataSource = classSource;
                cboClass.DisplayMember = "Name";
                cboClass.ValueMember = "ClassId";
            }
            if(cboFaction.Text == "Alliance")
            {
                var classSource = await _classService.PopulateClassComboBoxFromDatabaseForAlliance();
                cboClass.DataSource = classSource;
                cboClass.DisplayMember = "Name";
                cboClass.ValueMember = "ClassId";
            }*/

            if (cboFaction.Text == "Horde")
            {
                var raceSource = await _raceService.PopulateRaceComboBoxFromDatabaseHorde();
                cboRace.DataSource = raceSource;
                cboRace.DisplayMember = "Name";
                cboRace.ValueMember = "RaceId";
            }
            if (cboFaction.Text == "Alliance")
            {
                var raceSource = await _raceService.PopulateRaceComboBoxFromDatabaseAlliance();
                cboRace.DataSource = raceSource;
                cboRace.DisplayMember = "Name";
                cboRace.ValueMember = "RaceId";
            }

        }

        private void cmdReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenuForm.Show();
        }

        private async void cmdCreateCharacter_Click(object sender, EventArgs e)
        {
            Character characterToCreate = new Character();
            characterToCreate.AccountUId = LoggedInToken.LoggedInId;
            characterToCreate.Name = txtCharacterName.Text;
            characterToCreate.Faction = (Faction)Enum.Parse(typeof(Faction), cboFaction.SelectedValue.ToString());
            characterToCreate.Gender = (Gender)Enum.Parse(typeof(Gender), cboGender.SelectedValue.ToString());
            characterToCreate.Race = (int)cboRace.SelectedValue;
            characterToCreate.Class = (int)cboClass.SelectedValue;
            var characterName = await _characterService.GetCharacterByName(txtCharacterName.Text);
            try
            {
                if (characterName != null)
                {
                    MessageBox.Show("That character already exists. Please choose another name.");
                }
                else
                { 
                    await _characterService.Upsert(characterToCreate);
                }

            }
            catch(NullReferenceException nullEx)
            {
                MessageBox.Show($"{nullEx.StackTrace}{nullEx.Message}");

            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}{ex.StackTrace}");
            }
            
        }
    }
}
