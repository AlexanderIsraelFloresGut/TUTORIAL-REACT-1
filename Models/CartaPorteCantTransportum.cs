using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteCantTransportum
    {
        public string CantTransporta { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public string? IdOrigen { get; set; }
        public string? IdDestino { get; set; }
        public string? Cvestransporte { get; set; }
        public string? Mercancia { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteCveTransporte? CvestransporteNavigation { get; set; }
        public virtual CartaPorteMercancium? MercanciaNavigation { get; set; }
    }
}
