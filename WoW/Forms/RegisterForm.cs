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

namespace WoW.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly IAccountService _accountSerivce;
        private readonly ICharacterService _characterService;
        public RegisterForm(IAccountService accountService, ICharacterService characterService)
        {
            _accountSerivce = accountService;
            _characterService = characterService;
            InitializeComponent();
        }
        public RegisterForm(ICharacterService characterService)
        {
            
            
        }
        public string PasswordInput { get; set; }
        public string DisplayNameInput { get; set; }
        public string EmailInput { get; set; }
        public List<Character> Characters = new List<Character>();
        private void cmdReturn_Click(object sender, EventArgs e)
        {
            {
                this.Close();  
            }
        }

        private async void cmdRegister_Click(object sender, EventArgs e)
        {
            // Query the database to check if display name or email already exists
            // return null from database which allows registration
            // return true from database which means name/email already exists

            DisplayNameInput = txtDisplayName.Text;
            EmailInput = txtEmailAddress.Text;
            PasswordInput = txtPassword.Text;
            
            
            var displayname = await _accountSerivce.CheckExistsDisplayName(DisplayNameInput);
            var email = await _accountSerivce.CheckExistsEmail(EmailInput);
            if (displayname.DisplayName == null && email.Email == null)
            {
                //allow registration
                Account accountToInsert = new Account();
                accountToInsert.DisplayName = DisplayNameInput;
                accountToInsert.Email = EmailInput;
                accountToInsert.Password = PasswordInput;
                accountToInsert.LastLoginDate = DateTime.Now;
                accountToInsert.Role = Convert.ToString(1);
                await _accountSerivce.Upsert(accountToInsert);
                MessageBox.Show("Alright Mate");
            }
            else
            if (displayname.DisplayName != null)
            { 
                MessageBox.Show("That display name already exists"); 
            }
            if (email.Email != null)
            {
                MessageBox.Show("That email address already exists"); 
            }  
        }

        private async void cmdTestAll_Click(object sender, EventArgs e)
        {
            List<Character> characters = await _characterService.List();
            Characters = characters;
        }

       
    }
}
