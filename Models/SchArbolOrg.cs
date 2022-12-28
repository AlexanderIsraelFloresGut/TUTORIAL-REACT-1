using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SchArbolOrg
    {
        public int? Id { get; set; }
        public int? Idpadre { get; set; }
        public string? Descripcion { get; set; }
        public string? Tipo { get; set; }
        public string? Idexterno { get; set; }
        public string? Idpadreexterno { get; set; }
        public string? Raiz { get; set; }
    }
}
