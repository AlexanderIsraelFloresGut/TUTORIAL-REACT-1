using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SugerenciaOpMrp
    {
        public string PdrmriCodesc { get; set; } = null!;
        public int PdrmriNrolot { get; set; }
        public int PdrmriNroitm { get; set; }
        public string PdrmriArtcod { get; set; } = null!;
        public DateTime? PdrmriFchhas { get; set; }
        public DateTime PdrmriFchini { get; set; }
        public DateTime? FechaRequerida { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public decimal? PdrmriCantid { get; set; }
        public decimal CantProcesada { get; set; }
        public decimal CantAsignada { get; set; }
        public string Origen { get; set; } = null!;
        public string? Mrpfirme { get; set; }
        public string Tipo { get; set; } = null!;
        public string? DocumentoRef { get; set; }
        public string? ConsumoInterno { get; set; }
        public int? PdrmriNrofor { get; set; }
        public string? Estado { get; set; }
        public string? Pedido { get; set; }
        public string? GeneradaDesde { get; set; }
        public string Consolidada { get; set; } = null!;
        public decimal? CantidadModificada { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
