﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenProdRubro
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Rubro { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal? CostoDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
