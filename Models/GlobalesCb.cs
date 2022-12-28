using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesCb
    {
        public string PausarEnCheques { get; set; } = null!;
        public string FecAsientoCheq { get; set; } = null!;
        public string ImpCheqPantalla { get; set; } = null!;
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string? AsientoDep { get; set; }
        public string? AsientoNcr { get; set; }
        public string? AsientoOcr { get; set; }
        public string? AsientoChq { get; set; }
        public string? AsientoNdb { get; set; }
        public string? AsientoOdb { get; set; }
        public string? AsientoTefdb { get; set; }
        public string? AsientoTefcr { get; set; }
        public DateTime FechaUltDifcamb { get; set; }
        public string ConcilNoentregado { get; set; } = null!;
        public string DefdocEntregado { get; set; } = null!;
        public string IntegracionConta { get; set; } = null!;
        public short ModAplicAsiento { get; set; }
        public string TipoContaOmision { get; set; } = null!;
        public string Copiarnotasenasnt { get; set; } = null!;
        public string MostrarChqSug { get; set; } = null!;
        public string ImprimirMontoMon { get; set; } = null!;
        public int CantLineasAsnt { get; set; }
        public string ValidarDocAsnt { get; set; } = null!;
        public string VerCtasInactivas { get; set; } = null!;
        public string FormaCreacion { get; set; } = null!;
        public string? UsarubrosCtabanco { get; set; }
        public string? Rubro1Ctabanco { get; set; }
        public string? Rubro2Ctabanco { get; set; }
        public string? Rubro3Ctabanco { get; set; }
        public string? Rubro4Ctabanco { get; set; }
        public string? Rubro5Ctabanco { get; set; }
        public string? Rubro6Ctabanco { get; set; }
        public string? Rubro7Ctabanco { get; set; }
        public string? Rubro8Ctabanco { get; set; }
        public string? Rubro9Ctabanco { get; set; }
        public string? Rubro10Ctabanco { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? ConseLote { get; set; }

        public virtual Paquete? PaqueteNavigation { get; set; }
        public virtual TipoAsiento? TipoAsientoNavigation { get; set; }
    }
}
