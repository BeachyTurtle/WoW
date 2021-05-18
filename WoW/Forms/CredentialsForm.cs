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
    public partial class CredentialsForm : Form
    {
        private readonly IAccountService _accountService;
        public CredentialsForm(IAccountService accountService)
        {
            _accountService = accountService;
            InitializeComponent();
        }

        public string InputEmail { get; set; }
        public string InputPassword { get; set; }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
            InputEmail = txtEmailAddress.Text;
                
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            InputPassword = txtPassword.Text;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    Application.Exit();
            }
        }
         
        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = FormFactory.OpenForm<RegisterForm>(this);
            registerForm.Show();
        }

        private async void cmdLogin_Click(object sender, EventArgs e)
        {
            Account accountToLogin = new Account();
            var loginRequest = await _accountService.Authenticate(InputEmail, InputPassword);
            if(loginRequest != null)
            {
                accountToLogin = await _accountService.GetAccountByEmail(InputEmail);
                LoggedInToken.LoggedInId = accountToLogin.UId;
                var mainMenuForm = FormFactory.OpenForm<MainMenuForm>(this);
                mainMenuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account does not exist, please try again");
            }
            
        }
        
    }
}
