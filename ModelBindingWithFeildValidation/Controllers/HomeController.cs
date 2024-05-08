using System.Web.Mvc;
using ModelBindingWithFeildValidation.Models;
public class HomeController : Controller
{
    public ActionResult EmployeeView()
    {
        return View();
    }

    [HttpPost]
    public ActionResult SubmitForm(EmployeeValidation model)
    {
        if (!ModelState.IsValid)
        {
            return View("EmployeeView", model); // Return the view with validation errors
        }
        else
        {
           TempData["Name"] = model.Name;
           return RedirectToAction("Success");
        }
    }

    public string Success(EmployeeValidation model)
    {
        string name = TempData["Name"] as string;
        // Clear the TempData to avoid storing unnecessary data
        //TempData.Remove("Name");
        return "welcome " + name;
    }
}