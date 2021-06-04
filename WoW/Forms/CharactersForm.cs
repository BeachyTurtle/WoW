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
using WoW.Factories;

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
        }

        private async void CharactersForm_Load(object sender, EventArgs e)
        {
             await CreateAllCharactersDataGrid();
        }

        private async Task CreateAllCharactersDataGrid()
        {
            // Get all characters from the CharacterService List method
            // Set data source of form datagrid to the characters object
            var characters = await _characterService.GetCharacterByAccountUid(LoggedInToken.LoggedInId);
            dgvCharacters.DataSource = characters;
            
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
    }
}
