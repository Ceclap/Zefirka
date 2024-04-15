using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZefirkaBuisnessLogic;
using ZefirkaBuisnessLogic.Interfaces;

namespace Zefirka.BuisnessLogic
{
    public class BussinessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }

    }
}
