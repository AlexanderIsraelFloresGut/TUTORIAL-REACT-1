using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoContrato2
    {
        public TipoContrato2()
        {
            EmpleadoContrato2s = new HashSet<EmpleadoContrato2>();
        }

        public string TipoContrato { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? JornadaParcPerm { get; set; }
        public decimal? Horas { get; set; }
        public string? TipoContratoNe { get; set; }

        public virtual TipoContratoNe2? TipoContratoNeNavigation { get; set; }
        public virtual ICollection<EmpleadoContrato2> EmpleadoContrato2s { get; set; }
    }
}
