using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Medicion
    {
        public string Equipo { get; set; } = null!;
        public string PuntoMedida { get; set; } = null!;
        public string UnidadMedicion { get; set; } = null!;
        public DateTime FechaHoraMed { get; set; }
        public decimal ValorTipico { get; set; }
        public decimal ValorInferior { get; set; }
        public decimal ValorSuperior { get; set; }
        public int? OrdenTrabajo { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EspecEquipo EspecEquipo { get; set; } = null!;
        public virtual OrdenTrabajo? OrdenTrabajoNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
