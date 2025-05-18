using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using DataAccess.Abstraction;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;


namespace DataAccess
{
    public class FacadeDatabase: IEnteringFacade, IManagerFacade, ICourierFacade
    {

        private readonly LibraryContext _dbContext;
        public FacadeDatabase()
        {
           _dbContext = DbContextFactory.Create();
        }

        //Методы для авторизации
        public bool AuthManager(string login, string password)
        {
            Manager? manager = _dbContext.Managers.FirstOrDefault(
                m => m.Login == login && m.HashPassword == password
            );
            
            if (manager == null)
                return false;

            Session.CurrentSessionID = manager.IdManager;
            Session.CurrentSessionName = manager.FullName;
            return true;
        }

        public bool AuthCourier(string login, string password)
        {
            Courier? courier = _dbContext.Couriers.FirstOrDefault(
                c => c.Login == login && c.HashPassword == password
            );
            
            if (courier == null)
                return false;

            Session.CurrentSessionID = courier.IdCourier;
            Session.CurrentSessionName = courier.FullName;
            return true;
        }


        //Методы для Manager
        public void CreateOrder(int idNullOrder)
        {
            var Order = _dbContext.Orders.FirstOrDefault(s => s.IdOrder == idNullOrder);
            Order.IsCart = false;
            Order.CreatedDate = DateTime.Now;
            Order.IdManager = Session.CurrentSessionID;
            var orderItems = _dbContext.OrderItems
            .Where(oi => oi.IdOrder == idNullOrder)
            .ToList();
            foreach (var item in orderItems)
            {
                DeleteCountProductInStock(item.IdProduct, (int)item.CountProduct);
            }
            _dbContext.SaveChanges();
        }
        
        public int CreateNullOrder(int idManager)
        {
            Order order = new Order
            { 
                IdManager = idManager,
                CreatedDate = null,
                IsCart = true
            };
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();

            return order.IdOrder;
        }

        public void AddProductToOrder(int idOrder, int idProduct, int countProduct)
        {
            if (countProduct <= _dbContext.Stocks.FirstOrDefault(s => s.IdProduct == idProduct).CountInStock)
            {
                OrderItem orderItem = new OrderItem
                {
                    IdOrder = (int)idOrder,
                    IdProduct = idProduct,
                    CountProduct = countProduct
                };
                _dbContext.OrderItems.Add(orderItem);
                _dbContext.SaveChanges();
            }
            else throw new Exception("Ошибка");
        }

        public void ConfirmOrder(int idOrder)
        {
            var order = _dbContext.TakenOrders.FirstOrDefault(s => s.IdOrder == idOrder);
            CompletedOrder completedOrder = new CompletedOrder
            {
                IdTakenOrder = order.IdTakenOrder,
                IdOrder = idOrder,
                IdCourier = order.IdCourier,
                IdManager = order.IdManager,
                DeliveryDate = DateTime.Now,
            };
            _dbContext.Remove(
                _dbContext.TakenOrders.FirstOrDefault(o => o.IdTakenOrder == order.IdTakenOrder)
            );
            _dbContext.CompletedOrders.Add(completedOrder);
            _dbContext.SaveChanges();
        }

        public void CancelOrder(int idOrder)
        {
            var orderItems = _dbContext.OrderItems
            .Where(oi => oi.IdOrder == idOrder)
            .ToList();
            foreach (var item in orderItems)
            {
                AppendCountProductInStock(item.IdProduct, (int)item.CountProduct);
            }
            _dbContext.Remove(
                _dbContext.Orders.FirstOrDefault(o => o.IdOrder == idOrder)
            );
            _dbContext.SaveChanges();
        }

        public void ChangeAdress(int idManager, string newAdress)
        {
            Manager? manager = _dbContext.Managers.FirstOrDefault(
                m => m.IdManager == idManager
            );
            if (manager == null) return;

            manager.DeliveryAdress = newAdress;
            _dbContext.SaveChanges();
        }

        public string GetAdressManager (int idManager)
        {
            var manager = _dbContext.Managers.FirstOrDefault(m => m.IdManager == idManager);
            return manager.DeliveryAdress;
        }

