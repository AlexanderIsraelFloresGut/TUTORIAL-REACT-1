using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ActivoFijo1
    {
        public ActivoFijo1()
        {
            ActivoAccion1s = new HashSet<ActivoAccion1>();
            ActivoCentro1s = new HashSet<ActivoCentro1>();
            ActivoHistMant1s = new HashSet<ActivoHistMant1>();
            ActivoMejora1s = new HashSet<ActivoMejora1>();
            Caja1s = new HashSet<Caja1>();
            DetSolicitudAfNotif1s = new HashSet<DetSolicitudAfNotif1>();
        }

        public string ActivoFijo { get; set; } = null!;
        public string? EstadoActivo { get; set; }
        public string? Ubicacion { get; set; }
        public string TipoActivo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime? FechaUltMant { get; set; }
        public DateTime? FechaProxMant { get; set; }
        public decimal? TasaDepreciacionF { get; set; }
        public decimal? TasaDepreciacionC { get; set; }
        public string? Clasificacion { get; set; }
        public string UsaComponente { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string ArreFinanciero { get; set; } = null!;
        public string? NumeroContrato { get; set; }
        public short? NumeroCuotas { get; set; }
        public DateTime? FechaContrato { get; set; }
        public DateTime? FechaArrendamiento { get; set; }
        public decimal? MontoArreMn { get; set; }
        public decimal? MontoArreMe { get; set; }

        public virtual EstadoActivo1? EstadoActivoNavigation { get; set; }
        public virtual TipoActivo1 TipoActivoNavigation { get; set; } = null!;
        public virtual Ubicacion1? UbicacionNavigation { get; set; }
        public virtual ICollection<ActivoAccion1> ActivoAccion1s { get; set; }
        public virtual ICollection<ActivoCentro1> ActivoCentro1s { get; set; }
        public virtual ICollection<ActivoHistMant1> ActivoHistMant1s { get; set; }
        public virtual ICollection<ActivoMejora1> ActivoMejora1s { get; set; }
        public virtual ICollection<Caja1> Caja1s { get; set; }
        public virtual ICollection<DetSolicitudAfNotif1> DetSolicitudAfNotif1s { get; set; }
    }
}
