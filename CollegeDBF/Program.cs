using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core;



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
            public virtual List<Class> Classes { get; set; }
        }

        List<Class> Classes = new List<Class>()
        {


        };

        Class OneClass = new Class();




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
            public virtual List<Class> ClassID { get; set; }


        }

        public class CollegeDBF : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Class> Classes { get; set; }
            public DbSet<Score> Scores { get; set; }

        }



        static void Main(string[] args)
        {

            DateTime Assigned = new DateTime(2018, 01, 02);
            DateTime Due = new DateTime(2018, 03, 02);
            DateTime Submitted = new DateTime(2018, 02, 18);

            using (var s = new CollegeDBF())
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

            }

            using (var c = new CollegeDBF())
            {
                Class Ladders = new Class

                {
                    Title = "Introduction to Ladders!",
                    Department = "History",
                    Number = 101
                };
                c.Classes.Add(Ladders);

                Class Math = new Class

                {
                    Title = "Prehistoric Math",
                    Department = "Mathematics",
                    Number = 203
                };
                c.Classes.Add(Math);

                Class English = new Class

                {
                    Title = "English in French!",
                    Department = "Linguistics",
                    Number = 117
                };
                c.Classes.Add(English);

                c.SaveChanges();
            }

            using (var scores = new CollegeDBF())
            {
                Score BustersScore = new Score
                {
                    Type = "quiz",
                    Date_Assigned = Assigned,
                    Date_Due = Due,
                    Date_Submitted = Submitted,
                    Points_Earned = 89,
                    Points_Possible = 100,

                };
                scores.Scores.Add(BustersScore);

                Score CarltonsScore = new Score
                {
                    Type = "test",
                    Date_Assigned = Assigned,
                    Date_Due = Due,
                    Date_Submitted = Submitted,
                    Points_Earned = 39,
                    Points_Possible = 100,

                };
                scores.Scores.Add(CarltonsScore);

                Score BritasScore = new Score
                {
                    Type = "exam",
                    Date_Assigned = Assigned,
                    Date_Due = Due,
                    Date_Submitted = Submitted,
                    Points_Earned = 59,
                    Points_Possible = 100,

                };
                scores.Scores.Add(CarltonsScore);

                scores.SaveChanges();
            }




        }



    }


}


