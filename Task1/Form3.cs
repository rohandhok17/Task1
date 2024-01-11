using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            first1.Text = "";
            last1.Text = "";
            age1.Text = "";
            date1.Text = "";
            gender1.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {


            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonsave_Click(object sender, EventArgs e)

        {
            string firstName = txt_firstname.Text.Trim();
            string lastName = txt_lastname.Text.Trim();
            if (string.IsNullOrWhiteSpace(firstName) || firstName.Length < 3 ||
                firstName.Length > 18 || firstName.Contains("  "))
            {


                if (string.IsNullOrWhiteSpace(firstName))
                {
                    first1.Text = "This Field is Required";
                    first1.ForeColor = Color.Red;
                }

                if (firstName.Contains(" "))
                {
                    first1.Text = "First Name must be between 3 and 18 characters.";
                    first1.ForeColor = Color.Red;
                }
                else
                {
                    first1.Text = "This Field is Required";
                    first1.ForeColor = Color.Red;
                }


            }
            else
            {
                first1.Text = "";
            }

            if (string.IsNullOrWhiteSpace(lastName)|| lastName.Length < 2 ||
                lastName.Length > 18 || lastName.Contains(" "))
            {
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    last1.Text = "This Field is Required";
                    last1.ForeColor = Color.Red;
                }
                if (lastName.Contains("  "))
                {
                    last1.Text = "Last Name must be between 2 and 18 characters.";
                    last1.ForeColor = Color.Red;
                }

                else
                {
                    last1.Text = "This Field is Required";
                    last1.ForeColor = Color.Red;
                }
            }
            if (string.IsNullOrWhiteSpace(txtcombo.Text) || txtcombo.Text != "Male" && txtcombo.Text != "Female" && txtcombo.Text != "Other")
            {
                if (string.IsNullOrWhiteSpace(txtcombo.Text))
                {
                    gender1.Text = "This field is required";
                    gender1.ForeColor = Color.Red;
                    //return;
                }
                else
                {
                    gender1.Text = "Please select valid data";
                    gender1.ForeColor = Color.Red;
                }
            }
            else
            {
                gender1.Text = "";
            }



            DateTime Time1 = dateTimePicker2.Value.Date;
            // if Age should be between 5 to 99 years
            if (!int.TryParse(txt_age.Text, out int age) || age < 5 || age > 99 && age == 0 && dateTimePicker2.Value.Date >= Time1)
            {
                if (age == 0 && dateTimePicker2.Value.Date >= Time1)
                {
                    date1.Text = "This field is required";
                    date1.ForeColor = Color.Red;
                    //age1.Text = "This field is required";
                    //age1.ForeColor = Color.Red;
                    //return;
                }
                else
                {
                    //date1.Text = "Age must be in\n between 5 to 99";
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

                return;
            }
            if (txt_lastname.Text.Length < 2 || txt_lastname.Text.Length > 18)
            {

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
            try
            {

                DateTime updatedDateOfBirth = dateTimePicker2.Value;


                int age = CalculateAge(updatedDateOfBirth);


                txt_age.Text = age.ToString();
            }
            catch (Exception ex)
            {

                age1.Text = "Invalid Date Format";
                age1.ForeColor = Color.Red;
            }
        }
        private int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!System.Text.RegularExpressions.Regex.IsMatch(txt_age.Text, "^[0-9]*$"))
                {

                    txt_age.Text = string.Empty;
                }
                else if (int.TryParse(txt_age.Text, out int age))
                {
                    DateTime todayDate = DateTime.Today;
                    DateTime birthDate = todayDate.AddYears(-age);

                    if (birthDate.Year >= 1900 && birthDate.Year <= DateTime.Now.Year || age >= 5 && age <= 99)
                    {
                        dateTimePicker2.Value = birthDate;
                        age1.Text=string.Empty;
                    }
                    else
                    {
                        age1.Text = "Invalid age entered";

                        age1.ForeColor = Color.Red;

                    }
                }


                else
                {

                    txt_age.Text = string.Empty;
                }
                if (int.TryParse(txt_age.Text, out int ageForValidation) && (ageForValidation < 5 || ageForValidation > 99))
                {
                    age1.Text = "Age must be \nbetween 5 and 99.";
                    age1.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                age.Text = "Invalid Date";

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

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (StudentDetailsList.Count > 0)
            {
                int lastIndex = StudentDetailsList.Count - 1;


                if (lastIndex >= 0)
                {

                    StudentDetailsList.RemoveAt(lastIndex);
                }

            }

            Form1 form1 = new Form1(StudentDetailsList);
            this.Hide();
            form1.Show();
        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {
            string firstName = txt_firstname.Text.Trim();
            if (string.IsNullOrWhiteSpace(firstName))
            {
                first1.Text = "This Field is Required";
                first1.ForeColor = Color.Red;
                return;
            }

            if (firstName.Length < 3 || firstName.Length > 15)
            {
                first1.Text = "First Name must be between 3 and 18 characters";
                first1.ForeColor = Color.Red;
                return;

            }

            first1.Text = "";

        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {
            string lastName = txt_lastname.Text.Trim();
            if (string.IsNullOrWhiteSpace(lastName))
            {
                last1.Text = "This Field is Required";
                last1.ForeColor = Color.Red;
                return;
            }
            if (lastName.Length < 2 || lastName.Length > 18 || lastName.EndsWith(""))
            {
                last1.Text = "Last Name Must be between 2 and 18 characters";
                last1.ForeColor = Color.Red;
                return;
            }
            last1.Text = "";
        }
    }
}