        public List<string> LoadProductTypes()
        {
            var types = _dbContext.Stocks.Select(static s => s.TypeProduct)
                .Distinct()
                .OrderBy(t => t)
                .ToList(); ;
            types.Insert(0, "Все типы");
            return types;
        }

        public List<string> LoadProductNames(string selectedType)
        {

            IQueryable<Stock> query = _dbContext.Stocks;
            if (selectedType != "Все типы")
            {
                query = query.Where(s => s.TypeProduct == selectedType);
            }
            return query.Select(static s => s.NameProduct)
                .Distinct()
                .OrderBy(t => t)
                .ToList();
        }

        public int GetProductIdByName(string name)
        {
            var product = _dbContext.Stocks.FirstOrDefault(s => s.NameProduct == name);
            return product.IdProduct;
        }

        public int? GetCountByName(string name)
        {
            var product = _dbContext.Stocks.FirstOrDefault(s => s.NameProduct == name);
            return product.CountInStock;
        }

        public int GetCurrentManagerId()
        {
            return Session.CurrentSessionID;
        }

        public string GetProductNameById(int idProduct)
        {
            var product = _dbContext.Stocks.FirstOrDefault(s => s.IdProduct == idProduct);
            return product?.NameProduct ?? "Товар не найден";
        }

        public int GetIdOrderItemByIdAndName(int idOrder, int idProduct)
        {
            var product = _dbContext.OrderItems.FirstOrDefault(s => s.IdProduct == idProduct && s.IdOrder == idOrder);
            return product.IdOrderItem;
        }

        public string GetStatusByIdOrder(int idOrder)
        {
            var takenOrder = _dbContext.TakenOrders.FirstOrDefault(s => s.IdOrder == idOrder);
            return takenOrder.Status;
        }

        public string GetCourierByIdOrder(int idOrder)
        {
            var takenOrder = _dbContext.TakenOrders.FirstOrDefault(s => s.IdOrder == idOrder);

            int? idCourier = takenOrder.IdCourier;
            var courier = _dbContext.Couriers.FirstOrDefault(s => s.IdCourier == idCourier);
            return courier.FullName;
        }
        public string GetCourierByCompletedOrder(int idOrder)
        {
            var completedOrder = _dbContext.CompletedOrders.FirstOrDefault(s => s.IdOrder == idOrder);

            int? idCourier = completedOrder.IdCourier;
            var courier = _dbContext.Couriers.FirstOrDefault(s => s.IdCourier == idCourier);
            return courier.FullName;
        }

        public void ChangeCount(int idOrderItem, int newCount)
        {
            var product = _dbContext.OrderItems.FirstOrDefault(s => s.IdOrderItem == idOrderItem);
            product.CountProduct = newCount;
            _dbContext.SaveChanges();
        }

        public List<object> GetOrderItems(int idOrder)
        {
            var orderItems = _dbContext.OrderItems
            .Where(oi => oi.IdOrder == idOrder)
            .ToList();

            var result = new List<object>();
            foreach (var item in orderItems)
            {
                string productName = GetProductNameById(item.IdProduct);
                int idOrderItem = GetIdOrderItemByIdAndName(item.IdOrder, item.IdProduct);
                result.Add(new
                {
                    ProductName = productName,
                    Count = item.CountProduct,
                    ID = idOrderItem
                });
            }

            return result;
        }

        public List<object> GetOrdersForDelivery()
        {
            var takenOrderIds = _dbContext.TakenOrders
                .Select(to => to.IdOrder)
                .ToList();

            var completedOrderIds = _dbContext.CompletedOrders
                .Select(to => to.IdOrder)
                .ToList();

            var orders = _dbContext.Orders
                .Where(o => o.IsCart == false
                && !takenOrderIds.Contains(o.IdOrder)
                && !completedOrderIds.Contains(o.IdOrder))
                .Distinct()
                .OrderBy(t => t)
                .ToList();
   
            var result = new List<object>();
            foreach(var item in orders)
            {
                result.Add(new
                {
                    idOrder = item.IdOrder,
                    Adress = GetAdressManager((int)item.IdManager),
                    Date = item.CreatedDate
                });
            }
            return result;
        }

