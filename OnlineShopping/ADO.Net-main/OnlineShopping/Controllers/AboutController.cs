using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Online_Shopping.Models;

namespace Online_Shopping.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}