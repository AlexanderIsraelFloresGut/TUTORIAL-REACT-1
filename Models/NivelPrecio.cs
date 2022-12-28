using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NivelPrecio
    {
        public NivelPrecio()
        {
            Clientes = new HashSet<Cliente>();
            Facturas = new HashSet<Factura>();
            Pedidos = new HashSet<Pedido>();
            VersionNivels = new HashSet<VersionNivel>();
        }

        public string NivelPrecio1 { get; set; } = null!;
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

        public virtual CondicionPago? CondicionPagoNavigation { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<VersionNivel> VersionNivels { get; set; }
    }
}
