using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorte
    {
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string? TranspInternac { get; set; }
        public string? EntradaSalidaMerc { get; set; }
        public string? ViaEntradaSalida { get; set; }
        public decimal? TotalDistRec { get; set; }
        public string? CveTransporte { get; set; }
        public string? Aprobado { get; set; }
        public string? Campo1 { get; set; }
        public string? Campo2 { get; set; }
        public string? Campo3 { get; set; }
        public string? Campo4 { get; set; }
        public string? Campo5 { get; set; }
        public string? PaisOrigenDestino { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteCveTransporte? CveTransporteNavigation { get; set; }
        public virtual Pai1? PaisOrigenDestinoNavigation { get; set; }
        public virtual CartaPorteCveTransporte? ViaEntradaSalidaNavigation { get; set; }
    }
}
