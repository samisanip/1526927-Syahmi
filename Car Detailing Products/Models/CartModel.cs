using Car_Detailing_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Car_Detailing_Carts.Models
{
    public class CartModel
    {
        public string InsertCart(Cart cart)
        {
            try
            {
                db_1526927_1526927_co5025Entities db = new db_1526927_1526927_co5025Entities();
                db.Carts.Add(cart);
                db.SaveChanges();

                return cart.DatePurchased + "was successfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
        public string UpdateCart(int id, Cart cart)
        {
            try
            {
                db_1526927_1526927_co5025Entities db = new db_1526927_1526927_co5025Entities();

                //from DB
                Cart p = db.Carts.Find(id);

                p.ID = cart.ID;
                p.Amount = cart.Amount;
                p.DatePurchased = cart.DatePurchased;
                p.ProductID = cart.ProductID;
                p.IsInCart = cart.IsInCart;
                p.ClientID = cart.ClientID;


                db.SaveChanges();
                return cart.DatePurchased + "was successfully updated";

            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
        public string DeleteCart(int id)
        {
            try
            {
                db_1526927_1526927_co5025Entities db = new db_1526927_1526927_co5025Entities();
                Cart cart = db.Carts.Find(id);

                db.Carts.Attach(cart);
                db.Carts.Remove(cart);
                db.SaveChanges();

                return cart.DatePurchased + "was successfully deleted";


        }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public List<Cart> GetOrdersInCart(string userId)
        {
            db_1526927_1526927_co5025Entities db = new db_1526927_1526927_co5025Entities();
            List<Cart> orders = (from x in db.Carts
                                 where x.ClientID == userId && x.IsInCart
                                 orderby x.DatePurchased
                                 select x).ToList();

            return orders;
        }
        public int GetAmountOfOrders(string userId)
        {
            try
            {
                db_1526927_1526927_co5025Entities db = new db_1526927_1526927_co5025Entities();
                int amount = (from x in db.Carts
                               where x.ClientID == userId && x.IsInCart
                               select x.Amount).Sum();

                return amount;
            }
            catch
            {
                return 0;
            }
        }

        public void UpdateQuantity(int id, int quantity)
        {
            db_1526927_1526927_co5025Entities db = new db_1526927_1526927_co5025Entities();
            Cart cart = db.Carts.Find(id);
            cart.Amount = quantity;

            db.SaveChanges();
        }
        public void MarkOrdersAsPaid(List<Cart> carts)
        {
            db_1526927_1526927_co5025Entities db = new db_1526927_1526927_co5025Entities();

            if(carts != null)
            {
                foreach(Cart cart in carts)
                {
                    Cart oldCart = db.Carts.Find(cart.ID);
                    oldCart.DatePurchased = DateTime.Now;
                    oldCart.IsInCart = false;
                }

                db.SaveChanges();
            }
        }
    }

}