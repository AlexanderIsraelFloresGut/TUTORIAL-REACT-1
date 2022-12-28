using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CentroCostoRubro
    {
        public string Rubro { get; set; } = null!;
        public string CentroCostoRubro1 { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCosto CentroCostoRubro1Navigation { get; set; } = null!;
        public virtual RubroLiq RubroNavigation { get; set; } = null!;
    }
}
