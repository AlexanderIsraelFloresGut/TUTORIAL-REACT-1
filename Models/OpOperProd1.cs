using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperProd1
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public decimal CantidadEstandar { get; set; }
        public decimal PorcDeCosto { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal? PorcCostoCoproducto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
        public virtual OpOperacion1 O { get; set; } = null!;
    }
}
