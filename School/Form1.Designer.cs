namespace School
{
    partial class Menu
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
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonSubjects = new System.Windows.Forms.Button();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonMarks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStudents.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonStudents.Location = new System.Drawing.Point(12, 134);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(222, 48);
            this.buttonStudents.TabIndex = 0;
            this.buttonStudents.Text = "Ученики";
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonSubjects
            // 
            this.buttonSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSubjects.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonSubjects.Location = new System.Drawing.Point(12, 188);
            this.buttonSubjects.Name = "buttonSubjects";
            this.buttonSubjects.Size = new System.Drawing.Size(222, 48);
            this.buttonSubjects.TabIndex = 1;
            this.buttonSubjects.Text = "Предметы";
            this.buttonSubjects.UseVisualStyleBackColor = false;
            this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTeachers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonTeachers.Location = new System.Drawing.Point(12, 242);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(222, 48);
            this.buttonTeachers.TabIndex = 2;
            this.buttonTeachers.Text = "Учителя";
            this.buttonTeachers.UseVisualStyleBackColor = false;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonMarks
            // 
            this.buttonMarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonMarks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMarks.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonMarks.Location = new System.Drawing.Point(12, 296);
            this.buttonMarks.Name = "buttonMarks";
            this.buttonMarks.Size = new System.Drawing.Size(222, 48);
            this.buttonMarks.TabIndex = 3;
            this.buttonMarks.Text = "Оценки";
            this.buttonMarks.UseVisualStyleBackColor = false;
            this.buttonMarks.Click += new System.EventHandler(this.buttonMarks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School.Properties.Resources._28_281003_stafford_county_public_school_logo_stafford_county_public_schools;
            this.pictureBox1.Location = new System.Drawing.Point(56, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(246, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMarks);
            this.Controls.Add(this.buttonTeachers);
            this.Controls.Add(this.buttonSubjects);
            this.Controls.Add(this.buttonStudents);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonSubjects;
        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonMarks;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

