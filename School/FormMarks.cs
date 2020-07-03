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
    public partial class FormMarks : Form
    {
        public FormMarks()
        {
            InitializeComponent();
            ShowStudents();
            ShowMarks();
            ShowSubject();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSubjects.Text != null && comboBoxStudents.Text != null && textBoxMarks.Text != "")
                {
                    MarksSet marksSet = new MarksSet();
                    marksSet.Mark = Convert.ToInt32(textBoxMarks.Text);
                    marksSet.IdStudents = Convert.ToInt32(comboBoxStudents.SelectedItem.ToString().Split('.')[0]);
                    marksSet.IdSubjects = Convert.ToInt32(comboBoxSubjects.SelectedItem.ToString().Split('.')[0]);
                    Program.school.MarksSet.Add(marksSet);
                    Program.school.SaveChanges();
                    ShowMarks();
                }
            }
            catch
            {
                MessageBox.Show("Неправильно введены данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            MarksSet marksSet = listViewMarks.SelectedItems[0].Tag as MarksSet;
            marksSet.IdStudents = Convert.ToInt32(comboBoxStudents.SelectedItem.ToString().Split('.')[0]);
            marksSet.IdSubjects = Convert.ToInt32(comboBoxSubjects.SelectedItem.ToString().Split('.')[0]);
            marksSet.Mark = Convert.ToInt32(textBoxMarks.Text);
            Program.school.SaveChanges();
            ShowMarks();
        }
        void ShowMarks()
        {
            listViewMarks.Items.Clear();
            foreach (MarksSet marksSet in Program.school.MarksSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                     marksSet.Id.ToString(), marksSet.StudentsSet.LastName + " " + marksSet.StudentsSet.FirstName +
                     " " + marksSet.StudentsSet.MiddleName,
                     marksSet.SubjectsSet.Name, marksSet.Mark.ToString()

                });
                item.Tag = marksSet;
                listViewMarks.Items.Add(item);
            }
            listViewMarks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowStudents()
        {
            comboBoxStudents.Items.Clear();
            foreach (StudentsSet studentsSet in Program.school.StudentsSet)
            {
                string[] item = { studentsSet.Id.ToString() + ".", studentsSet.LastName,
                studentsSet.FirstName, studentsSet.MiddleName};
                comboBoxStudents.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSubject()
        {
            comboBoxSubjects.Items.Clear();
            foreach (SubjectsSet subjectsSet in Program.school.SubjectsSet)
            {
                string[] item = { subjectsSet.Id.ToString() + ".", subjectsSet.Name };
                comboBoxSubjects.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewMarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMarks.SelectedItems.Count == 1)
            {
                MarksSet marksSet = listViewMarks.SelectedItems[0].Tag as MarksSet;
                comboBoxStudents.SelectedIndex = comboBoxStudents.FindString(marksSet.IdStudents.ToString());
                comboBoxSubjects.SelectedIndex = comboBoxSubjects.FindString(marksSet.IdSubjects.ToString());
                textBoxMarks.Text = marksSet.Mark.ToString();
            }
            else
            {
                textBoxMarks.Text = "";
                comboBoxStudents.Text = null;
                comboBoxSubjects.Text = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMarks.SelectedItems.Count == 1)
                {
                    MarksSet marksSet = listViewMarks.SelectedItems[0].Tag as MarksSet;
                    Program.school.MarksSet.Remove(marksSet);
                    Program.school.SaveChanges();
                    ShowMarks();
                }
                textBoxMarks.Text = "";
                comboBoxStudents.Text = null;
                comboBoxSubjects.Text = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
