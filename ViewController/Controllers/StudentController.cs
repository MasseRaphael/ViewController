using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ViewController.Models;
using ViewController.Services;

namespace ViewController.Controllers
{
    [Route("[Controller]/")]
    public class StudentController : Controller
    {
        public StudentService StudentService;
        public StudentController(StudentService service)
        {
            StudentService = service;
        }

        public IActionResult Index()
        {
            return View("Liste", StudentService.Students);
        }

        [HttpGet("create/{nom}/{prenom}/{technoPref}")]
        public IActionResult Create(string nom, string prenom, string technoPref)
        {
            Student newStudent = new Student()
            {
                Nom = nom,
                Prenom = prenom,
                TechnoPref = technoPref
            };

            string output = JsonConvert.SerializeObject(newStudent);

            return View("Create");
        }
    }
}
