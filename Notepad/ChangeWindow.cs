using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class ChangeWindow : Form
    {
        public ChangeWindow()
        {
            InitializeComponent();
            MessageBox.Show("Для изменения заметки введите её ID или название!");
        }

        private void ChangeNote_Click(object sender, EventArgs e)
        {
            //Дописать функциональный код для кнопки
            this.Close();
        }
    }
}
