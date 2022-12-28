﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CalculoVacacional
    {
        public CalculoVacacional()
        {
            CalcVacDetalles = new HashSet<CalcVacDetalle>();
        }

        public int CalculoVacacional1 { get; set; }
        public string? CentroCosto { get; set; }
        public string? Nomina { get; set; }
        public string? Ubicacion { get; set; }
        public string? Departamento { get; set; }
        public string? Puesto { get; set; }
        public string? RegimenVacacional { get; set; }
        public string? Empleado { get; set; }
        public string? TipoAccion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaCorte { get; set; }
        public string Estado { get; set; } = null!;
        public string? Referencia { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUltModif { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public string? Notas { get; set; }
        public string? UsuarioCancelac { get; set; }
        public string? UsuarioAplicacion { get; set; }
        public string? UsuarioAprobacion { get; set; }
        public string UsuarioUltModif { get; set; } = null!;
        public string UsuarioCreacion { get; set; } = null!;
        public string AccionUnica { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCosto? CentroCostoNavigation { get; set; }
        public virtual Departamento? DepartamentoNavigation { get; set; }
        public virtual Empleado? EmpleadoNavigation { get; set; }
        public virtual Nomina? NominaNavigation { get; set; }
        public virtual Puesto? PuestoNavigation { get; set; }
        public virtual RegimenVacacional? RegimenVacacionalNavigation { get; set; }
        public virtual TipoAccion? TipoAccionNavigation { get; set; }
        public virtual Ubicacion? UbicacionNavigation { get; set; }
        public virtual Usuario2? UsuarioAplicacionNavigation { get; set; }
        public virtual Usuario2? UsuarioAprobacionNavigation { get; set; }
        public virtual Usuario2? UsuarioCancelacNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioUltModifNavigation { get; set; } = null!;
        public virtual ICollection<CalcVacDetalle> CalcVacDetalles { get; set; }
    }
}
