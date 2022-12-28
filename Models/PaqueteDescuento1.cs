﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PaqueteDescuento1
    {
        public PaqueteDescuento1()
        {
            PaqDescGrupo1s = new HashSet<PaqDescGrupo1>();
            PaqDescRegDesc1s = new HashSet<PaqDescRegDesc1>();
        }

        public string PaqueteDescuento { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string TodaTienda { get; set; } = null!;
        public DateTime FechaRige { get; set; }
        public DateTime FechaVence { get; set; }
        public string? Notas { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<PaqDescGrupo1> PaqDescGrupo1s { get; set; }
        public virtual ICollection<PaqDescRegDesc1> PaqDescRegDesc1s { get; set; }
    }
}
