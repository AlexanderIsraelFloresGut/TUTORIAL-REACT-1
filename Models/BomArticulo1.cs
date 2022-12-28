using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BomArticulo1
    {
        public string Usuario { get; set; } = null!;
        public int Linea { get; set; }
        public string? Articulo { get; set; }
        public string Estructura { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string EstOriginal { get; set; } = null!;
        public decimal CantAproducir { get; set; }
        public decimal? CantProcesada { get; set; }
        public decimal? CantProducida { get; set; }
        public decimal? Existencia { get; set; }
        public string Carga { get; set; } = null!;
        public string CkExistencia { get; set; } = null!;
        public decimal? CostoTotal { get; set; }
        public string? Comentario { get; set; }
        public string? Orden { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1? ArticuloNavigation { get; set; }
        public virtual EstrucManufactura1 EstrucManufactura1 { get; set; } = null!;
    }
}
