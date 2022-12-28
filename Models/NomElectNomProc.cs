using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NomElectNomProc
    {
        public DateTime Periodo { get; set; }
        public string CodigoTrabajador { get; set; } = null!;
        public int Id { get; set; }
        public string Nomina { get; set; } = null!;
        public int NumeroNomina { get; set; }
        public string Tipo { get; set; } = null!;
        public string TipoXml { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DetNomElectEmp IdNavigation { get; set; } = null!;
    }
}
