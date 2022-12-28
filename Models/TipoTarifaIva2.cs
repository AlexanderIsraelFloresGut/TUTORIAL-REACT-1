using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoTarifaIva2
    {
        public TipoTarifaIva2()
        {
            Cliente2s = new HashSet<Cliente2>();
            Proveedor2s = new HashSet<Proveedor2>();
        }

        public string TipoTarifa { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoImpuesto { get; set; } = null!;
        public decimal? Porcentaje { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual TipoImpuesto2 TipoImpuestoNavigation { get; set; } = null!;
        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<Proveedor2> Proveedor2s { get; set; }
    }
}
