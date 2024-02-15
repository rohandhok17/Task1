using Microsoft.Extensions.Logging.Abstractions;
using StudentManagement;
using System.Collections.ObjectModel;
//using static System.Net.Mime.MediaTypeNames;

namespace MauiStudent.Models;

public class EditStudent : ContentPage
{
    private Entry Efirst;
    private Entry Elast;
    private Picker picker;
    private DatePicker datePicker;
    private Entry EAge;
    private Entry EClass;
    private Entry EAddress;
    int CalculateAge(DateTime dateOfBirth)
    {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - dateOfBirth.Year;

        
        if (currentDate < dateOfBirth.AddYears(age))
        {
            age--;
        }

        return age;
    }

   
    DateTime CalculateDateOfBirth(int age)
    {
        DateTime currentDate = DateTime.Now;
        int yearOfBirth = currentDate.Year - age;

 
        DateTime dateOfBirth = new DateTime(yearOfBirth, 1, 1);

        return dateOfBirth;
    }
    public EditStudent(int id)
	{
        
        Title = "EditStudent";
        Student studentToEdit = StudentService.GetStudent(id);

        
        Border border = new Border
        {

            Background = Color.FromArgb("#498ba3"),
            StrokeThickness = 4,
            Padding = new Thickness(16, 8),



            Content = new Label
            {
                Text = "FirstName",
                TextColor = Colors.White,
                FontSize = 14,
                FontAttributes = FontAttributes.Bold
            }
        };
        Label firstname = new Label
        {
            
            Text="FirstName"


        };
        Frame frame = new Frame
        {
            Padding = new Thickness(5),
            BorderColor = Colors.Black, // Set the border color as needed
            CornerRadius = 5 // Set the corner radius as needed
        };

        Entry Efirst = new Entry
        {
            Text = studentToEdit.FirstName,
            Placeholder = "Please Enter First Name",
            MaxLength = 15
        };

        frame.Content = Efirst;
        Border lastname = new Border
        {

            Background = Color.FromArgb("#498ba3"),
            StrokeThickness = 4,
            Padding = new Thickness(16, 8),



            Content = new Label
            {
                Text = "LastName",
                TextColor = Colors.White,
                FontSize = 14,
                FontAttributes = FontAttributes.Bold
            }
        };
       
        Entry Elast = new Entry
        {
            Text = studentToEdit.LastName,
            Placeholder = "Please Enter Last Name",
            MaxLength = 18
        };
        Border gender = new Border
        {

            Background = Color.FromArgb("#498ba3"),
            StrokeThickness = 4,
            Padding = new Thickness(16, 8),



            Content = new Label
            {
                Text = "Gender",
                TextColor = Colors.White,
                FontSize = 14,
                FontAttributes = FontAttributes.Bold
            }
        };

        var GenderList = new List<string>
        {
         "Male",
        "Female",
        "Other"
        };

        Picker picker = new Picker
        {
            Title = "Please Select Gender",
            ItemsSource = GenderList
        };

        // Set the default selected item based on studentToEdit.Gender
        picker.SelectedItem = studentToEdit.Gender;


        Border Dateofbirth = new Border
        {

            Background = Color.FromArgb("#498ba3"),
            StrokeThickness = 4,
            Padding = new Thickness(16, 8),



            Content = new Label
            {
                Text = "DateOfBirth",
                TextColor = Colors.White,
                FontSize = 14,
                FontAttributes = FontAttributes.Bold
            }
        };
     

        DatePicker datePicker = new DatePicker
        {
            
            MinimumDate = new DateTime(1924, 1, 1),
            MaximumDate = new DateTime(2024, 12, 31),
            Format="dd-MM-yyyy",
            Date =studentToEdit.DateOfBirth??DateTime.Now,
            
        };
        
       

        Border Age = new Border
        {

            Background = Color.FromArgb("#498ba3"),
            StrokeThickness = 4,
            Padding = new Thickness(16, 8),



            Content = new Label
            {
                Text = "Age",
                TextColor = Colors.White,
                FontSize = 14,
                FontAttributes = FontAttributes.Bold
            }
        };

        
        Entry EAge = new Entry
        {
            Text = studentToEdit.Age?.ToString(),
            Keyboard = Keyboard.Numeric,
            Placeholder = "Enter Age",
            MaxLength = 2
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
        Border Class = new Border
        {

            Background = Color.FromArgb("#498ba3"),
            StrokeThickness = 4,
            Padding = new Thickness(16, 8),



            Content = new Label
            {
                Text = "Class",
                TextColor = Colors.White,
                FontSize = 14,
                FontAttributes = FontAttributes.Bold
            }
        };
        //Label Class = new Label
        //{
        //    Text = "Class"


        //};
        Entry EClass = new Entry
        {
            Text = studentToEdit.Class,
            Placeholder = "Please Enter Class",
        };
        Border Address = new Border
        {

            Background = Color.FromArgb("#498ba3"),
            StrokeThickness = 4,
            Padding = new Thickness(16, 8),



            Content = new Label
            {
                Text = "Address",
                TextColor = Colors.White,
                FontSize = 14,
                FontAttributes = FontAttributes.Bold
            }
        };
        //Label Address = new Label
        //{
        //    Text = "Address"


        //};
        Entry EAddress = new Entry
        {Text = studentToEdit.Address,
            Placeholder = "Please Enter Address",
            HeightRequest = 50
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
            //
           // // Validate input fields before saving
           //if (string.IsNullOrWhiteSpace(Efirst.Text) || string.IsNullOrWhiteSpace(Elast.Text) ||
           //     picker.SelectedItem == null || datePicker.Date == null ||
           //     string.IsNullOrWhiteSpace(EClass.Text) || string.IsNullOrWhiteSpace(EAddress.Text))
           // {
               
           //     return;
           // }

            
            studentToEdit.FirstName = Efirst.Text.Trim();
            studentToEdit.LastName = Elast.Text.Trim();
            studentToEdit.Gender = picker.SelectedItem.ToString().Trim();
            studentToEdit.DateOfBirth = datePicker.Date;
            studentToEdit.Age = string.IsNullOrEmpty(EAge?.Text) ? 0 : Convert.ToInt32(EAge.Text);
            studentToEdit.Class = EClass.Text.Trim();
            studentToEdit.Address = EAddress.Text.Trim();

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
            TextColor=Colors.Red,
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
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,

        };

        Cancel.Clicked += (sender, e) =>
        {
            Navigation.PushAsync(new OurStudent());

        };
       
        StackLayout stackLayout =new StackLayout 
        
        {
            Children = {
             border,Efirst,lastname,Elast,gender,picker,Dateofbirth,datePicker,Age,EAge ,Class,EClass,Address,EAddress,Save,Delete
            }


        };
        ScrollView scrollView = new ScrollView
        {
            Content = stackLayout

        };

        Content = scrollView;

       

    }
    
    
}