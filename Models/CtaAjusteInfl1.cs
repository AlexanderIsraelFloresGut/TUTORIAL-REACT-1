﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CtaAjusteInfl1
    {
        public string CtaAjustable { get; set; } = null!;
        public string CtaAjuste { get; set; } = null!;
        public string ContraCtaAjuste { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CuentaContable1 ContraCtaAjusteNavigation { get; set; } = null!;
        public virtual CuentaContable1 CtaAjustableNavigation { get; set; } = null!;
        public virtual CuentaContable1 CtaAjusteNavigation { get; set; } = null!;
    }
}
