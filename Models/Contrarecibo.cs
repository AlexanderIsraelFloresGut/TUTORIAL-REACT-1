﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Contrarecibo
    {
        public Contrarecibo()
        {
            DocumentosCps = new HashSet<DocumentosCp>();
        }

        public string Contrarecibo1 { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string CondicionPago { get; set; } = null!;
        public string UsuarioUltMod { get; set; } = null!;
        public DateTime? FechaRige { get; set; }
        public DateTime? FechaUltMod { get; set; }
        public string? Estado { get; set; }
        public string? Notas { get; set; }
        public DateTime? FechaEmision { get; set; }
        public string? Congelado { get; set; }
        public DateTime FechaVence { get; set; }
        public string? PresupuestoCr { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CondicionPago CondicionPagoNavigation { get; set; } = null!;
        public virtual Proveedor ProveedorNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioUltModNavigation { get; set; } = null!;
        public virtual ContrarecMovPre ContrarecMovPre { get; set; } = null!;
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
    }
}
