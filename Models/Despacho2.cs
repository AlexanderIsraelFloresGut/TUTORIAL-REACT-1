﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Despacho2
    {
        public Despacho2()
        {
            DespachoDetalle2s = new HashSet<DespachoDetalle2>();
        }

        public string Despacho { get; set; } = null!;
        public string Consecutivo { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Transportista { get; set; }
        public string? NotasTransporte { get; set; }
        public string? DireccionEmbarque { get; set; }
        public string? EmbarcarA { get; set; }
        public string Estado { get; set; } = null!;
        public string? Observaciones { get; set; }
        public DateTime FchHoraCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FchHoraUltModif { get; set; }
        public string? UsuarioUltModif { get; set; }
        public DateTime? FchHoraAnulacion { get; set; }
        public string? UsuarioAnulacion { get; set; }
        public DateTime? FchHoraAplicacion { get; set; }
        public string? UsuarioAplicacion { get; set; }
        public string CargadoCg { get; set; } = null!;
        public string? AsientoDespacho { get; set; }
        public int? AuditTransInv { get; set; }
        public string? UsuarioAprobacion { get; set; }
        public DateTime? FchHoraAprobacio { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? TipoPago { get; set; }

        public virtual AuditTransInv2? AuditTransInvNavigation { get; set; }
        public virtual Cliente2 ClienteNavigation { get; set; } = null!;
        public virtual ConsecutivoFa2 ConsecutivoNavigation { get; set; } = null!;
        public virtual TipoPago2? TipoPagoNavigation { get; set; }
        public virtual ICollection<DespachoDetalle2> DespachoDetalle2s { get; set; }
    }
}
