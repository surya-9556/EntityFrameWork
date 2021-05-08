using System;
using System.Collections.Generic;

#nullable disable

namespace MoviesProject.OrgModel
{
    public partial class Account
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double? Balance { get; set; }
        public string Status { get; set; }
    }
}
