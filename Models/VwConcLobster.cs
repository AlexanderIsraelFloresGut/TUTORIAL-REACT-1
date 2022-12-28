﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwConcLobster
    {
        public string Empresa { get; set; } = null!;
        public int? AnoFechaDocumento { get; set; }
        public int? MesFechaDocumento { get; set; }
        public int? Dia { get; set; }
        public string? TipoArticulo { get; set; }
        public string? Clasificacion1 { get; set; }
        public string? Clasificacion6 { get; set; }
        public string? Bodega { get; set; }
        public string NombreBodega { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string ModuloOrigen { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public string AjusteConfigurable { get; set; } = null!;
        public string? Naturaleza { get; set; }
        public string Articulo { get; set; } = null!;
        public string DescripcionArticulo { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public decimal? Libras { get; set; }
    }
}
