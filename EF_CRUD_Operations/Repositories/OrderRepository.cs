using EF_CRUD_Operations.Context;
using EF_CRUD_Operations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRUD_Operations.Repositories
{
    internal class OrderRepository
    {
        public OrderRepository()
        {
            db = new NorthwindContext();
        }
        NorthwindContext db;

        public List<Order> GetAllOrders()
        {
            List<Order> orders = db.Orders.ToList();
            return orders;
        }

        public List<Order> GetOrdersByEmployeeID(int employeeID) 
        {
            List<Order> orders = db.Orders.Where(o=>o.EmployeeId == employeeID).ToList();
            return orders;
        }

        public List<Order> GetOrdersByShipperID(int shipperID)
        {
            List<Order> orders = db.Orders.Where(o => o.ShipVia == shipperID).ToList();
            return orders;
        }

        public List<Order> GetOrdersByEmployeeIDAndShipperID(int employeeID, int shipperID)
        {
            List<Order> orders = db.Orders.Where(o=>o.EmployeeId == employeeID && o.ShipVia==shipperID).ToList();
            return orders;
        }

        public int AddOrder(Order order)
        {
            db.Orders.Add(order);
            int affRows = db.SaveChanges(); //Normalde db.SaveChanges() diyerek database e kayıt islemini yapıyorduk ama burda gercekten kaydettik mi kaydetmedik mi bunun geri feedback olarak alıp kolayca kontrol edebilmek icin SaveChanges() metodunun database de etkilenen row sayısını int dondugunden dolayı bunu int tipinde bir degiskene atadık ki eğer ki kayıt ıslemi gerceklesirse satırlar etkilenecek ve bize null disinda bir int deger dondurecek ve deger donuyorsa da biz burda belirli kosullara baglayarak kullanıcıyı bilgilendirebiliriz..
            return affRows;
        }

        public int UpdateOrder(Order order)
        {
            db.Orders.Update(order);
            int affRows = db.SaveChanges();             //Etkilenen satır sayisini doner
            return affRows;
        }

        public int DeleteOrder(int orderID)
        {
            Order order = db.Orders.Find(orderID);
            db.Orders.Remove(order);
            int affRows = db.SaveChanges();
            return affRows;
        }

        public Order GetOrderByID(int orderID)
        {
            Order order = db.Orders.Find(orderID);
            return order;
        }
    }
}
