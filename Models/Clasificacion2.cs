using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Clasificacion2
    {
        public Clasificacion2()
        {
            Articulo2Clasificacion1Navigations = new HashSet<Articulo2>();
            Articulo2Clasificacion2Navigations = new HashSet<Articulo2>();
            Articulo2Clasificacion3Navigations = new HashSet<Articulo2>();
            Articulo2Clasificacion4Navigations = new HashSet<Articulo2>();
            Articulo2Clasificacion5Navigations = new HashSet<Articulo2>();
            Articulo2Clasificacion6Navigations = new HashSet<Articulo2>();
            ClasificacionCompra2s = new HashSet<ClasificacionCompra2>();
            PedidoSugerido2Clasificacion1Navigations = new HashSet<PedidoSugerido2>();
            PedidoSugerido2Clasificacion2Navigations = new HashSet<PedidoSugerido2>();
            PedidoSugerido2Clasificacion3Navigations = new HashSet<PedidoSugerido2>();
            PedidoSugerido2Clasificacion4Navigations = new HashSet<PedidoSugerido2>();
            PedidoSugerido2Clasificacion5Navigations = new HashSet<PedidoSugerido2>();
            PedidoSugerido2Clasificacion6Navigations = new HashSet<PedidoSugerido2>();
            ReglaDescuento2s = new HashSet<ReglaDescuento2>();
            Retencione2s = new HashSet<Retencione2>();
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

        public virtual SeriePlantilla2? PlantillaSerieNavigation { get; set; }
        public virtual UnidadDeMedidum2 UnidadMedidaNavigation { get; set; } = null!;
        public virtual ICollection<Articulo2> Articulo2Clasificacion1Navigations { get; set; }
        public virtual ICollection<Articulo2> Articulo2Clasificacion2Navigations { get; set; }
        public virtual ICollection<Articulo2> Articulo2Clasificacion3Navigations { get; set; }
        public virtual ICollection<Articulo2> Articulo2Clasificacion4Navigations { get; set; }
        public virtual ICollection<Articulo2> Articulo2Clasificacion5Navigations { get; set; }
        public virtual ICollection<Articulo2> Articulo2Clasificacion6Navigations { get; set; }
        public virtual ICollection<ClasificacionCompra2> ClasificacionCompra2s { get; set; }
        public virtual ICollection<PedidoSugerido2> PedidoSugerido2Clasificacion1Navigations { get; set; }
        public virtual ICollection<PedidoSugerido2> PedidoSugerido2Clasificacion2Navigations { get; set; }
        public virtual ICollection<PedidoSugerido2> PedidoSugerido2Clasificacion3Navigations { get; set; }
        public virtual ICollection<PedidoSugerido2> PedidoSugerido2Clasificacion4Navigations { get; set; }
        public virtual ICollection<PedidoSugerido2> PedidoSugerido2Clasificacion5Navigations { get; set; }
        public virtual ICollection<PedidoSugerido2> PedidoSugerido2Clasificacion6Navigations { get; set; }
        public virtual ICollection<ReglaDescuento2> ReglaDescuento2s { get; set; }
        public virtual ICollection<Retencione2> Retencione2s { get; set; }
    }
}
