using StudentManagement;
using System.Windows.Forms;
namespace Windows_Student
{
    public partial class Form1 : Form
    {
        public List<Student> _students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Student> students)
        {
            InitializeComponent();
            _students = students;
            dataGridView1.Refresh();
            StudentService.GetStudentsAll();
            foreach (var student in students)
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
        private void Form1_Load(object sender, EventArgs e)
        {
            StudentService.GetStudentsAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
