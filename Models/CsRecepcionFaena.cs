using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsRecepcionFaena
    {
        public int Recepcion { get; set; }
        public string? Faena { get; set; }
        public string? Orden { get; set; }
        public string? Articulo { get; set; }
        public decimal? Libras { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Total { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? Aprovechamiento { get; set; }
        public decimal? LibrasBono { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Usuario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
