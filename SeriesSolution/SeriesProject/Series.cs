using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SeriesProject
{
    class Series
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Duration { get; set; }
        public int Seasons { get; set; }
        public int Episodes { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name + " Duration: " + Duration + " Seaons: " + Seasons + " Episodes: " + Episodes;
        }
    }
}
