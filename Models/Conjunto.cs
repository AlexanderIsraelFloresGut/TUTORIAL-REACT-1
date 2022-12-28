using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Conjunto
    {
        public Conjunto()
        {
            AutenticaCatalogos = new HashSet<AutenticaCatalogo>();
            ModuloInstalados = new HashSet<ModuloInstalado>();
            Participante1s = new HashSet<Participante1>();
            Participante2s = new HashSet<Participante2>();
            Participantes = new HashSet<Participante>();
            Privilegioices = new HashSet<PrivilegioEx>();
        }

        public string Conjunto1 { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Direc1 { get; set; }
        public string? Direc2 { get; set; }
        public string Telefono { get; set; } = null!;
        public string? Logo { get; set; }
        public string DobleMoneda { get; set; } = null!;
        public string DobleContabilidad { get; set; } = null!;
        public string InventarioDolar { get; set; } = null!;
        public string UsaLotes { get; set; } = null!;
        public string UsarCentrosCosto { get; set; } = null!;
        public string Consolida { get; set; } = null!;
        public string? Consolidadora { get; set; }
        public string? BdCiaConsolidad { get; set; }
        public short? ContaAConsolid { get; set; }
        public string? MismoCuadroCtb { get; set; }
        public string UsuarioUltMod { get; set; } = null!;
        public DateTime FchHoraUltMod { get; set; }
        public string? Notas { get; set; }
        public string UsaUnidades { get; set; } = null!;
        public string? UnidadOmision { get; set; }
        public string? MonedaConsolida { get; set; }
        public string? VersionBd { get; set; }
        public string? UsuarioModifBd { get; set; }
        public DateTime? FchHoraModifBd { get; set; }
        public string? VersionInstalac { get; set; }
        public string? Nit { get; set; }
        public string? Pais { get; set; }
        public string? Gln { get; set; }
        public string? Ubicacion { get; set; }
        public string? Idioma { get; set; }
        public string? UsaSucursal { get; set; }
        public string? MascaraSucursal { get; set; }
        public string? DireccionWeb1 { get; set; }
        public string? DireccionWeb2 { get; set; }
        public string? NombreWeb1 { get; set; }
        public string? NombreWeb2 { get; set; }
        public string? DireccionPagWeb { get; set; }
        public string? EmailDocElectronico { get; set; }
        public string? PaisDivision { get; set; }
        public string? DivisionGeografica1 { get; set; }
        public string? DivisionGeografica2 { get; set; }
        public byte[]? LogoCia { get; set; }
        public string? NumeroRegistro { get; set; }
        public string? Direc3 { get; set; }
        public string? CodPostal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? DivisionGeografica3 { get; set; }
        public string? DivisionGeografica4 { get; set; }
        public string? RegimenFiscal { get; set; }
        public string? Coordenadas { get; set; }
        public string? ActividadComercial { get; set; }
        public string? NumeroRegistroIva { get; set; }
        public string? UsaConsorcio { get; set; }
        public string? TipoOperacion { get; set; }
        public string AgentePercepcion { get; set; } = null!;
        public string CalcPerceSoloVenta { get; set; } = null!;
        public string AgenteRetencion { get; set; } = null!;
        public string RetencionCliente { get; set; } = null!;

        public virtual Usuario2 UsuarioUltModNavigation { get; set; } = null!;
        public virtual ICollection<AutenticaCatalogo> AutenticaCatalogos { get; set; }
        public virtual ICollection<ModuloInstalado> ModuloInstalados { get; set; }
        public virtual ICollection<Participante1> Participante1s { get; set; }
        public virtual ICollection<Participante2> Participante2s { get; set; }
        public virtual ICollection<Participante> Participantes { get; set; }
        public virtual ICollection<PrivilegioEx> Privilegioices { get; set; }
    }
}
