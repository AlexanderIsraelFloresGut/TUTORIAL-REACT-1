using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperConsumo1
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public decimal CantidadEstandar { get; set; }
        public decimal CantidadConsumida { get; set; }
        public decimal CantidadReservada { get; set; }
        public decimal CostoStdLocal { get; set; }
        public decimal CostoStdDolar { get; set; }
        public decimal CostoRealLocal { get; set; }
        public decimal CostoRealDolar { get; set; }
        public string AceptaMovimientos { get; set; } = null!;
        public int? Secuencia { get; set; }
        public string PermiteBackflush { get; set; } = null!;
        public decimal CantidadPendAplicar { get; set; }
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
