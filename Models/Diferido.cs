using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Diferido
    {
        public Diferido()
        {
            DiferidoDocCcs = new HashSet<DiferidoDocCc>();
            DiferidoDocCps = new HashSet<DiferidoDocCp>();
            DiferidosImpuestos = new HashSet<DiferidosImpuesto>();
        }

        public string Diferido1 { get; set; } = null!;
        public string? Descripcion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaInicio { get; set; }
        public decimal MontoOriginal { get; set; }
        public string? Moneda { get; set; }
        public decimal Amortizado { get; set; }
        public decimal PendienteAmortizar { get; set; }
        public string Estado { get; set; } = null!;
        public string? Asiento { get; set; }
        public string Modalidad { get; set; } = null!;
        public decimal ValorModalidad { get; set; }
        public string Tipo { get; set; } = null!;
        public string Paquete { get; set; } = null!;
        public string TipoAsiento { get; set; } = null!;
        public string CtrDiferido { get; set; } = null!;
        public string CtaDiferido { get; set; } = null!;
        public string CtrContraasiento { get; set; } = null!;
        public string CtaContraasiento { get; set; } = null!;
        public string CtrAmortizacion { get; set; } = null!;
        public string CtaAmortizacion { get; set; } = null!;
        public string CtrGastoingreso { get; set; } = null!;
        public string CtaGastoingreso { get; set; } = null!;
        public DateTime FechaAudIng { get; set; }
        public string UsuarioAudIng { get; set; } = null!;
        public DateTime FechaUltMod { get; set; }
        public string UsuarioUltMod { get; set; } = null!;
        public string? Notas { get; set; }
        public string Nit { get; set; } = null!;
        public DateTime? FechaHoraAnulacion { get; set; }
        public string? UsuarioAnulacion { get; set; }
        public string? DiferidoOrigen { get; set; }
        public decimal? CostoLocF { get; set; }
        public decimal? CostoDolF { get; set; }
        public decimal? CostoLocC { get; set; }
        public decimal? CostoDolC { get; set; }
        public string? ModalidadC { get; set; }
        public decimal? ValorModalidadC { get; set; }
        public decimal? AmortizacionLocF { get; set; }
        public decimal? AmortizacionDolF { get; set; }
        public decimal? AmortizacionLocC { get; set; }
        public decimal? AmortizacionDolC { get; set; }
        public decimal? AmortizadoLocF { get; set; }
        public decimal? AmortizadoDolF { get; set; }
        public decimal? AmortizadoLocC { get; set; }
        public decimal? AmortizadoDolC { get; set; }
        public decimal? PendienteAmortLocF { get; set; }
        public decimal? PendienteAmortDolF { get; set; }
        public decimal? PendienteAmortLocC { get; set; }
        public decimal? PendienteAmortDolC { get; set; }
        public string? AsientoCorp { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string Marcado { get; set; } = null!;
        public string? UsuarioMarcado { get; set; }
        public string? ConceptoMe { get; set; }
        public string? DesgloseImp { get; set; }

        public virtual CentroCuentum Ct { get; set; } = null!;
        public virtual CentroCuentum Ct1 { get; set; } = null!;
        public virtual CentroCuentum Ct2 { get; set; } = null!;
        public virtual CentroCuentum CtNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioAnulacionNavigation { get; set; }
        public virtual ICollection<DiferidoDocCc> DiferidoDocCcs { get; set; }
        public virtual ICollection<DiferidoDocCp> DiferidoDocCps { get; set; }
        public virtual ICollection<DiferidosImpuesto> DiferidosImpuestos { get; set; }
    }
}
