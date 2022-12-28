using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ImplosionDetalle1
    {
        public string Usuario { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Estructura { get; set; } = null!;
        public decimal? ExistenciaReal { get; set; }
        public decimal? ExistenciaAjustad { get; set; }
        public decimal? CostoEstandar { get; set; }
        public decimal? ProdSugerida { get; set; }
        public decimal? ProdAjustada { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
        public virtual AliasProduccion1 EstructuraNavigation { get; set; } = null!;
        public virtual Implosion1 UsuarioNavigation { get; set; } = null!;
    }
}
