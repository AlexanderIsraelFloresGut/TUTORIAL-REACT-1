﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PedidoOrdenProduc2
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Pedido { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OrdenProduccion2 OrdenProduccionNavigation { get; set; } = null!;
        public virtual Pedido2 PedidoNavigation { get; set; } = null!;
    }
}
