using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Atributo2
    {
        public Atributo2()
        {
            ArticuloEspe2s = new HashSet<ArticuloEspe2>();
            AtributoValor2s = new HashSet<AtributoValor2>();
            LoteEspe2s = new HashSet<LoteEspe2>();
        }

        public string Atributo { get; set; } = null!;
        public string Clase { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ArticuloEspe2> ArticuloEspe2s { get; set; }
        public virtual ICollection<AtributoValor2> AtributoValor2s { get; set; }
        public virtual ICollection<LoteEspe2> LoteEspe2s { get; set; }
    }
}
