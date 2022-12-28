using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstrucProcMo
    {
        public string Articulo { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public short Secuencia { get; set; }
        public string TipoManoObra { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public short CantidadEmpleados { get; set; }
        public decimal CantidadHoras { get; set; }
        public decimal CostoPorHora { get; set; }
        public decimal? CostoPorHoraD { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EstrucProceso EstrucProceso { get; set; } = null!;
        public virtual Puesto PuestoNavigation { get; set; } = null!;
    }
}
