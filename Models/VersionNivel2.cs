using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VersionNivel2
    {
        public VersionNivel2()
        {
            ArticuloPrecio2s = new HashSet<ArticuloPrecio2>();
            EscalaBonif2s = new HashSet<EscalaBonif2>();
            EscalaDcto2s = new HashSet<EscalaDcto2>();
        }

        public string NivelPrecio { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public int Version { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCorte { get; set; }
        public string Estado { get; set; } = null!;
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FchHoraCreacion { get; set; }
        public string? UsuarioUltModif { get; set; }
        public DateTime? FchHoraUltModif { get; set; }
        public string? UsuarioAprobacion { get; set; }
        public DateTime? FchHoraAprobacio { get; set; }
        public string? UsuarioAnulacion { get; set; }
        public DateTime? FchHoraAnulacion { get; set; }
        public string? Identificador { get; set; }
        public string Impuesto1Incluido { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? PrecioReferenciaDe { get; set; }
        public string SincMovil { get; set; } = null!;

        public virtual NivelPrecio2 NivelPrecio2 { get; set; } = null!;
        public virtual ICollection<ArticuloPrecio2> ArticuloPrecio2s { get; set; }
        public virtual ICollection<EscalaBonif2> EscalaBonif2s { get; set; }
        public virtual ICollection<EscalaDcto2> EscalaDcto2s { get; set; }
    }
}
