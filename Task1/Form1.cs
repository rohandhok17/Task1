namespace Task1
{
    public partial class Form1 : Form
    {
        public List<StudentDetails> studentList = new List<StudentDetails>();
        public Form1()
        {
            InitializeComponent();

            studentList.Add(new StudentDetails { FirstName = "Guru", LastName = "Dev", Gender = "Male", DateOfBirth = new DateTime(2000, 1, 20), Age = 24, Class = "12", Address = "Nagpur" });
            studentList.Add(new StudentDetails { FirstName = "Manish", LastName = "Varma", Gender = "Male", DateOfBirth = new DateTime(2008, 1, 20), Age = 19, Class = "12", Address = "Vardha" });

            foreach (var student in studentList)
            {
                dataGridView1.Rows.Add(student.FirstName, student.LastName, student.Gender, student.Age, student.Class);
            }
            if (dataGridView1.Rows.Count > 2)
            {
                dataGridView1.Rows[2].Selected = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2(studentList);
            frm2.Show();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textsearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchValue))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Selected = true;
                            dataGridView1.CurrentCell = cell;
                            return;
                        }
                    }
                }
                MessageBox.Show("No Matching record found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a search value.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.DarkBlue,ButtonBorderStyle.Solid);
        }
    }
}
