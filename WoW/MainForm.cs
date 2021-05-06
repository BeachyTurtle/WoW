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
using WoW.Forms;

namespace WoW
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        // Open another form
        private void cmdSeeCharacters_Click(object sender, EventArgs e)
        {
            var charactersForm = FormFactory.OpenForm<CharactersForm>();
            charactersForm.Show();
        }

        private void cmdBegin_Click(object sender, EventArgs e)
        {

        }
    }
}
