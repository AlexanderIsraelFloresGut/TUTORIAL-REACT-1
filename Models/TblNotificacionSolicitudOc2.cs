using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TblNotificacionSolicitudOc2
    {
        public int Id { get; set; }
        public string? SolicitudOc { get; set; }
        public string? Departamento { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaRequerida { get; set; }
        public string? Usuario { get; set; }
        public string? Rubro1 { get; set; }
        public string? Estado { get; set; }
    }
}
