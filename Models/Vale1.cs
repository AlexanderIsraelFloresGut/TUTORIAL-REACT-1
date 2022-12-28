using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Vale1
    {
        public Vale1()
        {
            DocsSoporte1s = new HashSet<DocsSoporte1>();
        }

        public int Consecutivo { get; set; }
        public string? Departamento { get; set; }
        public string CajaChica { get; set; } = null!;
        public string Vale { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public DateTime? FechaLiquidacion { get; set; }
        public string ConceptoVale { get; set; } = null!;
        public string Beneficiario { get; set; } = null!;
        public string? Notas { get; set; }
        public decimal MontoCaja { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal MontoDolar { get; set; }
        public decimal TipoCambCaja { get; set; }
        public decimal TipoCambDolar { get; set; }
        public string Estado { get; set; } = null!;
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string AdminCreacion { get; set; } = null!;
        public string UsuarioModific { get; set; } = null!;
        public DateTime FechaModific { get; set; }
        public string? AdminModific { get; set; }
        public decimal? MontoVale { get; set; }
        public decimal? MontoEfectivo { get; set; }
        public int? Reintegro { get; set; }
        public string? Asiento { get; set; }
        public string? PresupuestoCr { get; set; }
        public string? UsuarioAnulacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string? AdminAnulacion { get; set; }
        public DateTime? FechaContAnulacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? FacturaElectronica { get; set; }
        public string? ConsecutivoDoc { get; set; }
        public decimal? SubtotalBienes { get; set; }
        public decimal? SubtotalServicios { get; set; }
        public string? DestinoItbis { get; set; }
        public string? TipoCf { get; set; }
        public string? CuentaBanco { get; set; }
        public decimal? MontoEfectivoDolar { get; set; }

        public virtual CajaChica1 CajaChicaNavigation { get; set; } = null!;
        public virtual ConceptoVale1 ConceptoValeNavigation { get; set; } = null!;
        public virtual CuentaBancarium1? CuentaBancoNavigation { get; set; }
        public virtual Departamento1? DepartamentoNavigation { get; set; }
        public virtual ValeMovPre1 ValeMovPre1 { get; set; } = null!;
        public virtual ICollection<DocsSoporte1> DocsSoporte1s { get; set; }
    }
}
