using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RangosAutorizaDep
    {
        public string Departamento { get; set; } = null!;
        public int ConsecDep { get; set; }
        public decimal MontoMaxCompra { get; set; }
        public int CantAutorizReq { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Departamento DepartamentoNavigation { get; set; } = null!;
    }
}
