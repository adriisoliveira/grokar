using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grokar
{
    public partial class Login : Form
    {
        public Login()
        {
           InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var user = txtUser.Text;
            var password = txtPassword.Text;
            try
            {
                if (user == "adrianne" && password == "123456")
                {
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
