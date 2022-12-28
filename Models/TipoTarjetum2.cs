using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoTarjetum2
    {
        public TipoTarjetum2()
        {
            Cliente2s = new HashSet<Cliente2>();
            ConfigTarjeta2s = new HashSet<ConfigTarjeta2>();
            FacturaCancela2s = new HashSet<FacturaCancela2>();
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

        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<ConfigTarjeta2> ConfigTarjeta2s { get; set; }
        public virtual ICollection<FacturaCancela2> FacturaCancela2s { get; set; }
    }
}
