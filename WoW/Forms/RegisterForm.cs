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
        public string DisplayNameInput { get; set; }
        public string EmailInput { get; set; }
        private void cmdReturn_Click(object sender, EventArgs e)
        {
            {
                this.Close();  
            }
        }

        private async void cmdRegister_Click(object sender, EventArgs e)
        {
            DisplayNameInput = txtDisplayName.Text;
            EmailInput = txtEmailAddress.Text;
            // Query the database to check if display name or email already exists
            // return null from database or allow registration
            var email = await _accountSerivce.CheckExistsEmail(EmailInput);
            if(email.Email == null)
            {
                //allow registration
                MessageBox.Show("Alright Mate");
            }
            else
            {
                MessageBox.Show("That display name already exists");
            }
            var displayname = await _accountSerivce.CheckExistsDisplayName(DisplayNameInput);
            if (displayname.DisplayName == null)
            {
                //allow registration
                MessageBox.Show("Alright Mate");
            }
            else
            {
                MessageBox.Show("That display name already exists");
            }
        }
    }
}
