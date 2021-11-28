﻿using System;
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
            MessageBox.Show("Для изменения заметки введите её ID!");
        }

        private void ChangeNote_Click(object sender, EventArgs e)
        {
            if (ValidateUpdateForm(sender, e))
            {
                //Создаём объект класса таблицы
                NotebookDataSetTableAdapters.NotesTableAdapter notes = new NotebookDataSetTableAdapters.NotesTableAdapter();
                //Уже умный Update
                notes.Update(Convert.ToInt32(IDBox.Text), NoteNameBox.Text, textBox1.Text, StatusBox.Text, "test");
                this.Close();
            }
        }

        private bool ValidateUpdateForm(object sender, EventArgs e)
        {
            string errors = "";
            _ = (IDBox.Text == "") ? errors += "Введите ID заметки\n" : errors += "";
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
