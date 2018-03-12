using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using static System.Console;

namespace CollegeDBF
{
    class Program
    {

        public class Student
        {
            [Key]
            public int ID { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int Zip { get; set; }
            public long Phone { get; set; }

        }

        public class Class
        {
            [Key]
            public int ID { get; set; }
            public string Title { get; set; }
            public int Number { get; set; }
            public string Department { get; set; }
            public virtual List<Student> StudentID { get; set; }
        }


        public class Score
        {

            [Key]
            public int ID { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public DateTime Date_Assigned { get; set; }
            public DateTime Date_Due { get; set; }
            public DateTime Date_Submitted { get; set; }
            public int Points_Earned { get; set; }
            public int Points_Possible { get; set; }
            public virtual Student Student_ID { get; set; }
        }

        public class College : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Class> Classes { get; set; }
            public DbSet<Score> Scores { get; set; }

        }


        static void Main(string[] args)
        {
            DateTime Assigned = new DateTime(01 / 02 / 2018);
            DateTime Due = new DateTime(03 / 03 / 2018);
            DateTime Submitted = new DateTime(02 / 02 / 2018);

            using (var s = new College() )
            {
                Student Buster = new Student
                {

                    FName = "Buster",
                    LName = "Bluth",
                    Address = "123 Sudden Valley",
                    City = "Sacramende",
                    State = "California",
                    Phone = 1 - 234 - 5678,
                    Zip = 11213
                };
                s.Students.Add(Buster);


                Student Carlton = new Student
                {

                    FName = "Carlton",
                    LName = "Banks",
                    Address = "456 Bellair",
                    City = "Bellair",
                    State = "California",
                    Phone = 1 - 333 - 8839,
                    Zip = 33213
                };
                s.Students.Add(Carlton);

                Student Brita = new Student
                {

                    FName = "Brita",
                    LName = "Perry",
                    Address = "579 Rivers St.",
                    City = "Greendale",
                    State = "Colorado",
                    Phone = 1 - 339 - 848 - 3882,
                    Zip = 99431
                };
                s.Students.Add(Brita);

                s.SaveChanges();

                var ClassLadders = new Class
                {
                    Title = "Ladders 101",
                    Number = 233,
                    Department = "History",
                    StudentID = new List<Student>()
                };
                s.Classes.Add(ClassLadders);

                Score scorebook1 = new Score
                {
                    Student_ID = Buster,
                    Type = "exam",
                    Description = "not so great",
                    Date_Assigned = Assigned,
                    Date_Due = Due,
                    Date_Submitted = Submitted,
                    Points_Earned = 50,
                    Points_Possible = 100
                };
                ClassLadders.StudentID.Add(null);

                s.SaveChanges();

                var query = from Classes in Class
                            orderby ClassLadders
                            select Classes;




            }
        }
    }
}

