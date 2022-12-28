using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AuxiliarCp1
    {
        public string Proveedor { get; set; } = null!;
        public string TipoDebito { get; set; } = null!;
        public string Debito { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string TipoCredito { get; set; } = null!;
        public string Credito { get; set; } = null!;
        public decimal MontoDebito { get; set; }
        public decimal MontoProv { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal MontoDolar { get; set; }
        public string MonedaDebito { get; set; } = null!;
        public decimal MontoCredito { get; set; }
        public string MonedaCredito { get; set; } = null!;
        public string? Asiento { get; set; }
        public string? TipoDocppago { get; set; }
        public string? DocumentoDocppago { get; set; }
        public string? TipoDocintcte { get; set; }
        public string? DocDocintcte { get; set; }
        public string? FoliosatDebito { get; set; }
        public string? FoliosatCredito { get; set; }
        public decimal? TipoCambioAplica { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? AsientoDifCambMr { get; set; }
        public decimal? MontoTotalRetPago { get; set; }
        public string? CodigoRetPago { get; set; }

        public virtual Retencione1? CodigoRetPagoNavigation { get; set; }
        public virtual DocumentosCp1 DocumentosCp1 { get; set; } = null!;
        public virtual DocumentosCp1 DocumentosCp1Navigation { get; set; } = null!;
        public virtual Monedum1 MonedaCreditoNavigation { get; set; } = null!;
        public virtual Monedum1 MonedaDebitoNavigation { get; set; } = null!;
        public virtual Proveedor1 ProveedorNavigation { get; set; } = null!;
    }
}
