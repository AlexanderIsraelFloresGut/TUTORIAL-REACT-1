using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Nit1
    {
        public Nit1()
        {
            Articulo1s = new HashSet<Articulo1>();
            AsientoDistLinea1s = new HashSet<AsientoDistLinea1>();
            AsientoRecuLinea1s = new HashSet<AsientoRecuLinea1>();
            CartaPorteUbicacions = new HashSet<CartaPorteUbicacion>();
            Cheque1s = new HashSet<Cheque1>();
            Cliente1s = new HashSet<Cliente1>();
            Diario1s = new HashSet<Diario1>();
            DocsSoporte1s = new HashSet<DocsSoporte1>();
            Empleado1s = new HashSet<Empleado1>();
            EntidadFinanciera1s = new HashSet<EntidadFinanciera1>();
            LineaDocInv1s = new HashSet<LineaDocInv1>();
            LiquidacGasto1s = new HashSet<LiquidacGasto1>();
            Mayor1s = new HashSet<Mayor1>();
            MovBanco1s = new HashSet<MovBanco1>();
            MultipleAdquiriente1s = new HashSet<MultipleAdquiriente1>();
            Participante1s = new HashSet<Participante1>();
            Proveedor1s = new HashSet<Proveedor1>();
            ResolucionE1s = new HashSet<ResolucionE1>();
            Responsable1s = new HashSet<Responsable1>();
            TransaccionInv1s = new HashSet<TransaccionInv1>();
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
        public string? CodInternoEmp { get; set; }
        public string? Cargo { get; set; }
        public string? AreaDeptoSecc { get; set; }

        public virtual Pai1? PaisNavigation { get; set; }
        public virtual TipoNit1? TipoNavigation { get; set; }
        public virtual Tributo1? TributoRutNavigation { get; set; }
        public virtual ICollection<Articulo1> Articulo1s { get; set; }
        public virtual ICollection<AsientoDistLinea1> AsientoDistLinea1s { get; set; }
        public virtual ICollection<AsientoRecuLinea1> AsientoRecuLinea1s { get; set; }
        public virtual ICollection<CartaPorteUbicacion> CartaPorteUbicacions { get; set; }
        public virtual ICollection<Cheque1> Cheque1s { get; set; }
        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<Diario1> Diario1s { get; set; }
        public virtual ICollection<DocsSoporte1> DocsSoporte1s { get; set; }
        public virtual ICollection<Empleado1> Empleado1s { get; set; }
        public virtual ICollection<EntidadFinanciera1> EntidadFinanciera1s { get; set; }
        public virtual ICollection<LineaDocInv1> LineaDocInv1s { get; set; }
        public virtual ICollection<LiquidacGasto1> LiquidacGasto1s { get; set; }
        public virtual ICollection<Mayor1> Mayor1s { get; set; }
        public virtual ICollection<MovBanco1> MovBanco1s { get; set; }
        public virtual ICollection<MultipleAdquiriente1> MultipleAdquiriente1s { get; set; }
        public virtual ICollection<Participante1> Participante1s { get; set; }
        public virtual ICollection<Proveedor1> Proveedor1s { get; set; }
        public virtual ICollection<ResolucionE1> ResolucionE1s { get; set; }
        public virtual ICollection<Responsable1> Responsable1s { get; set; }
        public virtual ICollection<TransaccionInv1> TransaccionInv1s { get; set; }
    }
}
