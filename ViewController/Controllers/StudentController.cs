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
    [Route("/")]
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
                Id = Guid.NewGuid(),
                Nom = nom,
                Prenom = prenom,
                TechnoPref = technoPref
            };

            StudentService.AddStudent(newStudent);

            return RedirectToAction("Index");
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            StudentService.DeleteStudent(id);
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{nom}/{prenom}/{technoPref}")]
        public IActionResult Edit(string nom, string prenom, string technoPref)
        {
            StudentService.EditStudent(nom, prenom, technoPref);
            return RedirectToAction("Index");
        }
    }
}
