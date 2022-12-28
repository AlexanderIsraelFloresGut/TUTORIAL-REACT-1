﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AsientoDistribuid2
    {
        public AsientoDistribuid2()
        {
            AsientoDistLinea2s = new HashSet<AsientoDistLinea2>();
            DetalleCorridum2s = new HashSet<DetalleCorridum2>();
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

        public virtual Paquete2? PaqueteNavigation { get; set; }
        public virtual TipoAsiento2? TipoAsientoNavigation { get; set; }
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltAplicNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModifNavigation { get; set; }
        public virtual ICollection<AsientoDistLinea2> AsientoDistLinea2s { get; set; }
        public virtual ICollection<DetalleCorridum2> DetalleCorridum2s { get; set; }
    }
}
