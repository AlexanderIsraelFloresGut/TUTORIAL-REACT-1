using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPortePropietario
    {
        public string Propietario { get; set; } = null!;
        public string? RfcPropietario { get; set; }
        public string? NombrePropietario { get; set; }
        public string? NumRegIdtribPropietario { get; set; }
        public string? ResidenciaFiscalPropietario { get; set; }
        public string? Domicilio { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteDomicilio? DomicilioNavigation { get; set; }
        public virtual Pai1? ResidenciaFiscalPropietarioNavigation { get; set; }
    }
}
