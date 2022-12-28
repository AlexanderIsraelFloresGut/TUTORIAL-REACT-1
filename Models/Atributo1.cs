using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Atributo1
    {
        public Atributo1()
        {
            ArticuloEspe1s = new HashSet<ArticuloEspe1>();
            AtribEquipo1s = new HashSet<AtribEquipo1>();
            AtributoValor1s = new HashSet<AtributoValor1>();
            LoteEspe1s = new HashSet<LoteEspe1>();
        }

        public string Atributo { get; set; } = null!;
        public string Clase { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ArticuloEspe1> ArticuloEspe1s { get; set; }
        public virtual ICollection<AtribEquipo1> AtribEquipo1s { get; set; }
        public virtual ICollection<AtributoValor1> AtributoValor1s { get; set; }
        public virtual ICollection<LoteEspe1> LoteEspe1s { get; set; }
    }
}
