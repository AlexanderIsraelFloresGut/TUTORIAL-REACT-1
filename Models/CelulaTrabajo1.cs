using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CelulaTrabajo1
    {
        public CelulaTrabajo1()
        {
            CelulaPuesto1s = new HashSet<CelulaPuesto1>();
            CelulaRubro1s = new HashSet<CelulaRubro1>();
            Equipo1s = new HashSet<Equipo1>();
            EstrucProceso1s = new HashSet<EstrucProceso1>();
            LiqPcDesgRubro1s = new HashSet<LiqPcDesgRubro1>();
            OpOperacion1s = new HashSet<OpOperacion1>();
        }

        public string CelulaTrabajo { get; set; } = null!;
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

        public virtual Departamento1 DepartamentoNavigation { get; set; } = null!;
        public virtual ICollection<CelulaPuesto1> CelulaPuesto1s { get; set; }
        public virtual ICollection<CelulaRubro1> CelulaRubro1s { get; set; }
        public virtual ICollection<Equipo1> Equipo1s { get; set; }
        public virtual ICollection<EstrucProceso1> EstrucProceso1s { get; set; }
        public virtual ICollection<LiqPcDesgRubro1> LiqPcDesgRubro1s { get; set; }
        public virtual ICollection<OpOperacion1> OpOperacion1s { get; set; }
    }
}
