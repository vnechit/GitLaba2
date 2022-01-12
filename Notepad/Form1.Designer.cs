namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PrintNotes = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Filterbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_ЗАМЕТКИ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ТАйтл = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STAsadtas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notesBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notebookDataSet1 = new Notepad.NotebookDataSet1();
            this.notebookDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.notesTableAdapter1 = new Notepad.NotebookDataSet1TableAdapters.NotesTableAdapter();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new Notepad.NotebookDataSet1TableAdapters.CategoriesTableAdapter();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.notesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.notesBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.notebookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notebookDataSet = new Notepad.NotebookDataSet();
            this.notesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notesTableAdapter = new Notepad.NotebookDataSetTableAdapters.NotesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintNotes
            // 
            this.PrintNotes.Location = new System.Drawing.Point(790, 70);
            this.PrintNotes.Margin = new System.Windows.Forms.Padding(2);
            this.PrintNotes.Name = "PrintNotes";
            this.PrintNotes.Size = new System.Drawing.Size(135, 34);
            this.PrintNotes.TabIndex = 1;
            this.PrintNotes.Text = "Вывести все заметки";
            this.PrintNotes.UseVisualStyleBackColor = true;
            this.PrintNotes.Click += new System.EventHandler(this.PrintNotes_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "status",
            "description"});
            this.comboBox1.Location = new System.Drawing.Point(26, 525);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Фильтровать";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 526);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Filterbutton
            // 
            this.Filterbutton.Location = new System.Drawing.Point(405, 526);
            this.Filterbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Filterbutton.Name = "Filterbutton";
            this.Filterbutton.Size = new System.Drawing.Size(82, 22);
            this.Filterbutton.TabIndex = 4;
            this.Filterbutton.Text = "Фильтровать";
            this.Filterbutton.UseVisualStyleBackColor = true;
            this.Filterbutton.Click += new System.EventHandler(this.Filterbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 476);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Удалить заметку по ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 476);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 6;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(405, 476);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(82, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(790, 318);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 33);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(790, 180);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(129, 33);
            this.EditButton.TabIndex = 13;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ЗАМЕТКИ,
            this.ТАйтл,
            this.Column1,
            this.STAsadtas,
            this.category_name});
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(678, 420);
            this.dataGridView1.TabIndex = 17;
            // 
            // ID_ЗАМЕТКИ
            // 
            this.ID_ЗАМЕТКИ.HeaderText = "id";
            this.ID_ЗАМЕТКИ.Name = "ID_ЗАМЕТКИ";
            // 
            // ТАйтл
            // 
            this.ТАйтл.HeaderText = "title";
            this.ТАйтл.Name = "ТАйтл";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "description";
            this.Column1.Name = "Column1";
            // 
            // STAsadtas
            // 
            this.STAsadtas.HeaderText = "status";
            this.STAsadtas.Name = "STAsadtas";
            // 
            // category_name
            // 
            this.category_name.HeaderText = "category";
            this.category_name.Name = "category_name";
            // 
            // notesBindingSource5
            // 
            this.notesBindingSource5.DataMember = "Notes";
            this.notesBindingSource5.DataSource = this.notebookDataSetBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.description,
            this.status,
            this.category});
            this.dataGridView2.Location = new System.Drawing.Point(26, 581);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(678, 163);
            this.dataGridView2.TabIndex = 18;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // title
            // 
            this.title.HeaderText = "title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 125;
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // category
            // 
            this.category.HeaderText = "category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // notesBindingSource1
            // 
            this.notesBindingSource1.DataMember = "Notes";
            this.notesBindingSource1.DataSource = this.notebookDataSetBindingSource;
            // 
            // notebookDataSet1
            // 
            this.notebookDataSet1.DataSetName = "NotebookDataSet1";
            this.notebookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notebookDataSet1BindingSource
            // 
            this.notebookDataSet1BindingSource.DataSource = this.notebookDataSet1;
            this.notebookDataSet1BindingSource.Position = 0;
            // 
            // notesBindingSource2
            // 
            this.notesBindingSource2.DataMember = "Notes";
            this.notesBindingSource2.DataSource = this.notebookDataSet1BindingSource;
            // 
            // notesTableAdapter1
            // 
            this.notesTableAdapter1.ClearBeforeFill = true;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.notebookDataSet1BindingSource;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "Categories";
            this.categoriesBindingSource1.DataSource = this.notebookDataSet1BindingSource;
            // 
            // notesBindingSource3
            // 
            this.notesBindingSource3.DataMember = "Notes";
            this.notesBindingSource3.DataSource = this.notebookDataSet1BindingSource;
            // 
            // notesBindingSource4
            // 
            this.notesBindingSource4.DataMember = "Notes";
            this.notesBindingSource4.DataSource = this.notebookDataSet1BindingSource;
            // 
            // notesBindingSource6
            // 
            this.notesBindingSource6.DataMember = "Notes";
            this.notesBindingSource6.DataSource = this.notebookDataSetBindingSource;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Все"});
            this.comboBox2.Location = new System.Drawing.Point(1046, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(339, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // notebookDataSetBindingSource
            // 
            this.notebookDataSetBindingSource.DataSource = this.notebookDataSet;
            this.notebookDataSetBindingSource.Position = 0;
            // 
            // notebookDataSet
            // 
            this.notebookDataSet.DataSetName = "NotebookDataSet";
            this.notebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notesBindingSource
            // 
            this.notesBindingSource.DataMember = "Notes";
            this.notesBindingSource.DataSource = this.notebookDataSet;
            // 
            // notesTableAdapter
            // 
            this.notesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 817);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filterbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PrintNotes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PrintNotes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Filterbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NotebookDataSet notebookDataSet;
        private System.Windows.Forms.BindingSource notesBindingSource;
        private NotebookDataSetTableAdapters.NotesTableAdapter notesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.BindingSource notebookDataSetBindingSource;
        private System.Windows.Forms.BindingSource notesBindingSource1;
        private System.Windows.Forms.BindingSource notebookDataSet1BindingSource;
        private NotebookDataSet1 notebookDataSet1;
        private System.Windows.Forms.BindingSource notesBindingSource2;
        private NotebookDataSet1TableAdapters.NotesTableAdapter notesTableAdapter1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private NotebookDataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource notesBindingSource5;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.BindingSource notesBindingSource3;
        private System.Windows.Forms.BindingSource notesBindingSource4;
        private System.Windows.Forms.BindingSource notesBindingSource6;
        private System.Windows.Forms.BindingSource fINALBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ЗАМЕТКИ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ТАйтл;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STAsadtas;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

