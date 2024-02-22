using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using StudentManagement;

namespace Task1
{
    public partial class Form1 : Form
    {
        public List<StudentDetails> studentList = new List<StudentDetails>();
        public Form1()
        {
            InitializeComponent();
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;

            studentList.Add(new StudentDetails { FirstName = "Guru", LastName = "Dev", Gender = "Male", DateOfBirth = new DateTime(2000, 1, 20), Age = 24, Class = "8", Address = "Nagpur" });
            studentList.Add(new StudentDetails { FirstName = "Manish", LastName = "Varma", Gender = "Male", DateOfBirth = new DateTime(2008, 1, 20), Age = 19, Class = "12", Address = "Vardha" });

            foreach (var student in studentList)
            {
                dataGridView1.Rows.Add(student.FirstName, student.LastName, student.Gender, student.Age, student.Class);
            }
            if (dataGridView1.Rows.Count > 2)
            {
                
            }
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }

        }
        public Form1(List<StudentDetails> stdlist)
        {
            InitializeComponent();
            studentList = stdlist;
            dataGridView1.Refresh();

            foreach (var student in studentList)
            {
                dataGridView1.Rows.Add(student.FirstName,
                    student.LastName,
                    student.Gender,
                    student.Age,
                    student.Class);


            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 frm3 = new Form3();
            openeditForm(studentList[e.RowIndex], e.RowIndex);
            this.Hide();

        }
        private void openeditForm(StudentDetails student, int Index)
        {
            Form3 frm3 = new Form3(student, Index);
            frm3.StudentDetails.AddRange(studentList);
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles =false;
            dataGridView1.CellClick += dataGridView1_CellClick;
            //dataGridView1.Rows[0].Selected = false;

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2(studentList);
            frm2.Show();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            List<StudentDetails> studentsearch = new List<StudentDetails>();
            StudentDetails Std = new StudentDetails();


            string searchValue = textsearch.Text.ToLower();




            foreach (var student in studentList)
            {
                if (student.FirstName.ToLower().Contains(searchValue) ||
                        student.LastName.ToLower().Contains(searchValue) ||
                        student.Age.ToString().Contains(searchValue))
                {
                    studentsearch.Add(student);
                }

            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Clear();
            foreach (var student in studentsearch)
            {
                dataGridView1.Rows.Add(student.FirstName,

                    student.LastName,
                    student.Gender,
                    student.Age,
                    student.Class);

            }


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Unselect the previously selected row (optional)
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                    dataGridView1.SelectedRows[0].DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.SelectionBackColor;
                }

                // Change the background color of the clicked row
                  //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.YellowGreen;
            //    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            }
        }

        //private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (e.RowIndex == 0)
        //    {
        //        e.CellStyle.BackColor = Color.AntiqueWhite;
        //        e.CellStyle.ForeColor = Color.Black;
        //    }
        //    else
        //    {
        //        e.CellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
        //        e.CellStyle.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;
        //    }
        //}
        private void InitializeDataGridView()
        {
           // dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        //{
        //    if (e.RowIndex >= 2)
        //    {
        //        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
        //        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
        //    }
        //}
    }
}
