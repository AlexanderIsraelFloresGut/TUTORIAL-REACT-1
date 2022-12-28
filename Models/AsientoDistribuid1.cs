using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AsientoDistribuid1
    {
        public AsientoDistribuid1()
        {
            AsientoDistLinea1s = new HashSet<AsientoDistLinea1>();
            DetalleCorridum1s = new HashSet<DetalleCorridum1>();
        }

        public string AsientoDistribuid { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoDistribucion { get; set; } = null!;
        public string SaldoDistribuir { get; set; } = null!;
        public string ModoDistribucion { get; set; } = null!;
        public short? Secuencia { get; set; }
        public string Activo { get; set; } = null!;
        public string Marcado { get; set; } = null!;
        public short ModalidadAplic { get; set; }
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string? Fuente { get; set; }
        public string Contabilidad { get; set; } = null!;
        public DateTime? FchHoraCreacion { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTime? FchHoraUltModif { get; set; }
        public string? UsuarioUltModif { get; set; }
        public DateTime? FchHoraUltAplic { get; set; }
        public string? UsuarioUltAplic { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Paquete1? PaqueteNavigation { get; set; }
        public virtual TipoAsiento1? TipoAsientoNavigation { get; set; }
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltAplicNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModifNavigation { get; set; }
        public virtual ICollection<AsientoDistLinea1> AsientoDistLinea1s { get; set; }
        public virtual ICollection<DetalleCorridum1> DetalleCorridum1s { get; set; }
    }
}
