using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3.MENU
{
    public class OrderBo
    {
        public static List<Order> orderList = new List<Order>(); // Create a new User
        public bool CreateNewCart(string collection, string fabric, string color, string size, string brand)
        {
            Order order = Findcart(brand);
            if (order == null)
            {
                order = new Order(collection, fabric, color, size, brand);
                orderList.Add(order);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Order> GetAllcart()
        {
            if (orderList.Count == 0)
            {
                return null;
            }
            else
            {
                return orderList;
            }
        }
        public bool DeleteRoute(string BranD)
        {
            Order order = Findcart(BranD);
            if (order != null)
            {
                orderList.Remove(order);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Order Findcart(string BranD)
        {
            var order = (from k in orderList
                         where k.Brand == BranD
                         select k).FirstOrDefault();
            return order;
        }
    }
}


