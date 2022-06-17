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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradeDataSet5.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.tradeDataSet5.User);

        }
        // вывод сообщений на экран и возврат к главному меню
        private void Pravkaorder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правка разрешена только с согласия администратора!");
        }

        private void BackToMenuFromOrders_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();

            frm.Show();

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление разрешено только с согласия администратора!");
        }
    }
}
