using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AjusteConfig
    {
        public AjusteConfig()
        {
            AjusteSubsubtipos = new HashSet<AjusteSubsubtipo>();
            AjusteSubtipos = new HashSet<AjusteSubtipo>();
            ConsecAjusteConfs = new HashSet<ConsecAjusteConf>();
            Devolucions = new HashSet<Devolucion>();
            LineaDocInvs = new HashSet<LineaDocInv>();
            TransaccionInvs = new HashSet<TransaccionInv>();
            UsuarioAjustes = new HashSet<UsuarioAjuste>();
        }

        public string AjusteConfig1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string AjusteBase { get; set; } = null!;
        public string Activa { get; set; } = null!;
        public string Ingreso { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<AjusteSubsubtipo> AjusteSubsubtipos { get; set; }
        public virtual ICollection<AjusteSubtipo> AjusteSubtipos { get; set; }
        public virtual ICollection<ConsecAjusteConf> ConsecAjusteConfs { get; set; }
        public virtual ICollection<Devolucion> Devolucions { get; set; }
        public virtual ICollection<LineaDocInv> LineaDocInvs { get; set; }
        public virtual ICollection<TransaccionInv> TransaccionInvs { get; set; }
        public virtual ICollection<UsuarioAjuste> UsuarioAjustes { get; set; }
    }
}
