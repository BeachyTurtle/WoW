using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoW.Forms
{
    public partial class RegisterForm : Form
    {
        CredentialsForm _owningCredentialsSettings;
        public RegisterForm(CredentialsForm owningCredentialsSettings)
        {
            if (owningCredentialsSettings == null)
                throw new ArgumentNullException("owningCredentialsSettings");

            _owningCredentialsSettings = owningCredentialsSettings;
            InitializeComponent();
        }
        
        private void cmdReturn_Click(object sender, EventArgs e)
        {
            {
                this.Close();  
            }
        }
    }
}
