



using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Platform;
using System.Collections.ObjectModel;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

using static System.Net.Mime.MediaTypeNames;

namespace MauiStudent.Models;

public class AddStudent : ContentPage
{

    public ObservableCollection<Student> students { get; set; }
    List<Student> listOfStudent = new List<Student>();
    private Entry Efirst;
    private Entry Elast;
    private Picker picker;
    private DatePicker datePicker;
    private Entry EAge;
    private Entry EClass;
    private Entry EAddress;


    private Action updateAction;


    public AddStudent(Action updateAction)
    {
        this.updateAction = updateAction;
        Title = "AddStudent";

        
        Label border = new Label
        {
            Margin = new Thickness(20, 2, 10, 5),
            FormattedText = new FormattedString
            {
                Spans =
            {
                new Span
                {
                    Text = "FirstName",
                    TextColor = Colors.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.Bold
                },
                new Span
                {
                    Text = " *",
                    TextColor = Colors.Red,
                    FontSize = 14,
                    FontAttributes = FontAttributes.Bold
                }
            }
            }

        };

        Entry Efirst = new Entry
        {
            ClassId = "FirstNameEntry",
            Placeholder = "Please Enter First Name",
            MaxLength = 15,
           Keyboard = Keyboard.Text,
        };
        Label errorfirst = new Label
        {
            

            TextColor = Colors.White,
            FontSize = 12,
            Margin = new Thickness(16, -6, 20,5),
            IsVisible = true
        };

        Frame entryFrame = new Frame
        {
            WidthRequest = 360,
            HeightRequest = 40,
            BorderColor = Colors.Black,
            Padding = new Thickness(1),
            CornerRadius = 4,
            Margin = new Thickness(5, 10, 10, 6),

            Content = Efirst
        };

        Efirst.TextChanged += (sender, e) =>
        {
            //var newText = Regex.Replace(Efirst.Text, @"^(?=(?:.*[^\s]){3})\s*\S(?:\s*\S){2,}\s*$", "");

            var newText = Regex.Replace(Efirst.Text, @"[^a-zA-Z\s\S]+", " ");
            if (Efirst.Text != newText)
            {
                Efirst.Text = newText;
            }

            if (string.IsNullOrEmpty(Efirst.Text) || Efirst.Text.Trim().Length < 3 || Efirst.Text.Trim().Length > 15)
            {
                if (string.IsNullOrEmpty(Efirst.Text))
                {
                    errorfirst.Text = "This Field is required";
                    errorfirst.TextColor = Colors.Red;
                    errorfirst.IsVisible = true;
                }
                else if (Efirst.Text.Trim().Length < 3 || Efirst.Text.Trim().Length > 15)
                {
                    errorfirst.Text = "First Name must be between 3 and 15 characters.";
                    errorfirst.TextColor = Colors.Red;
                    errorfirst.IsVisible = true;
                }
            }
            else
            {

                errorfirst.Text = "";
                errorfirst.TextColor = Colors.White;
                errorfirst.IsVisible = false;
            }
        };



        Label lastname = new Label
        {
            Margin = new Thickness(20, 2, 10, 5),
            FormattedText = new FormattedString
            {
                Spans =
            {
                new Span
                {
                    Text = "LastName",
                    TextColor = Colors.Black,
                     FontSize = 16,
                    FontAttributes = FontAttributes.Bold
                },
                new Span
                {
                    Text = " *",
                    TextColor = Colors.Red,
                    FontSize = 14,
                    FontAttributes = FontAttributes.Bold
                }
            }
            }

        };

        Entry Elast = new Entry
        {

            Placeholder = "Please Enter Last Name",
            MaxLength = 18,
            Keyboard = Keyboard.Text,

        };
        Label errorlast = new Label
        {

            TextColor = Colors.White,
            FontSize = 12,
            Margin = new Thickness(16, -16, 20, 5),
            IsVisible = true
        };
        Frame entryFrame1 = new Frame
        {
            WidthRequest = 360,
            HeightRequest = 40,
            CornerRadius = 4,
            BorderColor = Colors.Black,
            Padding = new Thickness(2),
            Margin = new Thickness(5, 5, 10, 20),

            Content = Elast
        };
        Elast.TextChanged += (sender, e) =>
        {
            var newText = Regex.Replace(Elast.Text, @"[^a-zA-Z\s]", "");
            if (Elast.Text != newText)
            {
                Elast.Text = newText;
            }
            if (string.IsNullOrEmpty(Elast.Text) || Elast.Text.Trim().Length < 2 || Elast.Text.Trim().Length > 18)
            {
                if (string.IsNullOrEmpty(Elast.Text))
                {
                    errorlast.Text = "This Field is Required";
                    errorlast.TextColor = Colors.Red;
                    errorlast.IsVisible = true;
                }
                else if (Elast.Text.Trim().Length < 2 || Elast.Text.Trim().Length > 18)
                {
                    errorlast.Text = "Last Name must be between 2 and 18 characters";
                    errorlast.TextColor = Colors.Red;
                    errorlast.IsVisible = true;
                }
            }
            else
            {
                errorlast.Text = "";
                errorlast.TextColor = Colors.White;
                errorlast.IsVisible = false;
            }


        };

        Label gender = new Label
        {
            Margin = new Thickness(20, 2, 10, 5),
            FormattedText = new FormattedString
            {
                Spans =
                {
                    new Span
                    {
                        Text = "Gender",
                        TextColor = Colors.Black,
                         FontSize = 16,
                        FontAttributes = FontAttributes.Bold
                    },
                    new Span
                    {
                        Text = " *",
                        TextColor = Colors.Red,
                        FontSize = 14,
                        FontAttributes = FontAttributes.Bold
                    }
                }
            }
        };

        var GenderList = new List<string>();
        GenderList.Add("Male");
        GenderList.Add("Female");
        GenderList.Add("Other");
        ;

        Picker picker = new Picker { Title = "Please Select Gender" };
        picker.ItemsSource = GenderList;
        Frame entryFrame2 = new Frame
        {
            WidthRequest = 360,
            HeightRequest = 40,
            BorderColor = Colors.Black,
            CornerRadius = 4,
            Padding = new Thickness(2, 1, 2, 10),
            Margin = new Thickness(5, 5, 10, 20),
            Content = new StackLayout
            {
                Children =
        {
            picker
        }
            }
        };
        Label errorgender = new Label
        {
            Text = "This field is required",
            TextColor = Colors.White,
            FontSize = 12,
            Margin = new Thickness(16, -10, 20, 5),
            IsVisible = true
        };
        picker.SelectedIndexChanged += (sender, args) =>
        {
            errorgender.IsVisible = string.IsNullOrEmpty(picker.SelectedItem?.ToString());
        };


        Label Dateofbirth = new Label
        {
            Margin = new Thickness(20, 2, 10, 5),
            FormattedText = new FormattedString
            {
                Spans =
            {
                new Span
                {
                    Text = "DateOfBirth",
                    TextColor = Colors.Black,
                     FontSize = 16,
                    FontAttributes = FontAttributes.Bold
                },
                new Span
                {
                    Text = " *",
                    TextColor = Colors.Red,
                    FontSize = 14,
                    FontAttributes = FontAttributes.Bold
                }
            }
            }

        };


        DatePicker datePicker = new DatePicker
        {
            MinimumDate = new DateTime(1924, 1, 1),
            MaximumDate = new DateTime(2024, 12, 31),
            Format = "dd-MM-yyyy",
            //Date = studentToEdit.DateOfBirth.Value
            Date =DateTime.Today,

        };
        //datePicker.DateSelected += (sender, args) =>
        //{
        //    if (datePicker.Date == DateTime.Today)
        //    {
        //        errordate.Text = "This field is Required";
        //    }
        //};
        Label errordate = new Label
        {
            Text = "This field is required",
            TextColor = Colors.White,
            FontSize = 12,
            Margin = new Thickness(16, -10, 20, 5),
            IsVisible = true
        };
        Frame entryFrame3 = new Frame
        {
            WidthRequest = 360,
            HeightRequest = 40,
            BorderColor = Colors.Black,
            Padding = new Thickness(1),
            Margin = new Thickness(5, 5, 10, 20),
            CornerRadius = 4,
            Content = new StackLayout
            {
                Children =
        {
            datePicker
        }
            }
        };

        Label Age = new Label
        {
            Margin = new Thickness(20, 2, 10, 5),
            FormattedText = new FormattedString
            {
                Spans =
            {
                new Span
                {
                    Text = "Age",
                    TextColor = Colors.Black,
                     FontSize = 16,
                    FontAttributes = FontAttributes.Bold
                },
                new Span
                {
                    Text = " *",
                    TextColor = Colors.Red,
                    FontSize = 14,
                    FontAttributes = FontAttributes.Bold
                }
            }
            }


        };


        Entry EAge = new Entry
        {
            Keyboard = Keyboard.Numeric,
            Placeholder = "Enter Age",
            MaxLength = 2
        };
        Label errorAge = new Label
        {

            TextColor = Colors.White,
            FontSize = 12,
            Margin = new Thickness(16, -16, 20, 5),
            IsVisible = true
        };
        Frame entryFrame4 = new Frame
        {
            WidthRequest = 360,
            HeightRequest = 40,
            BorderColor = Colors.Black,
            Padding = new Thickness(1),
            Margin = new Thickness(5, 5, 10, 20),
            CornerRadius = 4,
            Content = EAge
        };
       // EAge.TextChanged += OnAgeTextChanged;
        EAge.TextChanged += (sender, e) =>
       {
           if (string.IsNullOrEmpty(EAge.Text) || !int.TryParse(EAge.Text, out int age) || age < 5 || age > 99)
           {
               if (string.IsNullOrEmpty(EAge.Text))
               {

                   errorAge.Text = "This field is required";
                   errorAge.TextColor = Colors.Red;
                   errorAge.IsVisible = true;
               }
               else if (!int.TryParse(EAge.Text, out int age1) || age1 < 5 || age1 > 99)
               {
                   errorAge.Text = "Age must be between 5 and 99";
                   errorAge.TextColor = Colors.Red;
                   errorAge.IsVisible = true;
               }
           }
           else
           {

               errorAge.TextColor = Colors.White;

           }
       };
        DateTime selectedDate = DateTime.Now;
        datePicker.DateSelected += (sender, e) =>
        {

            selectedDate = e.NewDate;

            // Calculate age based on the selected date
            int age = DateTime.Now.Year - e.NewDate.Year;

            // Update the text of a control with the calculated age
            EAge.Text = age.ToString();

        };

       
        EAge.TextChanged += (sender, e) =>
        {
            if (int.TryParse(EAge.Text, out int age))
            {
                
                DateTime birthdate = DateTime.Now.AddYears(-age);

               
                datePicker.Date = birthdate;
            }
            
        };




        Label Class = new Label
        {
            Margin = new Thickness(20, 2, 10, 5),
            FormattedText = new FormattedString
            {
                Spans =
            {
                new Span
                {
                    Text = "Class",
                     TextColor = Colors.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.Bold
                },

            }
            }

        };

        Entry EClass = new Entry
        {

            Placeholder = "Please Enter Class",
        };
        Frame entryFrame5 = new Frame
        {
            WidthRequest = 360,
            HeightRequest = 40,
            BorderColor = Colors.Black,
            Padding = new Thickness(1),
            Margin = new Thickness(5, 5, 10, 20),
            CornerRadius = 4,
            Content = EClass
        };

        Label Address = new Label
        {
            Margin = new Thickness(20, 2, 10, 5),
            FormattedText = new FormattedString
            {
                Spans =
            {
                new Span
                {
                    Text = "Address",
                    TextColor = Colors.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.Bold
                },

            }
            }

        };

        Editor EAddress = new Editor
        {
            Margin = new Thickness(5, 5, 10, 10),
            
            Placeholder = "Please Enter Address",
        };
        Frame entryFrame6 = new Frame
        {
            WidthRequest = 360,
            HeightRequest = 80,
            BorderColor = Colors.Black,
            Padding = new Thickness(1),
            Margin = new Thickness(5, 5, 10, 20),
            CornerRadius = 4,
            Content = EAddress
        };

        Button Cancel = new Button
        {
            Background = Color.FromArgb("#498ba3"),
            FontSize = 20,
            Margin = 5,
            Text = "Cancel",


        };
        Button Save = new Button
        {
            Background = Color.FromArgb("#498ba3"),
            FontSize = 20,
            Margin = 5,
            Text = "Save",



        };

        Save.Clicked += async (sender, e) =>
        {

            // Validate input fields before saving
            if ((string.IsNullOrEmpty(Efirst.Text)) || (Efirst.Text.Trim().Length < 3 || Efirst.Text.Trim().Length > 15) ||
            (string.IsNullOrEmpty(Elast.Text)) || (Elast.Text.Trim().Length < 3 || Elast.Text.Trim().Length > 15) ||
            picker.SelectedItem == null ||
            (string.IsNullOrEmpty(EAge.Text) || !int.TryParse(EAge.Text, out int age) || age < 5 || age > 99) ||
            datePicker.Date == DateTime.Today)
            {
                if(string.IsNullOrEmpty(Efirst.Text))
                {
                    errorfirst.Text = "This Field is Required";
                    errorfirst.TextColor = Colors.Red;

                }
                else if((Efirst.Text.Trim().Length < 3 || Efirst.Text.Trim().Length > 15))
                {
                    errorfirst.Text = "Last Name must be between 3 and 15 characters";
                    errorfirst.TextColor = Colors.Red;
                    errorfirst.IsVisible = true;
                }
                if (string.IsNullOrEmpty(Elast.Text))
                {
                    errorlast.Text = "This Field is Required";
                    errorlast.TextColor = Colors.Red;
                }
                else if((Elast.Text.Trim().Length<2 || Elast.Text.Trim().Length > 18))
                {
                    errorlast.Text = "Last Name must be between 2 and 18 characters";
                    errorlast.TextColor = Colors.Red;
                    errorlast.IsVisible = true;
                }
                if (picker.SelectedItem == null)
                {
                    errorgender.Text = "This Field is Required";
                    errorgender.TextColor = Colors.Red;
                    errorgender.IsVisible = true;
                }
                if (datePicker.Date == DateTime.Today)
                {
                    errordate.Text = "This Field is Required";
                    errordate.TextColor = Colors.Red;
                    errordate.IsVisible = true; 

                }
                if (string.IsNullOrEmpty(EAge.Text))
                {

                    errorAge.Text = "This field is required";
                    errorAge.TextColor = Colors.Red;
                    errorAge.IsVisible = true;
                }
                else if (!int.TryParse(EAge.Text, out int age1) || age1 < 5 || age1 > 99)
                {
                    errorAge.Text = "Age must be between 5 and 99";
                    errorAge.TextColor = Colors.Red;
                    errorAge.IsVisible = true;
                }
                return;
            }
            else
            {
                errorfirst.TextColor = Colors.White;
                errorlast.TextColor = Colors.White;
            }

            Student newStudent = new Student
            {
                FirstName = Efirst.Text ?? string.Empty,
                LastName = Elast.Text ?? string.Empty,
                Gender = picker.SelectedItem.ToString().Trim(),
                DateOfBirth = datePicker?.Date ?? DateTime.MinValue,
                Age = int.Parse(EAge.Text.Trim()),
                Class = EClass.Text ?? string.Empty,
                Address = EAddress.Text ?? string.Empty
            };



            StudentService.AddStudent(newStudent);

            updateAction?.Invoke();
            await Navigation.PushAsync(new OurStudent());




        };


        Cancel.Clicked += (sender, e) =>
        {
            Navigation.PopAsync();

        };
        Label Addstudent = new Label
        {
            TextColor = Colors.SteelBlue,

            Text = "AddStudent",
            FontSize = 25,
            HorizontalOptions = LayoutOptions.Fill,

        };
        var cancelButton = new Button
        {
            Text = "Cancel",
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

        cancelButton.Clicked += async (sender, args) =>
        {
            await Navigation.PopAsync();
        };


        StackLayout stackLayout = new StackLayout
        {
            Children = {
    border ,entryFrame,errorfirst,lastname,entryFrame1,errorlast,gender,entryFrame2,errorgender,Dateofbirth,entryFrame3,errordate,Age,entryFrame4,errorAge ,Class,entryFrame5,Address,entryFrame6, Save,Cancel
            }
        };
        ScrollView scrollView = new ScrollView
        {
            Content = stackLayout

        };

        Content = scrollView;
    }



    private int CalculateAge(DateTime dateOfBirth)
    {
        try
        {
            if (dateOfBirth > DateTime.Now || dateOfBirth.Year < 1900)
            {

                throw new ArgumentException("Invalid date of birth");
            }

            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - dateOfBirth.Year;


            if (currentDate < dateOfBirth.AddYears(age))
            {
                age--;
            }

            return age;
        }
        catch (Exception ex)
        {

            throw;


        }
    }



    private DateTime CalculateDateOfBirth(int age)
    {
        try
        {
            if (age <= 0)
            {

            }

            DateTime currentDate = DateTime.Now;
            int yearOfBirth = currentDate.Year - age;

            if (yearOfBirth < DateTime.MinValue.Year || yearOfBirth > DateTime.MaxValue.Year)
            {

            }


            DateTime dateOfBirth = new DateTime(yearOfBirth, 1, 1);

            return dateOfBirth;
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Exception: {ex.Message}");


            throw;

        }
    }



}


