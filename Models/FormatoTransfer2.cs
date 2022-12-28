using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FormatoTransfer2
    {
        public FormatoTransfer2()
        {
            FormatoTranParam2s = new HashSet<FormatoTranParam2>();
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

        public virtual EntidadFinanciera2 EntidadFinancieraNavigation { get; set; } = null!;
        public virtual FormatoTranSftp2 FormatoTranSftp2 { get; set; } = null!;
        public virtual ICollection<FormatoTranParam2> FormatoTranParam2s { get; set; }
    }
}
