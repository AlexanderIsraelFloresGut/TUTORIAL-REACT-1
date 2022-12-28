using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Atributo
    {
        public Atributo()
        {
            ArticuloEspes = new HashSet<ArticuloEspe>();
            AtribEquipos = new HashSet<AtribEquipo>();
            AtributoValors = new HashSet<AtributoValor>();
            LoteEspes = new HashSet<LoteEspe>();
        }

        public string Atributo1 { get; set; } = null!;
        public string Clase { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ArticuloEspe> ArticuloEspes { get; set; }
        public virtual ICollection<AtribEquipo> AtribEquipos { get; set; }
        public virtual ICollection<AtributoValor> AtributoValors { get; set; }
        public virtual ICollection<LoteEspe> LoteEspes { get; set; }
    }
}
