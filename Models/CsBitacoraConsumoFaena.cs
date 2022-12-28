using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsBitacoraConsumoFaena
    {
        public int Id { get; set; }
        public string? Faena { get; set; }
        public int? AuditTransInv { get; set; }
        public string? Articulo { get; set; }
        public string? Bodega { get; set; }
        public decimal? CantDisponible { get; set; }
        public decimal? CantSolicitada { get; set; }
        public decimal? CantDespachada { get; set; }
        public string? Nota { get; set; }
        public DateTime? FechaTransaccion { get; set; }
        public string? UsuarioTransaccion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
