using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupmenu_baziu_egzaminas_2023
{
    public class Lesson
    {


        public int Id { get; set; }
        public string Description { get; set; }

        public List<Departament> Departaments { get; set; }
    

        public Lesson(string description)
        {

            Description = description;
            Departaments = new List<Departament>();
         
          
        }

        public Lesson() { }
    }
}
