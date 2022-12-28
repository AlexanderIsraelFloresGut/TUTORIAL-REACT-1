using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ContribucionVac
    {
        public ContribucionVac()
        {
            CalcVacDetalles = new HashSet<CalcVacDetalle>();
            RegimenVacContris = new HashSet<RegimenVacContri>();
        }

        public string ContribucionVac1 { get; set; } = null!;
        public string UsuarioCreacion { get; set; } = null!;
        public string UsuarioUltModif { get; set; } = null!;
        public string TipoAccion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Activa { get; set; } = null!;
        public string VerificaCondicion { get; set; } = null!;
        public decimal? CantidadDias { get; set; }
        public string Periodicidad { get; set; } = null!;
        public short? Periodo { get; set; }
        public string FechaReferencia { get; set; } = null!;
        public string EdicionCalculo { get; set; } = null!;
        public string EliminarContCero { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUltModif { get; set; }
        public string? Notas { get; set; }
        public string UsarFracciones { get; set; } = null!;
        public decimal? CantMaxAnno { get; set; }
        public decimal? CantMaxLey { get; set; }
        public string ControlIncap { get; set; } = null!;
        public string TipoFraccion { get; set; } = null!;
        public short CantDecimales { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual TipoAccion TipoAccionNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioUltModifNavigation { get; set; } = null!;
        public virtual ContribVacCondic ContribVacCondic { get; set; } = null!;
        public virtual ContribVacForm ContribVacForm { get; set; } = null!;
        public virtual ICollection<CalcVacDetalle> CalcVacDetalles { get; set; }
        public virtual ICollection<RegimenVacContri> RegimenVacContris { get; set; }
    }
}
