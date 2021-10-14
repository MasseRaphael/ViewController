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
        public List<Student> Students;

        public StudentService()
        {
            string text = File.ReadAllText("student.json");

            Students = JsonConvert.DeserializeObject<List<Student>>(text);
        }

        public void AddStudent(Student newStudent)
        {
            Students.Add(newStudent);

            string text = JsonConvert.SerializeObject(Students);

            File.WriteAllText("student.json", text);
        }

        public void DeleteStudent(Guid id)
        {
            Students.Remove(Students.First(i => i.Id == id));
            string text = JsonConvert.SerializeObject(Students);

            File.WriteAllText("student.json", text);
        }

        public void EditStudent(string nom, string prenom, string technoPref)
        {
            Student studentFind = Students.FirstOrDefault(i => i.Nom == nom && i.Prenom == prenom);
            DeleteStudent(studentFind.Id);
            studentFind.TechnoPref = technoPref;
            AddStudent(studentFind);
        }
    }
}
