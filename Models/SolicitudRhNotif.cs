﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudRhNotif
    {
        public int SolicitudRh { get; set; }
        public int Consecutivo { get; set; }
        public string Empleado { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime? FechaHora { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado EmpleadoNavigation { get; set; } = null!;
        public virtual SolicitudRh SolicitudRhNavigation { get; set; } = null!;
    }
}