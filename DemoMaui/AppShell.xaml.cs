using DemoMaui.Views;
namespace DemoMaui

{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Add", typeof(AddStudent));
            Routing.RegisterRoute("Edit", typeof(EditStudent));
           Routing.RegisterRoute("Our", typeof(OurStudent));
        }
    }
}
