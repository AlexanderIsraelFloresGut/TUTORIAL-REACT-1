using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class UCashFlow1
    {
        public string? UCodigo { get; set; }
        public string? UDescrip { get; set; }
        public byte? NoteExistsFlag { get; set; }
        public DateTime? RecordDate { get; set; }
        public Guid? RowPointer { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
