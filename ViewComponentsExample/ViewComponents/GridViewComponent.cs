using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.ViewComponents;
public class GridViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        PersonGridModel personGridModel = new PersonGridModel()
        {
            GridTitle = "Person List",
            Persons = new List<Person>()
            {
                new Person() {PersonName = "John", JobTitle = "Manager" },
                new Person() {PersonName = "Jones", JobTitle = "Asst." },
                new Person() {PersonName = "Johny", JobTitle = "Clerk" }
            }
        };

        ViewData["Grid"] = personGridModel;

        //invoked a partial view Views/Shared/Components/Grid/Default.cshtml
        return View("Sample", personGridModel); 
    }
}
