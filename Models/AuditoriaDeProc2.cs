﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AuditoriaDeProc2
    {
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string Origen { get; set; } = null!;
        public string Opcion { get; set; } = null!;
        public string? Notas { get; set; }
        public string? Asiento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
