using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EspecEquipo
    {
        public EspecEquipo()
        {
            Medicions = new HashSet<Medicion>();
        }

        public string Equipo { get; set; } = null!;
        public string PuntoMedida { get; set; } = null!;
        public string UnidadMedicion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal MedidaNominal { get; set; }
        public decimal LimInferior { get; set; }
        public decimal LimSuperior { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Equipo EquipoNavigation { get; set; } = null!;
        public virtual UnidadMedicion UnidadMedicionNavigation { get; set; } = null!;
        public virtual ICollection<Medicion> Medicions { get; set; }
    }
}
