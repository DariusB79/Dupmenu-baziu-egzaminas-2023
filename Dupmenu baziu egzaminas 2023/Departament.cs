using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupmenu_baziu_egzaminas_2023
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> Students { get; set; }

        public List<Lesson> Lessons { get; set; }


        public Departament(string name)
        {
            Name = name;
            Students = new List<Student>();
            Lessons = new List<Lesson>();
        }
    }


}

