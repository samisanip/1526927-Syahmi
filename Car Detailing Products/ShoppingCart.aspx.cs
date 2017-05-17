using Car_Detailing_Carts.Models;
using Car_Detailing_Products.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Detailing_Products
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //log in user and will diplay the items in the cart
            string userId = User.Identity.GetUserId();
            GetPurchasesInCart(userId);
        }

        private void GetPurchasesInCart(string userId)
        {
            CartModel model = new CartModel();
            double subTotal = 0;

            //generate purchaselist
            List<Cart> purchaseList = model.GetOrdersInCart(userId);
            CreateShopTable(purchaseList, out subTotal);

            //the total will be add to webpage
            double vat = subTotal * 0.21;
            double totalAmount = subTotal + vat + 15;

            //Display the values
            litTotal.Text = "$" + subTotal;
            litVat.Text = "$" + vat;
            litTotalAmount.Text = "$" + totalAmount;
        }

        private void CreateShopTable(List<Cart> purchaseList, out double subTotal)
        {
            subTotal = new Double();
            ProductModel model = new ProductModel();

            foreach (Cart cart in purchaseList)
            {
                Product product = model.GetProduct(cart.ProductID);

                //Image for button
                ImageButton btnImage = new ImageButton
                {
                    ImageUrl = string.Format("~/Image/Products/{0}", product.Image),
                    PostBackUrl = string.Format("~/Product.aspx?id={0}", product.Id)

                };

                //delete link
                LinkButton lnkDelete = new LinkButton
                {
                    PostBackUrl = string.Format("/ShoppingCart.aspx?productId={0}", cart.ID),
                    Text = "Delete Item",
                    ID = "del" + cart.ID

                };

                //Adding a OnClick
                lnkDelete.Click += Delete_Item;

                //Quantity ddl
                //list form 1 to 20
                int[] amount = Enumerable.Range(1, 20).ToArray();
                DropDownList ddlAmount = new DropDownList
                {
                    DataSource = amount,
                    AppendDataBoundItems = true,
                    AutoPostBack = true,
                    ID = cart.ID.ToString()
                };

                ddlAmount.DataBind();
                ddlAmount.SelectedValue = cart.Amount.ToString();
                ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;

                //table with 2 rows
                Table table = new Table { CssClass = "cartTable" };
                TableRow a = new TableRow();
                TableRow b = new TableRow();

                //Row A have 6 cells
                TableCell a1 = new TableCell { RowSpan = 2, Width = 50 };
                TableCell a2 = new TableCell
                {
                    Text = string.Format("<h4>{0}</h4><br/>{1}<br/>In Stock",
                    product.Name, "Item No: " + product.Id),
                    HorizontalAlign = HorizontalAlign.Left,
                    Width = 350
                };




                TableCell a3 = new TableCell { Text = "Unit Price<hr/>" };
                TableCell a4 = new TableCell { Text = "Quantity<hr/>" };
                TableCell a5 = new TableCell { Text = "Item Total<hr/>" };
                TableCell a6 = new TableCell { };

                //row B 6 cells
                TableCell b1 = new TableCell { };
                TableCell b2 = new TableCell { Text = "$" + product.Price };
                TableCell b3 = new TableCell { };
                TableCell b4 = new TableCell { Text = "$" + Math.Round((cart.Amount * (double) product.Price), 2) };
                TableCell b5 = new TableCell { };
                TableCell b6 = new TableCell { };

                //to set Control for Special
                a1.Controls.Add(btnImage);
                a6.Controls.Add(lnkDelete);
                b3.Controls.Add(ddlAmount);

                //add cell to rows
                a.Cells.Add(a1);
                a.Cells.Add(a2);
                a.Cells.Add(a3);
                a.Cells.Add(a4);
                a.Cells.Add(a5);
                a.Cells.Add(a6);

                b.Cells.Add(b1);
                b.Cells.Add(b2);
                b.Cells.Add(b3);
                b.Cells.Add(b4);
                b.Cells.Add(b5);
                b.Cells.Add(b6);

                //add rows to table
                table.Rows.Add(a);
                table.Rows.Add(b);

                //pnlShoppingCart
                pnlShoppingCart.Controls.Add(table);

                //amount in the subtotal
                subTotal += (cart.Amount * (double)product.Price);
            }

            //current user in the shopping cart
            Session[User.Identity.GetUserId()] = purchaseList;

        }
        private void Delete_Item(object sender, EventArgs e)
        {
            LinkButton selectedLink = (LinkButton)sender;
            string link = selectedLink.ID.Replace("del", "");
            int cartId = Convert.ToInt32(link);

            CartModel model = new CartModel();
            model.DeleteCart(cartId);

            Response.Redirect("~/ShoppingCart.aspx");

        }
        private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList selectedList = (DropDownList)sender;
            int quantity = Convert.ToInt32(selectedList.SelectedValue);
            int cartId = Convert.ToInt32(selectedList.ID);

            CartModel model = new CartModel();
            model.UpdateQuantity(cartId, quantity);

            Response.Redirect("~/ShoppingCart.aspx");
        }

    }
}