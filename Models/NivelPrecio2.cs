using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NivelPrecio2
    {
        public NivelPrecio2()
        {
            Cliente2s = new HashSet<Cliente2>();
            Factura2s = new HashSet<Factura2>();
            Pedido2s = new HashSet<Pedido2>();
            VersionNivel2s = new HashSet<VersionNivel2>();
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

        public virtual CondicionPago2? CondicionPagoNavigation { get; set; }
        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<Factura2> Factura2s { get; set; }
        public virtual ICollection<Pedido2> Pedido2s { get; set; }
        public virtual ICollection<VersionNivel2> VersionNivel2s { get; set; }
    }
}
