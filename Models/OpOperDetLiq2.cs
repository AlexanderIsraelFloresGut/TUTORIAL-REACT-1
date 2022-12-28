﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperDetLiq2
    {
        public string Liquidacion { get; set; } = null!;
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public DateTime FechaHoraProduc { get; set; }
        public string Rubro { get; set; } = null!;
        public decimal MontoRepLocal { get; set; }
        public decimal? MontoRepDolar { get; set; }
        public decimal UnidadesRep { get; set; }
        public decimal MontoVariacLocal { get; set; }
        public decimal? MontoVariacDolar { get; set; }
        public decimal MedDistRubLoc { get; set; }
        public decimal? MedDistRubDol { get; set; }
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public decimal PorcentajeProrrateo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual LiquidacionPc2 LiquidacionNavigation { get; set; } = null!;
        public virtual OpOperDet2 OpOperDet2 { get; set; } = null!;
    }
}
