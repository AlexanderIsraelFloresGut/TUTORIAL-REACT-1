using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteConteCarro
    {
        public string ConteCarro { get; set; } = null!;
        public string? TipoContenedor { get; set; }
        public decimal? PesoContenedorVacio { get; set; }
        public decimal? PesoNetoMercancia { get; set; }
        public string Carro { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteCarro CarroNavigation { get; set; } = null!;
        public virtual CartaPorteCatContenedor? TipoContenedorNavigation { get; set; }
    }
}
