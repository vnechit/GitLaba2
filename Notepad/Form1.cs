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
            fillData();
        }

        private void PrintNotes_Click(object sender, EventArgs e)
        {
            fillData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                MessageBox.Show("ID пустой");
            else
            {
                NotebookDataSetTableAdapters.NotesTableAdapter notes = new NotebookDataSetTableAdapters.NotesTableAdapter();
                notesTableAdapter.Delete(Convert.ToInt32(textBox2.Text));
            }
        }
        public void fillData()
        {
            this.notesTableAdapter.Fill(this.notebookDataSet.Notes);
        }
    }
}
