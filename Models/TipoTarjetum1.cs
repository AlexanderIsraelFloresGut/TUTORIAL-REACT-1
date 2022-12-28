using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoTarjetum1
    {
        public TipoTarjetum1()
        {
            Cliente1s = new HashSet<Cliente1>();
            ConfigTarjeta1s = new HashSet<ConfigTarjeta1>();
            FacturaCancela1s = new HashSet<FacturaCancela1>();
        }

        public string TipoTarjeta { get; set; } = null!;
        public string TipoCobro { get; set; } = null!;
        public string? AssemblyInvocacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<ConfigTarjeta1> ConfigTarjeta1s { get; set; }
        public virtual ICollection<FacturaCancela1> FacturaCancela1s { get; set; }
    }
}
