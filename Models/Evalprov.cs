using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Evalprov
    {
        public string Proveedor { get; set; } = null!;
        public decimal? NotaCriterio1 { get; set; }
        public decimal? NotaCriterio2 { get; set; }
        public decimal? NotaCriterio3 { get; set; }
        public decimal? NotaCriterio4 { get; set; }
        public decimal? NotaCriterio5 { get; set; }
        public decimal? NotaCriterio6 { get; set; }
        public decimal? NotaCriterio7 { get; set; }
        public decimal? NotaCriterio8 { get; set; }
        public decimal? NotaCriterio9 { get; set; }
        public decimal? NotaCriterio10 { get; set; }
        public decimal? NotaProveedor { get; set; }
        public DateTime FechaAplicoEval { get; set; }
        public DateTime FechaProxAplica { get; set; }
        public string? ComentarioProv { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Proveedor ProveedorNavigation { get; set; } = null!;
    }
}
