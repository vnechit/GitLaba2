namespace Notepad
{
    partial class AddWindow
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
            this.AddNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NoteName = new System.Windows.Forms.Label();
            this.NoteNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNote
            // 
            this.AddNote.Location = new System.Drawing.Point(398, 609);
            this.AddNote.Name = "AddNote";
            this.AddNote.Size = new System.Drawing.Size(243, 80);
            this.AddNote.TabIndex = 0;
            this.AddNote.Text = "Добавить новую заметку";
            this.AddNote.UseVisualStyleBackColor = true;
            this.AddNote.Click += new System.EventHandler(this.AddNote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(79, 50);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 26);
            this.IDBox.TabIndex = 2;
            // 
            // NoteName
            // 
            this.NoteName.AutoSize = true;
            this.NoteName.Location = new System.Drawing.Point(234, 53);
            this.NoteName.Name = "NoteName";
            this.NoteName.Size = new System.Drawing.Size(150, 20);
            this.NoteName.TabIndex = 3;
            this.NoteName.Text = "Название заметки";
            // 
            // NoteNameBox
            // 
            this.NoteNameBox.Location = new System.Drawing.Point(410, 50);
            this.NoteNameBox.Name = "NoteNameBox";
            this.NoteNameBox.Size = new System.Drawing.Size(231, 26);
            this.NoteNameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Статус";
            // 
            // StatusBox
            // 
            this.StatusBox.Location = new System.Drawing.Point(808, 46);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(208, 26);
            this.StatusBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 334);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Текст заметки";
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 763);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoteNameBox);
            this.Controls.Add(this.NoteName);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNote);
            this.Name = "AddWindow";
            this.Text = "AddWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label NoteName;
        private System.Windows.Forms.TextBox NoteNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}