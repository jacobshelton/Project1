using System;
using System.Collections.Generic;
//using PizzaBox.Data.Entities;

namespace PizzaBox.Domain.Models
{
    public class PizzaShop
    {
        //private readonly Project0DBContext _db = new Project0DBContext();

        public Address Address {get; set;}
        public Dictionary<string, int> Inventory {get; set;}
        public List<Order> Orders {get; set;}


        public void CheckUserData(User u)
        {
            //search the database to verify they are there
        }

        public void RegisterUserData(User u)
        {
            //var du = new Data.Entities.User();

            //add new user to database
        }

        public void SendPizzaData(Order o, List<Pizza> PizzaList)
        {
            // var dp = new Data.Entities.Pizza();
            // //var do = new Data.Entities.Order();

            // Orders.Add(o);

            // for(int i = 0; i < PizzaList.Count; i++)
            // {
            //   dp.Crust.Name = PizzaList[i].Crust.Name;
            //   dp.Size.Name = PizzaList[i].Size.Name;

            //   dp.Crust.Price = PizzaList[i].Crust.Price;
            //   dp.Size.Price = PizzaList[i].Size.Price;

            //   _db.Add(dp);
            //}

            //_db.Add(do)

            //_db.SaveChanges();
        }

        //+ should be able to view its orders
        public void ViewOrders()
        {

        }

        //+ should be able to view its sales
        public void ViewSales()
        {

        }

        //+ should be able to view its inventory
        public void ViewInventory()
        {

        }

        //+ should be able to view its users
        public void ViewUsers()
        {

        }
    }
}