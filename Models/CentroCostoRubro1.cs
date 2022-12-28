using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CentroCostoRubro1
    {
        public string Rubro { get; set; } = null!;
        public string CentroCostoRubro { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCosto1 CentroCostoRubroNavigation { get; set; } = null!;
        public virtual RubroLiq1 RubroNavigation { get; set; } = null!;
    }
}
