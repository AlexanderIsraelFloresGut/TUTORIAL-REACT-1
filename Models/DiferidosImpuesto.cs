﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DiferidosImpuesto
    {
        public string Diferido { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string Impuesto { get; set; } = null!;
        public string ConceptoMe { get; set; } = null!;
        public decimal Valor { get; set; }
        public decimal Porcentaje { get; set; }
        public string ImpuestoAfectaCosto { get; set; } = null!;
        public string TipoImpuesto { get; set; } = null!;
        public string ImpuestoAsumido { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Diferido DiferidoNavigation { get; set; } = null!;
        public virtual Impuesto ImpuestoNavigation { get; set; } = null!;
        public virtual TipoImpuesto TipoImpuestoNavigation { get; set; } = null!;
    }
}
