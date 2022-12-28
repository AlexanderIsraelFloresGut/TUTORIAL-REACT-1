using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesSp2
    {
        public string Formula { get; set; } = null!;
        public DateTime UltFacturaLinea { get; set; }
        public DateTime UltTransaccionInv { get; set; }
        public DateTime UltOrdenCompra { get; set; }
        public DateTime UltOrdenCompraLinea { get; set; }
        public DateTime UltAuditTransInv { get; set; }
        public DateTime UltEmbarque { get; set; }
        public DateTime UltEmbarqueLinea { get; set; }
        public string UsaConsumo { get; set; } = null!;
        public string UsaRotacion { get; set; } = null!;
        public string UsaFrecuencia { get; set; } = null!;
        public string UsaMargen { get; set; } = null!;
        public string PeriodicidadAbc { get; set; } = null!;
        public string CategConsumo { get; set; } = null!;
        public string CategFrecuencia { get; set; } = null!;
        public string CategRotacion { get; set; } = null!;
        public string CategMargen { get; set; } = null!;
        public int PorcConsumoA { get; set; }
        public int PorcConsumoB { get; set; }
        public int PorcConsumoC { get; set; }
        public int PorcFrecuenciaA { get; set; }
        public int PorcFrecuenciaB { get; set; }
        public int PorcFrecuenciaC { get; set; }
        public int PorcRotacionA { get; set; }
        public int PorcRotacionB { get; set; }
        public int PorcRotacionC { get; set; }
        public int PorcMargenA { get; set; }
        public int PorcMargenB { get; set; }
        public int PorcMargenC { get; set; }
        public string ModuloInicializado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
