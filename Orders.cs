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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradeDataSet3.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.tradeDataSet3.Product);

        }

        private void Pravkaorder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правка разрешена только с согласия администратора!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление разрешено только с согласия администратора!");
        }
    }
}
