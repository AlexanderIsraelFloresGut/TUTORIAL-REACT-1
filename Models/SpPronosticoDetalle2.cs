﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SpPronosticoDetalle2
    {
        public int Id { get; set; }
        public string Pronostico { get; set; } = null!;
        public DateTime Periodo { get; set; }
        public short ItemPronosticado { get; set; }
        public string Articulo { get; set; } = null!;
        public string? Bodega { get; set; }
        public decimal CantidadPronosticada { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo2 ArticuloNavigation { get; set; } = null!;
        public virtual Bodega2? BodegaNavigation { get; set; }
        public virtual SpPronostico2 PronosticoNavigation { get; set; } = null!;
    }
}
