using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Caja
    {
        public Caja()
        {
            AperturaCajas = new HashSet<AperturaCaja>();
            FacturaCancelas = new HashSet<FacturaCancela>();
            UsuarioCajaFas = new HashSet<UsuarioCajaFa>();
        }

        public string Caja1 { get; set; } = null!;
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

        public virtual ActivoFijo? ActivoFijoNavigation { get; set; }
        public virtual ICollection<AperturaCaja> AperturaCajas { get; set; }
        public virtual ICollection<FacturaCancela> FacturaCancelas { get; set; }
        public virtual ICollection<UsuarioCajaFa> UsuarioCajaFas { get; set; }
    }
}
