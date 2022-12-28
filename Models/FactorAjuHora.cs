using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FactorAjuHora
    {
        public FactorAjuHora()
        {
            GrupoTrabajoPcs = new HashSet<GrupoTrabajoPc>();
            OpOperDetMos = new HashSet<OpOperDetMo>();
        }

        public string Horario { get; set; } = null!;
        public decimal Factor { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Horario HorarioNavigation { get; set; } = null!;
        public virtual ICollection<GrupoTrabajoPc> GrupoTrabajoPcs { get; set; }
        public virtual ICollection<OpOperDetMo> OpOperDetMos { get; set; }
    }
}
