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
    public partial class FormSubjects : Form
    {
        public FormSubjects()
        {
            InitializeComponent();
            ShowSubject();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
                SubjectsSet subjectsSet = new SubjectsSet();
                subjectsSet.Name = textBoxName.Text;
                Program.school.SubjectsSet.Add(subjectsSet);
                Program.school.SaveChanges();
                ShowSubject();
        }
        void ShowSubject()
        {
            listViewSubjects.Items.Clear();
            foreach (SubjectsSet subjectsSet in Program.school.SubjectsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    subjectsSet.Id.ToString(), subjectsSet.Name
                });
                item.Tag = subjectsSet;
                listViewSubjects.Items.Add(item);
            }
            listViewSubjects.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSubjects.SelectedItems.Count == 1)
            {
                SubjectsSet subjectsSet = listViewSubjects.SelectedItems[0].Tag as SubjectsSet;
                textBoxName.Text = subjectsSet.Name;
            }
            else
            {
                textBoxName.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSubjects.SelectedItems.Count == 1)
                {
                    SubjectsSet subjectsSet = listViewSubjects.SelectedItems[0].Tag as SubjectsSet;
                    Program.school.SubjectsSet.Remove(subjectsSet);
                    Program.school.SaveChanges();
                }
                textBoxName.Text = "";
                ShowSubject();
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSubjects.SelectedItems.Count == 1)
            {
                SubjectsSet subjectsSet = listViewSubjects.SelectedItems[0].Tag as SubjectsSet;
                subjectsSet.Name = textBoxName.Text;
                Program.school.SaveChanges();
                ShowSubject();
            }
        }
    }
}
