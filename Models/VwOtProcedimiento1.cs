using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwOtProcedimiento1
    {
        public int? Solicitud { get; set; }
        public string? EmpSolicitante { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public string? Equipo { get; set; }
        public string? Procedimiento { get; set; }
        public string? VersionSt { get; set; }
        public string? DescripcionLarg { get; set; }
        public int OrdenTrabajo { get; set; }
        public DateTime FechaOrden { get; set; }
        public DateTime FechaRequerida { get; set; }
        public string DescripcionCorta { get; set; } = null!;
        public string? Notas { get; set; }
        public string? DescripcionFinal { get; set; }
    }
}
