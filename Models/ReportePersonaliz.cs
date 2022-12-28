using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ReportePersonaliz
    {
        public ReportePersonaliz()
        {
            ReporteDetalles = new HashSet<ReporteDetalle>();
            ReporteFiltros = new HashSet<ReporteFiltro>();
            ReporteParametros = new HashSet<ReporteParametro>();
            ReporteUbicacions = new HashSet<ReporteUbicacion>();
        }

        public string Accion { get; set; } = null!;
        public string? Reporte { get; set; }
        public string? Descripcion { get; set; }
        public string? Modulo { get; set; }
        public string Tipo { get; set; } = null!;
        public string? Estandar { get; set; }
        public string? Modalidad { get; set; }
        public string? Formato { get; set; }
        public string? Personalizacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ReporteDefinicion ReporteDefinicion { get; set; } = null!;
        public virtual ReportePantallaParam ReportePantallaParam { get; set; } = null!;
        public virtual ICollection<ReporteDetalle> ReporteDetalles { get; set; }
        public virtual ICollection<ReporteFiltro> ReporteFiltros { get; set; }
        public virtual ICollection<ReporteParametro> ReporteParametros { get; set; }
        public virtual ICollection<ReporteUbicacion> ReporteUbicacions { get; set; }
    }
}
