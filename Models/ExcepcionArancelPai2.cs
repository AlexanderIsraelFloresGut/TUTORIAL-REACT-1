﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ExcepcionArancelPai2
    {
        public ExcepcionArancelPai2()
        {
            ExcepcionArancelImp2s = new HashSet<ExcepcionArancelImp2>();
        }

        public string CodigoArancel { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CodigoArancel2 CodigoArancelNavigation { get; set; } = null!;
        public virtual ICollection<ExcepcionArancelImp2> ExcepcionArancelImp2s { get; set; }
    }
}
