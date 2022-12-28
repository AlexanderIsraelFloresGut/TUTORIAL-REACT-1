using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FiadoresDocFa2
    {
        public string FiadorId { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string NombreFiador { get; set; } = null!;
        public string? OcupacFiador { get; set; }
        public string? TipoFiador { get; set; }
        public string? DirecFiador { get; set; }
        public string? TelDomFiador { get; set; }
        public string? LugTrabFiador { get; set; }
        public string? DirTrabFiador { get; set; }
        public string? TelTrabFiador { get; set; }
        public string? ContratoFiador { get; set; }
        public string? ObsFiador { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Factura2 Factura2 { get; set; } = null!;
    }
}
