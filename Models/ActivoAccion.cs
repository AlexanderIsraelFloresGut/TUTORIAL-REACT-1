using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ActivoAccion
    {
        public int ActivoAccion1 { get; set; }
        public string? Ubicacion { get; set; }
        public string? Responsable { get; set; }
        public string TipoAccionAf { get; set; } = null!;
        public string? EstadoActivo { get; set; }
        public string ActivoFijo { get; set; } = null!;
        public string EstadoAccion { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaRige { get; set; }
        public DateTime? FechaVence { get; set; }
        public string? Notas { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string? UsuarioAplicacion { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public string? UsuarioAprobacion { get; set; }
        public string? EstadoActivoAnt { get; set; }
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
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ActivoFijo ActivoFijoNavigation { get; set; } = null!;
        public virtual EstadoActivo? EstadoActivoAntNavigation { get; set; }
        public virtual EstadoActivo? EstadoActivoNavigation { get; set; }
        public virtual Responsable? ResponsableNavigation { get; set; }
        public virtual TipoAccionAf TipoAccionAfNavigation { get; set; } = null!;
        public virtual Ubicacion? UbicacionNavigation { get; set; }
    }
}
