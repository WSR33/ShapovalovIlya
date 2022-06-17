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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void Role_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradeDataSet2.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.tradeDataSet2.Role);

        }

        private void Pravkaorder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правка разрешена только с согласия администратора!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление разрешено только с согласия администратора!");
        }

        private void BackToMenuFromOrders_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();

            frm.Show();

            Close();
        }
    }
}
