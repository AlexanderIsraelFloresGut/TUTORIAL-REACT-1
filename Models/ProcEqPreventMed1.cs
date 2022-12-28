﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ProcEqPreventMed1
    {
        public ProcEqPreventMed1()
        {
            FactProcMedic1s = new HashSet<FactProcMedic1>();
        }

        public string Equipo { get; set; } = null!;
        public string Procedimiento { get; set; } = null!;
        public string Version { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EquipoPrevent1 EquipoNavigation { get; set; } = null!;
        public virtual Procedimiento1 Procedimiento1 { get; set; } = null!;
        public virtual ICollection<FactProcMedic1> FactProcMedic1s { get; set; }
    }
}
