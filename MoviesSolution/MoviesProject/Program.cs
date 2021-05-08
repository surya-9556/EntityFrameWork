using MoviesProject.OrgModel;
using System;

namespace MoviesProject
{
    class Program
    {
        //public static pubsContext db = new pubsContext();
        public static TblMovie t = new TblMovie();
        static void Main(string[] args)
        {
            NewMethod();
        }

        private static void NewMethod()
        {
            using (var db = new pubsContext())
            {
                TblMovie t = AcceptData();
                Console.WriteLine("Please enter the movie details");
                InsertData(t);
                DisplayData();
            }
        }

        private static void DisplayData()
        {
            using (var db = new pubsContext())
            {
                foreach (var item in db.TblMovies)
                {
                    Console.WriteLine("Id: " + item.Id + " Name: " + item.Name + " Duration: " + item.Duration);
                }
            }
        }

        private static void InsertData(TblMovie t)
        {
            using (var db = new pubsContext())
            {
                db.TblMovies.Add(t);
                db.SaveChanges();
            }
        }

        private static TblMovie AcceptData()
        {
            using (var db = new pubsContext())
            {
                Console.WriteLine("Please enter the movie name");
                t.Name = Console.ReadLine();
                Console.WriteLine("Please enter the duration");
                t.Duration = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
                return t;
            }
        }
    }
}
