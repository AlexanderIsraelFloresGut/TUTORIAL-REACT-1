using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FormatoTranSftp1
    {
        public string ServidorSftp { get; set; } = null!;
        public string DirectorioSftp { get; set; } = null!;
        public int PuertoSftp { get; set; }
        public string Usuario { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PasswordConfirmacion { get; set; } = null!;
        public string PrefijoArchivo { get; set; } = null!;
        public string Formato { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual FormatoTransfer1 FormatoNavigation { get; set; } = null!;
    }
}
