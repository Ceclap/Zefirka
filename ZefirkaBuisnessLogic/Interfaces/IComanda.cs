using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zefirka.Domain.Entites;

namespace ZefirkaBuisnessLogic.Interfaces
{
    public interface IComanda
    {
        Comanda GetDetailComanda(int id);
    }
}
