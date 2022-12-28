using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteCatDerechoPaso
    {
        public CartaPorteCatDerechoPaso()
        {
            CartaPorteDerePasos = new HashSet<CartaPorteDerePaso>();
        }

        public string Codigo { get; set; } = null!;
        public string? DerechoPaso { get; set; }
        public string? Entre { get; set; }
        public string? Hasta { get; set; }
        public string? OtorgaRecibe { get; set; }
        public string? Concesionario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CartaPorteDerePaso> CartaPorteDerePasos { get; set; }
    }
}
