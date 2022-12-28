using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Pedimento1
    {
        public Pedimento1()
        {
            Embarque1s = new HashSet<Embarque1>();
            PedimentoLote1s = new HashSet<PedimentoLote1>();
        }

        public string Pedimento { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Aduana { get; set; } = null!;
        public string? AgenteAduanal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Aduana1 AduanaNavigation { get; set; } = null!;
        public virtual AgenteAduanal1? AgenteAduanalNavigation { get; set; }
        public virtual ICollection<Embarque1> Embarque1s { get; set; }
        public virtual ICollection<PedimentoLote1> PedimentoLote1s { get; set; }
    }
}
