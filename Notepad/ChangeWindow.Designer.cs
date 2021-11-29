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
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChangeNote
            // 
            this.ChangeNote.Location = new System.Drawing.Point(389, 610);
            this.ChangeNote.Name = "ChangeNote";
            this.ChangeNote.Size = new System.Drawing.Size(243, 80);
            this.ChangeNote.TabIndex = 1;
            this.ChangeNote.Text = "Изменить заметку";
            this.ChangeNote.UseVisualStyleBackColor = true;
            this.ChangeNote.Click += new System.EventHandler(this.ChangeNote_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Текст заметки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 239);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(627, 334);
            this.textBox1.TabIndex = 16;
            // 
            // StatusBox
            // 
            this.StatusBox.Location = new System.Drawing.Point(635, 67);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(231, 26);
            this.StatusBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Статус";
            // 
            // NoteNameBox
            // 
            this.NoteNameBox.Location = new System.Drawing.Point(239, 123);
            this.NoteNameBox.Name = "NoteNameBox";
            this.NoteNameBox.Size = new System.Drawing.Size(231, 26);
            this.NoteNameBox.TabIndex = 13;
            // 
            // NoteName
            // 
            this.NoteName.AutoSize = true;
            this.NoteName.Location = new System.Drawing.Point(39, 126);
            this.NoteName.Name = "NoteName";
            this.NoteName.Size = new System.Drawing.Size(150, 20);
            this.NoteName.TabIndex = 12;
            this.NoteName.Text = "Название заметки";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(239, 67);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(231, 26);
            this.IDBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Категория";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(635, 126);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(231, 26);
            this.CategoryTextBox.TabIndex = 19;
            // 
            // ChangeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 763);
            this.Controls.Add(this.CategoryTextBox);
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
            this.Name = "ChangeWindow";
            this.Text = "ChangeWindow";
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
        private System.Windows.Forms.TextBox CategoryTextBox;
    }
}