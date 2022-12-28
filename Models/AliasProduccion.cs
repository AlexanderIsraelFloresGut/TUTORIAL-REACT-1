using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AliasProduccion
    {
        public AliasProduccion()
        {
            ArticuloEspes = new HashSet<ArticuloEspe>();
            EstrucManufacturas = new HashSet<EstrucManufactura>();
            ImplosionAliasFinalNavigations = new HashSet<Implosion>();
            ImplosionAliasInicialNavigations = new HashSet<Implosion>();
            ImplosionDetalles = new HashSet<ImplosionDetalle>();
        }

        public string AliasProduccion1 { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
        public virtual CostoComponente CostoComponente { get; set; } = null!;
        public virtual Disenadum Disenadum { get; set; } = null!;
        public virtual ICollection<ArticuloEspe> ArticuloEspes { get; set; }
        public virtual ICollection<EstrucManufactura> EstrucManufacturas { get; set; }
        public virtual ICollection<Implosion> ImplosionAliasFinalNavigations { get; set; }
        public virtual ICollection<Implosion> ImplosionAliasInicialNavigations { get; set; }
        public virtual ICollection<ImplosionDetalle> ImplosionDetalles { get; set; }
    }
}
