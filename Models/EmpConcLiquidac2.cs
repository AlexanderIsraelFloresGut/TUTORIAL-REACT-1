using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpConcLiquidac2
    {
        public string Concepto { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public DateTime FechaLiquidac { get; set; }
        public decimal? NumeroDocumento { get; set; }
        public string? AsientoDocumento { get; set; }
        public string? DocumentoImpreso { get; set; }
        public string? DocumentoSeleccio { get; set; }
        public string DocumentoGenerado { get; set; } = null!;
        public decimal MontoCalculado { get; set; }
        public decimal MontoAPagar { get; set; }
        public string? Notas { get; set; }
        public string? Usuario { get; set; }
        public DateTime FechaHora { get; set; }
        public string? FormaPago { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ConceptoLiquidac2 ConceptoLiquidac2 { get; set; } = null!;
        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioNavigation { get; set; }
    }
}
