using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteTransMaritimo
    {
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string? PermSct { get; set; }
        public string? NumPermisoSct { get; set; }
        public string? NombreAseg { get; set; }
        public string? NumPolizaSeguro { get; set; }
        public string? TipoEmbarcacion { get; set; }
        public string? Matricula { get; set; }
        public string? NumeroOmi { get; set; }
        public int? AnioEmbarcacion { get; set; }
        public string? NombreEmbarc { get; set; }
        public string? NacionalidadEmbarc { get; set; }
        public decimal? UnidadesDearqbruto { get; set; }
        public string? TipoCarga { get; set; }
        public string? NumCertitc { get; set; }
        public decimal? Eslora { get; set; }
        public decimal? Manga { get; set; }
        public decimal? Calado { get; set; }
        public string? LineaNaviera { get; set; }
        public string? NombreAgentenaviero { get; set; }
        public string? NumAutorizacionnaviero { get; set; }
        public string? NumViaje { get; set; }
        public string? NumConocembarc { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Pai1? NacionalidadEmbarcNavigation { get; set; }
        public virtual CartaPorteAutoNaviero? NumAutorizacionnavieroNavigation { get; set; }
        public virtual CartaPorteTipoPermiso? PermSctNavigation { get; set; }
        public virtual CartaPorteTipoCarga? TipoCargaNavigation { get; set; }
        public virtual CartaPorteConfigMaritima? TipoEmbarcacionNavigation { get; set; }
    }
}
