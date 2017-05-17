using Car_Detailing_Products.Models;
using System;
using System.Collections;
using System.IO;


namespace Car_Detailing_Products.Pages.Management
{
    public partial class ManageProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GetImages();

                //to check if the url have an id parameter
                if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    FillPage(id);
                }
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ProductModel productModel = new ProductModel();
            Product product = CreateProduct();

            //to check if the url have an id parameter
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //To update the existing row
                int id = Convert.ToInt32(Request.QueryString["id"]);
                lblResult.Text = productModel.UpdateProduct(id, product);
            }
            else
            {
                //if do not exist need to create a new row
                lblResult.Text = productModel.InsertProduct(product);
            }
        }
    
        private void FillPage(int id)
        {
            //product thath selected from the Database
            ProductModel productModel = new ProductModel();
            Product product = productModel.GetProduct(id);

            //insert Textboxes
            txtDescription.Text = product.Description;
            txtName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();

            //DDL values
            ddlImage.SelectedValue = product.Image;
            ddlType.SelectedValue = product.TypeId.ToString();

        }
        private void GetImages()
        {
            try
            {
                //where the filepath is enter
                string[] images = Directory.GetFiles(Server.MapPath("~/Image/Products/"));

                //all file and insert them into the arraylist
                ArrayList imageList = new ArrayList();
                foreach (string image in images)
                {

                    string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    imageList.Add(imageName);
                }

                //set the arraylist in dropdown as a datasource and refresh
                ddlImage.DataSource = imageList;
                ddlImage.AppendDataBoundItems = true;
                ddlImage.DataBind();
            }
            catch (Exception e)
            {
                lblResult.Text = e.ToString();
            }
        }
        private Product CreateProduct()
        {
            Product product = new Product();

            product.Name = txtName.Text;
            product.Price = Convert.ToInt32(txtPrice.Text);
            product.TypeId = Convert.ToInt32(ddlType.SelectedValue);
            product.Description = txtDescription.Text;
            product.Image = ddlImage.SelectedValue;

            return product;
        }
    }
}