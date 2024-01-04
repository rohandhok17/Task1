using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form3 : Form

    {
        StudentDetails StudentData = new StudentDetails();
        public List<StudentDetails> StudentDetailsList = new List<StudentDetails>();
        public List<StudentDetails> StudentDetails
        {
            get { return StudentDetailsList; }
        }
        Form1 frm1 = new Form1();
        int Index;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(StudentDetails StudentData, int Index)
        {
            InitializeComponent();
            this.StudentData = StudentData;
            txt_firstname.Text = StudentData.FirstName;
            txt_lastname.Text = StudentData.LastName;
            txtcombo.Text = StudentData.Gender;
            dateTimePicker2.Value = StudentData.DateOfBirth.Date;
            txt_age.Text = StudentData.Age.ToString();
            txt_class.Text = StudentData.Class;
            textBox2.Text = StudentData.Address;
            this.Index = Index;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_firstname.Text))
            {
                first1.Text = "This Field is Required";
                first1.ForeColor = Color.Red;
            }

            if (string.IsNullOrWhiteSpace(txt_lastname.Text))
            {
                last1.Text = "This Field is Required";
                last1.ForeColor = Color.Red;
            }

            if (string.IsNullOrWhiteSpace(txtcombo.Text))
            {
                gender1.Text = "This Field is Required";
                gender1.ForeColor = Color.Red;
            }

            DateTime Time1 = dateTimePicker2.Value.Date;
           // if Age should be between 5 to 99 years
            if (!int.TryParse(txt_age.Text, out int age) || age < 5 || age > 99 && age == 0 && dateTimePicker2.Value.Date >= Time1)
            {
                if (age == 0 && dateTimePicker2.Value.Date >= Time1)
                {
                    date1.Text = "This field is required";
                    date1.ForeColor = Color.Red;
                    age1.Text = "This field is required";
                    age1.ForeColor = Color.Red;
                    //return;
                }
                else
                {
                    date1.Text = "Age must be in between 5 to 99";
                    date1.ForeColor = Color.Red;
                    return;
                }
            }
            else
            {
                age1.Text = "";
                age1.Text = "";
            }

            if (string.IsNullOrWhiteSpace(txt_age.Text))
            {
                age1.Text = "This Field is Required";
                age1.ForeColor = Color.Red;
            }
            if (txt_firstname.Text.Length < 3 || txt_firstname.Text.Length > 15)
            {
                // MessageBox.Show("First Name must be between 3 and 15 characters", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_lastname.Text.Length < 2 || txt_lastname.Text.Length > 18)
            {
                //MessageBox.Show("Last Name Must be between 3 and 15 characters", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StudentData.FirstName = txt_firstname.Text;
            StudentData.LastName = txt_lastname.Text;
            StudentData.Gender = txtcombo.Text;
            StudentData.Age = int.Parse(txt_age.Text);
            StudentData.DateOfBirth = dateTimePicker2.Value;
            StudentData.Class = txt_class.Text;

            Form1 frm1 = new Form1(StudentDetailsList);
            this.Hide();
            frm1.Show();



            txt_firstname.Clear();
            txt_lastname.Clear();
            txtcombo.Items.Clear();
            txt_age.Clear();
            txt_class.Clear();
            dateTimePicker2 = new DateTimePicker();


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime timeStart = Convert.ToDateTime(dateTimePicker2.Value);
            DateTime timeEnd = DateTime.Today;

            TimeSpan span = timeEnd - timeStart;
            var InYears = Math.Truncate(span.TotalDays / 365);
            txt_age.Text = Convert.ToString(InYears);
        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!System.Text.RegularExpressions.Regex.IsMatch(txt_age.Text, "^[0-9]*$"))
                {
                    //MessageBox.Show("Please enter only number in Age.");
                    txt_age.Text = string.Empty;
                }
                else if (int.TryParse(txt_age.Text, out int age))
                {
                    DateTime todayDate = DateTime.Today;
                    DateTime birthDate = todayDate.AddYears(-age);

                    if (birthDate.Year >= 1900 && birthDate.Year <= DateTime.Now.Year)
                    {
                        dateTimePicker2.Value = birthDate;
                    }
                    else
                    {
                        MessageBox.Show("Invalid age entered.Please enter a valid Age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_age.Text = string.Empty;
                    }
                }


                else
                {

                    txt_age.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);



        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
