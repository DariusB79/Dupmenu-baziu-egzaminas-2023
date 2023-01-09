using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupmenu_baziu_egzaminas_2023
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartamentId { get; set; }

        public List<Lesson> Lessons { get; set; }

        public Student(string name)
        {
            Name = name;
        
            Lessons = new List<Lesson>();


        }
        public Student()
        {

        }

    }
}
