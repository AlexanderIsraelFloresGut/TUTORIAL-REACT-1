using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuadreContum2
    {
        public int CuadresCg { get; set; }
        public string Asiento { get; set; } = null!;
        public int Linea { get; set; }
        public string Ubicacion { get; set; } = null!;
        public string Origen { get; set; } = null!;
        public string Contabilidad { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Cuenta { get; set; } = null!;
        public string? CuentaDesc { get; set; }
        public string Centro { get; set; } = null!;
        public string? CentroDesc { get; set; }
        public string? Nit { get; set; }
        public string? NitDesc { get; set; }
        public string Fuente { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public decimal? DebitoLoc { get; set; }
        public decimal? DebitoDol { get; set; }
        public decimal? CreditoLoc { get; set; }
        public decimal? CreditoDol { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
