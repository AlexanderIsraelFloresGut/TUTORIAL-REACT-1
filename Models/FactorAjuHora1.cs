using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FactorAjuHora1
    {
        public FactorAjuHora1()
        {
            GrupoTrabajoPc1s = new HashSet<GrupoTrabajoPc1>();
            OpOperDetMo1s = new HashSet<OpOperDetMo1>();
        }

        public string Horario { get; set; } = null!;
        public decimal Factor { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Horario1 HorarioNavigation { get; set; } = null!;
        public virtual ICollection<GrupoTrabajoPc1> GrupoTrabajoPc1s { get; set; }
        public virtual ICollection<OpOperDetMo1> OpOperDetMo1s { get; set; }
    }
}
