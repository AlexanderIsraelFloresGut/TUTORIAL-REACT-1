using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FacturaCancela1
    {
        public string TipoDocumento { get; set; } = null!;
        public string Factura { get; set; } = null!;
        public int NumeroPago { get; set; }
        public string Tipo { get; set; } = null!;
        public decimal Monto { get; set; }
        public string Moneda { get; set; } = null!;
        public string? NumDocumento { get; set; }
        public string? EntidadFinanciera { get; set; }
        public string? TipoTarjeta { get; set; }
        public string? NumAutoriza { get; set; }
        public string Usuario { get; set; } = null!;
        public string Caja { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string? Devolucion { get; set; }
        public string? CheckDevolucion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? FormaPagoDe { get; set; }

        public virtual Caja1 CajaNavigation { get; set; } = null!;
        public virtual EntidadFinanciera1? EntidadFinancieraNavigation { get; set; }
        public virtual Factura1 Factura1 { get; set; } = null!;
        public virtual TipoTarjetum1? TipoTarjetaNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
