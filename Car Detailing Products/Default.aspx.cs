using Car_Detailing_Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Detailing_Products
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }
        private void FillPage()
        {
            //list of all products from the DB
            ProductModel productModel = new ProductModel();
            List<Product> products = productModel.GetAllProducts();

            //the products must be exist in the DB
            if (products !=null)
            {

                //image button and label for each products
                foreach (Product product in products)
                {
                    Panel productPanel = new Panel();
                    ImageButton imageButton = new ImageButton();
                    Label lblName = new Label();
                    Label lblPrice = new Label();

                    //properties for childcontrols
                    imageButton.ImageUrl = "~/Image/Products/" + product.Image;
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/Product.aspx?id=" + product.Id;

                    lblName.Text = product.Name;
                    lblName.CssClass = "productName";

                    lblPrice.Text = "$" + product.Price;
                    lblPrice.CssClass = "productPrice";

                    //direct to panel
                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblPrice);

                    //add the panels to parent panel
                    pnlProducts.Controls.Add(productPanel);
                }
            }
            else
            {
                //No products in here
                pnlProducts.Controls.Add(new Literal { Text = "Error No Products" });
            }
        }
    }
}