using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationProject.View
{
    public partial class TeacherMain : Form
    {
        public TeacherMain()
        {
            InitializeComponent();
        }

        private void editTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherInfo info = new TeacherInfo();
            info.Show();
        }

        private void workMatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherWorkMates workMates = new TeacherWorkMates();
            workMates.Show();
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTask addTask = new AddNewTask();
            addTask.Show();
        }

        private void showTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTasks tasks = new ShowTasks();
            tasks.Show();
        }

        private void assignTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignTask assignTask = new AssignTask();
            assignTask.Show();
        }
    }
}

