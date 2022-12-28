using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteOperador
    {
        public CartaPorteOperador()
        {
            CartaPorteFiguraPartes = new HashSet<CartaPorteFiguraParte>();
            CartaPorteFiguraTransportes = new HashSet<CartaPorteFiguraTransporte>();
        }

        public string Operador { get; set; } = null!;
        public string? RfcOperador { get; set; }
        public string? NumLicencia { get; set; }
        public string? NombreOperador { get; set; }
        public string? NumRegIdtribOperador { get; set; }
        public string? ResidenciaFiscalOperador { get; set; }
        public string? Domicilio { get; set; }
        public string? TipoFigura { get; set; }
        public string? DescripcionFigura { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteDomicilio? DomicilioNavigation { get; set; }
        public virtual Pai1? ResidenciaFiscalOperadorNavigation { get; set; }
        public virtual CartaPorteCatTransporte? TipoFiguraNavigation { get; set; }
        public virtual ICollection<CartaPorteFiguraParte> CartaPorteFiguraPartes { get; set; }
        public virtual ICollection<CartaPorteFiguraTransporte> CartaPorteFiguraTransportes { get; set; }
    }
}
