using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesA2
    {
        public DateTime FechaAdvIni { get; set; }
        public DateTime FechaAdvFin { get; set; }
        public DateTime FechaTrabajoIni { get; set; }
        public DateTime FechaTrabajoFin { get; set; }
        public string NombreMonFunc { get; set; } = null!;
        public string NombreMonRep { get; set; } = null!;
        public string SimboloMonFunc { get; set; } = null!;
        public string SimboloMonRep { get; set; } = null!;
        public string Impuesto1Desc { get; set; } = null!;
        public string Impuesto2Desc { get; set; } = null!;
        public string PaisLocal { get; set; } = null!;
        public string MonedaLocal { get; set; } = null!;
        public string MonedaDolar { get; set; } = null!;
        public string TipoCambioDolar { get; set; } = null!;
        public string? PatronCcosto { get; set; }
        public string CobrarImp1ppCc { get; set; } = null!;
        public string CobrarImp2ppCc { get; set; } = null!;
        public string CalcFraccIntcte { get; set; } = null!;
        public string AjustarFechapago { get; set; } = null!;
        public string AjFchpagoAtras { get; set; } = null!;
        public string AjFchpagoAde { get; set; } = null!;
        public string ReplTcCodigo { get; set; } = null!;
        public string ReplTcHist { get; set; } = null!;
        public string? ReplListaCia { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? CodSmtp { get; set; }
        public string? RutaDocs { get; set; }

        public virtual Monedum2 MonedaDolarNavigation { get; set; } = null!;
        public virtual Monedum2 MonedaLocalNavigation { get; set; } = null!;
        public virtual Pai2 PaisLocalNavigation { get; set; } = null!;
        public virtual TipoCambio2 TipoCambioDolarNavigation { get; set; } = null!;
    }
}
