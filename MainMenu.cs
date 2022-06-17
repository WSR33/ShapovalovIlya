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

    public partial class KapchaWindow : Form


    {
        Random rnd = new Random();
        public KapchaWindow()
         // инициализация рандома
        {
            InitializeComponent();
        }

        private void Vhod_Click(object sender, EventArgs e)
        {
            // Процесс создания капчи
            object kapch = rnd.Next();
            if (Kapcha.Text != kapch.ToString())
            {
                Menu frm = new Menu();

                frm.Show();

                Close();
            }
            else
            {
                MessageBox.Show("Вы ввели капчу неправильно");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Reload_Click(object sender, EventArgs e)
        {

        }
// Обновление капчи
        private void Reload_Click_1(object sender, EventArgs e)
        {
            int kapch = rnd.Next();
            kapchatekst.Text = kapch.ToString();
        }

        private void KapchaWindow_Load(object sender, EventArgs e)
        {
        }
    }
}
