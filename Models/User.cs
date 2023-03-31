using System;
using System.Collections.Generic;

namespace ParksLookupApi.Models
{
    public partial class User
    {
        public string UserId { get; set; } = null!;
        #nullable enable
        public string? Name { get; set; }
        public string? Password { get; set; }
        #nullable disable
    }
}
