using System;
using System.Collections.Generic;

#nullable disable

namespace MoviesProject.OrgModel
{
    public partial class Transaction
    {
        public int? TranId { get; set; }
        public int? FromAcc { get; set; }
        public int? ToAcc { get; set; }
        public double? Amount { get; set; }
        public string Remarks { get; set; }
    }
}
