﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ExcepRegiman
    {
        public string Codigo { get; set; } = null!;
        public string CodigoRetencion { get; set; } = null!;
        public decimal Porcentaje { get; set; }
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCuentum? C { get; set; }
    }
}