        public List<object> GetTakenOrders(int idCourier)
        {
            var takenOrder = _dbContext.TakenOrders
                .Where(t => t.IdCourier == idCourier)
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            List<object> result = new List<object>();
            foreach (var item in takenOrder)
            {
                result.Add(new
                {
                    idOrder = item.IdOrder,
                    Adress = GetAdressManager((int)item.IdManager),
                    Date = item.CreatedDate
                });
            }
            return result;
        }

        public class OrderDisplayDto
        {
            public int? IdOrder { get; set; }
            public string? Status { get; set; }
            public DateTime? Date { get; set; }
        }
        public List<OrderDisplayDto> GetOrders(int idManager)
        {
            var takenOrderIds = _dbContext.TakenOrders
                .Where(to => to.IdManager == idManager)
                .Select(to => to.IdOrder)
                .ToList();
            var completedOrderIds = _dbContext.CompletedOrders
                .Where(to => to.IdManager == idManager)
                .Select(to => to.IdOrder)
                .ToList();

            var takenOrders = _dbContext.TakenOrders
                .Where(o => o.IdManager == idManager)
                .Distinct()
                .OrderBy(t => t)
                .ToList();
            var notTakenOrders = _dbContext.Orders
                .Where(o => o.IsCart == false && o.IdManager == idManager
                && !takenOrderIds.Contains(o.IdOrder) 
                && !completedOrderIds.Contains(o.IdOrder))
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            var result = new List<OrderDisplayDto>();
            foreach (var item in takenOrders)
            {
                result.Add(new OrderDisplayDto
                {
                    IdOrder = item.IdOrder,
                    Status = item.Status,
                    Date = item.CreatedDate
                });
            }
            foreach (var item in notTakenOrders)
            {
                result.Add(new OrderDisplayDto
                {
                    IdOrder = item.IdOrder,
                    Status = "Создан",
                    Date = item.CreatedDate
                });
            }
            return result;
        }

        public List<object> GetCompletedOrders(int idManager)
        {
            var completedOrders = _dbContext.CompletedOrders
                .Where(o => o.IdManager == idManager)
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            var result = new List<object>();
            foreach (var item in completedOrders)
            {
                result.Add(new
                {
                    idOrder = item.IdOrder,
                    Date = item.DeliveryDate
                });
            }
            return result;
        }

        public void DeleteProductInOrderItems(int IdOrderItem)
        {
            _dbContext.Remove(
                _dbContext.OrderItems.FirstOrDefault(o => o.IdOrderItem == IdOrderItem)
            );
            _dbContext.SaveChanges();
        }

        public void DeleteCountProductInStock(int idProduct, int count)
        {
            var product = _dbContext.Stocks.FirstOrDefault(s => s.IdProduct == idProduct);
            product.CountInStock -= count;
            _dbContext.SaveChanges();
        }

        public void AppendCountProductInStock(int idProduct, int count)
        {
            var product = _dbContext.Stocks.FirstOrDefault(s => s.IdProduct == idProduct);
            product.CountInStock += count;
            _dbContext.SaveChanges();
        }


        //Методы для Courier
        public void TakeOrder(int idOrder, int IdCourier)
        {
            var order = _dbContext.Orders.FirstOrDefault(s => s.IdOrder == idOrder);
            TakenOrder takenOrder = new TakenOrder
            {
                IdOrder = idOrder,
                IdCourier = IdCourier,
                CreatedDate = order.CreatedDate,
                IdManager = order.IdManager,
                Status = "Принят"
            };
            _dbContext.TakenOrders.Add(takenOrder);
            _dbContext.SaveChanges();
        }

        public void ChangeOrderStatus(int idOrder, string status)
        {
            TakenOrder? takenOrder = _dbContext.TakenOrders.FirstOrDefault(
                o => o.IdOrder == idOrder
            );
            if (takenOrder == null) return;

            takenOrder.Status = status;
            _dbContext.SaveChanges();
        }
    }
}
