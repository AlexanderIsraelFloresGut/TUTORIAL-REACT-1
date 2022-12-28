using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FormatoTransfer
    {
        public FormatoTransfer()
        {
            FormatoTranParams = new HashSet<FormatoTranParam>();
        }

        public string Formato { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string EntidadFinanciera { get; set; } = null!;
        public string TipoArchivo { get; set; } = null!;
        public string ArchivoTransformacion { get; set; } = null!;
        public string FuenteDatos { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EntidadFinanciera EntidadFinancieraNavigation { get; set; } = null!;
        public virtual FormatoTranSftp FormatoTranSftp { get; set; } = null!;
        public virtual ICollection<FormatoTranParam> FormatoTranParams { get; set; }
    }
}
