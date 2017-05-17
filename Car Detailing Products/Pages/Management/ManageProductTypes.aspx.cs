using Car_Detailing_Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Detailing_Products.Pages.Management
{
    public partial class ManageProductTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ProductTypes model = new ProductTypes();
            ProductType pt = CreateProductType();

            lblResult.Text = model.InsertProductTypes(pt);
            
        }

        private ProductType CreateProductType()
        {
            ProductType p = new ProductType();
            p.Name = txtName.Text;

            return p;
        }
    }
}