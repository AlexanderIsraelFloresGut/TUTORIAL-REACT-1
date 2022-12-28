using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HistDeterioro1
    {
        public int HistDeterioro { get; set; }
        public string ActivoFijo { get; set; } = null!;
        public string Mejora { get; set; } = null!;
        public string? Desmantelamiento { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorLocal { get; set; }
        public decimal ValorDolar { get; set; }
        public decimal ValorLocalF { get; set; }
        public decimal ValorDolarF { get; set; }
        public decimal TipoCambio { get; set; }
        public string? Asiento { get; set; }
        public string? AsientoF { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ActivoMejora1 ActivoMejora1 { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
