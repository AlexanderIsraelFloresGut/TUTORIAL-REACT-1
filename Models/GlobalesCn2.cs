using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesCn2
    {
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string? CedulaJuridica { get; set; }
        public string NumeroPatronal { get; set; } = null!;
        public decimal FactorRedondeo { get; set; }
        public string IntegracionConta { get; set; } = null!;
        public short ModAplicAsiento { get; set; }
        public string TipoContaOmision { get; set; } = null!;
        public string UsaRubrosNomina { get; set; } = null!;
        public string UsaRubrosEmp { get; set; } = null!;
        public string PermiteNetosCero { get; set; } = null!;
        public string? NombRubro1Nomi { get; set; }
        public string? NombRubro2Nomi { get; set; }
        public string? NombRubro3Nomi { get; set; }
        public string? NombRubro4Nomi { get; set; }
        public string? NombRubro5Nomi { get; set; }
        public string? NombRubro6Nomi { get; set; }
        public string? NombRubro7Nomi { get; set; }
        public string? NombRubro8Nomi { get; set; }
        public string? NombRubro9Nomi { get; set; }
        public string? NombRubro10Nomi { get; set; }
        public string? NombRubro6Emp { get; set; }
        public string? NombRubro7Emp { get; set; }
        public string? NombRubro8Emp { get; set; }
        public string? NombRubro9Emp { get; set; }
        public string? NombRubro10Emp { get; set; }
        public string? NombRubro11Emp { get; set; }
        public string? NombRubro12Emp { get; set; }
        public string? NombRubro13Emp { get; set; }
        public string? NombRubro14Emp { get; set; }
        public string? NombRubro15Emp { get; set; }
        public string UsaFechasAntig { get; set; } = null!;
        public string SegNominaRep { get; set; } = null!;
        public string SeguridadConcepto { get; set; } = null!;
        public string SegConceptoRep { get; set; } = null!;
        public string SegNominaEmp { get; set; } = null!;
        public string? NombRubro16Emp { get; set; }
        public string? NombRubro17Emp { get; set; }
        public string? NombRubro18Emp { get; set; }
        public string? NombRubro19Emp { get; set; }
        public string? NombRubro20Emp { get; set; }
        public string? NombRubro21Emp { get; set; }
        public string? NombRubro22Emp { get; set; }
        public string? NombRubro23Emp { get; set; }
        public string? NombRubro24Emp { get; set; }
        public string? NombRubro25Emp { get; set; }
        public string? IntegracionCr { get; set; }
        public string? RequierePresup { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? TipoDocCc { get; set; }
        public short? SubtipoDocCc { get; set; }

        public virtual Paquete2? PaqueteNavigation { get; set; }
        public virtual TipoAsiento2? TipoAsientoNavigation { get; set; }
    }
}
