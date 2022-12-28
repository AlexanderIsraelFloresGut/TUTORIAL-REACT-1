using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Nit2
    {
        public Nit2()
        {
            Articulo2s = new HashSet<Articulo2>();
            AsientoDistLinea2s = new HashSet<AsientoDistLinea2>();
            AsientoRecuLinea2s = new HashSet<AsientoRecuLinea2>();
            Cheque2s = new HashSet<Cheque2>();
            Cliente2s = new HashSet<Cliente2>();
            Diario2s = new HashSet<Diario2>();
            DocsSoporte2s = new HashSet<DocsSoporte2>();
            Empleado2s = new HashSet<Empleado2>();
            EntidadFinanciera2s = new HashSet<EntidadFinanciera2>();
            LineaDocInv2s = new HashSet<LineaDocInv2>();
            LiquidacGasto2s = new HashSet<LiquidacGasto2>();
            Mayor2s = new HashSet<Mayor2>();
            MovBanco2s = new HashSet<MovBanco2>();
            MultipleAdquiriente2s = new HashSet<MultipleAdquiriente2>();
            Participante2s = new HashSet<Participante2>();
            Proveedor2s = new HashSet<Proveedor2>();
            ResolucionE2s = new HashSet<ResolucionE2>();
            TransaccionInv2s = new HashSet<TransaccionInv2>();
        }

        public string Nit { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string? Alias { get; set; }
        public string? Notas { get; set; }
        public string? Tipo { get; set; }
        public string? DigitoVerificador { get; set; }
        public string? UsaReporteD151 { get; set; }
        public string Origen { get; set; } = null!;
        public string? NumeroDocNit { get; set; }
        public string? Sucursal { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? TipoDocumento { get; set; }
        public string? ClaseDocumento { get; set; }
        public string? Departamento { get; set; }
        public string? Municipio { get; set; }
        public string? Pais { get; set; }
        public string? Exterior { get; set; }
        public int? DetalleDireccion { get; set; }
        public string? Direccion { get; set; }
        public string? Naturaleza { get; set; }
        public string? ActividadEconomina { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public string? Celular { get; set; }
        public string Activo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? TipoContribuyente { get; set; }
        public string? Nrc { get; set; }
        public string? Giro { get; set; }
        public string? Categoria { get; set; }
        public string? Dui { get; set; }
        public string? TipoRegimen { get; set; }
        public string? Pasaporte { get; set; }
        public string? Carne { get; set; }
        public string? Otro { get; set; }
        public string InfLegal { get; set; } = null!;
        public string? CodPostal { get; set; }
        public string? ObligResponRut { get; set; }
        public string? ResponsableRut { get; set; }
        public string? TributoRut { get; set; }

        public virtual Pai2? PaisNavigation { get; set; }
        public virtual TipoNit2? TipoNavigation { get; set; }
        public virtual Tributo2? TributoRutNavigation { get; set; }
        public virtual ICollection<Articulo2> Articulo2s { get; set; }
        public virtual ICollection<AsientoDistLinea2> AsientoDistLinea2s { get; set; }
        public virtual ICollection<AsientoRecuLinea2> AsientoRecuLinea2s { get; set; }
        public virtual ICollection<Cheque2> Cheque2s { get; set; }
        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<Diario2> Diario2s { get; set; }
        public virtual ICollection<DocsSoporte2> DocsSoporte2s { get; set; }
        public virtual ICollection<Empleado2> Empleado2s { get; set; }
        public virtual ICollection<EntidadFinanciera2> EntidadFinanciera2s { get; set; }
        public virtual ICollection<LineaDocInv2> LineaDocInv2s { get; set; }
        public virtual ICollection<LiquidacGasto2> LiquidacGasto2s { get; set; }
        public virtual ICollection<Mayor2> Mayor2s { get; set; }
        public virtual ICollection<MovBanco2> MovBanco2s { get; set; }
        public virtual ICollection<MultipleAdquiriente2> MultipleAdquiriente2s { get; set; }
        public virtual ICollection<Participante2> Participante2s { get; set; }
        public virtual ICollection<Proveedor2> Proveedor2s { get; set; }
        public virtual ICollection<ResolucionE2> ResolucionE2s { get; set; }
        public virtual ICollection<TransaccionInv2> TransaccionInv2s { get; set; }
    }
}
