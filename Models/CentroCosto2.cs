using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CentroCosto2
    {
        public CentroCosto2()
        {
            ActivoCentro2s = new HashSet<ActivoCentro2>();
            CalculoVacacional2s = new HashSet<CalculoVacacional2>();
            CentroConcepto2s = new HashSet<CentroConcepto2>();
            CentroCuentum2s = new HashSet<CentroCuentum2>();
            CuentaDepreciacio2s = new HashSet<CuentaDepreciacio2>();
            DeprCentroCosto2s = new HashSet<DeprCentroCosto2>();
            Empleado2s = new HashSet<Empleado2>();
            EmpleadoAccPer2s = new HashSet<EmpleadoAccPer2>();
            EmpleadoCentro2s = new HashSet<EmpleadoCentro2>();
            FacturaLinea2s = new HashSet<FacturaLinea2>();
            HistoricoEmpleado2s = new HashSet<HistoricoEmpleado2>();
            HoraLaboradum2s = new HashSet<HoraLaboradum2>();
            OrdenProduccion2s = new HashSet<OrdenProduccion2>();
            PedidoLinea2s = new HashSet<PedidoLinea2>();
            TipoActivo2CtrAiDeprecCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtrAiDeprecNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtrAjuInflacCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtrAjuInflacNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtrDeprDesmanCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtrDeprDesmanFNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtrDesmanCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtrDesmanFNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtrDeterioroCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtrDeterioroFNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtrGastoDeterioroCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2CtrGastoDeterioroFNavigations = new HashSet<TipoActivo2>();
            UsuariosXCentro2s = new HashSet<UsuariosXCentro2>();
        }

        public string CentroCosto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string AceptaDatos { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoCentro2> ActivoCentro2s { get; set; }
        public virtual ICollection<CalculoVacacional2> CalculoVacacional2s { get; set; }
        public virtual ICollection<CentroConcepto2> CentroConcepto2s { get; set; }
        public virtual ICollection<CentroCuentum2> CentroCuentum2s { get; set; }
        public virtual ICollection<CuentaDepreciacio2> CuentaDepreciacio2s { get; set; }
        public virtual ICollection<DeprCentroCosto2> DeprCentroCosto2s { get; set; }
        public virtual ICollection<Empleado2> Empleado2s { get; set; }
        public virtual ICollection<EmpleadoAccPer2> EmpleadoAccPer2s { get; set; }
        public virtual ICollection<EmpleadoCentro2> EmpleadoCentro2s { get; set; }
        public virtual ICollection<FacturaLinea2> FacturaLinea2s { get; set; }
        public virtual ICollection<HistoricoEmpleado2> HistoricoEmpleado2s { get; set; }
        public virtual ICollection<HoraLaboradum2> HoraLaboradum2s { get; set; }
        public virtual ICollection<OrdenProduccion2> OrdenProduccion2s { get; set; }
        public virtual ICollection<PedidoLinea2> PedidoLinea2s { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtrAiDeprecCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtrAiDeprecNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtrAjuInflacCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtrAjuInflacNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtrDeprDesmanCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtrDeprDesmanFNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtrDesmanCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtrDesmanFNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtrDeterioroCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtrDeterioroFNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtrGastoDeterioroCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2CtrGastoDeterioroFNavigations { get; set; }
        public virtual ICollection<UsuariosXCentro2> UsuariosXCentro2s { get; set; }
    }
}
