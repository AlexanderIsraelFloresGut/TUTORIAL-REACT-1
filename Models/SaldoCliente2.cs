using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SaldoCliente2
    {
        public string Cliente { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal Saldo { get; set; }
        public decimal SaldoCorporacion { get; set; }
        public decimal SaldoSucursales { get; set; }
        public DateTime FechaUltMov { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Cliente2 ClienteNavigation { get; set; } = null!;
        public virtual Monedum2 MonedaNavigation { get; set; } = null!;
    }
}
