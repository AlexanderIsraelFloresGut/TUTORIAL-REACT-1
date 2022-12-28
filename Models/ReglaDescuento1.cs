using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ReglaDescuento1
    {
        public ReglaDescuento1()
        {
            PaqDescRegDesc1s = new HashSet<PaqDescRegDesc1>();
        }

        public int ReglaDescuento { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public decimal? Descuento { get; set; }
        public int? Prioridad { get; set; }
        public string? CategoriaCliente { get; set; }
        public string? Cliente { get; set; }
        public string? Clasificacion { get; set; }
        public string? Articulo { get; set; }
        public string? ArticuloPatron { get; set; }
        public string? Notas { get; set; }
        public string TipoDescuento { get; set; } = null!;
        public decimal? CantidadCompra { get; set; }
        public decimal? CantidadFacturar { get; set; }
        public string? Clasificacion2 { get; set; }
        public string? Clasificacion3 { get; set; }
        public string? Clasificacion4 { get; set; }
        public string? Clasificacion5 { get; set; }
        public string? Clasificacion6 { get; set; }
        public string RequiereAutorizacion { get; set; } = null!;
        public string? FormaPago { get; set; }
        public string? DetalleFormaPago { get; set; }
        public decimal? MinimoDocumento { get; set; }
        public decimal? MinimoPago { get; set; }
        public decimal? DescFormaPago { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1? ArticuloNavigation { get; set; }
        public virtual CategoriaCliente1? CategoriaClienteNavigation { get; set; }
        public virtual Clasificacion1? ClasificacionNavigation { get; set; }
        public virtual Cliente1? ClienteNavigation { get; set; }
        public virtual ICollection<PaqDescRegDesc1> PaqDescRegDesc1s { get; set; }
    }
}
