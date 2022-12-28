using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CentroCosto1
    {
        public CentroCosto1()
        {
            ActivoCentro1s = new HashSet<ActivoCentro1>();
            CalculoVacacional1s = new HashSet<CalculoVacacional1>();
            CentroConcepto1s = new HashSet<CentroConcepto1>();
            CentroCostoRubro1s = new HashSet<CentroCostoRubro1>();
            CentroCuentum1s = new HashSet<CentroCuentum1>();
            CuentaDepreciacio1s = new HashSet<CuentaDepreciacio1>();
            DeprCentroCosto1s = new HashSet<DeprCentroCosto1>();
            Empleado1s = new HashSet<Empleado1>();
            EmpleadoAccPer1s = new HashSet<EmpleadoAccPer1>();
            EmpleadoCentro1s = new HashSet<EmpleadoCentro1>();
            Equipo1s = new HashSet<Equipo1>();
            EstrucManufactura1s = new HashSet<EstrucManufactura1>();
            FacturaLinea1s = new HashSet<FacturaLinea1>();
            HistoricoEmpleado1s = new HashSet<HistoricoEmpleado1>();
            HoraLaboradum1s = new HashSet<HoraLaboradum1>();
            OrdenProduccion1s = new HashSet<OrdenProduccion1>();
            OrdenTrabajo1s = new HashSet<OrdenTrabajo1>();
            PedidoLinea1s = new HashSet<PedidoLinea1>();
            SolicitudTrabajo1s = new HashSet<SolicitudTrabajo1>();
            TipoActivo1CtrAiDeprecCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtrAiDeprecNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtrAjuInflacCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtrAjuInflacNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtrDeprDesmanCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtrDeprDesmanFNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtrDesmanCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtrDesmanFNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtrDeterioroCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtrDeterioroFNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtrGastoDeterioroCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1CtrGastoDeterioroFNavigations = new HashSet<TipoActivo1>();
            UsuariosXCentro1s = new HashSet<UsuariosXCentro1>();
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

        public virtual ICollection<ActivoCentro1> ActivoCentro1s { get; set; }
        public virtual ICollection<CalculoVacacional1> CalculoVacacional1s { get; set; }
        public virtual ICollection<CentroConcepto1> CentroConcepto1s { get; set; }
        public virtual ICollection<CentroCostoRubro1> CentroCostoRubro1s { get; set; }
        public virtual ICollection<CentroCuentum1> CentroCuentum1s { get; set; }
        public virtual ICollection<CuentaDepreciacio1> CuentaDepreciacio1s { get; set; }
        public virtual ICollection<DeprCentroCosto1> DeprCentroCosto1s { get; set; }
        public virtual ICollection<Empleado1> Empleado1s { get; set; }
        public virtual ICollection<EmpleadoAccPer1> EmpleadoAccPer1s { get; set; }
        public virtual ICollection<EmpleadoCentro1> EmpleadoCentro1s { get; set; }
        public virtual ICollection<Equipo1> Equipo1s { get; set; }
        public virtual ICollection<EstrucManufactura1> EstrucManufactura1s { get; set; }
        public virtual ICollection<FacturaLinea1> FacturaLinea1s { get; set; }
        public virtual ICollection<HistoricoEmpleado1> HistoricoEmpleado1s { get; set; }
        public virtual ICollection<HoraLaboradum1> HoraLaboradum1s { get; set; }
        public virtual ICollection<OrdenProduccion1> OrdenProduccion1s { get; set; }
        public virtual ICollection<OrdenTrabajo1> OrdenTrabajo1s { get; set; }
        public virtual ICollection<PedidoLinea1> PedidoLinea1s { get; set; }
        public virtual ICollection<SolicitudTrabajo1> SolicitudTrabajo1s { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtrAiDeprecCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtrAiDeprecNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtrAjuInflacCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtrAjuInflacNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtrDeprDesmanCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtrDeprDesmanFNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtrDesmanCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtrDesmanFNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtrDeterioroCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtrDeterioroFNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtrGastoDeterioroCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1CtrGastoDeterioroFNavigations { get; set; }
        public virtual ICollection<UsuariosXCentro1> UsuariosXCentro1s { get; set; }
    }
}
