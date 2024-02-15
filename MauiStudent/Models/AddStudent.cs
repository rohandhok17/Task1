
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Maui.Controls.Shapes;
using System.Collections.ObjectModel;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

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



    private void txt_firstname_TextChanged(object sender, EventArgs e)
    {
        string firstName = Efirst.Text.Trim();

        if (string.IsNullOrWhiteSpace(firstName))
        {
            Efirst.Text = "This Field is Required";

            return;
        }

        if (firstName.Length < 3 || firstName.Length > 18 || firstName.Replace(" ", "").Length < 3)
        {
            Efirst.Text = "First Name must be between 3 and 18 characters.";

            return;

        }
        else
            Efirst.Text = "";


    }
    public AddStudent()
    {
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


        };
        Frame entryFrame = new Frame
        {
            WidthRequest = 360, HeightRequest = 40,
            BorderColor = Colors.Black,
            Padding = new Thickness(1),
            CornerRadius = 4,
            Margin = new Thickness(5, 5, 10, 20),

            Content = Efirst
        };



      
         Label  lastname = new Label
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
        Label gender = new Label
        {
            Margin = new Thickness(20,2, 10, 5),
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
        Border gender1 = new Border
        {

            WidthRequest = 360,
            HeightRequest = 40,
            Padding = new Thickness(16, 8),
            Content = new Label
            {
                FormattedText = new FormattedString
                {
                    Spans =
            {
                new Span
                {
                    Text = "Gender",
                    TextColor = Colors.Black,
                    FontSize = 14,
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
            }
        };
    
        var GenderList = new List<string>();
        GenderList.Add("Male");
        GenderList.Add("Female");
        GenderList.Add("Other");
        ;

        Picker picker = new Picker { Title = "Please Select Gender"  };
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
       
         Label   Dateofbirth = new Label
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

            Date = DateTime.Now,
              
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
       
         Label   Age = new Label
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
            Keyboard=Keyboard.Numeric,
            Placeholder = "Enter Age",
            MaxLength = 2
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
        EAge.TextChanged += (sender, e) =>
        {
            if (!string.IsNullOrEmpty(EAge.Text))
            {
                int enteredAge = Convert.ToInt32(EAge.Text);
                DateTime calculatedDateOfBirth = CalculateDateOfBirth(enteredAge);
                datePicker.Date = calculatedDateOfBirth;
            }
        };
        datePicker.DateSelected += (sender, e) =>
        {
            DateTime selectedDate = e.NewDate;
            int age = CalculateAge(selectedDate);
            EAge.Text = age.ToString();
        };

        
        Label    Class = new Label
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
        
        Entry EAddress = new Entry
        {
            
            Placeholder = "Please Enter Address",
        };
        Frame entryFrame6 = new Frame
        {
            WidthRequest = 360,
            HeightRequest = 40,
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

        Save.Clicked +=  (sender, e) =>
        {
            Student newStudent = new Student
            {
                FirstName = Efirst.Text ?? string.Empty,
                LastName = Elast.Text ?? string.Empty,
                Gender = picker.SelectedItem?.ToString() ?? string.Empty,
                DateOfBirth = datePicker?.Date ?? DateTime.MinValue,
                Age = string.IsNullOrEmpty(EAge?.Text) ? 0 : Convert.ToInt32(EAge.Text),
                Class = EClass.Text ?? string.Empty,
                Address = EAddress.Text ?? string.Empty
            };
          

            
            StudentService.AddStudent(newStudent);
           
            Navigation.PushAsync(new OurStudent());
            
        


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
    border ,entryFrame,lastname,entryFrame1,gender,entryFrame2,Dateofbirth,entryFrame3,Age,entryFrame4 ,Class,entryFrame5,Address,entryFrame6, Save,Cancel
            }
        };
        ScrollView scrollView = new ScrollView 
        { 
            Content = stackLayout
   
        };
       
        Content =scrollView;
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


