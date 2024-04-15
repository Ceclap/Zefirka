using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zefirka.Domain.Entites.User
{
    public class URegisterData
    {
        public string Credential { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string LoginIp { get; set; }
        public DateTime LoginDateTime { get; set; }
        public string Email { get; set; }
    }
}
