﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocumentoElectronico1
    {
        public int TipoDoc { get; set; }
        public decimal NumeroDoc { get; set; }
        public string NitEmisor { get; set; } = null!;
        public string EmailEmisor { get; set; } = null!;
        public string GlnEmisor { get; set; } = null!;
        public string NitReceptor { get; set; } = null!;
        public string EmailReceptor { get; set; } = null!;
        public string GlnReceptor { get; set; } = null!;
        public string Enviado { get; set; } = null!;
        public string? Aceptado { get; set; }
        public string? CargadoErp { get; set; }
        public decimal? NumeroRecepcion { get; set; }
        public int CantidadImpresiones { get; set; }
        public string? DocumentoElectronico { get; set; }
        public string? AceptacionRechazo { get; set; }
        public string? NombrePdf { get; set; }
        public string? DocumentoElectronicoText { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
