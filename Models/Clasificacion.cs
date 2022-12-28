using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Clasificacion
    {
        public Clasificacion()
        {
            ArticuloClasificacion1Navigations = new HashSet<Articulo>();
            ArticuloClasificacion2Navigations = new HashSet<Articulo>();
            ArticuloClasificacion3Navigations = new HashSet<Articulo>();
            ArticuloClasificacion4Navigations = new HashSet<Articulo>();
            ArticuloClasificacion5Navigations = new HashSet<Articulo>();
            ArticuloClasificacion6Navigations = new HashSet<Articulo>();
            ClasificacionCompras = new HashSet<ClasificacionCompra>();
            PedidoSugeridoClasificacion1Navigations = new HashSet<PedidoSugerido>();
            PedidoSugeridoClasificacion2Navigations = new HashSet<PedidoSugerido>();
            PedidoSugeridoClasificacion3Navigations = new HashSet<PedidoSugerido>();
            PedidoSugeridoClasificacion4Navigations = new HashSet<PedidoSugerido>();
            PedidoSugeridoClasificacion5Navigations = new HashSet<PedidoSugerido>();
            PedidoSugeridoClasificacion6Navigations = new HashSet<PedidoSugerido>();
            ReglaDescuentos = new HashSet<ReglaDescuento>();
            Retenciones = new HashSet<Retencione>();
        }

        public string Clasificacion1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public short Agrupacion { get; set; }
        public string UsaNumerosSerie { get; set; } = null!;
        public string? PlantillaSerie { get; set; }
        public string? AporteCodigo { get; set; }
        public string? TipoCodigoBarras { get; set; }
        public string UnidadMedida { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual SeriePlantilla? PlantillaSerieNavigation { get; set; }
        public virtual UnidadDeMedidum UnidadMedidaNavigation { get; set; } = null!;
        public virtual ICollection<Articulo> ArticuloClasificacion1Navigations { get; set; }
        public virtual ICollection<Articulo> ArticuloClasificacion2Navigations { get; set; }
        public virtual ICollection<Articulo> ArticuloClasificacion3Navigations { get; set; }
        public virtual ICollection<Articulo> ArticuloClasificacion4Navigations { get; set; }
        public virtual ICollection<Articulo> ArticuloClasificacion5Navigations { get; set; }
        public virtual ICollection<Articulo> ArticuloClasificacion6Navigations { get; set; }
        public virtual ICollection<ClasificacionCompra> ClasificacionCompras { get; set; }
        public virtual ICollection<PedidoSugerido> PedidoSugeridoClasificacion1Navigations { get; set; }
        public virtual ICollection<PedidoSugerido> PedidoSugeridoClasificacion2Navigations { get; set; }
        public virtual ICollection<PedidoSugerido> PedidoSugeridoClasificacion3Navigations { get; set; }
        public virtual ICollection<PedidoSugerido> PedidoSugeridoClasificacion4Navigations { get; set; }
        public virtual ICollection<PedidoSugerido> PedidoSugeridoClasificacion5Navigations { get; set; }
        public virtual ICollection<PedidoSugerido> PedidoSugeridoClasificacion6Navigations { get; set; }
        public virtual ICollection<ReglaDescuento> ReglaDescuentos { get; set; }
        public virtual ICollection<Retencione> Retenciones { get; set; }
    }
}
