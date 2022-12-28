using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TblNotificacionSolicitudOc
    {
        public int Id { get; set; }
        public string? SolicitudOc { get; set; }
        public string? Departamento { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaRequerida { get; set; }
        public string? Usuario { get; set; }
        public string? Rubro1 { get; set; }
        public string? Estado { get; set; }
        public DateTime FhGrabcion { get; set; }
        public string UsuarioGrabacion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
