using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PersonController1 : Controller
    {
        private static List<Person> persons = new List<Person>
        {
            new Person { Id = 1, FirstName = "John", LastName = "Doe", Gender = "Male", DateOfBirth = DateTime.Parse("1990-01-01"), Age = 32, SClass = "Class A", Address = "123 Main St" },
            new Person { Id = 2, FirstName = "Jane", LastName = "Doe", Gender = "Female", DateOfBirth = DateTime.Parse("1995-05-15"), Age = 27, SClass = "Class B", Address = "456 Oak St" }
            // Add more data as needed
        };
        public IActionResult Index()
        {
            return View(persons);
        }
        public ActionResult Edit(int id)
        {
            // Retrieve the person based on the provided ID
            var personToEdit = persons.Find(p => p.Id == id);

            if (personToEdit == null)
            {
                // Handle not found, redirect to index or show an error
                return RedirectToAction("Index");
            }

            return View(personToEdit);
        }

        [HttpPost]
        public ActionResult Edit(Person updatedPerson)
        {
            // Update the person in the list
            var existingPerson = persons.Find(p => p.Id == updatedPerson.Id);

            if (existingPerson != null)
            {
                existingPerson.FirstName = updatedPerson.FirstName;
                existingPerson.LastName = updatedPerson.LastName;
                existingPerson.Gender = updatedPerson.Gender;
                existingPerson.DateOfBirth = updatedPerson.DateOfBirth;
                existingPerson.Age = updatedPerson.Age;
                existingPerson.SClass = updatedPerson.SClass;
                existingPerson.Address = updatedPerson.Address;
            }

            // Redirect to the index page after editing
            return RedirectToAction("Index");
        }
    }
}

