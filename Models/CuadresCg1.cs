using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuadresCg1
    {
        public int CuadresCg { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Modulo { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string Filtros { get; set; } = null!;
        public string Cuentas { get; set; } = null!;
        public string Otros { get; set; } = null!;
        public int Tab { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
