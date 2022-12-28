﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoEquipoProc1
    {
        public string Procedimiento { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string TipoEquipo { get; set; } = null!;
        public decimal PeriodicidadDias { get; set; }
        public string? Comentario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Procedimiento1 Procedimiento1 { get; set; } = null!;
        public virtual TipoEquipo1 TipoEquipoNavigation { get; set; } = null!;
    }
}
