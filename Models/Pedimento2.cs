using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Pedimento2
    {
        public Pedimento2()
        {
            Embarque2s = new HashSet<Embarque2>();
            PedimentoLote2s = new HashSet<PedimentoLote2>();
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

        public virtual Aduana2 AduanaNavigation { get; set; } = null!;
        public virtual AgenteAduanal2? AgenteAduanalNavigation { get; set; }
        public virtual ICollection<Embarque2> Embarque2s { get; set; }
        public virtual ICollection<PedimentoLote2> PedimentoLote2s { get; set; }
    }
}
