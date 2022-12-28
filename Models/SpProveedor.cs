using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SpProveedor
    {
        public string Proveedor { get; set; } = null!;
        public string? Nombre { get; set; }
        public string CondicionPago { get; set; } = null!;
        public string Local { get; set; } = null!;
        public string Impuesto1Incluido { get; set; } = null!;
        public string Contacto { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string? Telefono1 { get; set; }
        public decimal OrdenMinima { get; set; }
        public string Moneda { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public decimal Saldo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
