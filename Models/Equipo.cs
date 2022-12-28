using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Equipo
    {
        public Equipo()
        {
            AtribEquipos = new HashSet<AtribEquipo>();
            DocsEquipos = new HashSet<DocsEquipo>();
            EquipoEquivalenteEquipoEquivalente1Navigations = new HashSet<EquipoEquivalente>();
            EquipoEquivalenteEquipoNavigations = new HashSet<EquipoEquivalente>();
            EquipoParentescoEquipoHijoNavigations = new HashSet<EquipoParentesco>();
            EquipoParentescoEquipoPadreNavigations = new HashSet<EquipoParentesco>();
            EspecEquipos = new HashSet<EspecEquipo>();
            EstrucProcesos = new HashSet<EstrucProceso>();
            InverseEquipoPadreNavigation = new HashSet<Equipo>();
            OpOperDets = new HashSet<OpOperDet>();
            OpOperacionEquipoNavigations = new HashSet<OpOperacion>();
            OpOperacionEquipoSimulacionNavigations = new HashSet<OpOperacion>();
            OtDetalleEquipoNavigations = new HashSet<OtDetalle>();
            OtDetalleEquipoPadreNavigations = new HashSet<OtDetalle>();
            OtEquipoEquipoNavigations = new HashSet<OtEquipo>();
            OtEquipoEquipoPadreNavigations = new HashSet<OtEquipo>();
            OtGastos = new HashSet<OtGasto>();
            OtReporteConsumos = new HashSet<OtReporteConsumo>();
            OtReporteLabors = new HashSet<OtReporteLabor>();
            ProcEquipos = new HashSet<ProcEquipo>();
            SolicitudTrabajos = new HashSet<SolicitudTrabajo>();
            TransaccionMants = new HashSet<TransaccionMant>();
        }

        public string Equipo1 { get; set; } = null!;
        public string TipoEquipo { get; set; } = null!;
        public string? Modelo { get; set; }
        public string? Serie { get; set; }
        public string Descripcion { get; set; } = null!;
        public string EstaActivo { get; set; } = null!;
        public string Clase { get; set; } = null!;
        public string? Marca { get; set; }
        public string? NumParteProv { get; set; }
        public decimal ConfiabiDada { get; set; }
        public decimal ConfiabiCalcu { get; set; }
        public DateTime? FechaInstalacion { get; set; }
        public string? Notas { get; set; }
        public string? Departamento { get; set; }
        public string? ActivoFijo { get; set; }
        public string? Mejora { get; set; }
        public string? Proveedor { get; set; }
        public string? Ubicacion { get; set; }
        public DateTime? FechaAdquisicion { get; set; }
        public DateTime? FechaManufactura { get; set; }
        public decimal HorasProdDiarias { get; set; }
        public int? OtUltimoMant { get; set; }
        public DateTime? FechaUltimoMant { get; set; }
        public DateTime? FechaProxMant { get; set; }
        public decimal VidaUtilPromedio { get; set; }
        public string? UnidadVida { get; set; }
        public decimal CostoMantAcuLoc { get; set; }
        public decimal CostoMantAcuDol { get; set; }
        public string? EquipoPadre { get; set; }
        public string? Usuario { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal Capacidad { get; set; }
        public string? CelulaTrabajo { get; set; }
        public string CapacidadUnid { get; set; } = null!;
        public string? Calendario { get; set; }
        public string? CtrEquipo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ActivoMejora? ActivoMejora { get; set; }
        public virtual Calendario? CalendarioNavigation { get; set; }
        public virtual UnidadMedicion CapacidadUn { get; set; } = null!;
        public virtual CelulaTrabajo? CelulaTrabajoNavigation { get; set; }
        public virtual ClaseEquipo ClaseNavigation { get; set; } = null!;
        public virtual CentroCosto? CtrEquipoNavigation { get; set; }
        public virtual Departamento? DepartamentoNavigation { get; set; }
        public virtual Equipo? EquipoPadreNavigation { get; set; }
        public virtual Marca? MarcaNavigation { get; set; }
        public virtual OrdenTrabajo? OtUltimoMantNavigation { get; set; }
        public virtual Proveedor? ProveedorNavigation { get; set; }
        public virtual TipoEquipo TipoEquipoNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioNavigation { get; set; }
        public virtual EquipoPrevent EquipoPrevent { get; set; } = null!;
        public virtual ICollection<AtribEquipo> AtribEquipos { get; set; }
        public virtual ICollection<DocsEquipo> DocsEquipos { get; set; }
        public virtual ICollection<EquipoEquivalente> EquipoEquivalenteEquipoEquivalente1Navigations { get; set; }
        public virtual ICollection<EquipoEquivalente> EquipoEquivalenteEquipoNavigations { get; set; }
        public virtual ICollection<EquipoParentesco> EquipoParentescoEquipoHijoNavigations { get; set; }
        public virtual ICollection<EquipoParentesco> EquipoParentescoEquipoPadreNavigations { get; set; }
        public virtual ICollection<EspecEquipo> EspecEquipos { get; set; }
        public virtual ICollection<EstrucProceso> EstrucProcesos { get; set; }
        public virtual ICollection<Equipo> InverseEquipoPadreNavigation { get; set; }
        public virtual ICollection<OpOperDet> OpOperDets { get; set; }
        public virtual ICollection<OpOperacion> OpOperacionEquipoNavigations { get; set; }
        public virtual ICollection<OpOperacion> OpOperacionEquipoSimulacionNavigations { get; set; }
        public virtual ICollection<OtDetalle> OtDetalleEquipoNavigations { get; set; }
        public virtual ICollection<OtDetalle> OtDetalleEquipoPadreNavigations { get; set; }
        public virtual ICollection<OtEquipo> OtEquipoEquipoNavigations { get; set; }
        public virtual ICollection<OtEquipo> OtEquipoEquipoPadreNavigations { get; set; }
        public virtual ICollection<OtGasto> OtGastos { get; set; }
        public virtual ICollection<OtReporteConsumo> OtReporteConsumos { get; set; }
        public virtual ICollection<OtReporteLabor> OtReporteLabors { get; set; }
        public virtual ICollection<ProcEquipo> ProcEquipos { get; set; }
        public virtual ICollection<SolicitudTrabajo> SolicitudTrabajos { get; set; }
        public virtual ICollection<TransaccionMant> TransaccionMants { get; set; }
    }
}
