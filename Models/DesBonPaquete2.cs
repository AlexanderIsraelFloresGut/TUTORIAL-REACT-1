using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DesBonPaquete2
    {
        public DesBonPaquete2()
        {
            DesBonPaqueteRegla2s = new HashSet<DesBonPaqueteRegla2>();
            DesBonPaqueteRutum2s = new HashSet<DesBonPaqueteRutum2>();
            DesBonPaqueteTiendum2s = new HashSet<DesBonPaqueteTiendum2>();
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

        public virtual ICollection<DesBonPaqueteRegla2> DesBonPaqueteRegla2s { get; set; }
        public virtual ICollection<DesBonPaqueteRutum2> DesBonPaqueteRutum2s { get; set; }
        public virtual ICollection<DesBonPaqueteTiendum2> DesBonPaqueteTiendum2s { get; set; }
    }
}
