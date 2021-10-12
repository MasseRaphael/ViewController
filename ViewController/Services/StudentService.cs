using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ViewController.Models;

namespace ViewController.Services
{
    public class StudentService
    {
        public IEnumerable<Student> Students;

        public StudentService()
        {
            string text = File.ReadAllText("students.json");

            Students = JsonConvert.DeserializeObject<IEnumerable<Student>>(text);
        }
    }
}
