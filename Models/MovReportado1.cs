﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MovReportado1
    {
        public MovReportado1()
        {
            InverseDocCompensacNavigation = new HashSet<MovReportado1>();
            MovBanco1DocAjusteNavigations = new HashSet<MovBanco1>();
            MovBanco1DocReportadoNavigations = new HashSet<MovBanco1>();
        }

        public int DocReportado { get; set; }
        public string? CuentaBanco { get; set; }
        public string TipoDocumento { get; set; } = null!;
        public decimal Numero { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } = null!;
        public string ModoRegistro { get; set; } = null!;
        public string Compensado { get; set; } = null!;
        public int? Conciliacion { get; set; }
        public string? Notas { get; set; }
        public DateTime FchHoraCreacion { get; set; }
        public DateTime? FchHoraModific { get; set; }
        public int? DocCompensac { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public string? UsuarioModific { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? TipoCf { get; set; }

        public virtual Conciliacion1? C { get; set; }
        public virtual CuentaBancarium1? CuentaBancoNavigation { get; set; }
        public virtual MovReportado1? DocCompensacNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioModificNavigation { get; set; }
        public virtual ICollection<MovReportado1> InverseDocCompensacNavigation { get; set; }
        public virtual ICollection<MovBanco1> MovBanco1DocAjusteNavigations { get; set; }
        public virtual ICollection<MovBanco1> MovBanco1DocReportadoNavigations { get; set; }
    }
}