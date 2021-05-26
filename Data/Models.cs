using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace Tarea4.Data
{
    public class PersonContext : DbContext
    {
        public DbSet<Persons> Persons { get; set; }
        public DbSet<Accidents> Accidents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Reports.db");
    }

    public class Accidents
    {
        public int AccidentsId { get; set; }
        public string Description { get; set; }
        public byte[] Imagen { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Place { get; set; }
        public string latitude { get; set; }
        public string longitud { get; set; }



       
        public List<Persons> Person { get; } = new List<Persons>();
    }

    public class Persons
    {
        public int PersonsId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Cedula { get; set; }

        public int AccidentsId { get; set; }
        public Accidents Accidents { get; set; }
    }
}