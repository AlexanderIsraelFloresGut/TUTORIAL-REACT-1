﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class UsuarioCajaFa1
    {
        public string Caja { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Privilegios { get; set; } = null!;
        public decimal? PorcDiferencia { get; set; }
        public decimal? MontoDifDolar { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Caja1 CajaNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
