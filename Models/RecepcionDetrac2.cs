using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RecepcionDetrac2
    {
        public string Constancia { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string TipoDebito { get; set; } = null!;
        public string Debito { get; set; } = null!;
        public string TipoCredito { get; set; } = null!;
        public string Credito { get; set; } = null!;
        public DateTime FechaDoc { get; set; }
        public string TipoDetraccion { get; set; } = null!;
        public string CodDetraccion { get; set; } = null!;
        public decimal Monto { get; set; }
        public DateTime FechaOperacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DocumentosCp2 DocumentosCp2 { get; set; } = null!;
        public virtual DocumentosCp2 DocumentosCp2Navigation { get; set; } = null!;
        public virtual Proveedor2 ProveedorNavigation { get; set; } = null!;
        public virtual TiposDetraccione2 TiposDetraccione2 { get; set; } = null!;
    }
}
