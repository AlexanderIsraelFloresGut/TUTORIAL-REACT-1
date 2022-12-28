using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConsecutivoCi1
    {
        public ConsecutivoCi1()
        {
            AuditTransInv1s = new HashSet<AuditTransInv1>();
            Bodega1s = new HashSet<Bodega1>();
            ConsecAjusteConf1s = new HashSet<ConsecAjusteConf1>();
            ConsecUsuario1s = new HashSet<ConsecUsuario1>();
            DocumentoInv1s = new HashSet<DocumentoInv1>();
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
        public string? TieneComplemento { get; set; }

        public virtual Usuario2 UltimoUsuarioNavigation { get; set; } = null!;
        public virtual ICollection<AuditTransInv1> AuditTransInv1s { get; set; }
        public virtual ICollection<Bodega1> Bodega1s { get; set; }
        public virtual ICollection<ConsecAjusteConf1> ConsecAjusteConf1s { get; set; }
        public virtual ICollection<ConsecUsuario1> ConsecUsuario1s { get; set; }
        public virtual ICollection<DocumentoInv1> DocumentoInv1s { get; set; }
    }
}
