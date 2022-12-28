﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetDocumentoEmbarque2
    {
        public DetDocumentoEmbarque2()
        {
            EmbarqueLinea2s = new HashSet<EmbarqueLinea2>();
        }

        public string Documento { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string Embarque { get; set; } = null!;
        public decimal MontoAplicar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DocumentoEmbarque2 DocumentoEmbarque2 { get; set; } = null!;
        public virtual Embarque2 EmbarqueNavigation { get; set; } = null!;
        public virtual ICollection<EmbarqueLinea2> EmbarqueLinea2s { get; set; }
    }
}
