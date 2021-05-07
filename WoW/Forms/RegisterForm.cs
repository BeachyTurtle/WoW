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
    public partial class RegisterForm : Form
    {
        private readonly IAccountService _accountSerivce;
        public RegisterForm(IAccountService accountService)
        {
            _accountSerivce = accountService;
            InitializeComponent();
        }
        public string UsernameInput { get; set; }
        public string PasswordInput { get; set; }
        private void cmdReturn_Click(object sender, EventArgs e)
        {
            {
                this.Close();  
            }
        }

        private async void cmdRegister_Click(object sender, EventArgs e)
        {
            // Query the database to check if display name or email already exists
            // return null from database or allow registration
            var accounts = await _accountSerivce.CheckExists(UsernameInput, PasswordInput);
            if(accounts.DisplayName == null)
            {
                //allow registration
            }
            else
            {
                MessageBox.Show("That display name already exists");
            }
            if(accounts.Email == null)
            {
                //allow registration
            }
            else
            {
                MessageBox.Show("That email address already exists");
            }
        }
    }
}
