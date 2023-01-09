using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupmenu_baziu_egzaminas_2023
{
    public class StudentDbContext : DbContext
    {
            public DbSet<Student> Students { get; set; }

            public DbSet<Departament> Departaments { get; set; }

            public DbSet<Lesson> Lessons { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseSqlServer("Server=DESKTOP-17930GK\\TEW_SQLEXPRESS;Initial Catalog=DB_EGZ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }

        }
}
