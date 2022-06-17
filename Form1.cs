using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersProgramm
{
    public partial class LoginPassword : Form
    {
        public LoginPassword()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            // Система авторизации
            if (logintext.Text == "1" & passwordtext.Text == "1")
            {      
                KapchaWindow frm = new KapchaWindow();

                frm.Show();

                Hide();
            }
            else
            {
                MessageBox.Show("Логин или пароль написан неправильно");
            }
        }

        private void logintext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
