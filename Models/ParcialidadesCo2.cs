using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ParcialidadesCo2
    {
        public string Proveedor { get; set; } = null!;
        public string TipoDocOrigen { get; set; } = null!;
        public string DocumentoOrigen { get; set; } = null!;
        public short Parcialidad { get; set; }
        public DateTime FechaRige { get; set; }
        public DateTime FechaVence { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Saldo { get; set; }
        public decimal SaldoLocal { get; set; }
        public decimal SaldoDolar { get; set; }
        public decimal? MontoPrincipal { get; set; }
        public decimal? MontoPrincipalLoc { get; set; }
        public decimal? MontoPrincipalDol { get; set; }
        public decimal? MontoAmortiza { get; set; }
        public decimal? MontoAmortizaLoc { get; set; }
        public decimal? MontoAmortizaDol { get; set; }
        public decimal? SaldoAmortiza { get; set; }
        public decimal? SaldoAmortizaLoc { get; set; }
        public decimal? SaldoAmortizaDol { get; set; }
        public decimal? MontoInteres { get; set; }
        public decimal? MontoInteresLoc { get; set; }
        public decimal? MontoInteresDol { get; set; }
        public decimal? SaldoInteres { get; set; }
        public decimal? SaldoInteresLoc { get; set; }
        public decimal? SaldoInteresDol { get; set; }
        public decimal? MontoCuota { get; set; }
        public decimal? MontoCuotaLoc { get; set; }
        public decimal? MontoCuotaDol { get; set; }
        public decimal? SaldoCuota { get; set; }
        public decimal? SaldoCuotaLoc { get; set; }
        public decimal? SaldoCuotaDol { get; set; }
        public decimal? SaldoPrincipal { get; set; }
        public decimal? SaldoPrincipalLoc { get; set; }
        public decimal? SaldoPrincipalDol { get; set; }
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

        public virtual DocumentoEmbarque2 DocumentoEmbarque2 { get; set; } = null!;
    }
}
