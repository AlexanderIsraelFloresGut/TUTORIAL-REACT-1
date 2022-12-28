using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VAsociacionPaisImpExcep1
    {
        public string CodigoArancel { get; set; } = null!;
        public string ImpuestoCompra { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Existe { get; set; } = null!;
        public string? Tipo { get; set; }
        public string? Pais { get; set; }
        public string? Nombre { get; set; }
        public string UtilizadoSiempre { get; set; } = null!;
        public byte? NoteExistsFlag { get; set; }
        public DateTime? RecordDate { get; set; }
        public Guid? RowPointer { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
