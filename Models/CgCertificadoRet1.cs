using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CgCertificadoRet1
    {
        public string Guid { get; set; } = null!;
        public string? Asiento { get; set; }
        public int? Consecutivo { get; set; }
        public string? CuentaContable { get; set; }
        public string? DescripcionCuenta { get; set; }
        public string? Nit { get; set; }
        public string? RazonSocial { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? DebitoLocal { get; set; }
        public decimal? CreditoLocal { get; set; }
        public decimal? DebitoDolar { get; set; }
        public decimal? CreditoDolar { get; set; }
        public decimal? BaseDolar { get; set; }
        public decimal? BaseLocal { get; set; }
        public string? SaldoNormal { get; set; }
        public string? Pais { get; set; }
        public string? DivGeo1 { get; set; }
        public string? DivGeo2 { get; set; }
        public string? Ubicacion { get; set; }
        public string Contabilidad { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
