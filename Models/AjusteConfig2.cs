using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AjusteConfig2
    {
        public AjusteConfig2()
        {
            AjusteSubsubtipo2s = new HashSet<AjusteSubsubtipo2>();
            AjusteSubtipo2s = new HashSet<AjusteSubtipo2>();
            ConsecAjusteConf2s = new HashSet<ConsecAjusteConf2>();
            Devolucion2s = new HashSet<Devolucion2>();
            LineaDocInv2s = new HashSet<LineaDocInv2>();
            TransaccionInv2s = new HashSet<TransaccionInv2>();
            UsuarioAjuste2s = new HashSet<UsuarioAjuste2>();
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

        public virtual ICollection<AjusteSubsubtipo2> AjusteSubsubtipo2s { get; set; }
        public virtual ICollection<AjusteSubtipo2> AjusteSubtipo2s { get; set; }
        public virtual ICollection<ConsecAjusteConf2> ConsecAjusteConf2s { get; set; }
        public virtual ICollection<Devolucion2> Devolucion2s { get; set; }
        public virtual ICollection<LineaDocInv2> LineaDocInv2s { get; set; }
        public virtual ICollection<TransaccionInv2> TransaccionInv2s { get; set; }
        public virtual ICollection<UsuarioAjuste2> UsuarioAjuste2s { get; set; }
    }
}
