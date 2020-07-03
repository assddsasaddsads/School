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
    public partial class FormTeachers : Form
    {
        public FormTeachers()
        {
            InitializeComponent();
            ShowTeachers();
            ShowSubjects();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxMiddleName.Text != "" &&
                  textBoxPhone.Text != "" && comboBoxSubjects != null)
                {
                    TeachersSet teachersSet = new TeachersSet();
                    teachersSet.FirstName = textBoxFirstName.Text;
                    teachersSet.LastName = textBoxLastName.Text;
                    teachersSet.MiddleName = textBoxMiddleName.Text;
                    teachersSet.Phone = Convert.ToInt64(textBoxPhone.Text);
                    teachersSet.IdSubject = Convert.ToInt32(comboBoxSubjects.SelectedItem.ToString().Split('.')[0]);
                    Program.school.TeachersSet.Add(teachersSet);
                    Program.school.SaveChanges();
                    ShowTeachers();
                    ShowSubjects();
                }
            }
            catch
            {
                MessageBox.Show("Неправильно введены данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowTeachers()
        {
            listViewTeachers.Items.Clear();
            foreach (TeachersSet teachersSet in Program.school.TeachersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    teachersSet.Id.ToString(), teachersSet.LastName, teachersSet.FirstName, teachersSet.MiddleName,
                    teachersSet.Phone.ToString(), teachersSet.SubjectsSet.Name

                });
                item.Tag = teachersSet;
                listViewTeachers.Items.Add(item);
            }
            listViewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowSubjects()
        {
            comboBoxSubjects.Items.Clear();
            foreach (SubjectsSet subjectsSet in Program.school.SubjectsSet)
            {
                string[] item = { subjectsSet.Id.ToString() + ".", subjectsSet.Name };
                comboBoxSubjects.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTeachers.SelectedItems.Count == 1)
            {
                TeachersSet teachersSet = listViewTeachers.SelectedItems[0].Tag as TeachersSet;
                textBoxFirstName.Text = teachersSet.FirstName;
                textBoxLastName.Text = teachersSet.LastName;
                textBoxMiddleName.Text = teachersSet.MiddleName;
                textBoxPhone.Text = Convert.ToString(teachersSet.Phone);
                comboBoxSubjects.SelectedIndex = comboBoxSubjects.FindString(teachersSet.IdSubject.ToString());
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                comboBoxSubjects.Text = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewTeachers.SelectedItems.Count == 1)
            {
                TeachersSet teachersSet = listViewTeachers.SelectedItems[0].Tag as TeachersSet;
                teachersSet.FirstName = textBoxFirstName.Text;
                teachersSet.LastName = textBoxLastName.Text;
                teachersSet.MiddleName = textBoxMiddleName.Text;
                teachersSet.Phone = Convert.ToInt64(textBoxPhone.Text);
                teachersSet.IdSubject = Convert.ToInt32(comboBoxSubjects.SelectedItem.ToString().Split('.')[0]);
                Program.school.SaveChanges();
                ShowTeachers();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTeachers.SelectedItems.Count == 1)
                {
                    TeachersSet teachersSet = listViewTeachers.SelectedItems[0].Tag as TeachersSet;
                    Program.school.TeachersSet.Remove(teachersSet);
                    Program.school.SaveChanges();
                    ShowTeachers();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                comboBoxSubjects.Text = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
