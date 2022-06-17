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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        // Выход из приложения
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // открытие форма с пользователями
        private void Users_Click(object sender, EventArgs e)
        {
            Users frm = new Users();

            frm.Show();

            Close();
        }
        // открытие форма с заказанными продуктами
        private void OrderProduct_Click(object sender, EventArgs e)
        {
            OrderProduct frm = new OrderProduct();

            frm.Show();

            Close();
        }

        private void Role_Click(object sender, EventArgs e)
        {
            Role frm = new Role();

            frm.Show();

            Close();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            Order frm = new Order();

            frm.Show();

            Close();

        }
    }
}
