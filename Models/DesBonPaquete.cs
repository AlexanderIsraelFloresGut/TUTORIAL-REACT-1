using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DesBonPaquete
    {
        public DesBonPaquete()
        {
            DesBonPaqueteReglas = new HashSet<DesBonPaqueteRegla>();
            DesBonPaqueteRuta = new HashSet<DesBonPaqueteRutum>();
            DesBonPaqueteTienda = new HashSet<DesBonPaqueteTiendum>();
        }

        public string Paquete { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int? Prioridad { get; set; }
        public string? Dias { get; set; }
        public string AplicaTodaTienda { get; set; } = null!;
        public string AplicaTodaRuta { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string AplicaAFa { get; set; } = null!;

        public virtual ICollection<DesBonPaqueteRegla> DesBonPaqueteReglas { get; set; }
        public virtual ICollection<DesBonPaqueteRutum> DesBonPaqueteRuta { get; set; }
        public virtual ICollection<DesBonPaqueteTiendum> DesBonPaqueteTienda { get; set; }
    }
}
