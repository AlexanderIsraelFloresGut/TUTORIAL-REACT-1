using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdModulo
    {
        public DdModulo()
        {
            DdModuloTablas = new HashSet<DdModuloTabla>();
        }

        public string Modulo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Estandar { get; set; } = null!;
        public string Area { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DdArea AreaNavigation { get; set; } = null!;
        public virtual ICollection<DdModuloTabla> DdModuloTablas { get; set; }
    }
}
