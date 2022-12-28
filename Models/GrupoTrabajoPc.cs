using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GrupoTrabajoPc
    {
        public GrupoTrabajoPc()
        {
            GrupoTrabajoPcLineas = new HashSet<GrupoTrabajoPcLinea>();
        }

        public string GrupoTrabajo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Horario { get; set; }
        public string? TipoMo { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFin { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual FactorAjuHora? HorarioNavigation { get; set; }
        public virtual ICollection<GrupoTrabajoPcLinea> GrupoTrabajoPcLineas { get; set; }
    }
}
