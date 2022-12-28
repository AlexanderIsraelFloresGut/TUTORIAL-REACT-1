﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClienteVendedor
    {
        public string Cliente { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Cliente ClienteNavigation { get; set; } = null!;
        public virtual Vendedor VendedorNavigation { get; set; } = null!;
    }
}
