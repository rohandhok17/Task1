using MauiApp1.Views;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Ourstudent),typeof(Ourstudent));
            Routing.RegisterRoute(nameof(Addstudent),typeof(Addstudent));
            Routing.RegisterRoute(nameof(Editstudent), typeof(Editstudent));
           
        }
    }
}
