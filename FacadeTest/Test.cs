using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace FacadeTest
{
    [TestClass]
    public class FacadeDatabaseTests
    {
        private LibraryContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<LibraryContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new LibraryContext(options);
        }

        private void ResetSession()
        {
            DataAccess.Session.CurrentSessionID = 0;
            DataAccess.Session.CurrentSessionName = null;
        }

        [TestMethod]
        public void AuthCourier_ValidCredentials_ShouldSetSession()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var courier = new Courier
                {
                    IdCourier = 5,
                    Login = "courier1",
                    HashPassword = "pass123",
                    FullName = "Иван Курьеров"
                };
                context.Couriers.Add(courier);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);
                ResetSession();

                // Act
                var result = facade.AuthCourier("courier1", "pass123");

                // Assert
                Assert.IsTrue(result);
                Assert.AreEqual(5, DataAccess.Session.CurrentSessionID);
                Assert.AreEqual("Иван Курьеров", DataAccess.Session.CurrentSessionName);
            }
        }

        [TestMethod]
        public void CreateNullOrder_ShouldCreateCartOrder()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var manager = new Manager { IdManager = 3 };
                context.Managers.Add(manager);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                int orderId = facade.CreateNullOrder(3);

                // Assert
                var order = context.Orders.Find(orderId);
                Assert.IsTrue(order.IsCart);
                Assert.IsNull(order.CreatedDate);
                Assert.AreEqual(3, order.IdManager);
            }
        }

        [TestMethod]
        public void GetProductIdByName_ExistingProduct_ShouldReturnCorrectId()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var stock = new Stock
                {
                    IdProduct = 10,
                    NameProduct = "Диск сцепления",
                    TypeProduct = "Трансмиссия"
                };
                context.Stocks.Add(stock);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                int productId = facade.GetProductIdByName("Диск сцепления");

                // Assert
                Assert.AreEqual(10, productId);
            }
        }

        [TestMethod]
        public void DeleteCountProductInStock_ShouldDecreaseStockCount()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var stock = new Stock { IdProduct = 1, CountInStock = 50 };
                context.Stocks.Add(stock);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                facade.DeleteCountProductInStock(1, 15);

                // Assert
                var updatedStock = context.Stocks.Find(1);
                Assert.AreEqual(35, updatedStock.CountInStock);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddProductToOrder_WhenStockExceeded_ShouldThrowException()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var stock = new Stock { IdProduct = 1, CountInStock = 5 };
                context.Stocks.Add(stock);

                var order = new Order { IdOrder = 1, IsCart = true };
                context.Orders.Add(order);

                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                facade.AddProductToOrder(1, 1, 10);
            }
        }

        [TestMethod]
        public void ConfirmOrder_ShouldMoveToCompletedOrders()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var takenOrder = new TakenOrder
                {
                    IdTakenOrder = 1,
                    IdOrder = 100,
                    IdCourier = 5,
                    IdManager = 3
                };
                context.TakenOrders.Add(takenOrder);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                facade.ConfirmOrder(100);

                // Assert
                Assert.IsNull(context.TakenOrders.Find(1));
                Assert.IsNotNull(context.CompletedOrders.FirstOrDefault(co => co.IdOrder == 100));
            }
        }

        [TestMethod]
        public void LoadProductNames_WithTypeFilter_ShouldReturnFilteredResults()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var stocks = new[]
                {
                    new Stock { NameProduct = "Ремень ГРМ", TypeProduct = "Двигатель и его компоненты" },
                    new Stock { NameProduct = "Ступица", TypeProduct = "Ходовая часть" },
                    new Stock { NameProduct = "Амортизатор", TypeProduct = "Ходовая часть" }
                };
                context.Stocks.AddRange(stocks);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                var result = facade.LoadProductNames("Ходовая часть");

                // Assert
                Assert.AreEqual(2, result.Count);
                Assert.IsTrue(result.Contains("Ступица"));
                Assert.IsTrue(result.Contains("Амортизатор"));
            }
        }

        [TestMethod]
        public void ChangeAdress_ShouldUpdateManagerAdress()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var manager = new Manager
                {
                    IdManager = 7,
                    DeliveryAdress = "Старый адрес"
                };
                context.Managers.Add(manager);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                facade.ChangeAdress(7, "Новый адрес");

                // Assert
                var updatedManager = context.Managers.Find(7);
                Assert.AreEqual("Новый адрес", updatedManager.DeliveryAdress);
            }
        }

        [TestMethod]
        public void DeleteProductInOrderItems_ShouldRemoveItemAndUpdateDatabase()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var orderItem = new OrderItem { IdOrderItem = 1, IdOrder = 1, IdProduct = 1, CountProduct = 2 };
                context.OrderItems.Add(orderItem);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                facade.DeleteProductInOrderItems(1);

                // Assert
                Assert.IsNull(context.OrderItems.Find(1));
                Assert.AreEqual(0, context.OrderItems.Count());
            }
        }

        [TestMethod]
        public void ChangeCount_ShouldUpdateQuantityAndPersistChanges()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var orderItem = new OrderItem { IdOrderItem = 1, CountProduct = 5 };
                context.OrderItems.Add(orderItem);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                facade.ChangeCount(1, 8);

                // Assert
                var updatedItem = context.OrderItems.Find(1);
                Assert.AreEqual(8, updatedItem.CountProduct);
            }
        }

        [TestMethod]
        public void GetStatusByIdOrder_ShouldReturnCorrectStatus()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var takenOrder = new TakenOrder
                {
                    IdOrder = 1,
                    Status = "В доставке"
                };
                context.TakenOrders.Add(takenOrder);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                var status = facade.GetStatusByIdOrder(1);

                // Assert
                Assert.AreEqual("В доставке", status);
            }
        }

        [TestMethod]
        public void ChangeOrderStatus_ShouldUpdateStatusCorrectly()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var takenOrder = new TakenOrder
                {
                    IdTakenOrder = 1,
                    IdOrder = 1,
                    Status = "Принят"
                };
                context.TakenOrders.Add(takenOrder);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                facade.ChangeOrderStatus(1, "Доставлен");

                // Assert
                var updatedOrder = context.TakenOrders.Find(1);
                Assert.AreEqual("Доставлен", updatedOrder.Status);
            }
        }

        [TestMethod]
        public void GetCourierByIdOrder_ShouldReturnCorrectCourierName()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var courier = new Courier
                {
                    IdCourier = 1,
                    FullName = "Иван Петров"
                };
                var takenOrder = new TakenOrder
                {
                    IdOrder = 1,
                    IdCourier = 1
                };

                context.Couriers.Add(courier);
                context.TakenOrders.Add(takenOrder);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                var result = facade.GetCourierByIdOrder(1);

                // Assert
                Assert.AreEqual("Иван Петров", result);
            }
        }

        [TestMethod]
        public void GetCourierByCompletedOrder_ShouldReturnHistoricalData()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var courier = new Courier
                {
                    IdCourier = 1,
                    FullName = "Сергей Сидоров"
                };
                var completedOrder = new CompletedOrder
                {
                    IdOrder = 1,
                    IdCourier = 1
                };

                context.Couriers.Add(courier);
                context.CompletedOrders.Add(completedOrder);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                var result = facade.GetCourierByCompletedOrder(1);

                // Assert
                Assert.AreEqual("Сергей Сидоров", result);
            }
        }

        [TestMethod]
        public void AppendCountProductInStock_ShouldIncreaseQuantity()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var stock = new Stock { IdProduct = 1, CountInStock = 5 };
                context.Stocks.Add(stock);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                facade.AppendCountProductInStock(1, 3);

                // Assert
                var updatedStock = context.Stocks.Find(1);
                Assert.AreEqual(8, updatedStock.CountInStock);
            }
        }

        [TestMethod]
        public void LoadProductTypes_ShouldReturnCorrectHierarchy()
        {
            using (var context = CreateContext())
            {
                // Arrange
                var stocks = new[]
                {
                new Stock { TypeProduct = "Молочные" },
                new Stock { TypeProduct = "Бакалея" },
                new Stock { TypeProduct = "Молочные" }
            };
                context.Stocks.AddRange(stocks);
                context.SaveChanges();

                var facade = new FacadeDatabase(context);

                // Act
                var result = facade.LoadProductTypes();

                // Assert
                Assert.AreEqual(3, result.Count);
                Assert.AreEqual("Все типы", result[0]);
                Assert.IsTrue(result.Contains("Бакалея"));
                Assert.IsTrue(result.Contains("Молочные"));
            }
        }
    }
}