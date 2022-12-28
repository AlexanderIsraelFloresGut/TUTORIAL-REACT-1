using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TmpOpOperDetEquipoExt1
    {
        public string Seleccionado { get; set; } = null!;
        public DateTime FechaProceso { get; set; }
        public string? Clasificacion1 { get; set; }
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string OperacionDesc { get; set; } = null!;
        public short Secuencia { get; set; }
        public DateTime FechaHoraProduc { get; set; }
        public string Estructura { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string ArticuloDesc { get; set; } = null!;
        public decimal PesoNeto { get; set; }
        public string UnidadAlmacen { get; set; } = null!;
        public decimal CantidadProducida { get; set; }
        public decimal? PesoProrrateo { get; set; }
        public decimal? PorcPesoProrrateo { get; set; }
        public decimal? CantHoras { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
