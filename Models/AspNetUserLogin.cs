using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AspNetUserLogin
    {
        public string LoginProvider { get; set; } = null!;
        public string ProviderKey { get; set; } = null!;
        public string UserId { get; set; } = null!;

        public virtual AspNetUser User { get; set; } = null!;
    }
}
