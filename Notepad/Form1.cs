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
            // TODO: This line of code loads data into the 'notebookDataSet1.Categories' table. You can move, or remove it, as needed.
            //this.categoriesTableAdapter.Fill(this.notebookDataSet1.Categories);
            // TODO: This line of code loads data into the 'notebookDataSet1.Notes' table. You can move, or remove it, as needed.
            //this.notesTableAdapter1.Fill(this.notebookDataSet1.Notes);
            NotebookDataSetTableAdapters.NotesTableAdapter notes = new NotebookDataSetTableAdapters.NotesTableAdapter();
            List<string> cats1 = notes.listCategories();
            foreach (var i in cats1)
            {
                comboBox2.Items.Add(i);
            }
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
            dataGridView1.Rows.Clear();
            NotebookDataSetTableAdapters.NotesTableAdapter notes = new NotebookDataSetTableAdapters.NotesTableAdapter();

            List<string[]> cats = notes.generalMotors();
            foreach (var cat in cats)
            {
                dataGridView1.Rows.Add(cat);
            }
        }

        private void Filterbutton_Click(object sender, EventArgs e)
        {
            NotebookDataSetTableAdapters.NotesTableAdapter notes = new NotebookDataSetTableAdapters.NotesTableAdapter();
            dataGridView2.Rows.Clear();
            var data = notesTableAdapter.FilterBy(comboBox1.SelectedItem.ToString(), textBox1.Text);
            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Все")
            {
                fillData();
            }
            else
            {
                dataGridView1.Rows.Clear();
                NotebookDataSetTableAdapters.NotesTableAdapter notes = new NotebookDataSetTableAdapters.NotesTableAdapter();
                var data = notesTableAdapter.FilterBy("category_id", comboBox2.SelectedItem.ToString());
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }
    }
}
