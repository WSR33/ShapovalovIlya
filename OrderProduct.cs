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
    public partial class OrderProduct : Form
    {
        public OrderProduct()
        {
            InitializeComponent();
        }

        private void OrderProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradeDataSet1.OrderProduct". При необходимости она может быть перемещена или удалена.
            this.orderProductTableAdapter.Fill(this.tradeDataSet1.OrderProduct);

        }

        private void BackToMenuFromOrders_Click(object sender, EventArgs e)
            // уход в главное меню
        {
            Menu frm = new Menu();

            frm.Show();

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление разрешено только с согласия администратора!");
        }

        private void Pravkaorder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правка разрешена только с согласия администратора!");
        }
    }
}
