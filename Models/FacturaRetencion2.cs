﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FacturaRetencion2
    {
        public string TipoDocumento { get; set; } = null!;
        public string Factura { get; set; } = null!;
        public string CodigoRetencion { get; set; } = null!;
        public decimal Monto { get; set; }
        public string DocReferencia { get; set; } = null!;
        public decimal Base { get; set; }
        public string Autoretenedora { get; set; } = null!;
        public DateTime? FechaDocumento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? FechaRige { get; set; }

        public virtual Retencione2 CodigoRetencionNavigation { get; set; } = null!;
        public virtual Factura2 Factura2 { get; set; } = null!;
    }
}
