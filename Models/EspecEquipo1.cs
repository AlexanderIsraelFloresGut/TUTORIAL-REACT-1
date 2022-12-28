using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EspecEquipo1
    {
        public EspecEquipo1()
        {
            Medicion1s = new HashSet<Medicion1>();
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

        public virtual Equipo1 EquipoNavigation { get; set; } = null!;
        public virtual UnidadMedicion1 UnidadMedicionNavigation { get; set; } = null!;
        public virtual ICollection<Medicion1> Medicion1s { get; set; }
    }
}
