﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdPropietarioTabla
    {
        public string Propietario { get; set; } = null!;
        public string Tabla { get; set; } = null!;
        public string Principal { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DdTabla TablaNavigation { get; set; } = null!;
    }
}
