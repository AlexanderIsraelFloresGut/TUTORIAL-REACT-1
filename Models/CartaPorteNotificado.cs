using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteNotificado
    {
        public string Notificado { get; set; } = null!;
        public string? RfcNotificado { get; set; }
        public string? NombreNotificado { get; set; }
        public string? NumRegIdtribNotificado { get; set; }
        public string? ResidenciaFiscalNotificado { get; set; }
        public string? Domicilio { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteDomicilio? DomicilioNavigation { get; set; }
        public virtual Pai1? ResidenciaFiscalNotificadoNavigation { get; set; }
    }
}
