using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Implosion
    {
        public Implosion()
        {
            ImplosionDetalles = new HashSet<ImplosionDetalle>();
        }

        public string Usuario { get; set; } = null!;
        public string? AliasInicial { get; set; }
        public string? AliasFinal { get; set; }
        public string? ConsumoReserva { get; set; }
        public string? UsarExistencia { get; set; }
        public string? InvCuarentena { get; set; }
        public string? SoloTerminados { get; set; }
        public string? RespetarLotes { get; set; }
        public DateTime Fecha { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual AliasProduccion? AliasFinalNavigation { get; set; }
        public virtual AliasProduccion? AliasInicialNavigation { get; set; }
        public virtual ICollection<ImplosionDetalle> ImplosionDetalles { get; set; }
    }
}
