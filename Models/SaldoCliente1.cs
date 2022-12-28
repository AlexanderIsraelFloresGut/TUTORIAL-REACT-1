using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SaldoCliente1
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

        public virtual Cliente1 ClienteNavigation { get; set; } = null!;
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
    }
}
