﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HistCierreCg1
    {
        public DateTime FechaCierre { get; set; }
        public string Contabilidad { get; set; } = null!;
        public string Asiento { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int? MayorAuditoria { get; set; }
        public string? DocumentoGlobal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual MayorAuditorium1? MayorAuditoriaNavigation { get; set; }
        public virtual PeriodoContable1 PeriodoContable1 { get; set; } = null!;
    }
}
