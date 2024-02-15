using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Layouts;
using System.Collections.ObjectModel;

namespace MauiStudent.Models;

public class OurStudent : ContentPage
{
    
    public ObservableCollection<Student> students { get; set; }
    public ListView StudentListView { get; set; }

    

    public OurStudent()
    {Title = "OurStudent";


        students = new ObservableCollection<Student> {


           new Student { Id = 1, FirstName = "Rohan", LastName = "Dhok", Gender = "Male", DateOfBirth = new DateTime(2000, 4, 4), Age = 34, Class = "12th", Address = "Wardha" },
               new Student { Id = 2, FirstName = "Rahul", LastName = "Guru", Gender = "Male", DateOfBirth = new DateTime(1995, 5, 10), Age = 25, Class = "10th", Address = "Wardha" }

      };
        Grid newGrid = new Grid();

        // Header Grid
        Grid headerGrid = new Grid
        {
            ColumnDefinitions =
    {
        new ColumnDefinition { Width = GridLength.Star }, // Name column
        new ColumnDefinition { Width = GridLength.Star }, // Last Name column
        new ColumnDefinition { Width = GridLength.Star }, // Gender column
        new ColumnDefinition { Width = GridLength.Star }, // Age column
        new ColumnDefinition { Width = GridLength.Star }  // Class column
    }
        };

        headerGrid.Add(new Label { Text = "Name", FontAttributes = FontAttributes.Bold }, 0, 0);
        headerGrid.Add(new Label { Text = "Last Name", FontAttributes = FontAttributes.Bold }, 1, 0);
        headerGrid.Add(new Label { Text = "Gender", FontAttributes = FontAttributes.Bold }, 2, 0);
        headerGrid.Add(new Label { Text = "Age", FontAttributes = FontAttributes.Bold }, 3, 0);
        headerGrid.Add(new Label { Text = "Class", FontAttributes = FontAttributes.Bold }, 4, 0);

        ListView StudentListView = new ListView
        {
            
            Margin = new Thickness(25, 10, 10, 10),
            ItemsSource = StudentService.GetStudentsAll(),
            ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize=17};
                nameLabel.SetBinding(Label.TextProperty, "FirstName");
                

                var lastLabel = new Label { FontSize = 17 };
                lastLabel.SetBinding(Label.TextProperty, "LastName");

                var genderLabel = new Label { FontSize = 17 };
                genderLabel.SetBinding(Label.TextProperty, "Gender");

                var ageLabel = new Label { FontSize = 17 };
                ageLabel.SetBinding(Label.TextProperty, "Age");

                var classLabel = new Label { FontSize = 17 };
                classLabel.SetBinding(Label.TextProperty, "Class");

                var grid = new Grid
                {
                    ColumnDefinitions =
            {
                new ColumnDefinition { Width = GridLength.Star }, // Name column
                new ColumnDefinition { Width = GridLength.Star }, // Last Name column
                new ColumnDefinition { Width = GridLength.Star }, // Gender column
                new ColumnDefinition { Width = GridLength.Star }, // Age column
                new ColumnDefinition { Width = GridLength.Star }  // Class column
            }
                };

                grid.Add(nameLabel, 0, 0);
                grid.Add(lastLabel, 1, 0);
                grid.Add(genderLabel, 2, 0);
                grid.Add(ageLabel, 3, 0);
                grid.Add(classLabel, 4, 0);

                return new ViewCell
                {
                    View = grid
                };
            })
        };

        // Add header grid and data ListView to the main grid
        newGrid.Add(headerGrid);
        newGrid.Add(StudentListView);



        StudentListView.ItemTapped += (sender, e) =>
        {
            if (e.Item is Student selectedStudent)
            {

                Student studentToEdit = StudentService.GetStudent(selectedStudent.Id);

               
                if (studentToEdit != null)
                {
                   
                    Navigation.PushAsync(new EditStudent(studentToEdit.Id));
                }
                


            }
        };


        
        Button add = new Button
        {
            FontSize = 20,
            Background = Color.FromArgb("#498ba3"),
            Text = "Add",
            Margin = 5,
           
             
        };
        Border border = new Border
        {
            Stroke = Color.FromArgb("#C49B33"),
            Background = Color.FromArgb("#2B0B98"),
            StrokeThickness = 4,
            Padding = new Thickness(16, 8),
            HorizontalOptions = LayoutOptions.Center,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(40, 0, 0, 40)
            },
            Content = new Label
            {
                Text = ".NET MAUI",
                TextColor = Colors.White,
                FontSize = 18,
                FontAttributes = FontAttributes.Bold
            }
        };

        add.Clicked += (sender, e) =>
        {
           
           Navigation.PushAsync(new AddStudent());
            
        };

        Frame frameWithBorder = new Frame
        {
            Margin= 5,
            
            BorderColor = Colors.SteelBlue, 
            CornerRadius = 5, 
            Padding = new Thickness(5),
            Content = new SearchBar
            {
                Placeholder = "Search....",
               
            }
        };

        Content = new StackLayout
        {
            Children = {
              
                frameWithBorder,
                StudentListView,
                 add

            }
        };

    }
    
    

}
   
