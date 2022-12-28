using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Cotizante
    {
        public Cotizante()
        {
            AdminCotizantes = new HashSet<AdminCotizante>();
        }

        public string Empleado { get; set; } = null!;
        public string TipoCotizante { get; set; } = null!;
        public string SubtipoCotizante { get; set; } = null!;
        public string CotizaPension { get; set; } = null!;
        public string ResideExterior { get; set; } = null!;
        public string CentroTrabajo { get; set; } = null!;
        public string Municipio { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string? DevSalIntegral { get; set; }
        public string ActividadAltoRiesgo { get; set; } = null!;
        public string? Pais { get; set; }
        public string? DivisionGeografica { get; set; }
        public string? TipoVinculacion { get; set; }
        public string? CondicionEspecial { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroTrabajo CentroTrabajoNavigation { get; set; } = null!;
        public virtual DivisionGeografica1? DivisionGeografica1 { get; set; }
        public virtual DivisionGeografica2? DivisionGeografica2 { get; set; }
        public virtual Empleado EmpleadoNavigation { get; set; } = null!;
        public virtual SubtipoCotizante SubtipoCotizanteNavigation { get; set; } = null!;
        public virtual TipoCotizante TipoCotizanteNavigation { get; set; } = null!;
        public virtual ICollection<AdminCotizante> AdminCotizantes { get; set; }
    }
}
