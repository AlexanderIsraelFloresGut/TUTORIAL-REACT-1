using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CajaChica1
    {
        public CajaChica1()
        {
            CajaBanco1s = new HashSet<CajaBanco1>();
            Procesoch1s = new HashSet<Procesoch1>();
            UsuarioCaja1s = new HashSet<UsuarioCaja1>();
            Vale1s = new HashSet<Vale1>();
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
        public string? EntregasRendir { get; set; }
        public string? CuentaRendirLoc { get; set; }
        public string? CentroRendirLoc { get; set; }
        public string? CuentaRendirSec { get; set; }
        public string? CentroRendirSec { get; set; }

        public virtual Departamento1? AreaFuncionalNavigation { get; set; }
        public virtual CentroCuentum1? C { get; set; }
        public virtual CentroCuentum1? C1 { get; set; }
        public virtual CentroCuentum1? C2 { get; set; }
        public virtual CentroCuentum1? CNavigation { get; set; }
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
        public virtual Responsable1? ResponsableNavigation { get; set; }
        public virtual ICollection<CajaBanco1> CajaBanco1s { get; set; }
        public virtual ICollection<Procesoch1> Procesoch1s { get; set; }
        public virtual ICollection<UsuarioCaja1> UsuarioCaja1s { get; set; }
        public virtual ICollection<Vale1> Vale1s { get; set; }
    }
}
