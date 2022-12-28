﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetalleRetencion1
    {
        public DetalleRetencion1()
        {
            CpDetRetencionPar1s = new HashSet<CpDetRetencionPar1>();
        }

        public string Tipo { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string CodigoRetencion { get; set; } = null!;
        public string? Retencion { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; } = null!;
        public string Pagada { get; set; } = null!;
        public decimal? Base { get; set; }
        public string? Autoretenedora { get; set; }
        public string? TipoApliCancelar { get; set; }
        public decimal? SaldoCancelar { get; set; }
        public string? Asiento { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? FechaRige { get; set; }
        public DateTime? FechaContable { get; set; }
        public string? ClaseDocEs { get; set; }
        public string? Resolucion { get; set; }
        public string? Serie { get; set; }
        public string? ControlInterno { get; set; }
        public string? SerieNumero { get; set; }

        public virtual Retencione1 CodigoRetencionNavigation { get; set; } = null!;
        public virtual DocumentosCp1 DocumentosCp1 { get; set; } = null!;
        public virtual ICollection<CpDetRetencionPar1> CpDetRetencionPar1s { get; set; }
    }
}