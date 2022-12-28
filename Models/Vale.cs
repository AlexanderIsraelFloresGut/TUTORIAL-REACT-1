using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Vale
    {
        public Vale()
        {
            DocsSoportes = new HashSet<DocsSoporte>();
        }

        public int Consecutivo { get; set; }
        public string? Departamento { get; set; }
        public string CajaChica { get; set; } = null!;
        public string Vale1 { get; set; } = null!;
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

        public virtual CajaChica CajaChicaNavigation { get; set; } = null!;
        public virtual ConceptoVale ConceptoValeNavigation { get; set; } = null!;
        public virtual Departamento? DepartamentoNavigation { get; set; }
        public virtual ValeMovPre ValeMovPre { get; set; } = null!;
        public virtual ICollection<DocsSoporte> DocsSoportes { get; set; }
    }
}
