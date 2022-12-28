﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoAccidente2
    {
        public string Empleado { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int? NumeroAccion { get; set; }
        public string Puesto { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string TipoAccidente { get; set; } = null!;
        public string Lugar { get; set; } = null!;
        public string Efecto { get; set; } = null!;
        public string Causa { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal? DiasIncapacidad { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Departamento2 DepartamentoNavigation { get; set; } = null!;
        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual EmpleadoAccPer2? NumeroAccionNavigation { get; set; }
        public virtual Puesto2 PuestoNavigation { get; set; } = null!;
        public virtual TipoAccidente2 TipoAccidenteNavigation { get; set; } = null!;
    }
}
