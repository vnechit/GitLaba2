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
    public partial class AddWindow : Form
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void AddNote_Click(object sender, EventArgs e)
        {
            //Проверяем введённые значения
            if (ValidateAddForm(sender, e))
            {
                //Создаём объект класса таблицы
                NotebookDataSetTableAdapters.NotesTableAdapter notes = new NotebookDataSetTableAdapters.NotesTableAdapter();
                //Получаем максимальны id, т.к не существует метода add для TableAdapter, включаещего в себя Autoincrement.
                //var max_id = notes.SelectMaxId();
                //Вставляем новую заметку
                //notes.Insert(max_id, NoteNameBox.Text, textBox1.Text, StatusBox.Text, "money");
                //Закрываем форму добавления заметки
                this.Close();
            }
        }

        private bool ValidateAddForm(object sender, EventArgs e)
        {
            string errors = "";
            _ = (NoteNameBox.Text == "") ? errors += "Введите название заметки\n" : errors += "";
            _ = (StatusBox.Text == "") ? errors += "Введите статус заметки\n" : errors += "";
            _ = (textBox1.Text == "") ? errors += "Введите текст заметки\n" : errors += "";
            if (errors != "")
            {
                MessageBox.Show(errors);
                return false;
            }
            else return true;
        }
    }
}
