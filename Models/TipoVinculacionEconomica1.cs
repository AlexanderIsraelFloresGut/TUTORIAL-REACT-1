using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoVinculacionEconomica1
    {
        public TipoVinculacionEconomica1()
        {
            Proveedor1s = new HashSet<Proveedor1>();
        }

        public string TipoVinculacion { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? VinculacionEconomica { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Proveedor1> Proveedor1s { get; set; }
    }
}
