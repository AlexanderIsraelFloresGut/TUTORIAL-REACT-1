using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Nit
    {
        public Nit()
        {
            Articulos = new HashSet<Articulo>();
            AsientoDistLineas = new HashSet<AsientoDistLinea>();
            AsientoRecuLineas = new HashSet<AsientoRecuLinea>();
            Cheques = new HashSet<Cheque>();
            Clientes = new HashSet<Cliente>();
            Diarios = new HashSet<Diario>();
            DocsSoportes = new HashSet<DocsSoporte>();
            Empleados = new HashSet<Empleado>();
            EntidadFinancieras = new HashSet<EntidadFinanciera>();
            LineaDocInvs = new HashSet<LineaDocInv>();
            LiquidacGastos = new HashSet<LiquidacGasto>();
            Mayors = new HashSet<Mayor>();
            MovBancos = new HashSet<MovBanco>();
            MultipleAdquirientes = new HashSet<MultipleAdquiriente>();
            Participantes = new HashSet<Participante>();
            Proveedors = new HashSet<Proveedor>();
            ResolucionEs = new HashSet<ResolucionE>();
            TransaccionInvs = new HashSet<TransaccionInv>();
        }

        public string Nit1 { get; set; } = null!;
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

        public virtual Pai? PaisNavigation { get; set; }
        public virtual TipoNit? TipoNavigation { get; set; }
        public virtual Tributo? TributoRutNavigation { get; set; }
        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<AsientoDistLinea> AsientoDistLineas { get; set; }
        public virtual ICollection<AsientoRecuLinea> AsientoRecuLineas { get; set; }
        public virtual ICollection<Cheque> Cheques { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Diario> Diarios { get; set; }
        public virtual ICollection<DocsSoporte> DocsSoportes { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<EntidadFinanciera> EntidadFinancieras { get; set; }
        public virtual ICollection<LineaDocInv> LineaDocInvs { get; set; }
        public virtual ICollection<LiquidacGasto> LiquidacGastos { get; set; }
        public virtual ICollection<Mayor> Mayors { get; set; }
        public virtual ICollection<MovBanco> MovBancos { get; set; }
        public virtual ICollection<MultipleAdquiriente> MultipleAdquirientes { get; set; }
        public virtual ICollection<Participante> Participantes { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
        public virtual ICollection<ResolucionE> ResolucionEs { get; set; }
        public virtual ICollection<TransaccionInv> TransaccionInvs { get; set; }
    }
}
