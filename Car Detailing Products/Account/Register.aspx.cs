using Car_Detailing_Products.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Detailing_Products.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();

            userStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.
                ConnectionStrings["db_1526927_1526927_co5025ConnectionString"].ConnectionString;

            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

            //register for new customer and information will be store in the DB
            IdentityUser user = new IdentityUser();
            user.UserName = txtUserName.Text;

            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                try
                {
                    //user a create
                    //database for user will be make
                    IdentityResult result = manager.Create(user, txtPassword.Text);

                    if (result.Succeeded)
                    {
                        UserInformation info = new UserInformation
                        {
                            Address = txtAddress.Text,
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            PostalCode = Convert.ToInt32(txtPostalCode.Text),
                            GUID = user.Id
                        };

                        UserInfoModel model = new UserInfoModel();
                        model.InsertUserInformation(info);


                        //user info will be store in DB
                        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                        //new user login
                        var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                        //after login and it will birng the user to the homepage
                        authenticationManager.SignIn(new Microsoft.Owin.Security.AuthenticationProperties(), userIdentity);
                        Response.Redirect("~/Default.aspx");
                    }

                    else
                    {
                        litStatus.Text = result.Errors.FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    litStatus.Text = ex.ToString();
                }

            }
            else
            {
                litStatus.Text = "The password must be same";
            }
        }
    }
}