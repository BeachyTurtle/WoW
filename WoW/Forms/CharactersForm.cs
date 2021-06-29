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
using System.Threading;
using WoW.Core.Services;
using WoW.Factories;
using System.Collections;

namespace WoW.Forms
{
    public partial class CharactersForm : Form
    {

        MainMenuForm MainMenuForm;
        private readonly ICharacterService _characterService;
        public CharactersForm(ICharacterService characterService, CredentialsForm CredentialsForm, MainMenuForm mainMenuForm)
        {
            MainMenuForm = mainMenuForm;
            MainMenuForm.Hide();
            _characterService = characterService;
            InitializeComponent();
            Load += new EventHandler(CharactersForm_Load);

        }



        private void CharactersForm_Load(object sender, EventArgs e)
        {
            try
            {
                //await CreateAllCharactersDataGrid();
                PopulateListViewFromSelectedName();
            }
            catch (NullReferenceException nullEx)
            {
                MessageBox.Show($"{nullEx.StackTrace}{nullEx.Message}");
            }

        }

        private async void CharacterList_Load(object sender, EventArgs e)
        {
            try
            {
                var characters = await _characterService.GetCharacterByAccountUid(LoggedInToken.LoggedInId);
                lvwCharacters.View = View.Details;
                lvwCharacters.Columns.Add("Name");

                foreach (var character in characters)
                {
                    lvwCharacters.Items.Add(new ListViewItem(Text = character.Name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{ex.StackTrace}");
            }
        }

        private async Task CreateAllCharactersDataGrid()
        {
            // Get all characters from the CharacterService List method
            // Set data source of form datagrid to the characters object

            var characters = await _characterService.GetCharacterByAccountUid(LoggedInToken.LoggedInId);
            dgvCharacters.DataSource = characters;


        }

        private void PopulateListViewFromSelectedName()
        {
            lvwSelectedCharacter.View = View.Details;
            lvwSelectedCharacter.Columns.Add("Name");
            lvwSelectedCharacter.Columns.Add("Class");
            lvwSelectedCharacter.Columns.Add("Race");
            lvwSelectedCharacter.Columns.Add("Gender");
            lvwSelectedCharacter.Columns.Add("Level");
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm.Show();
        }

        private void cmdDisplayAccountUId_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LoggedInToken.LoggedInId.ToString());
        }



        private async void lvwCharacters_Click(object sender, EventArgs e)
        {
            string text = lvwCharacters.SelectedItems[0].Text;
            var characters = await _characterService.GetCharacterByAccountUid(LoggedInToken.LoggedInId);
            var selectedCharacter = characters.Select(x => new CharacterViewModel
            {
                Name = x.Name,
                Class = x.Class,
                RaceName = x.RaceName,
                Gender = x.Gender,
                Level = x.Level,
                Statistics = x.Statistics
                
            }).Where(t => t.Name == text).FirstOrDefault();

            txtSelectedCharacterName.Text = selectedCharacter.Name;
            txtSelectedCharacterRace.Text = selectedCharacter.RaceName;
            txtSelectedCharacterClass.Text = selectedCharacter.Class;
            txtSelectedCharacterGender.Text = selectedCharacter.Gender;
            txtSelectedCharacterLevel.Text = selectedCharacter.Level.ToString();
            txtIntellect.Text = selectedCharacter.Statistics.Intellect.ToString();
            txtStrength.Text = selectedCharacter.Statistics.Strength.ToString();
            txtAgility.Text = selectedCharacter.Statistics.Agility.ToString();
            txtStamina.Text = selectedCharacter.Statistics.Stamina.ToString();
            txtCrit.Text = selectedCharacter.Statistics.Crit.ToString();
            txtHaste.Text = selectedCharacter.Statistics.Haste.ToString();
            txtMastery.Text = selectedCharacter.Statistics.Mastery.ToString();
            txtVersatility.Text = selectedCharacter.Statistics.Versatility.ToString();


            if (lvwCharacters.SelectedItems[0].Text != null)
            {
                cmdSelectCharacter.Visible = true;
                cmdSelectCharacter.Text = ($"Select { selectedCharacter.Name}");
            }
        }

        private async void cmdSelectCharacter_Click(object sender, EventArgs e)
        {
            string text = lvwCharacters.SelectedItems[0].Text;
            var characters = await _characterService.GetCharacterByAccountUid(LoggedInToken.LoggedInId);
            var selectedCharacter = characters.Where(x => x.Name == text).Select(t => t.UId).FirstOrDefault();
            LoggedInToken.SelectedCharacter = selectedCharacter;
            MessageBox.Show(selectedCharacter.ToString());
                
                //get the Uid by using the currently selected character on the list view            
        }

        
    }
}
