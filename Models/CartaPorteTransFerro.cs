using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteTransFerro
    {
        public CartaPorteTransFerro()
        {
            CartaPorteFerroCarros = new HashSet<CartaPorteFerroCarro>();
        }

        public string TransFerro { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string? TipoDeServicio { get; set; }
        public string? NombreAseg { get; set; }
        public string? NumPolizaSeguro { get; set; }
        public string? Concesionario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteTipoServicio? TipoDeServicioNavigation { get; set; }
        public virtual ICollection<CartaPorteFerroCarro> CartaPorteFerroCarros { get; set; }
    }
}
