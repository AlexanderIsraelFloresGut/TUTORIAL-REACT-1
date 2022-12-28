using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HistDepreciacion1
    {
        public HistDepreciacion1()
        {
            ActivoHistReval1ConsecDeprCNavigations = new HashSet<ActivoHistReval1>();
            ActivoHistReval1ConsecDeprFNavigations = new HashSet<ActivoHistReval1>();
            DeprCentroCosto1s = new HashSet<DeprCentroCosto1>();
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

        public virtual ActivoMejora1 ActivoMejora1 { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<ActivoHistReval1> ActivoHistReval1ConsecDeprCNavigations { get; set; }
        public virtual ICollection<ActivoHistReval1> ActivoHistReval1ConsecDeprFNavigations { get; set; }
        public virtual ICollection<DeprCentroCosto1> DeprCentroCosto1s { get; set; }
    }
}
