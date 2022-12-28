using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Equipo1
    {
        public Equipo1()
        {
            AtribEquipo1s = new HashSet<AtribEquipo1>();
            DocsEquipo1s = new HashSet<DocsEquipo1>();
            EquipoEquivalente1EquipoEquivalenteNavigations = new HashSet<EquipoEquivalente1>();
            EquipoEquivalente1EquipoNavigations = new HashSet<EquipoEquivalente1>();
            EquipoParentesco1EquipoHijoNavigations = new HashSet<EquipoParentesco1>();
            EquipoParentesco1EquipoPadreNavigations = new HashSet<EquipoParentesco1>();
            EspecEquipo1s = new HashSet<EspecEquipo1>();
            EstrucProceso1s = new HashSet<EstrucProceso1>();
            InverseEquipoPadreNavigation = new HashSet<Equipo1>();
            OpOperDet1s = new HashSet<OpOperDet1>();
            OpOperacion1EquipoNavigations = new HashSet<OpOperacion1>();
            OpOperacion1EquipoSimulacionNavigations = new HashSet<OpOperacion1>();
            OtDetalle1EquipoNavigations = new HashSet<OtDetalle1>();
            OtDetalle1EquipoPadreNavigations = new HashSet<OtDetalle1>();
            OtEquipo1EquipoNavigations = new HashSet<OtEquipo1>();
            OtEquipo1EquipoPadreNavigations = new HashSet<OtEquipo1>();
            OtGasto1s = new HashSet<OtGasto1>();
            OtReporteConsumo1s = new HashSet<OtReporteConsumo1>();
            OtReporteLabor1s = new HashSet<OtReporteLabor1>();
            ProcEquipo1s = new HashSet<ProcEquipo1>();
            SolicitudTrabajo1s = new HashSet<SolicitudTrabajo1>();
            TransaccionMant1s = new HashSet<TransaccionMant1>();
        }

        public string Equipo { get; set; } = null!;
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

        public virtual ActivoMejora1? ActivoMejora1 { get; set; }
        public virtual Calendario1? CalendarioNavigation { get; set; }
        public virtual UnidadMedicion1 CapacidadUn { get; set; } = null!;
        public virtual CelulaTrabajo1? CelulaTrabajoNavigation { get; set; }
        public virtual ClaseEquipo1 ClaseNavigation { get; set; } = null!;
        public virtual CentroCosto1? CtrEquipoNavigation { get; set; }
        public virtual Departamento1? DepartamentoNavigation { get; set; }
        public virtual Equipo1? EquipoPadreNavigation { get; set; }
        public virtual Marca1? MarcaNavigation { get; set; }
        public virtual OrdenTrabajo1? OtUltimoMantNavigation { get; set; }
        public virtual Proveedor1? ProveedorNavigation { get; set; }
        public virtual TipoEquipo1 TipoEquipoNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioNavigation { get; set; }
        public virtual EquipoPrevent1 EquipoPrevent1 { get; set; } = null!;
        public virtual ICollection<AtribEquipo1> AtribEquipo1s { get; set; }
        public virtual ICollection<DocsEquipo1> DocsEquipo1s { get; set; }
        public virtual ICollection<EquipoEquivalente1> EquipoEquivalente1EquipoEquivalenteNavigations { get; set; }
        public virtual ICollection<EquipoEquivalente1> EquipoEquivalente1EquipoNavigations { get; set; }
        public virtual ICollection<EquipoParentesco1> EquipoParentesco1EquipoHijoNavigations { get; set; }
        public virtual ICollection<EquipoParentesco1> EquipoParentesco1EquipoPadreNavigations { get; set; }
        public virtual ICollection<EspecEquipo1> EspecEquipo1s { get; set; }
        public virtual ICollection<EstrucProceso1> EstrucProceso1s { get; set; }
        public virtual ICollection<Equipo1> InverseEquipoPadreNavigation { get; set; }
        public virtual ICollection<OpOperDet1> OpOperDet1s { get; set; }
        public virtual ICollection<OpOperacion1> OpOperacion1EquipoNavigations { get; set; }
        public virtual ICollection<OpOperacion1> OpOperacion1EquipoSimulacionNavigations { get; set; }
        public virtual ICollection<OtDetalle1> OtDetalle1EquipoNavigations { get; set; }
        public virtual ICollection<OtDetalle1> OtDetalle1EquipoPadreNavigations { get; set; }
        public virtual ICollection<OtEquipo1> OtEquipo1EquipoNavigations { get; set; }
        public virtual ICollection<OtEquipo1> OtEquipo1EquipoPadreNavigations { get; set; }
        public virtual ICollection<OtGasto1> OtGasto1s { get; set; }
        public virtual ICollection<OtReporteConsumo1> OtReporteConsumo1s { get; set; }
        public virtual ICollection<OtReporteLabor1> OtReporteLabor1s { get; set; }
        public virtual ICollection<ProcEquipo1> ProcEquipo1s { get; set; }
        public virtual ICollection<SolicitudTrabajo1> SolicitudTrabajo1s { get; set; }
        public virtual ICollection<TransaccionMant1> TransaccionMant1s { get; set; }
    }
}
