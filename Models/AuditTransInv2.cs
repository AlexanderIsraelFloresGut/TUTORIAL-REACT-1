using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AuditTransInv2
    {
        public AuditTransInv2()
        {
            Despacho2s = new HashSet<Despacho2>();
            TransaccionInv2s = new HashSet<TransaccionInv2>();
        }

        public int AuditTransInv { get; set; }
        public string? Consecutivo { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string ModuloOrigen { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string? Asiento { get; set; }
        public string? UsuarioApro { get; set; }
        public DateTime? FechaHoraAprob { get; set; }
        public string? PaqueteInventario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ConsecutivoCi2? ConsecutivoNavigation { get; set; }
        public virtual Usuario2? UsuarioAproNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<Despacho2> Despacho2s { get; set; }
        public virtual ICollection<TransaccionInv2> TransaccionInv2s { get; set; }
    }
}
