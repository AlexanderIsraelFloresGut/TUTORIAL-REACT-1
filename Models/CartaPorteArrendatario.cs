using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteArrendatario
    {
        public string Arrendatario { get; set; } = null!;
        public string? RfcArrendatario { get; set; }
        public string? NombreArrendatario { get; set; }
        public string? NumRegIdtribArrendatario { get; set; }
        public string? ResidenciaFiscalArrendatario { get; set; }
        public string? Domicilio { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteDomicilio? DomicilioNavigation { get; set; }
        public virtual Pai1? ResidenciaFiscalArrendatarioNavigation { get; set; }
    }
}
