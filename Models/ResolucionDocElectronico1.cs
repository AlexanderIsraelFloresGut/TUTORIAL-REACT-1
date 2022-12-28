using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ResolucionDocElectronico1
    {
        public ResolucionDocElectronico1()
        {
            ConsecutivoFa1s = new HashSet<ConsecutivoFa1>();
        }

        public string Resolucion { get; set; } = null!;
        public string? Caja { get; set; }
        public string TipoDocumento { get; set; } = null!;
        public string TipoActivo { get; set; } = null!;
        public DateTime? FechaResolucion { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public string? NumeroAutorizacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string InformacionRegimen { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public string? Mascara { get; set; }
        public int FolioInicial { get; set; }
        public int FolioFinal { get; set; }
        public int? UltimoFolio { get; set; }
        public string Estado { get; set; } = null!;
        public string UsuarioCreacion { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public string NombreSucursal { get; set; } = null!;
        public string? DispositivoElectronico { get; set; }
        public string? Direccion1 { get; set; }
        public string? Municipio { get; set; }
        public string? Departamento { get; set; }
        public string? CodigoPais { get; set; }
        public string? FormatoPdf { get; set; }
        public string? FormatoXslt { get; set; }
        public int? AnnoActual { get; set; }
        public int? Correlativo { get; set; }
        public string SinVencimiento { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ConsecutivoFa1> ConsecutivoFa1s { get; set; }
    }
}
