using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zefirka.Domain.Entites.Responce;
using Zefirka.Domain.Entites.User;
using Zefirka.Domain.User;

namespace ZefirkaBuisnessLogic.Interfaces
{
    public interface ISession
    {
        ULoginResp UserLoginAction(ULoginData data);
        ULoginResp RegisterNewUserAction(URegisterData regData);
    }
}
