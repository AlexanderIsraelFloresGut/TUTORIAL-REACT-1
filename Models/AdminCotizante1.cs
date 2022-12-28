using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AdminCotizante1
    {
        public int Consecutivo { get; set; }
        public string Empleado { get; set; } = null!;
        public string Administradora { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaSalida { get; set; }
        public int? NumeroAccion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Administradora1 AdministradoraNavigation { get; set; } = null!;
        public virtual Cotizante1 EmpleadoNavigation { get; set; } = null!;
        public virtual EmpleadoAccPer1? NumeroAccionNavigation { get; set; }
    }
}
