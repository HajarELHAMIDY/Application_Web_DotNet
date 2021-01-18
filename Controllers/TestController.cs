using Microsoft.AspNetCore.Mvc;
using webProject.Model;
using System.Collections.Generic;
namespace webProject.Controllers
{
    public class TestController:Controller{
        public IActionResult Index(){
            IList<string> items=new List<string>();
            items.Add("Hajar");
            items.Add("Mohamed");
            items.Add("Mehdi");
            items.Add("khadija");
            ViewData["email"]="hajar.elhamidy@gmail.com";
            ViewBag.contact="hajar ELHAMIDY";
            return View(items);
        }
        public IActionResult List(){
            IList<Student> students=new List<Student>();
            students.Add(new Student{Id=1,Name="Hajar",Score=100});
            students.Add(new Student{Id=2,Name="Mehdi",Score=500});
            students.Add(new Student{Id=3,Name="Mohammed",Score=50});
            return View(students);
        }
        public IActionResult A(){
            return View();
        }
        public IActionResult B(){
            return View("BB");
        }
    }
}