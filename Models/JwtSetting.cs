using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoWebApi6.Models
{
    public class JwtSetting
    {
        public bool ValidateIssuerSigningKey { get; set; }
        public string IssuerSigningKey { get; set; }

        public bool ValidateIssuer { get; set; } = true;

        public string ValidIssuer { get; set; }

        public bool ValidateAudience { get; set; } = true;

        public string ValidAudience { get; set; } = string.Empty;
        public bool RequireExpirationTime { get; set; }

        public bool ValidateLifeTime { get; set; } = true;


    }
}
