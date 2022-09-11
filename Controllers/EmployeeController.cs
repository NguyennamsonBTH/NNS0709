using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NNS0709.Models;

namespace NNS0709.Controllers;

public class EmployeeControllers : Controller
{
    private readonly ILogger<EmployeeControllers> _logger;

    public EmployeeControllers(ILogger<EmployeeControllers> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Index(Employee std)
    {
        int ID = std.EmployeeID;
        String Name = std.EmployeeName;
        int Phone = std.EmployeePhone;
        String Address = std.EmployeeAddress;
        int Age = std.EmployeeAge;
        ViewBag.ID = std.EmployeeID;
        ViewBag.Name = std.EmployeeName;
        ViewBag.Phone = std.EmployeePhone;
        ViewBag.Address = std.EmployeeAddress;
        ViewBag.Age = std.EmployeeAge;
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
