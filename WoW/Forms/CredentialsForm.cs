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
    public partial class CredentialsForm : Form
    {
        public CredentialsForm()
        {
            InitializeComponent();
        }

        public string InputUsername { get; set; }
        public string InputPassword { get; set; }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
            InputUsername = txtUsername.Text;
                
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

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (InputUsername.Length > 10)
            {
                MessageBox.Show("Username too long!");
            }
            if (InputUsername.Length < 10)
            {
                MessageBox.Show("Username too short!");
            }
            if (InputPassword.Length > 10)
            {
                MessageBox.Show("Password too long!");
            }
            if (InputPassword.Length < 10)
            {
                MessageBox.Show("Password too short!");
            }
        }
    }
}
