using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoTarjetum
    {
        public TipoTarjetum()
        {
            Clientes = new HashSet<Cliente>();
            ConfigTarjeta = new HashSet<ConfigTarjeta>();
            FacturaCancelas = new HashSet<FacturaCancela>();
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

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<ConfigTarjeta> ConfigTarjeta { get; set; }
        public virtual ICollection<FacturaCancela> FacturaCancelas { get; set; }
    }
}
