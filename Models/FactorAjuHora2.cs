using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FactorAjuHora2
    {
        public FactorAjuHora2()
        {
            GrupoTrabajoPc2s = new HashSet<GrupoTrabajoPc2>();
            OpOperDetMo2s = new HashSet<OpOperDetMo2>();
        }

        public string Horario { get; set; } = null!;
        public decimal Factor { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Horario2 HorarioNavigation { get; set; } = null!;
        public virtual ICollection<GrupoTrabajoPc2> GrupoTrabajoPc2s { get; set; }
        public virtual ICollection<OpOperDetMo2> OpOperDetMo2s { get; set; }
    }
}
