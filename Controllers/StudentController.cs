using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NNS0709.Models;

namespace NNS0709.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }
    [HttpPost]
    public IActionResult Index(Student std)
    {
        std.StudentName = "Tin Hoc Kinh Te";
        ViewBag.mess = std.StudentID;
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