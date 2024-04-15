using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zefirka.Domain.Entites.Responce;
using Zefirka.Domain.Entites.User;
using Zefirka.Domain.User;
using ZefirkaBuisnessLogic.Interfaces;

namespace ZefirkaBuisnessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLoginAction(ULoginData data)
        {
            return RLoginUpService(data);
        }

        public ULoginResp RegisterNewUserAction(URegisterData regData)
        {
            return RRegisterNewUserAction(regData);
        }


    }
}
