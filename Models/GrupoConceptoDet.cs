﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GrupoConceptoDet
    {
        public string GrupoConcepto { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public short Secuencia { get; set; }
        public string Operador { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Concepto ConceptoNavigation { get; set; } = null!;
        public virtual GrupoConcepto GrupoConceptoNavigation { get; set; } = null!;
    }
}
