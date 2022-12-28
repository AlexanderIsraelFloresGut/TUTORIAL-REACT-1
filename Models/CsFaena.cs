using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsFaena
    {
        public string Faena { get; set; } = null!;
        public string? Proveedor { get; set; }
        public DateTime? FechaSalida { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public DateTime? FechaLiquidacion { get; set; }
        public string? Embarcacion { get; set; }
        public string? Capitan { get; set; }
        public int? Estado { get; set; }
        public decimal? CostoAcumulado { get; set; }
        public decimal? IngresoAcumulado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string? UsuarioCreo { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModifico { get; set; }
        public int? DoctoCp { get; set; }
        public string? Bloqueado { get; set; }
        public DateTime? FechaBloqueo { get; set; }
        public string? UsuarioBloqueo { get; set; }
        public DateTime? FechaDesbloqueo { get; set; }
        public string? UsuarioDesbloqueo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CsEstadosFaena? EstadoNavigation { get; set; }
    }
}
