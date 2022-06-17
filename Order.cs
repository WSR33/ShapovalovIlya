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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradeDataSet6.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter1.Fill(this.tradeDataSet6.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradeDataSet4.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.tradeDataSet4.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradeDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.tradeDataSet.Order);

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
