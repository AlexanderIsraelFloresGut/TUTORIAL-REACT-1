﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudRhDoc2
    {
        public int SolicitudRh { get; set; }
        public int Documento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Documento2 DocumentoNavigation { get; set; } = null!;
        public virtual SolicitudRh2 SolicitudRhNavigation { get; set; } = null!;
    }
}
