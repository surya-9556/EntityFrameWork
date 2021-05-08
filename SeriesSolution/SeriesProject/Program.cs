using Microsoft.EntityFrameworkCore;
using System;

namespace SeriesProject
{
    class Program
    {
        public static Series s = new Series();
        static void Main(string[] args)
        {
            NewMethod();
        }

        private static void NewMethod()
        {
            using(var db = new SeriesContext())
            {
                Series s = AcceptDetails();
                Console.WriteLine("Please enter the series details");
                InsertData(s);
                DisplayData();
                UpdateSeries();
                DeleteRecord();
            }
        }

        private static void DisplayData()
        {
            using (var db = new SeriesContext())
            {
                foreach (var item in db.Series)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private static void InsertData(Series s)
        {
            using (var db = new SeriesContext())
            {
                db.Series.Add(s);
                db.SaveChanges();
            }
        }

        private static Series AcceptDetails()
        {
            using (var db = new SeriesContext())
            {
                Console.WriteLine("Please enter the name");
                s.Name = Console.ReadLine();
                Console.WriteLine("Please enter the duration of each episode");
                s.Duration = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
                Console.WriteLine("Please Enter the Number of seasons");
                s.Seasons = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter the Number of episodes for each season");
                s.Episodes = Convert.ToInt32(Console.ReadLine());
                return s;
            }
        }

        private static void DeleteRecord()
        {
            using (var db = new SeriesContext())
            {
                Console.WriteLine("Please enter the id that needed to be deleted");
                int id = Convert.ToInt32(Console.ReadLine());
                s = GetSeriesById(id);
                if (s == null)
                {
                    Console.WriteLine("No records found");
                }
                db.Series.Remove(s);
                db.SaveChanges();
            }
        }

        private static void UpdateSeries()
        {
            using (var db = new SeriesContext())
            {
                Console.WriteLine("Please enter the id for which you want to update the record");
                int id = Convert.ToInt32(Console.ReadLine());
                s = GetSeriesById(id);
                Console.WriteLine(s.ToString());
                s = AcceptDetails();
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
                Console.WriteLine("Data Updated SuccessFully");
            }
        }

        private static Series GetSeriesById(int id)
        {
            using (var db = new SeriesContext())
            {
                s = db.Series.Find(id);
            }
            return s;
        }
    }
}
