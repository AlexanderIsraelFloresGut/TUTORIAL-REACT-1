﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsUsuarioAprobacione1
    {
        public string Usuario { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public decimal? RangoMinimo { get; set; }
        public decimal? RangoMaximo { get; set; }
        public int? CantAprob { get; set; }
        public int Consecutivo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
