using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoW.Factories;

namespace WoW.Forms
{
    public partial class MainMenuForm : Form
    {
        CredentialsForm credentialsForm;
        public MainMenuForm(CredentialsForm _credentialsForm)
        {
            credentialsForm = _credentialsForm;
            InitializeComponent();
        }

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            credentialsForm.Show();
            
        }

        private void cmdCreateCharacter_Click(object sender, EventArgs e)
        {
            var createCharacterForm = FormFactory.OpenForm<CreateCharacterForm>(this);
            createCharacterForm.Show();
        }
    }
}
