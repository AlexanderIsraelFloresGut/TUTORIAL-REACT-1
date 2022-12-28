using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteCarro
    {
        public CartaPorteCarro()
        {
            CartaPorteConteCarros = new HashSet<CartaPorteConteCarro>();
            CartaPorteFerroCarros = new HashSet<CartaPorteFerroCarro>();
        }

        public string Carro { get; set; } = null!;
        public string? TipoCarro { get; set; }
        public string? MatriculaCarro { get; set; }
        public string? GuiaCarro { get; set; }
        public decimal? ToneladasNetasCarro { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteTipoCarro? TipoCarroNavigation { get; set; }
        public virtual ICollection<CartaPorteConteCarro> CartaPorteConteCarros { get; set; }
        public virtual ICollection<CartaPorteFerroCarro> CartaPorteFerroCarros { get; set; }
    }
}
