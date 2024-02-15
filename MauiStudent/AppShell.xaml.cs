using MauiStudent.Models;
namespace MauiStudent

{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddStudent),typeof(AddStudent));
            Routing.RegisterRoute(nameof(EditStudent), typeof(EditStudent));
            Routing.RegisterRoute(nameof(OurStudent), typeof(OurStudent));
        }
        
    }
}
