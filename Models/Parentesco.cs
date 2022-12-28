﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Parentesco
    {
        public int Accion { get; set; }
        public int Padre { get; set; }
        public short Numerohermano { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
