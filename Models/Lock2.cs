using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Lock2
    {
        public string Llave { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string ConnectionId { get; set; } = null!;
        public DateTime Fecha { get; set; }

        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
