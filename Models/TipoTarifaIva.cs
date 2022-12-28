using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoTarifaIva
    {
        public TipoTarifaIva()
        {
            Clientes = new HashSet<Cliente>();
            Proveedors = new HashSet<Proveedor>();
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

        public virtual TipoImpuesto TipoImpuestoNavigation { get; set; } = null!;
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}
