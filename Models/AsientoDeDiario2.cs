using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AsientoDeDiario2
    {
        public AsientoDeDiario2()
        {
            AsientoMarcado2s = new HashSet<AsientoMarcado2>();
            Diario2s = new HashSet<Diario2>();
        }

        public string Asiento { get; set; } = null!;
        public string Paquete { get; set; } = null!;
        public string TipoAsiento { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Contabilidad { get; set; } = null!;
        public string Origen { get; set; } = null!;
        public string ClaseAsiento { get; set; } = null!;
        public decimal TotalDebitoLoc { get; set; }
        public decimal TotalDebitoDol { get; set; }
        public decimal TotalCreditoLoc { get; set; }
        public decimal TotalCreditoDol { get; set; }
        public string UltimoUsuario { get; set; } = null!;
        public DateTime FechaUltModif { get; set; }
        public string Marcado { get; set; } = null!;
        public string? Notas { get; set; }
        public decimal TotalControlLoc { get; set; }
        public decimal TotalControlDol { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string? Dependencia { get; set; }
        public string? DocumentoGlobal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Paquete2 PaqueteNavigation { get; set; } = null!;
        public virtual TipoAsiento2 TipoAsientoNavigation { get; set; } = null!;
        public virtual Usuario2 UltimoUsuarioNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual ICollection<AsientoMarcado2> AsientoMarcado2s { get; set; }
        public virtual ICollection<Diario2> Diario2s { get; set; }
    }
}
