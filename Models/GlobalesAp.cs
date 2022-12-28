using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesAp
    {
        public string MetodoCosteoMo { get; set; } = null!;
        public string MetodoCosteoGif { get; set; } = null!;
        public string RecetaSuma100 { get; set; } = null!;
        public short DecimalesReceta { get; set; }
        public short DecimalesCostos { get; set; }
        public short DecimalesTiempo { get; set; }
        public short DecimalesPorc { get; set; }
        public string MonedaDeCostos { get; set; } = null!;
        public string CantConDesperdi { get; set; } = null!;
        public string NivelFamilia { get; set; } = null!;
        public string TipoDeCambio { get; set; } = null!;
        public string? Versiones { get; set; }
        public string IntegracionConta { get; set; } = null!;
        public string? TipoContaOmision { get; set; }
        public short? ModAplicAsiento { get; set; }
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string DesglosarGif { get; set; } = null!;
        public string DesglosarMo { get; set; } = null!;
        public string? SalarioReferencia { get; set; }
        public string IncluirClientes { get; set; } = null!;
        public string PermiteTraslapes { get; set; } = null!;
        public string AsigLotProd { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual TipoCambio TipoDeCambioNavigation { get; set; } = null!;
    }
}
