using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoNomiNeto1
    {
        public string Empleado { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public decimal TotalBeneficios { get; set; }
        public decimal TotalDeduccion { get; set; }
        public decimal TotalAnticipos { get; set; }
        public decimal TotalAportes { get; set; }
        public decimal Neto { get; set; }
        public string? DocumentoImpreso { get; set; }
        public decimal? NumeroDocumento { get; set; }
        public string? DocumentoSeleccio { get; set; }
        public string? CuentaBancoDoc { get; set; }
        public string? AsientoDocumento { get; set; }
        public string? Notas { get; set; }
        public string Calculado { get; set; } = null!;
        public string? FormaPago { get; set; }
        public short? DiasLaborados { get; set; }
        public decimal? SalariopdLocal { get; set; }
        public decimal? SalariopdDolar { get; set; }
        public decimal? SalariopdNomina { get; set; }
        public string? SalariopdCalculo { get; set; }
        public decimal? TipoCambio { get; set; }
        public string? EstadoNomina { get; set; }
        public DateTime? FechaCalculoSpd { get; set; }
        public int? Liquidacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? FichaSipe { get; set; }

        public virtual CuentaBancarium1? CuentaBancoDocNavigation { get; set; }
        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual NominaHistorico1 N { get; set; } = null!;
    }
}
