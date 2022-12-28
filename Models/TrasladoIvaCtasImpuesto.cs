using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TrasladoIvaCtasImpuesto
    {
        public string Modulo { get; set; } = null!;
        public string Impuesto { get; set; } = null!;
        public string CentroOrigen { get; set; } = null!;
        public string CuentaOrigen { get; set; } = null!;
        public string CentroDestino { get; set; } = null!;
        public string CuentaDestino { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
