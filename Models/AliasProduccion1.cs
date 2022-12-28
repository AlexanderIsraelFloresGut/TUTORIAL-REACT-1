using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AliasProduccion1
    {
        public AliasProduccion1()
        {
            ArticuloEspe1s = new HashSet<ArticuloEspe1>();
            EstrucManufactura1s = new HashSet<EstrucManufactura1>();
            Implosion1AliasFinalNavigations = new HashSet<Implosion1>();
            Implosion1AliasInicialNavigations = new HashSet<Implosion1>();
            ImplosionDetalle1s = new HashSet<ImplosionDetalle1>();
        }

        public string AliasProduccion { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
        public virtual CostoComponente1 CostoComponente1 { get; set; } = null!;
        public virtual Disenadum1 Disenadum1 { get; set; } = null!;
        public virtual ICollection<ArticuloEspe1> ArticuloEspe1s { get; set; }
        public virtual ICollection<EstrucManufactura1> EstrucManufactura1s { get; set; }
        public virtual ICollection<Implosion1> Implosion1AliasFinalNavigations { get; set; }
        public virtual ICollection<Implosion1> Implosion1AliasInicialNavigations { get; set; }
        public virtual ICollection<ImplosionDetalle1> ImplosionDetalle1s { get; set; }
    }
}
