using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
            ShowStudents();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                StudentsSet studentsSet = new StudentsSet();
                studentsSet.FirstName = textBoxFirstName.Text;
                studentsSet.LastName = textBoxLastName.Text;
                studentsSet.MiddleName = textBoxMiddleName.Text;
                studentsSet.Class = Convert.ToInt32(textBoxClass.Text);
                Program.school.StudentsSet.Add(studentsSet);
                Program.school.SaveChanges();
                ShowStudents();
            }
            catch
            {
                MessageBox.Show("Неправильно введены данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowStudents()
        {
            listViewStudents.Items.Clear();
            foreach (StudentsSet studentsSet in Program.school.StudentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    studentsSet.Id.ToString(), studentsSet.LastName, studentsSet.FirstName,
                    studentsSet.MiddleName, studentsSet.Class.ToString()
                });
                item.Tag = studentsSet;
                listViewStudents.Items.Add(item);
            }
            listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count == 1)
            {
                StudentsSet studentsSet = listViewStudents.SelectedItems[0].Tag as StudentsSet;
                textBoxFirstName.Text = studentsSet.FirstName;
                textBoxLastName.Text = studentsSet.LastName;
                textBoxMiddleName.Text = studentsSet.MiddleName;
                textBoxClass.Text = Convert.ToString(studentsSet.Class);
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxClass.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count == 1)
            {
                StudentsSet studentsSet = listViewStudents.SelectedItems[0].Tag as StudentsSet;
                studentsSet.FirstName = textBoxFirstName.Text;
                studentsSet.MiddleName = textBoxMiddleName.Text;
                studentsSet.LastName = textBoxLastName.Text;
                studentsSet.Class = Convert.ToInt32(textBoxClass.Text);
                Program.school.SaveChanges();
                ShowStudents();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStudents.SelectedItems.Count == 1)
                {
                    StudentsSet studentsSet = listViewStudents.SelectedItems[0].Tag as StudentsSet;
                    Program.school.StudentsSet.Remove(studentsSet);
                    Program.school.SaveChanges();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxClass.Text = "";
                ShowStudents();
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}