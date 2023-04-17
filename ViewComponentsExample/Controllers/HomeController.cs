using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.Controllers;
public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("/about")]
    public IActionResult About()
    {
        return View();
    }

    [Route("friends-list")]
    public IActionResult LoadFriendsList()
    {
        PersonGridModel personGridModel = new PersonGridModel()
        {
            GridTitle = "Persons",
            Persons = new List<Person>()
        {
            new Person() {PersonName = "John", JobTitle = "Manager" },
            new Person() {PersonName = "Jones", JobTitle = "Asst." },
            new Person() {PersonName = "Johny", JobTitle = "Clerk" }
        }
        };

        return ViewComponent("Grid", new {grid = personGridModel});
    }
}
