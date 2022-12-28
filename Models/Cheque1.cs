﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Cheque1
    {
        public Cheque1()
        {
            AsientosCheque1s = new HashSet<AsientosCheque1>();
        }

        public int ChequeInterno { get; set; }
        public string CuentaBanco { get; set; } = null!;
        public string? Tipo { get; set; }
        public short? Subtipo { get; set; }
        public string PagaderoA { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public decimal Monto { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FchHoraModific { get; set; }
        public string? UsuarioModific { get; set; }
        public DateTime? FchHoraUltAplic { get; set; }
        public string Recurrente { get; set; } = null!;
        public string? Concepto { get; set; }
        public string? Contribuyente { get; set; }
        public string Seleccionado { get; set; } = null!;
        public DateTime FchHoraCreacion { get; set; }
        public string? UsuarioUltAplic { get; set; }
        public string? ResponsableSolici { get; set; }
        public string EstadoSolicitud { get; set; } = null!;
        public string OrigenSolicitud { get; set; } = null!;
        public string? DocumentoGlobal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? MetodoPago { get; set; }

        public virtual Nit1? ContribuyenteNavigation { get; set; }
        public virtual CuentaBancarium1 CuentaBancoNavigation { get; set; } = null!;
        public virtual MetodoPago1? MetodoPagoNavigation { get; set; }
        public virtual SubtipoDocCb1? SubtipoDocCb1 { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioModificNavigation { get; set; }
        public virtual Usuario2? UsuarioUltAplicNavigation { get; set; }
        public virtual ICollection<AsientosCheque1> AsientosCheque1s { get; set; }
    }
}
