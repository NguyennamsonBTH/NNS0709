using System.Reflection.Metadata;
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
    public IActionResult Index()
    {
        List<Student> stdList = new List<Student>
        {
            new Student { StudentID = 11, StudentName = "Sinh vien A", StudentEmail = "Alpha@gmail.com", StudentAge = 17},
            new Student { StudentID = 12, StudentName = "Sinh vien B", StudentEmail = "Beta@gmail.com", StudentAge = 21},
            new Student { StudentID = 13, StudentName = "Sinh vien C", StudentEmail = "Celta@gmail.com", StudentAge = 33},
            new Student { StudentID = 14, StudentName = "Sinh vien D", StudentEmail = "Delta@gmail.com", StudentAge = 45},
            new Student { StudentID = 15, StudentName = "Sinh vien E", StudentEmail = "Eilta@gmail.com", StudentAge = 57}
        };
        ViewData["Student"] = stdList;
        return View();
    }
    [HttpPost]
    public IActionResult Create(Student std)
    {
        // string message = std.StudentID + "-";
        // message += std.Student + "-";
        // message += std.StudentAge;
        // ViewBag.TT = message;
        return View();
    }
    
    [HttpPost]
    public IActionResult Index(Student std)
    {
        std.StudentName = "Tin Học Kinh Tế";
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