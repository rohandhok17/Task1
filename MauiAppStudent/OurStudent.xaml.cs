using Microsoft.Maui.Controls.PlatformConfiguration;
using StudentManagement;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace MauiAppStudent;

public partial class OurStudent : ContentPage
{
	public List<Student> students;

	private readonly StudentService studentService;
	public OurStudent()
	{
		students = new List<Student>();
		InitializeComponent();
	}
}