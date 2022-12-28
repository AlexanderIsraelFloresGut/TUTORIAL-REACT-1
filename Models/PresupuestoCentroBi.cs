﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PresupuestoCentroBi
    {
        public string Presupuesto { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual PresupuestoVersionBi PresupuestoVersionBi { get; set; } = null!;
    }
}