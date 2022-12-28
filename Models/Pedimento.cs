using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Pedimento
    {
        public Pedimento()
        {
            Embarques = new HashSet<Embarque>();
            PedimentoLotes = new HashSet<PedimentoLote>();
        }

        public string Pedimento1 { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Aduana { get; set; } = null!;
        public string? AgenteAduanal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Aduana AduanaNavigation { get; set; } = null!;
        public virtual AgenteAduanal? AgenteAduanalNavigation { get; set; }
        public virtual ICollection<Embarque> Embarques { get; set; }
        public virtual ICollection<PedimentoLote> PedimentoLotes { get; set; }
    }
}
