using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwInfretalinsa
    {
        public DateTime FechaDocumento { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public DateTime? FechaRetencion { get; set; }
        public string Proveedor { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public string Ruc { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string? UsuarioAprobacion { get; set; }
        public string Documento { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public string? Notas { get; set; }
        public decimal MontoCp { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal MontoDolar { get; set; }
        public string? Asiento { get; set; }
        public decimal? Base { get; set; }
        public decimal Monto { get; set; }
        public string CodigoRetencion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Porcentaje { get; set; }
    }
}
