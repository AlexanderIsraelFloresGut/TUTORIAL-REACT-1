using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperacionMo2
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public short Secuencia { get; set; }
        public string TipoManoObra { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public short CantidadEmpleados { get; set; }
        public decimal CantidadHoras { get; set; }
        public decimal CostoPorHoraLoc { get; set; }
        public decimal? CostoPorHoraDol { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OpOperacion2 O { get; set; } = null!;
        public virtual Puesto2 PuestoNavigation { get; set; } = null!;
    }
}
