﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TempPrimitivaHistorica
    {
        public string Empleado { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public string? CentroCosto { get; set; }
        public decimal? Total { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
