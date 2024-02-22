using Microsoft.Maui.Graphics;
using StudentManagement;
using System.Text.RegularExpressions;
namespace DemoMaui.Views;

public class EditStudent : ContentPage
{
   
        private Entry Efirst;
        private Entry Elast;
        private Picker picker;
        private DatePicker datePicker;
        private Entry EAge;
        private Entry EClass;
        private Entry EAddress;
  
    public EditStudent(int id)
        {

            Title = "EditStudent";
            Student studentToEdit = StudentService.GetStudent(id);
        

        //Border border = new Border
        //{

        //    Background = Color.FromArgb("#498ba3"),
        //    StrokeThickness = 4,
        //    Padding = new Thickness(16, 8),



        //    Content = new Label
        //    {
        //        Text = "FirstName",
        //        TextColor = Colors.White,
        //        FontSize = 14,
        //        FontAttributes = FontAttributes.Bold
        //    }
        //};
        //Label firstname = new Label
        //{

        //    Text = "FirstName"


        //};
        //Frame frame = new Frame
        //{
        //    Padding = new Thickness(5),
        //    BorderColor = Colors.Black, // Set the border color as needed
        //    CornerRadius = 5 // Set the corner radius as needed
        //};

        //Entry Efirst = new Entry
        //{
        //    Text = studentToEdit.FirstName,
        //    Placeholder = "Please Enter First Name",
        //    MaxLength = 15
        //};

        //frame.Content = Efirst;

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
           Text=studentToEdit.FirstName,
            Placeholder = "Please Enter First Name",
            MaxLength = 15,


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
        Label errorfirst = new Label
        {


            TextColor = Colors.White,
            FontSize = 12,
            Margin = new Thickness(16, -6, 20, 5),
            IsVisible = true
        };
        Efirst.TextChanged += (sender, e) =>
        {
            //var newText = Regex.Replace(Efirst.Text, @"^(?=(?:.*[^\s]){3})\s*\S(?:\s*\S){2,}\s*$", "");

            var newText = Regex.Replace(Efirst.Text, @"[^a-zA-Z\s]+$", "");

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
            Text = studentToEdit.LastName,
            Placeholder = "Please Enter Last Name",
            MaxLength = 18,

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
        //Border lastname = new Border
        //    {

        //        Background = Color.FromArgb("#498ba3"),
        //        StrokeThickness = 4,
        //        Padding = new Thickness(16, 8),



        //        Content = new Label
        //        {
        //            Text = "LastName",
        //            TextColor = Colors.White,
        //            FontSize = 14,
        //            FontAttributes = FontAttributes.Bold
        //        }

        //    };

        //    Entry Elast = new Entry
        //    {
        //        Text = studentToEdit.LastName,
        //        Placeholder = "Please Enter Last Name",
        //        MaxLength = 18
        //    };
        //Border gender = new Border
        //    {

        //        Background = Color.FromArgb("#498ba3"),
        //        StrokeThickness = 4,
        //        Padding = new Thickness(16, 8),



        //        Content = new Label
        //        {
        //            Text = "Gender",
        //            TextColor = Colors.White,
        //            FontSize = 14,
        //            FontAttributes = FontAttributes.Bold
        //        }
        //    };

        //    var GenderList = new List<string>
        //{
        // "Male",
        //"Female",
        //"Other"
        //};

        //    Picker picker = new Picker
        //    {
        //        Title = "Please Select Gender",
        //        ItemsSource = GenderList
        //    };

        //    // Set the default selected item based on studentToEdit.Gender
        //    picker.SelectedItem = studentToEdit.Gender;
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
        picker.ItemsSource = GenderList; picker.SelectedItem = studentToEdit.Gender; 
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
            Date = studentToEdit.DateOfBirth.Value


        };

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


        //DatePicker datePicker = new DatePicker
        //    {

        //        MinimumDate = new DateTime(1924, 1, 1),
        //        MaximumDate = new DateTime(2024, 12, 31),
        //        Format = "dd-MM-yyyy",
        //        Date = studentToEdit.DateOfBirth.Value

        //    };

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
            Text = studentToEdit.Age.ToString(),
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

        //Border Age = new Border
        //    {

        //        Background = Color.FromArgb("#498ba3"),
        //        StrokeThickness = 4,
        //        Padding = new Thickness(16, 8),



        //        Content = new Label
        //        {
        //            Text = "Age",
        //            TextColor = Colors.White,
        //            FontSize = 14,
        //            FontAttributes = FontAttributes.Bold
        //        }
        //    };


        //    Entry EAge = new Entry
        //    {
        //        Text = studentToEdit.Age.ToString(),
        //        Keyboard = Keyboard.Numeric,
        //        Placeholder = "Enter Age",
        //        MaxLength = 2
        //    };

        //Border Class = new Border
        //{

        //    Background = Color.FromArgb("#498ba3"),
        //    StrokeThickness = 4,
        //    Padding = new Thickness(16, 8),



        //    Content = new Label
        //    {
        //        Text = "Class",
        //        TextColor = Colors.White,
        //        FontSize = 14,
        //        FontAttributes = FontAttributes.Bold
        //    }
        //};
        //Label Class = new Label
        //{
        //    Text = "Class"


        //};
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
            Text = studentToEdit.Class,
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
            Text = studentToEdit.Address,
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
        //Entry EClass = new Entry
        //    {
        //        Text = studentToEdit.Class,
        //        Placeholder = "Please Enter Class",
        //    };
        //    Border Address = new Border
        //    {

        //        Background = Color.FromArgb("#498ba3"),
        //        StrokeThickness = 4,
        //        Padding = new Thickness(16, 8),



        //        Content = new Label
        //        {
        //            Text = "Address",
        //            TextColor = Colors.White,
        //            FontSize = 14,
        //            FontAttributes = FontAttributes.Bold
        //        }
        //    };
        //    //Label Address = new Label
        //    //{
        //    //    Text = "Address"


        //    //};
        //    Editor EAddress = new Editor
        //    {
        //        Text = studentToEdit.Address,
        //        Placeholder = "Please Enter Address",
        //        HeightRequest = 50
        //    };
            datePicker.DateSelected += (sender, e) =>
            {

                int age = DateTime.Now.Year - e.NewDate.Year;


                if (DateTime.Now.DayOfYear < e.NewDate.DayOfYear)
                {
                    age--;
                }


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
            Button Save = new Button
            {
                Background = Color.FromArgb("#498ba3"),
                FontSize = 20,
                Margin = 5,
                Text = "Save",


            };
            Save.Clicked += (sender, e) =>
            {
                if ((string.IsNullOrEmpty(Efirst.Text)) || (Efirst.Text.Trim().Length < 3 || Efirst.Text.Trim().Length > 15) ||
     (string.IsNullOrEmpty(Elast.Text)) || (Elast.Text.Trim().Length < 3 || Elast.Text.Trim().Length > 15) ||
     picker.SelectedItem == null ||
     (string.IsNullOrEmpty(EAge.Text) || !int.TryParse(EAge.Text, out int age) || age < 5 || age > 99) ||
     datePicker.Date == DateTime.Today)
                {
                    if (string.IsNullOrEmpty(Efirst.Text))
                    {
                        errorfirst.Text = "This Field is Required";
                        errorfirst.TextColor = Colors.Red;

                    }
                    else if ((Efirst.Text.Trim().Length < 3 || Efirst.Text.Trim().Length > 15))
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
                    else if ((Elast.Text.Trim().Length < 2 || Elast.Text.Trim().Length > 18))
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



                studentToEdit.FirstName = Efirst.Text.Trim();
                studentToEdit.LastName = Elast.Text.Trim();
                studentToEdit.Gender = picker.SelectedItem.ToString().Trim();
                studentToEdit.DateOfBirth = datePicker.Date;
                studentToEdit.Age = int.Parse(EAge.Text.Trim());
                studentToEdit.Class = EClass.Text.Trim() ?? string.Empty;
                studentToEdit.Address = EAddress.Text.Trim() ?? string.Empty;

                try
                {

                    StudentService.UpdateStudent(studentToEdit);
                   

                    Navigation.PushAsync(new OurStudent());

                }
                catch (Exception ex)
                {


                }

            };
            Button Delete = new Button
            {
                Background = Colors.Gray,
                FontSize = 20,
                Margin = 5,
                TextColor = Colors.Red,
                Text = "Delete",


            };
            Delete.Clicked += async (sender, e) =>
            {
                bool confirmed = await DisplayAlert("Confirm", "Are you sure you want to delete this student record?", "Yes", "No");

                if (confirmed)
                {

                    if (id != null)
                    {
                        StudentService.DeleteStudent(id);


                        Navigation.PushAsync(new OurStudent());
                    }
                    else
                    {

                        await DisplayAlert("Error", "Student ID is null", "OK");
                    }
                }
            };


            Button Cancel = new Button
            {
                Background = Color.FromArgb("#498ba3"),
                FontSize = 20,
                Margin = 5,
                Text = "Cancel",


            };

            Cancel.Clicked += (sender, e) =>
            {
               Navigation.PushAsync(new OurStudent());

            };

            StackLayout stackLayout = new StackLayout

            {
                Children = {
             border,entryFrame,errorfirst,lastname,entryFrame1,errorlast,gender,entryFrame2,errorgender,Dateofbirth,entryFrame3,errordate,Age,entryFrame4,errorAge,Class,entryFrame5,Address,entryFrame6,Save,Delete,Cancel
            }


            };
            ScrollView scrollView = new ScrollView
            {
                Content = stackLayout

            };

            Content = scrollView;



        }


    }
