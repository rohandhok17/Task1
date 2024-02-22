using StudentManagement;
using OtherPageFormat.Views;
namespace OtherPageFormat
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute("Add", typeof(AddStudent));
           // Routing.RegisterRoute("Edit", typeof(EditStudent));
            Routing.RegisterRoute("Our", typeof(OurStudent));
        }
    }
    }

