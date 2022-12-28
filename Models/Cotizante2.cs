using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Cotizante2
    {
        public Cotizante2()
        {
            AdminCotizante2s = new HashSet<AdminCotizante2>();
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

        public virtual CentroTrabajo2 CentroTrabajoNavigation { get; set; } = null!;
        public virtual DivisionGeografica12? DivisionGeografica12 { get; set; }
        public virtual DivisionGeografica22? DivisionGeografica22 { get; set; }
        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual SubtipoCotizante2 SubtipoCotizanteNavigation { get; set; } = null!;
        public virtual TipoCotizante2 TipoCotizanteNavigation { get; set; } = null!;
        public virtual ICollection<AdminCotizante2> AdminCotizante2s { get; set; }
    }
}
