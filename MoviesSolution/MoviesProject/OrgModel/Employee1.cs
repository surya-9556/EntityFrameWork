using System;
using System.Collections.Generic;

#nullable disable

namespace MoviesProject.OrgModel
{
    public partial class Employee1
    {
        public Employee1()
        {
            InverseManager = new HashSet<Employee1>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int? ManagerId { get; set; }

        public virtual Employee1 Manager { get; set; }
        public virtual ICollection<Employee1> InverseManager { get; set; }
    }
}
