using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwGtosmescorriente
    {
        public string? Filtro { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public DateTime FechaDocumento { get; set; }
        public string Proveedor { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public short Subtipo { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Ctacontable { get; set; }
        public string Nombredectacontable { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public decimal Montoc { get; set; }
        public decimal Montou { get; set; }
        public string? Usuario { get; set; }
        public string CreatedBy { get; set; } = null!;
    }
}
