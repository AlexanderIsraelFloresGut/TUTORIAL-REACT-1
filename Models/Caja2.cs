using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Caja2
    {
        public Caja2()
        {
            AperturaCaja2s = new HashSet<AperturaCaja2>();
            FacturaCancela2s = new HashSet<FacturaCancela2>();
            UsuarioCajaFa2s = new HashSet<UsuarioCajaFa2>();
        }

        public string Caja { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string? ActivoFijo { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ActivoFijo2? ActivoFijoNavigation { get; set; }
        public virtual ICollection<AperturaCaja2> AperturaCaja2s { get; set; }
        public virtual ICollection<FacturaCancela2> FacturaCancela2s { get; set; }
        public virtual ICollection<UsuarioCajaFa2> UsuarioCajaFa2s { get; set; }
    }
}
