using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewController.Models;

namespace ViewController.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("View", new []
            {
                new Student {
                    Nom = "Henriques",
                    Prenom = "Sylvio",
                    TechnoPref = "C#"
                },
                new Student {
                    Nom = "Nguyen",
                    Prenom = "Timthée",
                    TechnoPref = "C#"
                },
                new Student {
                    Nom = "Couto de Oliviera",
                    Prenom = "Dylan",
                    TechnoPref = "Python"
                },
                new Student {
                    Nom = "De Campos",
                    Prenom = "Armelio",
                    TechnoPref = "Python"
                },
                new Student {
                    Nom = "Carlus",
                    Prenom = "Thomas",
                    TechnoPref = "C#"
                },
                new Student {
                    Nom = "Masse",
                    Prenom = "Raphaël",
                    TechnoPref = "PHP"
                },
                new Student {
                    Nom = "Lemelle",
                    Prenom = "Tom",
                    TechnoPref = "JS"
                },
                new Student {
                    Nom = "Vareille",
                    Prenom = "Nicolas",
                    TechnoPref = "C#"
                }
            });
        }
    }
}
