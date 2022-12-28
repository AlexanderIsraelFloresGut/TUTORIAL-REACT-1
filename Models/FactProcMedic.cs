using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FactProcMedic
    {
        public string Equipo { get; set; } = null!;
        public string Procedimiento { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string UnidadMedicion { get; set; } = null!;
        public string PuntoMedicion { get; set; } = null!;
        public decimal UltimaMedicion { get; set; }
        public decimal Frecuencia { get; set; }
        public decimal LimiteInferior { get; set; }
        public decimal? LimiteSuperior { get; set; }
        public string TipoMedicion { get; set; } = null!;
        public short PorcAproximacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ProcEqPreventMed ProcEqPreventMed { get; set; } = null!;
        public virtual UnidadMedicion UnidadMedicionNavigation { get; set; } = null!;
    }
}
