using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConsecutivoCi2
    {
        public ConsecutivoCi2()
        {
            AuditTransInv2s = new HashSet<AuditTransInv2>();
            Bodega2s = new HashSet<Bodega2>();
            ConsecAjusteConf2s = new HashSet<ConsecAjusteConf2>();
            ConsecUsuario2s = new HashSet<ConsecUsuario2>();
            DocumentoInv2s = new HashSet<DocumentoInv2>();
        }

        public string Consecutivo { get; set; } = null!;
        public string UltimoUsuario { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Mascara { get; set; } = null!;
        public string SiguienteConsec { get; set; } = null!;
        public string Editable { get; set; } = null!;
        public string MultiplesTrans { get; set; } = null!;
        public string? FormatoImp { get; set; }
        public DateTime UltFechaHora { get; set; }
        public string TodasTrans { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string UsaTraslado { get; set; } = null!;
        public string? EmailCfdi { get; set; }

        public virtual Usuario2 UltimoUsuarioNavigation { get; set; } = null!;
        public virtual ICollection<AuditTransInv2> AuditTransInv2s { get; set; }
        public virtual ICollection<Bodega2> Bodega2s { get; set; }
        public virtual ICollection<ConsecAjusteConf2> ConsecAjusteConf2s { get; set; }
        public virtual ICollection<ConsecUsuario2> ConsecUsuario2s { get; set; }
        public virtual ICollection<DocumentoInv2> DocumentoInv2s { get; set; }
    }
}
