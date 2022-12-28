using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Clasificacion1
    {
        public Clasificacion1()
        {
            Articulo1Clasificacion1Navigations = new HashSet<Articulo1>();
            Articulo1Clasificacion2Navigations = new HashSet<Articulo1>();
            Articulo1Clasificacion3Navigations = new HashSet<Articulo1>();
            Articulo1Clasificacion4Navigations = new HashSet<Articulo1>();
            Articulo1Clasificacion5Navigations = new HashSet<Articulo1>();
            Articulo1Clasificacion6Navigations = new HashSet<Articulo1>();
            ClasificacionCompra1s = new HashSet<ClasificacionCompra1>();
            PedidoSugerido1Clasificacion1Navigations = new HashSet<PedidoSugerido1>();
            PedidoSugerido1Clasificacion2Navigations = new HashSet<PedidoSugerido1>();
            PedidoSugerido1Clasificacion3Navigations = new HashSet<PedidoSugerido1>();
            PedidoSugerido1Clasificacion4Navigations = new HashSet<PedidoSugerido1>();
            PedidoSugerido1Clasificacion5Navigations = new HashSet<PedidoSugerido1>();
            PedidoSugerido1Clasificacion6Navigations = new HashSet<PedidoSugerido1>();
            ReglaDescuento1s = new HashSet<ReglaDescuento1>();
            Retencione1s = new HashSet<Retencione1>();
        }

        public string Clasificacion { get; set; } = null!;
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

        public virtual SeriePlantilla1? PlantillaSerieNavigation { get; set; }
        public virtual UnidadDeMedidum1 UnidadMedidaNavigation { get; set; } = null!;
        public virtual ICollection<Articulo1> Articulo1Clasificacion1Navigations { get; set; }
        public virtual ICollection<Articulo1> Articulo1Clasificacion2Navigations { get; set; }
        public virtual ICollection<Articulo1> Articulo1Clasificacion3Navigations { get; set; }
        public virtual ICollection<Articulo1> Articulo1Clasificacion4Navigations { get; set; }
        public virtual ICollection<Articulo1> Articulo1Clasificacion5Navigations { get; set; }
        public virtual ICollection<Articulo1> Articulo1Clasificacion6Navigations { get; set; }
        public virtual ICollection<ClasificacionCompra1> ClasificacionCompra1s { get; set; }
        public virtual ICollection<PedidoSugerido1> PedidoSugerido1Clasificacion1Navigations { get; set; }
        public virtual ICollection<PedidoSugerido1> PedidoSugerido1Clasificacion2Navigations { get; set; }
        public virtual ICollection<PedidoSugerido1> PedidoSugerido1Clasificacion3Navigations { get; set; }
        public virtual ICollection<PedidoSugerido1> PedidoSugerido1Clasificacion4Navigations { get; set; }
        public virtual ICollection<PedidoSugerido1> PedidoSugerido1Clasificacion5Navigations { get; set; }
        public virtual ICollection<PedidoSugerido1> PedidoSugerido1Clasificacion6Navigations { get; set; }
        public virtual ICollection<ReglaDescuento1> ReglaDescuento1s { get; set; }
        public virtual ICollection<Retencione1> Retencione1s { get; set; }
    }
}
