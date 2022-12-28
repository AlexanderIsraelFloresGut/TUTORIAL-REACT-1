using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DesBonEscalaBonificacion2
    {
        public int Escala { get; set; }
        public string Regla { get; set; } = null!;
        public string? Articulo { get; set; }
        public decimal CantidadMinima { get; set; }
        public decimal CantidadMaxima { get; set; }
        public decimal Factor { get; set; }
        public decimal CantidadInicial { get; set; }
        public decimal CantidadPedida { get; set; }
        public decimal? UnidadAlmacen { get; set; }
        public decimal? UnidadDetalle { get; set; }
        public decimal CantMinimaDet { get; set; }
        public decimal CantMaximaDet { get; set; }
        public decimal FactorDet { get; set; }
        public decimal CantidadInicialDet { get; set; }
        public decimal CantidadInicialConsol { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DesBonRegla2 ReglaNavigation { get; set; } = null!;
    }
}
