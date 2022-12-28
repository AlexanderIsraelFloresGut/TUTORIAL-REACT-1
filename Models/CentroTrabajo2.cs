using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CentroTrabajo2
    {
        public CentroTrabajo2()
        {
            Cotizante2s = new HashSet<Cotizante2>();
        }

        public string CentroTrabajo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Porcentaje { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Cotizante2> Cotizante2s { get; set; }
    }
}
