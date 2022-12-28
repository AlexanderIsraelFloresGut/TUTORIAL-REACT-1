using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AuditAjustesNomi2
    {
        public int Consecutivo { get; set; }
        public string Nomina { get; set; } = null!;
        public int NumeroNomina { get; set; }
        public string Empleado { get; set; } = null!;
        public decimal? NetoAnterior { get; set; }
        public string? RazonDefault { get; set; }
        public string? RazonUsuario { get; set; }
        public string UsuarioModif { get; set; } = null!;
        public string UsuarioAplica { get; set; } = null!;
        public string? Asiento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
