using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task1
{
    public partial class Form2 : Form
    {
        private string firstName;
        private string lastName;
        public DataGridView dataGridView1;



        StudentDetails StudentDetails = new StudentDetails();
        public List<StudentDetails> StudentDetailsList { get; private set; } = new List<StudentDetails>();
        public List<StudentDetails> stdList
        {
            get { return StudentDetailsList; }
        }
        public Form2()
        {

            InitializeComponent();

        }
        public Form2(List<StudentDetails> slist)
        {

            InitializeComponent();
            First.Text = "";
            Last.Text = "";
            Gender.Text = "";
            Date.Text = "";
            Age.Text = "";
            this.StudentDetailsList = slist;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            //txt_firstname.Text = "Please enter First Name";
            //txt_lastname.Text = "Please enter Last Name";
            //txtcombo.Text = "Please enter Gender";
            //dateTimePicker1 = new DateTimePicker();
            //txt_age.Clear();
            //txt_class.Text = "Please enter Class";
            //textBox2.Text = "PLease enter Address";
            //dateTimePicker1.Value = DateTime.Today;
            this.Hide();
            Form1 form1 = new Form1(StudentDetailsList);
            form1.Show();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {

            string firstname = txt_firstname.Text.Trim();
            string lastname = txt_lastname.Text.Trim();


            if (string.IsNullOrWhiteSpace(firstname) || firstname.Length < 3 ||
                firstname.Length > 18 || firstname.Replace(" ", "").Length < 3)
            {
                if (string.IsNullOrWhiteSpace(firstname))
                {
                    First.Text = "This Field is Required";
                    First.ForeColor = Color.Red;
                }
                //else if(firstname.Contains("  "))
                //{
                //    First.Text = "First Name must be between 3 and 18 characters.";
                //    First.ForeColor = Color.Red;
                //}

                else if
                    (firstname.Length < 3 || firstname.Length > 18 || firstname.Replace(" ", "").Length < 3)
                {
                    First.Text = "First Name must be between 3 and 18 characters.";
                    First.ForeColor = Color.Red;

                }
            }
            else
            {
                First.Text = string.Empty;
            }


            if (string.IsNullOrWhiteSpace(lastname) || lastname.Length < 2 ||
                lastname.Length > 18 || lastname.Replace(" ", "").Length < 2)
            {
                if (string.IsNullOrWhiteSpace(lastname))
                {
                    Last.Text = "This Field is Required";
                    Last.ForeColor = Color.Red;
                }
                else if (lastname.Contains("  "))
                {
                    Last.Text = "Last Name must be between 2 and 18 characters.";
                    Last.ForeColor = Color.Red;
                }

                else if (lastname.Length < 2 || lastname.Length > 18 || lastname.Replace(" ", "").Length < 2)
                {
                    Last.Text = "Last Name must be between 2 and 18 characters.";
                    Last.ForeColor = Color.Red;
                }

            }
            else
            {
                Last.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(txtcombo.Text) || txtcombo.Text != "Male" && txtcombo.Text != "Female" && txtcombo.Text != "Other")
            {
                if (string.IsNullOrWhiteSpace(txtcombo.Text))
                {
                    Gender.Text = "This field is required";
                    Gender.ForeColor = Color.Red;
                    //return;
                }
                else
                {
                    Gender.Text = string.Empty;
                }
            }
            else
            {
                Gender.Text = string.Empty;

            }


            //DateTime Time1 = dateTimePicker1.Value.Date;
            DateTime Time1 = DateTime.Today;
            if (dateTimePicker1.Value.Date >= Time1)
            {
                Date.Text = "This field is required";
                Date.ForeColor = Color.Red;
            }
            else
            {
                Date.Text = string.Empty;
                Date.Text = string.Empty;
            }


            //if Age should be between 5 to 99 years
            if (!int.TryParse(txt_age.Text, out int age) || age < 5 || age > 99)
            {
                if (age == 0)
                {


                }
                else
                {
                    //Date.Text = "";
                    ////Date.Text = "Age must be in between 5 to 99";
                    //Date.ForeColor = Color.Red;
                    return;
                }
            }


            if (string.IsNullOrWhiteSpace(txt_age.Text))
            {
                Age.Text = "This Field is Required";
                Age.ForeColor = Color.Red;
            }
            //if (dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            //{
            //    Date.Text = "This Field is Required";
            //    Date.ForeColor = Color.Red;
            //}
            if (string.IsNullOrWhiteSpace(firstname) || firstname.Length < 3 || firstname.Length > 18 || firstname.Replace(" ", "").Length < 3 |
              string.IsNullOrWhiteSpace(lastname) || lastname.Length < 2 || lastname.Length > 18 || lastname.Replace(" ", "").Length < 2 ||

                 string.IsNullOrWhiteSpace(txtcombo.Text) || txtcombo.Text != "Male" && txtcombo.Text != "Female" && txtcombo.Text != "Other" ||
                age < 5 || age > 99 && age == 0 && dateTimePicker1.Value.Date >= Time1)
            {

                return;
            }


            DateTime birthdate = dateTimePicker1.Value.Date;
            StudentDetails Std = new StudentDetails
            {
                FirstName = txt_firstname.Text.Trim(),
                LastName = txt_lastname.Text.Trim(),
                Gender = txtcombo.Text.Trim(),
                DateOfBirth = birthdate,
                Age = int.Parse(txt_age.Text),
                Class = txt_class.Text.Trim(),
                Address = textBox2.Text.Trim()

            };

            StudentDetailsList.Add(Std);
            Form1 frm1 = new Form1(StudentDetailsList);
            this.Hide();
            frm1.Show();




            txt_firstname.Clear();
            txt_lastname.Clear();
            txtcombo.Items.Clear();
            dateTimePicker1 = new DateTimePicker();
            txt_age.Clear();
            txt_class.Clear();




        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime dob = dateTimePicker1.Value;
                int age = CalculateAge(dob);
                txt_age.Text = age.ToString();
            }
            catch (Exception ex)
            {
                Date.Text = "Valid Date Format";
                Date.ForeColor = Color.Red;
            }


        }
        private int CalculateAge(DateTime dateOfBirth)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - dateOfBirth.Year;


            if (currentDate < dateOfBirth.AddYears(age))
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
                        dateTimePicker1.Value = birthDate;
                        Age.Text = string.Empty;
                    }
                    //else
                    //{
                    //    Age.Text = "Age must be\n between 5 and 99.";
                    //    Age.ForeColor = Color.Red;

                    //}
                }


                else
                {

                    txt_age.Text = string.Empty;
                }
                if (int.TryParse(txt_age.Text, out int ageForValidation) && (ageForValidation < 5 || ageForValidation > 99))
                {
                    Age.Text = "Age must be\n between 5 and 99.";
                    Age.ForeColor = Color.Red;
                    return;
                }


            }
            catch (Exception ex)
            {


            }
        }
        private DateTime CalculateDateOfBirth(int age)
        {
            DateTime currentDate = DateTime.Today;
            int yearOfBirth = currentDate.Year - age;


            DateTime dateOfBirth = new DateTime(yearOfBirth);

            return dateOfBirth;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {
            string firstName = txt_firstname.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                First.Text = "This Field is Required";
                First.ForeColor = Color.Red;
                return;
            }

            if (firstName.Length < 3 || firstName.Length > 18 || firstName.Replace(" ", "").Length < 3)
            {
                First.Text = "First Name must be between 3 and 18 characters.";
                First.ForeColor = Color.Red;
                return;

            }
            else
                First.Text = "";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {
            string lastName = txt_lastname.Text.Trim();

            if (string.IsNullOrWhiteSpace(lastName) || lastName.Replace(" ", "").Length < 2)
            {
                Last.Text = "This Field is Required";
                Last.ForeColor = Color.Red;
                return;
            }
            if (lastName.Length < 2 || lastName.Length > 18 || lastName.Replace(" ", "").Length < 2)
            {
                Last.Text = "Last Name must be between 2 and 18 characters.";
                Last.ForeColor = Color.Red;
                return;
            }
            else
                Last.Text = "";
        }

        private void txtcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtcombo.Text) || txtcombo.Text != "Male" && txtcombo.Text != "Female" && txtcombo.Text != "Other")
            {
                if (string.IsNullOrWhiteSpace(txtcombo.Text))
                {
                    Gender.Text = "This field is required";
                    Gender.ForeColor = Color.Red;
                    //return;
                }
                else
                {
                    Gender.Text = string.Empty;
                }
            }
            else
            {
                Gender.Text = string.Empty;

            }


        }

        private void txt_firstname_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_firstname.Text))
            {
                First.Text = "This Field is Required";
                First.ForeColor = Color.Red;
                return;
            }
            else
            {
                First.Text = "";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Asks before deleting the record of the selected row
            result = MessageBox.Show($"Are you sure you want to delete this student records ", "Our_Students", MessageBoxButtons.YesNo);
           ;
            if (result == DialogResult.Yes && StudentDetailsList.Count > 0)
            {


               

                StudentDetailsList.RemoveAt(StudentDetailsList.Count - 1);
                Form1 form1 = new Form1(StudentDetailsList);
                this.Hide();
                form1.Show();

            }
            else
            {
                txt_firstname.Text = StudentDetails.FirstName;
                txt_lastname.Text = StudentDetails.LastName;
                txtcombo.Text = StudentDetails.Gender;

                txt_age.Text = StudentDetails.Age.ToString();
              //  dateTimePicker1.Value = StudentDetails.DateOfBirth.Date;
                txt_class.Text = StudentDetails.Class;
                textBox2.Text = StudentDetails.Address;
                Form2 F2 = new Form2(StudentDetailsList);
                this.Hide();
                F2.Show();
            }


        }

        private void txt_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void txt_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')

                e.Handled = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_class_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
