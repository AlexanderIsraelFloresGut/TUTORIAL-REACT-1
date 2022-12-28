using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CelulaTrabajo
    {
        public CelulaTrabajo()
        {
            CelulaPuestos = new HashSet<CelulaPuesto>();
            CelulaRubros = new HashSet<CelulaRubro>();
            Equipos = new HashSet<Equipo>();
            EstrucProcesos = new HashSet<EstrucProceso>();
            LiqPcDesgRubros = new HashSet<LiqPcDesgRubro>();
            OpOperacions = new HashSet<OpOperacion>();
        }

        public string CelulaTrabajo1 { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public short NumeroDeTurnos { get; set; }
        public decimal? EficienciaPromedi { get; set; }
        public decimal? EficienciaEstanda { get; set; }
        public decimal? ProduccionEstanda { get; set; }
        public decimal? ProduccionReal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Departamento DepartamentoNavigation { get; set; } = null!;
        public virtual ICollection<CelulaPuesto> CelulaPuestos { get; set; }
        public virtual ICollection<CelulaRubro> CelulaRubros { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }
        public virtual ICollection<EstrucProceso> EstrucProcesos { get; set; }
        public virtual ICollection<LiqPcDesgRubro> LiqPcDesgRubros { get; set; }
        public virtual ICollection<OpOperacion> OpOperacions { get; set; }
    }
}
