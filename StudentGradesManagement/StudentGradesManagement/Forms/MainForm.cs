using StudentGradesManagement.Classes;
using StudentGradesManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradesManagement
{
    [Serializable]
    public partial class MainForm : Form
    {
        public Classes.Dashboard Dashboard {  get; set; }

        private string ConnectionString = "Data Source = Student.sqlite";

        public MainForm()
        {
            Dashboard = new Classes.Dashboard();
            InitializeComponent();
        }

        private void CreateStudent(Student student)
        {
            string query = "INSERT INTO Student(studentId, studentName, groupNo) VALUES " +
                "(@studentId, @studentName, @groupNo); ";

            using(SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentId", student.studentId);
                    command.Parameters.AddWithValue("@studentName", student.studentName.ToString());
                    command.Parameters.AddWithValue("@groupNo", student.groupNo.ToString());

                    command.ExecuteNonQuery();
                }
            }
        }

        private void ReadStudent()
        {
            Dashboard.Students.Clear();
            string query = "SELECT * FROM Student";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long studentId = (long)reader["studentId"];
                        string studentName = (string)reader["studentName"];
                        string groupNo = (string)reader["groupNo"];

                        Student student = new Student((int)studentId, studentName, groupNo);
                        Dashboard.Students.Add(student);
                    }
                }
            }
        }

        private void DeleteStudent(int studentId)
        {
            string query = "DELETE FROM Student WHERE studentId=@studentId;";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentId", studentId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void UpdateStudent(Student student)
        {
            string query = "UPDATE Student SET studentId = @studentId,"
                +"studentName = @studentName, groupNo = @groupNo WHERE studentId = @studentId";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentId", student.studentId);
                    command.Parameters.AddWithValue("@studentName", student.studentName);
                    command.Parameters.AddWithValue("@groupNo", student.groupNo);

                    command.ExecuteNonQuery();  

                }
            }
        }

        private void DisplayStudents()
        {
            lvStudent.Items.Clear();
            foreach (var student in Dashboard.Students)
            {
                ListViewItem lvi = new ListViewItem(student.studentId.ToString());
                lvi.SubItems.Add(student.studentName);
                lvi.SubItems.Add(student.groupNo);
                lvi.Tag = student;
                lvStudent.Items.Add(lvi);
            }
        }

        private void Add_Student_Click(object sender, EventArgs e)
        {
            AddStudent form = new AddStudent();
            Student student = new Student();
            
            form.Student = student;
            if (form.ShowDialog() == DialogResult.OK)
            {
                Dashboard.Students.Add(student);
                DisplayStudents();
            }

            CreateStudent(student);
        }

        private void btnDisplayDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnEditStud_Click(object sender, EventArgs e)
        {
            //AddStudent form = new AddStudent();
            

            if (lvStudent.SelectedItems.Count == 1)
            {
                Student student = lvStudent.SelectedItems[0].Tag as Student;
                //form.Student = student;
                AddStudent form = new AddStudent { Student = student };
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UpdateStudent(form.Student);
                    ReadStudent();
                    DisplayStudents();
                }

            }
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Binary File (*.bin)|*.bin";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, Dashboard);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadStudent();
            DisplayStudents();
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Forms.StudentDashboard sg = new Forms.StudentDashboard(); 
            sg.ShowDialog();
        }

        private void delete_Student_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count == 1)
            {
                Student student = lvStudent.SelectedItems[0].Tag as Student;
                //Dashboard.Students.Remove(student);
                //DisplayStudents();
                DeleteStudent(student.studentId);
                ReadStudent();
                DisplayStudents();
            }

            
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); 
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                using(FileStream fs = File.OpenRead(ofd.FileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    Dashboard = (Classes.Dashboard)bf.Deserialize(fs);
                    DisplayStudents();
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.C)
            {
                Add_Student_Click(sender, e);
                return;
            }

            if(e.Alt && e.KeyCode == Keys.E)
            {
                btnEditStud_Click(sender, e);
                return;
            }

            if(e.Alt && e.KeyCode == Keys.D)
            {
                delete_Student_Click(sender, e);
                return;
            }

            if(e.Alt && e.KeyCode == Keys.G)
            {
                Forms.StudentDashboard sg = new Forms.StudentDashboard(); 
                sg.ShowDialog();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Details d = new Forms.Details();
            d.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
