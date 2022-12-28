using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetNomElectEmp
    {
        public DetNomElectEmp()
        {
            NomElectAcciones = new HashSet<NomElectAccione>();
            NomElectNomProcs = new HashSet<NomElectNomProc>();
        }

        public string CodigoTrabajador { get; set; } = null!;
        public string? Consecutivo { get; set; }
        public DateTime Periodo { get; set; }
        public string? Cune { get; set; }
        public string? CuneNov { get; set; }
        public string Estado { get; set; } = null!;
        public string TipoXml { get; set; } = null!;
        public string? Nominas { get; set; }
        public int Id { get; set; }
        public string EsNovedad { get; set; } = null!;
        public string? ConsecNie { get; set; }
        public int? IdNie { get; set; }
        public int? IdPredecesor { get; set; }
        public string? FechaHoraArchivo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DetNomElect1 DetNomElect1 { get; set; } = null!;
        public virtual ICollection<NomElectAccione> NomElectAcciones { get; set; }
        public virtual ICollection<NomElectNomProc> NomElectNomProcs { get; set; }
    }
}
