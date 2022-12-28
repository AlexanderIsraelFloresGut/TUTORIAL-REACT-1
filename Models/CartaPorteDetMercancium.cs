using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteDetMercancium
    {
        public CartaPorteDetMercancium()
        {
            CartaPorteMercancia = new HashSet<CartaPorteMercancium>();
        }

        public string DetMercancia { get; set; } = null!;
        public string? UnidadPeso { get; set; }
        public decimal? PesoBruto { get; set; }
        public decimal? PesoNeto { get; set; }
        public decimal? PesoTara { get; set; }
        public int? NumPiezas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CartaPorteMercancium> CartaPorteMercancia { get; set; }
    }
}
