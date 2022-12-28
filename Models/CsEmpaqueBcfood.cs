using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsEmpaqueBcfood
    {
        public int Empaque { get; set; }
        public string Cliente { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public long OrdenProduccion { get; set; }
        public decimal Cajas { get; set; }
        public string Talla { get; set; } = null!;
        public decimal PesoNeto { get; set; }
        public decimal PesoBruto { get; set; }
        public decimal Pescados { get; set; }
        public string? Pedido { get; set; }
        public bool Impreso { get; set; }
        public decimal PesoInyectado { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
