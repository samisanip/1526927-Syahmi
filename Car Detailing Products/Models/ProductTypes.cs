using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Detailing_Products.Models
{
    public class ProductTypes
    {
        public string InsertProductTypes(ProductType productType)
        {
            try
            {
                db_1526927_1526927_co5025Entities db = new db_1526927_1526927_co5025Entities();
                db.ProductTypes.Add(productType);
                db.SaveChanges();

                return productType.Name + "was successfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
        public string UpdateProductType(int id, ProductType productType)
        {
            try
            {
                db_1526927_1526927_co5025Entities db= new db_1526927_1526927_co5025Entities();

                //from DB
                ProductType p = db.ProductTypes.Find(id);

                p.Name = productType.Name;

                db.SaveChanges();
                return productType.Name + "was successfully updated";

            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
        public string DeleteProductType(int id)
        {
            try
            {
                db_1526927_1526927_co5025Entities db = new db_1526927_1526927_co5025Entities();
                ProductType productType = db.ProductTypes.Find(id);

                db.ProductTypes.Attach(productType);
                db.ProductTypes.Remove(productType);
                db.SaveChanges();

                return productType.Name + "was successfully deleted";


        }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
    }
}