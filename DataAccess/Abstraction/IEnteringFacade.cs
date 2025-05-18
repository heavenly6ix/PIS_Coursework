using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Abstraction
{
    public interface IEnteringFacade
    {
        public bool AuthManager(string login, string password);
        public bool AuthCourier(string login, string password);
    }
}
