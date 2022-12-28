using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AjusteConfig1
    {
        public AjusteConfig1()
        {
            AjusteSubsubtipo1s = new HashSet<AjusteSubsubtipo1>();
            AjusteSubtipo1s = new HashSet<AjusteSubtipo1>();
            ConsecAjusteConf1s = new HashSet<ConsecAjusteConf1>();
            Devolucion1s = new HashSet<Devolucion1>();
            LineaDocInv1s = new HashSet<LineaDocInv1>();
            TransaccionInv1s = new HashSet<TransaccionInv1>();
            UsuarioAjuste1s = new HashSet<UsuarioAjuste1>();
        }

        public string AjusteConfig { get; set; } = null!;
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

        public virtual ICollection<AjusteSubsubtipo1> AjusteSubsubtipo1s { get; set; }
        public virtual ICollection<AjusteSubtipo1> AjusteSubtipo1s { get; set; }
        public virtual ICollection<ConsecAjusteConf1> ConsecAjusteConf1s { get; set; }
        public virtual ICollection<Devolucion1> Devolucion1s { get; set; }
        public virtual ICollection<LineaDocInv1> LineaDocInv1s { get; set; }
        public virtual ICollection<TransaccionInv1> TransaccionInv1s { get; set; }
        public virtual ICollection<UsuarioAjuste1> UsuarioAjuste1s { get; set; }
    }
}
