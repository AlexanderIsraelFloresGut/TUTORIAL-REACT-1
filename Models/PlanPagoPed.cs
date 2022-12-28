using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PlanPagoPed
    {
        public int ConsecutivoPago { get; set; }
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public DateTime FechaRige { get; set; }
        public DateTime FechaVence { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Saldo { get; set; }
        public decimal MontoPrincipal { get; set; }
        public decimal SaldoPrincipal { get; set; }
        public decimal MontoAmortiza { get; set; }
        public decimal SaldoAmortiza { get; set; }
        public decimal MontoInteres { get; set; }
        public decimal SaldoInteres { get; set; }
        public decimal MontoCuota { get; set; }
        public decimal SaldoCuota { get; set; }
        public DateTime? FechaProyectada { get; set; }
        public decimal? MontoImpRenta { get; set; }
        public decimal? MontoImpRentaLocal { get; set; }
        public decimal? MontoImpRentaDolar { get; set; }
        public decimal? MontoImpCree1 { get; set; }
        public decimal? MontoImpCree1Local { get; set; }
        public decimal? MontoImpCree1Dolar { get; set; }
        public decimal? MontoImpCree2 { get; set; }
        public decimal? MontoImpCree2Local { get; set; }
        public decimal? MontoImpCree2Dolar { get; set; }
        public decimal? MontoGanOcasional { get; set; }
        public decimal? MontoGanOcasionalLocal { get; set; }
        public decimal? MontoGanOcasionalDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Pedido DocumentoNavigation { get; set; } = null!;
    }
}
