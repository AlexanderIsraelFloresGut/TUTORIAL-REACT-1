using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HistDepreciacion2
    {
        public HistDepreciacion2()
        {
            ActivoHistReval2ConsecDeprCNavigations = new HashSet<ActivoHistReval2>();
            ActivoHistReval2ConsecDeprFNavigations = new HashSet<ActivoHistReval2>();
            DeprCentroCosto2s = new HashSet<DeprCentroCosto2>();
        }

        public int HistDepreciacion { get; set; }
        public string ActivoFijo { get; set; } = null!;
        public string Mejora { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Contabilidad { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string Ajuste { get; set; } = null!;
        public string Metodo { get; set; } = null!;
        public decimal DeprLocal { get; set; }
        public decimal DeprDolar { get; set; }
        public string? Asiento { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? Desmantelamiento { get; set; }

        public virtual ActivoMejora2 ActivoMejora2 { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<ActivoHistReval2> ActivoHistReval2ConsecDeprCNavigations { get; set; }
        public virtual ICollection<ActivoHistReval2> ActivoHistReval2ConsecDeprFNavigations { get; set; }
        public virtual ICollection<DeprCentroCosto2> DeprCentroCosto2s { get; set; }
    }
}
