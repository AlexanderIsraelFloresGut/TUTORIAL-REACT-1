using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Caja1
    {
        public Caja1()
        {
            AperturaCaja1s = new HashSet<AperturaCaja1>();
            FacturaCancela1s = new HashSet<FacturaCancela1>();
            UsuarioCajaFa1s = new HashSet<UsuarioCajaFa1>();
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

        public virtual ActivoFijo1? ActivoFijoNavigation { get; set; }
        public virtual ICollection<AperturaCaja1> AperturaCaja1s { get; set; }
        public virtual ICollection<FacturaCancela1> FacturaCancela1s { get; set; }
        public virtual ICollection<UsuarioCajaFa1> UsuarioCajaFa1s { get; set; }
    }
}
