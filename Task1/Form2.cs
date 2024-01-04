using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task1
{
    public partial class Form2 : Form
    {
        private string firstName;
        private string lastName;



        StudentDetails StudentDetails = new StudentDetails();
        public List<StudentDetails> StudentDetailsList = new List<StudentDetails>();
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

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {




            if (string.IsNullOrWhiteSpace(txt_firstname.Text))
            {
                First.Text = "This Field is Required";
                First.ForeColor = Color.Red;
            }

            if (string.IsNullOrWhiteSpace(txt_lastname.Text))
            {
                Last.Text = "This Field is Required";
                Last.ForeColor = Color.Red;
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
                    Gender.Text = "Please select valid data";
                    Gender.ForeColor = Color.Red;
                }
            }
            else
            {
                Gender.Text = "";
            }

            DateTime Time1 = dateTimePicker1.Value.Date;
            //if Age should be between 5 to 99 years
            if (!int.TryParse(txt_age.Text, out int age) || age < 5 || age > 99 && age == 0 && dateTimePicker1.Value.Date >= Time1)
            {
                if (age == 0 && dateTimePicker1.Value.Date >= Time1)
                {
                    Date.Text = "This field is required";
                    Date.ForeColor = Color.Red;
                    //TRF4.Text = "This field is required";
                    //TRF4.ForeColor = Color.Red;
                    //return;
                }
                else
                {
                    Date.Text = "Age must be in between 5 to 99";
                    Date.ForeColor = Color.Red;
                    return;
                }
            }
            else
            {
                Date.Text = "";
                Date.Text = "";
            }

            if (string.IsNullOrWhiteSpace(txt_age.Text))
            {
                Age.Text = "This Field is Required";
                Age.ForeColor = Color.Red;
            }
            if (dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            {
                Date.Text = "This Field is Required";
                Date.ForeColor = Color.Red;
            }

          
            DateTime birthdate = dateTimePicker1.Value.Date;
            StudentDetails Std = new StudentDetails
            {
                FirstName = txt_firstname.Text,
                LastName = txt_lastname.Text,
                Gender = txtcombo.Text,
                DateOfBirth = birthdate,
                Age = int.Parse(txt_age.Text),
                Class = txt_class.Text,
                Address = textBox2.Text

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
            DateTime timeStart = Convert.ToDateTime(dateTimePicker1.Value);
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

                    if (birthDate.Year >= 1900 && birthDate.Year <= DateTime.Now.Year || age >= 5 && age <= 99)
                    {
                        dateTimePicker1.Value = birthDate;
                    }
                    else
                    {
                        Age.Text = "Invalid age entered";

                        Age.ForeColor = Color.Red;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        private void CenterGroupBox(GroupBox groupBox2)
        {
            if (groupBox2.Parent != null)
            {
                // Calculate the new left position to center the GroupBox
                int newLeft = (groupBox2.Parent.Width - groupBox2.Width) / 2;

                // Calculate the new top position to center the GroupBox
                int newTop = (groupBox2.Parent.Height - groupBox2.Height) / 2;

                // Set the new position
                groupBox2.Location = new Point(newLeft, newTop);
            }
        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_firstname.Text))
            {
                First.Text = "This Field is Required";
                First.ForeColor = Color.Red;
                return;
            }

            if (txt_firstname.Text.Length < 3 || txt_firstname.Text.Length > 15)
            {
                First.Text = "First Name must be between 3 and 15 characters";
                First.ForeColor = Color.Red;
                return;

            }

            First.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_lastname.Text))
            {
                Last.Text = "This Field is Required";
                Last.ForeColor = Color.Red;
                return;
            }
            if (txt_lastname.Text.Length < 2 || txt_lastname.Text.Length > 18)
            {
                Last.Text = "Last Name Must be between 3 and 15 characters";
                Last.ForeColor = Color.Red;
                return;
            }
            Last.Text = "";
        }

        private void txtcombo_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        //private void txt_firstname_Leave(object sender, EventArgs e)
        //{

        //    if (string.IsNullOrWhiteSpace(txt_firstname.Text))
        //    {
        //        First.Text = "This Field is Required";
        //        First.ForeColor = Color.Red;
        //        return;
        //    }
        //    else
        //    {
        //        First.Text = "";
        //    }
        //}

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //private void txt_lastname_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txt_lastname.Text))
        //    {
        //        Last.Text = "This Field is Required";
        //        Last.ForeColor = Color.Red;
        //        return;
        //    }
        //    else
        //    {
        //        Last.Text = "";
        //    }
        //}

        //private void txtcombo_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtcombo.Text))
        //    {
        //        Gender.Text = "This field is required";
        //        Gender.ForeColor = Color.Red;
        //        //return;
        //    }
        //    else
        //    {
        //        Gender.Text = "";
        //    }
        //}

        //   private void txt_age_Leave(object sender, EventArgs e)
        //{

        //    if (string.IsNullOrWhiteSpace(txt_age.Text))
        //    {
        //        Age.Text = "This Field is Required";
        //        Age.ForeColor = Color.Red;
        //    }
        //    else
        //    {
        //        Age.Text = "";
        //    }
        //}

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                Date.Text = "Please Enter your birth date";
                Date.ForeColor = Color.Red;
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }
    }
}
