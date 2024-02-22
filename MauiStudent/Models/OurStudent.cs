using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Layouts;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace MauiStudent.Models;

public class OurStudent : ContentPage
{
    private ViewCell selectedViewCell;
    public ObservableCollection<Student> students { get; set; }
    public ListView StudentListView { get; set; }

   


    public OurStudent()
    {
        Title = "OurStudent";
     
     NavigationPage.SetHasBackButton(this, false);




        //collectionView.ItemTemplate = new DataTemplate(() =>
        //{
        //    Grid grid = new Grid { Padding = 10 };
        //    grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
        //    grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
        //    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
        //    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

        //            var nameLabel = new Label { FontSize = 17 };
        //           nameLabel.SetBinding(Label.TextProperty, "FirstName");


        //            var lastLabel = new Label { FontSize = 17 };
        //           lastLabel.SetBinding(Label.TextProperty, "LastName");

        //           // var genderLabel = new Label { FontSize = 17 };
        //           //genderLabel.SetBinding(Label.TextProperty, "Gender");

        //           //var ageLabel = new Label { FontSize = 17 };
        //           // ageLabel.SetBinding(Label.TextProperty, "Age");

        //           // var classLabel = new Label { FontSize = 17 };
        //           // classLabel.SetBinding(Label.TextProperty, "Class");

        //    //Label nameLabel = new Label { FontAttributes = FontAttributes.Bold };
        //    //nameLabel.SetBinding(Label.TextProperty, "Name");

        //    //Label locationLabel = new Label { FontAttributes = FontAttributes.Italic, VerticalOptions = LayoutOptions.End };
        //    //locationLabel.SetBinding(Label.TextProperty, "Location");




        //    grid.Add(nameLabel, 1, 0);
        //    grid.Add(lastLabel, 1, 1);

        //    return grid;
        //});

        StudentListView = new ListView
        {


            Margin = new Thickness(25, 10, 10, 10),
           
            ItemsSource = StudentService.GetStudentsAll(),
            ItemTemplate = new DataTemplate(() =>
            {
                var nameLabel = new Label { FontSize = 17 };
                Grid.SetColumn(nameLabel, 0);
                Grid.SetRow(nameLabel, 0);
                nameLabel.SetBinding(Label.TextProperty, "FirstName");


                var lastLabel = new Label { FontSize = 17 };
                Grid.SetColumn(lastLabel, 1);
                Grid.SetRow(lastLabel, 0);
                lastLabel.SetBinding(Label.TextProperty, "LastName");

                var genderLabel = new Label { FontSize = 17 };
                Grid.SetColumn(genderLabel, 4);
                Grid.SetRow(genderLabel, 0);
                genderLabel.SetBinding(Label.TextProperty, "Gender");

                var ageLabel = new Label { FontSize = 17 };
                Grid.SetColumn(ageLabel, 0); // Place in the 4th column
                Grid.SetRow(ageLabel, 1);
                ageLabel.SetBinding(Label.TextProperty, "Age");

                var classLabel = new Label { FontSize = 17 };
                Grid.SetColumn(classLabel, 4); // Place in the 4th column
                Grid.SetRow(classLabel, 1);
                classLabel.SetBinding(Label.TextProperty, "Class");

                var grid = new Grid
                {
                    ColumnDefinitions =
            {
                new ColumnDefinition { Width =new GridLength(75)}, // Name column
                new ColumnDefinition {  Width = GridLength.Star }, // Last Name column
                new ColumnDefinition { Width = GridLength.Star }, // Gender column
                new ColumnDefinition { Width = GridLength.Star }, // Age column
                new ColumnDefinition { Width = GridLength.Star }  // Class column
            }
                };
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row for the first line
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Row for the second line

                BoxView boxView = new BoxView { Color =Colors.SteelBlue,};
                grid.Add(nameLabel);
                grid.Add(lastLabel);
                grid.Add(genderLabel);
                grid.Add(ageLabel);
                grid.Add(classLabel);

                return new ViewCell
                {
                    View = grid
                   
                };
            })
        };
        




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
            Margin = new Thickness(5, 0, 5, 30),
            Background = Color.FromArgb("#498ba3"),
            Text = "Add",
            //Margin = 5,


        };
        StackLayout stacklayout = new StackLayout();
        stacklayout.Add(add);
        Content = stacklayout;
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

        add.Clicked += async(sender, args) =>
        {

            //var addStudentPage = new AddStudent(UpdateStudentData);
            await Navigation.PushAsync(new AddStudent());
            
        };
        EntryCell Age1 = new EntryCell
        {
            Label = "FirstName",
            Placeholder = "Password"
        };
        SearchBar search = new SearchBar { Placeholder = "Search....", };
        Frame frameWithBorder = new Frame
        {
            Margin = 5,

            BorderColor = Colors.SteelBlue,
            CornerRadius = 5,
            Padding = new Thickness(5),
            Content = new SearchBar
            {
                Placeholder = "Search....",

            }
        };

        //search.TextChanged += (sender, e) =>
        //{
        //    string searchText = e.NewTextValue;

        //    // Filter the students based on the search text
        //    filteredStudents = allStudents.Where(student =>
        //        student.FirstName.ToLower().Contains(searchText.ToLower()) ||
        //        student.LastName.ToLower().Contains(searchText.ToLower()) ||
        //        student.Age.ToString().Contains(searchText)
        //    ).ToList();

        //    // Update the ListView's ItemsSource with the filtered list
        //    StudentListView.ItemsSource = filteredStudents;
        //};
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

