using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SpAuditTransInv1
    {
        public int AuditTransInv { get; set; }
        public string? Consecutivo { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string ModuloOrigen { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string? Asiento { get; set; }
        public string? UsuarioApro { get; set; }
        public DateTime? FechaHoraAprob { get; set; }
        public string? PaqueteInventario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
