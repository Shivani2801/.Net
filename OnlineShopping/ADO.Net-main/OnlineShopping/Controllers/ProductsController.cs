using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Online_Shopping.Models;

namespace Online_Shopping.Controllers;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}