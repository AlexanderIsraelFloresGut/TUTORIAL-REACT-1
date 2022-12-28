using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoDiferido1
    {
        public string TipoDiferido { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Modalidad { get; set; } = null!;
        public decimal Valor { get; set; }
        public string Tipo { get; set; } = null!;
        public string Paquete { get; set; } = null!;
        public string TipoAsiento { get; set; } = null!;
        public string CtrDiferido { get; set; } = null!;
        public string CtaDiferido { get; set; } = null!;
        public string CtrContraasiento { get; set; } = null!;
        public string CtaContraasiento { get; set; } = null!;
        public string CtrAmortizacion { get; set; } = null!;
        public string CtaAmortizacion { get; set; } = null!;
        public string CtrGastoingreso { get; set; } = null!;
        public string CtaGastoingreso { get; set; } = null!;
        public string? Nit { get; set; }
        public string UsuarioUltMod { get; set; } = null!;
        public DateTime FechaUltMod { get; set; }
        public string UsuarioIngreso { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? ConceptoMe { get; set; }
    }
}
