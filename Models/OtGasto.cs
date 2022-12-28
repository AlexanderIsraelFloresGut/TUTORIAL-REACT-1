using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OtGasto
    {
        public int OrdenTrabajo { get; set; }
        public int Consecutivo { get; set; }
        public string Equipo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal CostoTotalLocal { get; set; }
        public decimal CostoTotalDolar { get; set; }
        public string Aprobado { get; set; } = null!;
        public string Contabilizado { get; set; } = null!;
        public string? Asiento { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Equipo EquipoNavigation { get; set; } = null!;
        public virtual OrdenTrabajo OrdenTrabajoNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
