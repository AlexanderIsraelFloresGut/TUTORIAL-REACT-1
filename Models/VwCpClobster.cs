using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwCpClobster
    {
        public string Empresa { get; set; } = null!;
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public DateTime FechaDocumento { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Asiento { get; set; }
        public string Documento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public short? Subtipo { get; set; }
        public string Aplicacion { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string TipoDc { get; set; } = null!;
        public decimal Monto { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal MontoDolar { get; set; }
    }
}
