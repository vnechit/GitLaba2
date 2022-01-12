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
                //Вставляем новую заметку
                notes.Insert(NoteNameBox.Text, textBox1.Text, StatusBox.Text, comboBox1.SelectedItem.ToString());
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

        private void AddWindow_Load(object sender, EventArgs e)
        {
            NotebookDataSetTableAdapters.NotesTableAdapter notes = new NotebookDataSetTableAdapters.NotesTableAdapter();
            List<string> cats = notes.listCategories();
            foreach(var i in cats)
            {
                comboBox1.Items.Add(i);
            }
        }
    }
}
