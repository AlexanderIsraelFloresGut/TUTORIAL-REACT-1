using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Cotizante1
    {
        public Cotizante1()
        {
            AdminCotizante1s = new HashSet<AdminCotizante1>();
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
        public DateTime? FechaExterior { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroTrabajo1 CentroTrabajoNavigation { get; set; } = null!;
        public virtual DivisionGeografica11? DivisionGeografica11 { get; set; }
        public virtual DivisionGeografica21? DivisionGeografica21 { get; set; }
        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual SubtipoCotizante1 SubtipoCotizanteNavigation { get; set; } = null!;
        public virtual TipoCotizante1 TipoCotizanteNavigation { get; set; } = null!;
        public virtual ICollection<AdminCotizante1> AdminCotizante1s { get; set; }
    }
}
