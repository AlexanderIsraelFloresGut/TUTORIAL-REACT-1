using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteOrigen
    {
        public string? Documento { get; set; }
        public string? TipoDocumento { get; set; }
        public string? IdOrigen { get; set; }
        public string? RfcRemitente { get; set; }
        public string? NombreRemitente { get; set; }
        public string? NumRegidTrib { get; set; }
        public string? ResidenciaFiscal { get; set; }
        public string? NumEstacion { get; set; }
        public string? NombreEstacion { get; set; }
        public string? NavegacionTrafico { get; set; }
        public DateTime? FechaHoraSalida { get; set; }
        public string? Ubicacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteEstacione? NumEstacionNavigation { get; set; }
        public virtual Pai1? ResidenciaFiscalNavigation { get; set; }
        public virtual Nit1? RfcRemitenteNavigation { get; set; }
        public virtual CartaPorteUbicacion? UbicacionNavigation { get; set; }
    }
}
