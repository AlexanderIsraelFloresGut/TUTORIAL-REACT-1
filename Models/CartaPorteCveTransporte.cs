using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteCveTransporte
    {
        public CartaPorteCveTransporte()
        {
            CartaPorteCantTransporta = new HashSet<CartaPorteCantTransportum>();
            CartaPorteCveTransporteNavigations = new HashSet<CartaPorte>();
            CartaPorteViaEntradaSalidaNavigations = new HashSet<CartaPorte>();
        }

        public string Codigo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CartaPorteCantTransportum> CartaPorteCantTransporta { get; set; }
        public virtual ICollection<CartaPorte> CartaPorteCveTransporteNavigations { get; set; }
        public virtual ICollection<CartaPorte> CartaPorteViaEntradaSalidaNavigations { get; set; }
    }
}
