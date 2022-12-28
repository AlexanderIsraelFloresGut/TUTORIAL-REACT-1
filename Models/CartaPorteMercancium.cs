using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteMercancium
    {
        public CartaPorteMercancium()
        {
            CartaPorteCantTransporta = new HashSet<CartaPorteCantTransportum>();
            CartaPorteIdentificacions = new HashSet<CartaPorteIdentificacion>();
            CartaPortePedimentos = new HashSet<CartaPortePedimento>();
        }

        public string Mercancia { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string? BienesTransp { get; set; }
        public string? ClaveStcc { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public string? ClaveUnidad { get; set; }
        public string? Unidad { get; set; }
        public string? Dimensiones { get; set; }
        public string? MaterialPeligroso { get; set; }
        public string? CveMaterialPeligroso { get; set; }
        public string? Embalaje { get; set; }
        public string? DescripEmbalaje { get; set; }
        public decimal? PesoEnKg { get; set; }
        public decimal? ValorMercancia { get; set; }
        public string? Moneda { get; set; }
        public string? FraccionArancelaria { get; set; }
        public string? UuidComercioext { get; set; }
        public string? DetMercancia { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteProdServ? BienesTranspNavigation { get; set; }
        public virtual CartaPorteClaveStcc? ClaveStccNavigation { get; set; }
        public virtual CartaPorteMatePeligroso? CveMaterialPeligrosoNavigation { get; set; }
        public virtual CartaPorteDetMercancium? DetMercanciaNavigation { get; set; }
        public virtual CartaPorteTipoEmbalaje? EmbalajeNavigation { get; set; }
        public virtual Monedum1? MonedaNavigation { get; set; }
        public virtual ICollection<CartaPorteCantTransportum> CartaPorteCantTransporta { get; set; }
        public virtual ICollection<CartaPorteIdentificacion> CartaPorteIdentificacions { get; set; }
        public virtual ICollection<CartaPortePedimento> CartaPortePedimentos { get; set; }
    }
}
