using System.Collections.ObjectModel;

namespace MauiStudent.Models;

public class OurStudent : ContentPage
{

    public ObservableCollection<Student> studentList { get; set; }
    public OurStudent()
    {
        ObservableCollection<Student> students= new ObservableCollection<Student>();
       

        Content = new VerticalStackLayout
        {

            Children = {
                new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center,  Text = "First line\nSecond line"

                }
            }
        };
        Entry entry = new Entry { Placeholder = "Enter text" };
    }
}


   
