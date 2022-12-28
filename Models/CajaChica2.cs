using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CajaChica2
    {
        public CajaChica2()
        {
            CajaBanco2s = new HashSet<CajaBanco2>();
            Procesoch2s = new HashSet<Procesoch2>();
            UsuarioCaja2s = new HashSet<UsuarioCaja2>();
            Vale2s = new HashSet<Vale2>();
        }

        public string CajaChica { get; set; } = null!;
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

        public virtual Departamento2? AreaFuncionalNavigation { get; set; }
        public virtual CentroCuentum2? C { get; set; }
        public virtual CentroCuentum2? CNavigation { get; set; }
        public virtual Monedum2 MonedaNavigation { get; set; } = null!;
        public virtual Responsable2? ResponsableNavigation { get; set; }
        public virtual ICollection<CajaBanco2> CajaBanco2s { get; set; }
        public virtual ICollection<Procesoch2> Procesoch2s { get; set; }
        public virtual ICollection<UsuarioCaja2> UsuarioCaja2s { get; set; }
        public virtual ICollection<Vale2> Vale2s { get; set; }
    }
}
