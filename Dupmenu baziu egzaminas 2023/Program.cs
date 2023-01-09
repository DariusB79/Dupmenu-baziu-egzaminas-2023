using Dupmenu_baziu_egzaminas_2023;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Duomenu baziu egzaminas 2023");

StudentDbContext context= new StudentDbContext();

//Metodai


//CreateNewDepartament();
//RemoveLesson();
//RemoveStudent();
//RemoveDepartament();

//ChangeStudentDepartament();

//ShowDepartamentStudents();
//ShowDepartamentLessons();
//ShowStudentLessons();

//AddNewStudentToDepartament();
//AddNewLectureToDepartament();








// Duomenu sukelimas

/*
//1.Sukurti departamentą ir į jį pridėti studentus,
//paskaitas(papildomi points jei pridedamos paskaitos
//jau egzistuojančios duomenų bazėje).

Departament departament1 = new Departament("Ekonomikos Fakultetas");
Departament departament2 = new Departament("Matematikos Fakultetas");
Departament departament3 = new Departament("Dailes Fakultetas");


Lesson leson1 = new Lesson("Ekonomika");
Lesson leson2 = new Lesson("Teise");
Lesson leson3 = new Lesson("Matematika");
Lesson leson4 = new Lesson("Geometrija");
Lesson leson5 = new Lesson("Skulptura");
Lesson leson6 = new Lesson("Daile");


Student student1 = new Student("Darius");
Student student2= new Student("Marius");
Student student3 = new Student("Ieva");
Student student4 = new Student("Inga");
Student student5 = new Student("Tomas");
Student student6 = new Student("Daiva");


student1.Lessons = new List<Lesson> { leson1, leson2 };
student2.Lessons = new List<Lesson> { leson1, leson2 };
student3.Lessons = new List<Lesson> { leson3, leson4 };
student4.Lessons = new List<Lesson> { leson3, leson4 };
student5.Lessons = new List<Lesson> { leson5, leson6 };
student6.Lessons = new List<Lesson> { leson5, leson6 };

departament1.Lessons = new List<Lesson> { leson1, leson2 };    
departament1.Students = new List<Student> { student1, student2 };
departament2.Lessons = new List<Lesson> { leson3, leson4 };
departament2.Students = new List<Student> { student3, student4 };
departament3.Lessons = new List<Lesson> { leson5, leson6 };
departament3.Students = new List<Student> { student5, student6 };


leson1.Departaments = new List<Departament> { departament1  };
leson2.Departaments = new List<Departament> { departament1 };
leson3.Departaments = new List<Departament> { departament2 };
leson4.Departaments = new List<Departament> { departament2 };
leson5.Departaments = new List<Departament> { departament3 };
leson6.Departaments = new List<Departament> { departament3 };


context.Departaments.AddRange(departament1, departament2, departament3);
context.Students.AddRange(student1, student2, student3, student4, student5, student6);
context.Lessons.AddRange(leson1, leson2, leson3, leson4, leson5, leson6);
context.SaveChanges();
*/



//  Metodai

void CreateNewDepartament()
    {
    Departament newDep = new Departament("IT fakultetas");
    Lesson newLes = new Lesson("C#");
    Student newStud = new Student("Domantas");

    newStud.Lessons = new List<Lesson> { newLes };
    newLes.Departaments = new List<Departament> { newDep };
    newDep.Lessons = new List<Lesson> { newLes };
    newDep.Students = new List<Student> { newStud };

    context.Students.Add(newStud);
    context.Lessons.Add(newLes);
    context.Departaments.Add(newDep);
    context.SaveChanges();
     }

void RemoveLesson()
{

    var removeLeson = context.Lessons.Single(x => x.Id ==13);
    context.Lessons.Remove(removeLeson);
    context.SaveChanges();
}


void RemoveStudent()
{

    var removeStudent = context.Students.Single(x => x.Id == 8);
    context.Students.Remove(removeStudent);
    context.SaveChanges();
}


void RemoveDepartament()
{

    var removeDep = context.Departaments.Single(x => x.Id == 5);
    context.Departaments.Remove(removeDep);
    context.SaveChanges();
}


void ChangeStudentDepartament()
{

    var stud = context.Students.Single(x => x.Id == 1);
    stud.DepartamentId = 6;
    context.SaveChanges();
}



*/


void ShowDepartamentStudents()
{
    Console.WriteLine("Departamento Nr.2  studentu sarasas");   

    var list = context.Departaments.Include(s => s.Students).Where(i => i.Id == 2).FirstOrDefault();
    var students = list.Students;
    Console.WriteLine();
    Console.WriteLine($"{context.Departaments.Single(x => x.Id == 2).Name} studentai");
    Console.WriteLine();
    Console.WriteLine("Saraso pradzia");
    Console.WriteLine();

    foreach (var student in students)
    {
        Console.WriteLine(student.Name);
    }
    Console.WriteLine();
    Console.WriteLine("Saraso pabaiga");

}


void ShowDepartamentLessons()
{
    Console.WriteLine("Departamento Nr.2  paskaitu sarasas");

    var list = context.Departaments.Include(s => s.Lessons).Where(i => i.Id == 2).FirstOrDefault();
    var lesons = list.Lessons;
    Console.WriteLine();
    Console.WriteLine($"{context.Departaments.Single(x => x.Id == 2).Name} paskaitos");
    Console.WriteLine();
    Console.WriteLine("Saraso pradzia");
    Console.WriteLine();

    foreach (var leson in lesons)
    {
        Console.WriteLine(leson.Description);
    }
    Console.WriteLine();
    Console.WriteLine("Saraso pabaiga");

}


void ShowStudentLessons()
{
    Console.WriteLine(" Psirinkto studento  pagal id paskaitu sarasas");

    var list = context.Students.Include(s => s.Lessons).Where(i => i.Id == 10).FirstOrDefault();
    var lesons = list.Lessons;
    Console.WriteLine();
    Console.WriteLine($"{context.Students.Single(x => x.Id == 10).Name} paskaitos");
    Console.WriteLine();
    Console.WriteLine("Saraso pradzia");
    Console.WriteLine();

    foreach (var leson in lesons)
    {
        Console.WriteLine(leson.Description);
    }
    Console.WriteLine();
    Console.WriteLine("Saraso pabaiga");

}


void AddNewStudentToDepartament()
{

    Console.WriteLine("Priskiriamas naujas studentas i departamenta pagal Id");

    Student newStud = new Student("Irma");

    var dep = context.Departaments.First(x => x.Id == 2);
    

    context.Students.Add(newStud);
    dep.Students.Add(newStud);
    context.Departaments.Update(dep);
    context.SaveChanges();
}


void AddNewLectureToDepartament()
{

    Console.WriteLine("Priskiriamas nauja i departamenta pagal Id");

    Lesson newLes = new Lesson("Taikomoji mtematika");

    var dep = context.Departaments.First(x => x.Id == 2);


    context.Lessons.Add(newLes);
    dep.Lessons.Add(newLes);
    context.Departaments.Update(dep);
    context.SaveChanges();
}

