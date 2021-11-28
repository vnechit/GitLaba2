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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ChangeWindow changewindow = new ChangeWindow();
            changewindow.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddWindow addwindow = new AddWindow();
            addwindow.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet.Notes". При необходимости она может быть перемещена или удалена.
            this.notesTableAdapter.Fill(this.notebookDataSet.Notes);
        }

        private void PrintNotes_Click(object sender, EventArgs e)
        {
            this.notesTableAdapter.Fill(this.notebookDataSet.Notes);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            NotebookDataSetTableAdapters.NotesTableAdapter notes = new NotebookDataSetTableAdapters.NotesTableAdapter();
            notesTableAdapter.Delete(Convert.ToInt32(textBox2.Text));
        }
    }
}
