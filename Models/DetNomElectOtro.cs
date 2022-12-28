using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetNomElectOtro
    {
        public DateTime Periodo { get; set; }
        public string CodigoTrabajador { get; set; } = null!;
        public string Rubro { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Pago { get; set; }
        public DateTime? Fecha { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
