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

namespace WoW.Forms
{
    public partial class CharactersForm : Form
    {
        private readonly ICharacterService _characterService;
        public CharactersForm(ICharacterService characterService)
        {
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
            var characters = await _characterService.List();
            dgvCharacters.DataSource = characters;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
