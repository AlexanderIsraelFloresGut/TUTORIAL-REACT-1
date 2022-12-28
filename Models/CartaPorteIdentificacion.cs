using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteIdentificacion
    {
        public string IdGuia { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string NumeroGuiaIdentificacion { get; set; } = null!;
        public string DescripGuiaIdentificacion { get; set; } = null!;
        public decimal PesoGuiaIdentificacion { get; set; }
        public string Mercancia { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteMercancium MercanciaNavigation { get; set; } = null!;
    }
}
