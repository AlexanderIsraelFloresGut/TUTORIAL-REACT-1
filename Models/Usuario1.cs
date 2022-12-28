using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Usuario1
    {
        /// <summary>
        /// Identificador del Usuario
        /// </summary>
        public int IdUsuario { get; set; }
        /// <summary>
        /// Código del Usuario
        /// </summary>
        public string NombreUsuario { get; set; } = null!;
        /// <summary>
        /// Contraseña cifrada de usuario
        /// </summary>
        public string Clave { get; set; } = null!;
        /// <summary>
        /// Nombre completo del Usuario
        /// </summary>
        public string Nombres { get; set; } = null!;
        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        public DateTime FechaCreacion { get; set; }
        /// <summary>
        /// Determina si el usuario está activo en el Sistema
        /// </summary>
        public bool Activo { get; set; }
    }
}
