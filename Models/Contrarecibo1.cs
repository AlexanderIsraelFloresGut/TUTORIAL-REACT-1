using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Contrarecibo1
    {
        public Contrarecibo1()
        {
            DocumentosCp1s = new HashSet<DocumentosCp1>();
        }

        public string Contrarecibo { get; set; } = null!;
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

        public virtual CondicionPago1 CondicionPagoNavigation { get; set; } = null!;
        public virtual Proveedor1 ProveedorNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioUltModNavigation { get; set; } = null!;
        public virtual ContrarecMovPre1 ContrarecMovPre1 { get; set; } = null!;
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
    }
}
