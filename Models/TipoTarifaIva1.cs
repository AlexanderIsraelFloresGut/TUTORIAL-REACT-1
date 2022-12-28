using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoTarifaIva1
    {
        public TipoTarifaIva1()
        {
            Cliente1s = new HashSet<Cliente1>();
            Proveedor1s = new HashSet<Proveedor1>();
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

        public virtual TipoImpuesto1 TipoImpuestoNavigation { get; set; } = null!;
        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<Proveedor1> Proveedor1s { get; set; }
    }
}
