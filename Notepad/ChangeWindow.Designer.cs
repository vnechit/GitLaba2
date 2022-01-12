namespace Notepad
{
    partial class ChangeWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChangeNote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NoteNameBox = new System.Windows.Forms.TextBox();
            this.NoteName = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ChangeNote
            // 
            this.ChangeNote.Location = new System.Drawing.Point(259, 396);
            this.ChangeNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeNote.Name = "ChangeNote";
            this.ChangeNote.Size = new System.Drawing.Size(162, 52);
            this.ChangeNote.TabIndex = 1;
            this.ChangeNote.Text = "Изменить заметку";
            this.ChangeNote.UseVisualStyleBackColor = true;
            this.ChangeNote.Click += new System.EventHandler(this.ChangeNote_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Текст заметки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 155);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 218);
            this.textBox1.TabIndex = 16;
            // 
            // StatusBox
            // 
            this.StatusBox.Location = new System.Drawing.Point(423, 44);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(155, 20);
            this.StatusBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Статус";
            // 
            // NoteNameBox
            // 
            this.NoteNameBox.Location = new System.Drawing.Point(159, 80);
            this.NoteNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoteNameBox.Name = "NoteNameBox";
            this.NoteNameBox.Size = new System.Drawing.Size(155, 20);
            this.NoteNameBox.TabIndex = 13;
            // 
            // NoteName
            // 
            this.NoteName.AutoSize = true;
            this.NoteName.Location = new System.Drawing.Point(26, 82);
            this.NoteName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteName.Name = "NoteName";
            this.NoteName.Size = new System.Drawing.Size(103, 13);
            this.NoteName.TabIndex = 12;
            this.NoteName.Text = "Название заметки";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(159, 44);
            this.IDBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(155, 20);
            this.IDBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Категория";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(423, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // ChangeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 496);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoteNameBox);
            this.Controls.Add(this.NoteName);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeNote);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangeWindow";
            this.Text = "ChangeWindow";
            this.Load += new System.EventHandler(this.ChangeWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NoteNameBox;
        private System.Windows.Forms.Label NoteName;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}