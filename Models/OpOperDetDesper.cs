using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperDetDesper
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public DateTime FechaHoraProduc { get; set; }
        public decimal SecuenciaDesp { get; set; }
        public string ArticuloDesp { get; set; } = null!;
        public string? DescArticuloDesp { get; set; }
        public decimal CantidadDesp { get; set; }
        public string? Notas { get; set; }
        public string UnidadMedida { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OpOperDet OpOperDet { get; set; } = null!;
        public virtual UnidadDeMedidum UnidadMedidaNavigation { get; set; } = null!;
    }
}
