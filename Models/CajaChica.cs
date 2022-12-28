using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CajaChica
    {
        public CajaChica()
        {
            CajaBancos = new HashSet<CajaBanco>();
            Procesoches = new HashSet<Procesoch>();
            UsuarioCajas = new HashSet<UsuarioCaja>();
            Vales = new HashSet<Vale>();
        }

        public string CajaChica1 { get; set; } = null!;
        public string? Responsable { get; set; }
        public string Moneda { get; set; } = null!;
        public string? AreaFuncional { get; set; }
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public decimal MontoCaja { get; set; }
        public decimal? MontoVale { get; set; }
        public decimal Saldo { get; set; }
        public short? NumVales { get; set; }
        public string ValidarLimite { get; set; } = null!;
        public int? Reintegro { get; set; }
        public string? LimitePorcentual { get; set; }
        public string Estado { get; set; } = null!;
        public string? UltimoConsecutivo { get; set; }
        public DateTime FchHoraUltModif { get; set; }
        public string UsuarioUltModif { get; set; } = null!;
        public DateTime FchHoraCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public string? Notas { get; set; }
        public string ParticipaFlujocaja { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? CuentaReembolsos { get; set; }
        public string? CentroReembolsos { get; set; }

        public virtual Departamento? AreaFuncionalNavigation { get; set; }
        public virtual CentroCuentum? C { get; set; }
        public virtual CentroCuentum? CNavigation { get; set; }
        public virtual Monedum MonedaNavigation { get; set; } = null!;
        public virtual Responsable? ResponsableNavigation { get; set; }
        public virtual ICollection<CajaBanco> CajaBancos { get; set; }
        public virtual ICollection<Procesoch> Procesoches { get; set; }
        public virtual ICollection<UsuarioCaja> UsuarioCajas { get; set; }
        public virtual ICollection<Vale> Vales { get; set; }
    }
}
