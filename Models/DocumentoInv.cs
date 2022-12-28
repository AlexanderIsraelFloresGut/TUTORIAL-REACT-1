using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocumentoInv
    {
        public DocumentoInv()
        {
            LineaDocInvs = new HashSet<LineaDocInv>();
        }

        public string PaqueteInventario { get; set; } = null!;
        public string DocumentoInv1 { get; set; } = null!;
        public string? Consecutivo { get; set; }
        public string Referencia { get; set; } = null!;
        public DateTime FechaHorCreacion { get; set; }
        public DateTime FechaDocumento { get; set; }
        public string Seleccionado { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string? MensajeSistema { get; set; }
        public string? UsuarioApro { get; set; }
        public DateTime? FechaHoraAprob { get; set; }
        public string? Aprobado { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ConsecutivoCi? ConsecutivoNavigation { get; set; }
        public virtual PaqueteInventario PaqueteInventarioNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioAproNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<LineaDocInv> LineaDocInvs { get; set; }
    }
}
