﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Alinsa2prv
    {
        public string SolicitudOc { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaRequerida { get; set; }
        public string Prioridad { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? Descripcion1 { get; set; }
        public decimal Cantidad { get; set; }
        public string? Descripcion2 { get; set; }
        public string Descripcion3 { get; set; } = null!;
        public string? CodigoBarrasAlm { get; set; }
        public string? CodigoBarrasDet { get; set; }
        public string Proveedor { get; set; } = null!;
        public decimal LoteMinimo { get; set; }
        public decimal FactorConversion { get; set; }
        public short PlazoReabastecimi { get; set; }
    }
}
