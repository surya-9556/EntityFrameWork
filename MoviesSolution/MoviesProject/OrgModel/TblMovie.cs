﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MoviesProject.OrgModel
{
    public partial class TblMovie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Duration { get; set; }
    }
}
