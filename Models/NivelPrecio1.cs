using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NivelPrecio1
    {
        public NivelPrecio1()
        {
            Cliente1s = new HashSet<Cliente1>();
            Factura1s = new HashSet<Factura1>();
            Pedido1s = new HashSet<Pedido1>();
            VersionNivel1s = new HashSet<VersionNivel1>();
        }

        public string NivelPrecio { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string? CondicionPago { get; set; }
        public string EsquemaTrabajo { get; set; } = null!;
        public string Descuentos { get; set; } = null!;
        public string SugerirDescuento { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string SincMovil { get; set; } = null!;

        public virtual CondicionPago1? CondicionPagoNavigation { get; set; }
        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<Factura1> Factura1s { get; set; }
        public virtual ICollection<Pedido1> Pedido1s { get; set; }
        public virtual ICollection<VersionNivel1> VersionNivel1s { get; set; }
    }
}
