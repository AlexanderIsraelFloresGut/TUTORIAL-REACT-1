using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConsecutivoCi
    {
        public ConsecutivoCi()
        {
            AuditTransInvs = new HashSet<AuditTransInv>();
            Bodegas = new HashSet<Bodega>();
            ConsecAjusteConfs = new HashSet<ConsecAjusteConf>();
            ConsecUsuarios = new HashSet<ConsecUsuario>();
            DocumentoInvs = new HashSet<DocumentoInv>();
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
        public virtual ICollection<AuditTransInv> AuditTransInvs { get; set; }
        public virtual ICollection<Bodega> Bodegas { get; set; }
        public virtual ICollection<ConsecAjusteConf> ConsecAjusteConfs { get; set; }
        public virtual ICollection<ConsecUsuario> ConsecUsuarios { get; set; }
        public virtual ICollection<DocumentoInv> DocumentoInvs { get; set; }
    }
}
