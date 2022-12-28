﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Regimene
    {
        public string Regimen { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? ModeloRetencion { get; set; }
        public string Imp1AsumidoCompras { get; set; } = null!;
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public string? Consecutivo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCuentum? C { get; set; }
        public virtual Consecutivo? ConsecutivoNavigation { get; set; }
        public virtual ModeloRetencion? ModeloRetencionNavigation { get; set; }
    }
}
