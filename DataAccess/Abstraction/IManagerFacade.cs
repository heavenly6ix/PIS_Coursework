using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstraction
{
    public interface IManagerFacade
    {
        public int CreateNullOrder(int idManager);
        public void CreateOrder(int idNullOrder);
        public void AddProductToOrder(int idOrder, int idProduct, int countProduct);
        public void ConfirmOrder(int idTakenOrder);
        public void CancelOrder(int IdOrder);
        public void ChangeAdress(int idManager, string newAdress);
    }
}
