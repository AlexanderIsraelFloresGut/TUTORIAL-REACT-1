using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DesBonPaquete1
    {
        public DesBonPaquete1()
        {
            DesBonPaqueteRegla1s = new HashSet<DesBonPaqueteRegla1>();
            DesBonPaqueteRutum1s = new HashSet<DesBonPaqueteRutum1>();
            DesBonPaqueteTiendum1s = new HashSet<DesBonPaqueteTiendum1>();
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

        public virtual ICollection<DesBonPaqueteRegla1> DesBonPaqueteRegla1s { get; set; }
        public virtual ICollection<DesBonPaqueteRutum1> DesBonPaqueteRutum1s { get; set; }
        public virtual ICollection<DesBonPaqueteTiendum1> DesBonPaqueteTiendum1s { get; set; }
    }
}
