using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CimenogluCourse.Models;

namespace CimenogluCourse.Controllers;

public class HomeController : Controller
{
    private static RegisterUsers users = new RegisterUsers();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Register()
    {

        return View();
    }

    [HttpPost]
    public IActionResult Register(User usr)
    {
        if(this.ModelState.IsValid)
        {
            users.Add(usr);
            return RedirectToAction("Index");
        }

        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
