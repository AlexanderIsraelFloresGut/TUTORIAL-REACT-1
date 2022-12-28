using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SpEmbarque1
    {
        public string Embarque { get; set; } = null!;
        public string? LiquidacCompra { get; set; }
        public string? Proveedor { get; set; }
        public DateTime? FechaRequerida { get; set; }
        public DateTime? FechaOfrecida { get; set; }
        public DateTime? FechaEmbarque { get; set; }
        public string Estado { get; set; } = null!;
        public string UsuarioCreado { get; set; } = null!;
        public DateTime FechaHoraCreado { get; set; }
        public string? UsuarioAplicado { get; set; }
        public DateTime? FechaHoraAplicac { get; set; }
        public string? Asiento { get; set; }
        public int? AuditTransInv { get; set; }
        public int? AuditTransLiq { get; set; }
        public DateTime? FechaCrm { get; set; }
        public string TieneFactura { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
