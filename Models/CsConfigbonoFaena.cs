﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsConfigbonoFaena
    {
        public int Id { get; set; }
        public decimal Minimo { get; set; }
        public decimal Maximo { get; set; }
        public decimal Tarifa { get; set; }
        public string Proveedor { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}