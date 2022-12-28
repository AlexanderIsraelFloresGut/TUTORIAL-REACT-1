using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CentroCosto
    {
        public CentroCosto()
        {
            ActivoCentros = new HashSet<ActivoCentro>();
            CalculoVacacionals = new HashSet<CalculoVacacional>();
            CentroConceptos = new HashSet<CentroConcepto>();
            CentroCostoRubros = new HashSet<CentroCostoRubro>();
            CentroCuenta = new HashSet<CentroCuentum>();
            CuentaDepreciacios = new HashSet<CuentaDepreciacio>();
            DeprCentroCostos = new HashSet<DeprCentroCosto>();
            EmpleadoAccPers = new HashSet<EmpleadoAccPer>();
            EmpleadoCentros = new HashSet<EmpleadoCentro>();
            Empleados = new HashSet<Empleado>();
            Equipos = new HashSet<Equipo>();
            EstrucManufacturas = new HashSet<EstrucManufactura>();
            FacturaLineas = new HashSet<FacturaLinea>();
            HistoricoEmpleados = new HashSet<HistoricoEmpleado>();
            HoraLaborada = new HashSet<HoraLaboradum>();
            OrdenProduccions = new HashSet<OrdenProduccion>();
            OrdenTrabajos = new HashSet<OrdenTrabajo>();
            PedidoLineas = new HashSet<PedidoLinea>();
            SolicitudTrabajos = new HashSet<SolicitudTrabajo>();
            TipoActivoCtrAiDeprecCNavigations = new HashSet<TipoActivo>();
            TipoActivoCtrAiDeprecNavigations = new HashSet<TipoActivo>();
            TipoActivoCtrAjuInflacCNavigations = new HashSet<TipoActivo>();
            TipoActivoCtrAjuInflacNavigations = new HashSet<TipoActivo>();
            TipoActivoCtrDeprDesmanCNavigations = new HashSet<TipoActivo>();
            TipoActivoCtrDeprDesmanFNavigations = new HashSet<TipoActivo>();
            TipoActivoCtrDesmanCNavigations = new HashSet<TipoActivo>();
            TipoActivoCtrDesmanFNavigations = new HashSet<TipoActivo>();
            TipoActivoCtrDeterioroCNavigations = new HashSet<TipoActivo>();
            TipoActivoCtrDeterioroFNavigations = new HashSet<TipoActivo>();
            TipoActivoCtrGastoDeterioroCNavigations = new HashSet<TipoActivo>();
            TipoActivoCtrGastoDeterioroFNavigations = new HashSet<TipoActivo>();
            UsuariosXCentros = new HashSet<UsuariosXCentro>();
        }

        public string CentroCosto1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string AceptaDatos { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoCentro> ActivoCentros { get; set; }
        public virtual ICollection<CalculoVacacional> CalculoVacacionals { get; set; }
        public virtual ICollection<CentroConcepto> CentroConceptos { get; set; }
        public virtual ICollection<CentroCostoRubro> CentroCostoRubros { get; set; }
        public virtual ICollection<CentroCuentum> CentroCuenta { get; set; }
        public virtual ICollection<CuentaDepreciacio> CuentaDepreciacios { get; set; }
        public virtual ICollection<DeprCentroCosto> DeprCentroCostos { get; set; }
        public virtual ICollection<EmpleadoAccPer> EmpleadoAccPers { get; set; }
        public virtual ICollection<EmpleadoCentro> EmpleadoCentros { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }
        public virtual ICollection<EstrucManufactura> EstrucManufacturas { get; set; }
        public virtual ICollection<FacturaLinea> FacturaLineas { get; set; }
        public virtual ICollection<HistoricoEmpleado> HistoricoEmpleados { get; set; }
        public virtual ICollection<HoraLaboradum> HoraLaborada { get; set; }
        public virtual ICollection<OrdenProduccion> OrdenProduccions { get; set; }
        public virtual ICollection<OrdenTrabajo> OrdenTrabajos { get; set; }
        public virtual ICollection<PedidoLinea> PedidoLineas { get; set; }
        public virtual ICollection<SolicitudTrabajo> SolicitudTrabajos { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtrAiDeprecCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtrAiDeprecNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtrAjuInflacCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtrAjuInflacNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtrDeprDesmanCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtrDeprDesmanFNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtrDesmanCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtrDesmanFNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtrDeterioroCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtrDeterioroFNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtrGastoDeterioroCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoCtrGastoDeterioroFNavigations { get; set; }
        public virtual ICollection<UsuariosXCentro> UsuariosXCentros { get; set; }
    }
}
