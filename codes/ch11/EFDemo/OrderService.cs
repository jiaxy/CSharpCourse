using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo {
  public class OrderService {

    public void Add(Order order) {
      using (var db = new OrderDB()) {
        //db.Order.Add(order);
        //db.Order.Attach(order);
        db.Entry(order).State = EntityState.Added;
        db.SaveChanges();
      }
    }

    public void Delete(String orderId) {
      using (var db = new OrderDB()) {
        var order = db.Order.Include("Items").SingleOrDefault(o => o.Id == orderId);
        db.OrderItem.RemoveRange(order.Items);
        db.Order.Remove(order);
        db.SaveChanges();
      }
    }

    public void Update(Order order,List<OrderItem> removed,List<OrderItem> newItems) {
      using (var db = new OrderDB()) {
        order.Items.AddRange(newItems);
        foreach (OrderItem item in order.Items) {
          if (removed.Contains(item)) {
            db.Entry(item).State = EntityState.Deleted;
          }else if (newItems.Contains(item)) {
            db.Entry(item).State = EntityState.Added;
          } else {
            db.Entry(item).State = EntityState.Modified;
          }
        }
        db.SaveChanges();//先保存items部分的修改
        db.Entry(order).State = EntityState.Modified;
        db.SaveChanges();//保存Order的属性修改
      }
    }

    public Order GetOrder(String Id) {
      using (var db = new OrderDB()) {
        return db.Order.Include("Items").
          SingleOrDefault(o => o.Id == Id);
      }
    }

    public List<Order> GetAllOrders() {
      using (var db = new OrderDB()) {
        return db.Order.Include("items").ToList<Order>();
      }
    }


    public List<Order> QueryByCustormer(String custormer) {
      using (var db = new OrderDB()) {
        return db.Order.Include("items")
          .Where(o => o.Customer.Equals(custormer)).ToList<Order>();
      }
    }

    public List<Order> QueryByGoods(String product) {
      using (var db = new OrderDB()) {
        var query = db.Order.Include("items")
          .Where(o => o.Items.Where(
            item => item.Product.Equals(product)).Count() > 0);
        return query.ToList<Order>();
      }
    }




  }
}
