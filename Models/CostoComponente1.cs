﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CostoComponente1
    {
        public string Articulo { get; set; } = null!;
        public decimal Costo { get; set; }
        public decimal? MatCorpLoc { get; set; }
        public decimal? MatCorpDol { get; set; }
        public decimal? MatTercerosLoc { get; set; }
        public decimal? MatTercerosDol { get; set; }
        public decimal? CostoMoLoc { get; set; }
        public decimal? CostoMoDol { get; set; }
        public decimal? CostoIndirLoc { get; set; }
        public decimal? CostoIndirDol { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual AliasProduccion1 ArticuloNavigation { get; set; } = null!;
    }
}
