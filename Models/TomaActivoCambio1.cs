using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TomaActivoCambio1
    {
        public string ActivoFijo { get; set; } = null!;
        public string? TipoActivo { get; set; }
        public string? Descripcion { get; set; }
        public string? Responsable { get; set; }
        public string? Ubicacion { get; set; }
        public string? CodigoBarras { get; set; }
        public string? NumeroSerie { get; set; }
        public string? EstadoActivo { get; set; }
        public string? Notas { get; set; }
        public string? Rubro1Activo { get; set; }
        public string? Rubro2Activo { get; set; }
        public string? Rubro3Activo { get; set; }
        public string? Rubro4Activo { get; set; }
        public string? Rubro5Activo { get; set; }
        public string? Rubro6Activo { get; set; }
        public string? Rubro7Activo { get; set; }
        public string? Rubro8Activo { get; set; }
        public string? Rubro9Activo { get; set; }
        public string? Rubro10Activo { get; set; }
        public string? Rubro11Activo { get; set; }
        public string? Rubro12Activo { get; set; }
        public string? Rubro13Activo { get; set; }
        public string? Rubro14Activo { get; set; }
        public string? Rubro15Activo { get; set; }
        public string? PocketId { get; set; }
        public string IdSincro { get; set; } = null!;
        public DateTime? FechaSincro { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
