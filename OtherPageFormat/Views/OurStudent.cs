using StudentManagement;
namespace OtherPageFormat.Views;

public class OurStudent : ContentView
{
    public static Student student2;
    private List<Student> students;
    List<Student> filterStudent;
    ListView studentListView;
    public OurStudent()
	{
       
            students = StudentService.GetStudents();
           
            Entry search = new Entry
            {
                Placeholder = "Search...",
            };
            Frame frameWithBorder = new Frame
            {
                Margin = 5,

                BorderColor = Colors.SteelBlue,
                CornerRadius = 5,
                Padding = new Thickness(5),
                Content = search
            };
            search.TextChanged += Search_TextChanged;
            studentListView = new ListView
            {

                Margin = new Thickness(10, 10, 10, 10),

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
                    grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
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
            studentListView.ItemsSource = students;
            if (students.Any())
            {
                studentListView.SelectedItem = students[0];
            }


            studentListView.ItemTapped += (sender, e) =>


            {

                if (e.Item is Student selectedStudent)
                {

                    Student studentToEdit = StudentService.GetStudent(selectedStudent.Id);


                    if (studentToEdit != null)
                    {

                     //   Navigation.PushAsync(new EditStudent(studentToEdit.Id));
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

               // Navigation.PushAsync(new AddStudent());
               // NavigationPage.SetHasBackButton(this, false);


               

            };
            Content = new StackLayout
            {
                Children = {

               frameWithBorder,
                studentListView,add


            }
            };
        }
        private void Search_TextChanged(object? sender, TextChangedEventArgs e)
        {
            string searchText = e.NewTextValue;

            filterStudent = students.Where(s => s.FirstName.ToLower().Contains(searchText.ToLower()) ||
                s.LastName.ToLower().Contains(searchText.ToLower()) || s.Age.ToString().Contains(searchText.ToLower())).ToList();

            studentListView.ItemsSource = filterStudent;
            if (filterStudent.Any())
            {
                studentListView.SelectedItem = filterStudent[0];
            }
        }


    }
