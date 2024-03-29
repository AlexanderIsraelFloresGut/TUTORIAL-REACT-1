﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AsientoRecurrente2
    {
        public AsientoRecurrente2()
        {
            AsientoRecuLinea2s = new HashSet<AsientoRecuLinea2>();
        }

        public string AsientoRecurrente { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public short ModalidadAplic { get; set; }
        public string? Unidad { get; set; }
        public string? Paquete { get; set; }
        public string TipoAsiento { get; set; } = null!;
        public string Contabilidad { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string? UsuarioUltAplic { get; set; }
        public DateTime? FchHoraUltAplic { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string Marcado { get; set; } = null!;
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Paquete2? PaqueteNavigation { get; set; }
        public virtual TipoAsiento2 TipoAsientoNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioUltAplicNavigation { get; set; }
        public virtual ICollection<AsientoRecuLinea2> AsientoRecuLinea2s { get; set; }
    }
}
