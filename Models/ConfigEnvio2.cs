using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConfigEnvio2
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? UsaCuentaActual { get; set; }
        public string? ServidorSmtp { get; set; }
        public string? EnvioMailSalida { get; set; }
        public int? Puerto { get; set; }
        public string? ReqAutenticacion { get; set; }
        public string? UsuarioSmtp { get; set; }
        public string? UsuarioPwdSmtp { get; set; }
        public string? ConfirmPwdSmtp { get; set; }
        public string? UsaUsuarioRed { get; set; }
        public string? UsaConexionSsl { get; set; }
        public string? MetodoEntrega { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
