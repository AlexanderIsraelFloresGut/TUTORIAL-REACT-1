using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstrucMaterial1
    {
        public string Articulo { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string Componente { get; set; } = null!;
        public string EntradaSalida { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public short TiempoPrevio { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal PorcDesperdicio { get; set; }
        public decimal PorcDeCosto { get; set; }
        public string? Referencia { get; set; }
        public string? Comentario { get; set; }
        public int? Secuencia { get; set; }
        public string PermiteBackflush { get; set; } = null!;
        public decimal? PorcCostoCoproducto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EstrucProceso1 EstrucProceso1 { get; set; } = null!;
    }
}
