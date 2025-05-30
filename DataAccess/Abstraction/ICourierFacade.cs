﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstraction
{
    public interface ICourierFacade
    {
        public void TakeOrder(int idOrder, int IdCourier);
        public void ChangeOrderStatus(int idTakenOrder, string status);
    }
}
