using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        User user;
        Utility utility = new Utility();
        protected void Page_Load(object sender, EventArgs e)
        {
            user = new User();
            user = (User)(Session["loggedInUser"]);
            //int id = int.Parse(Request.QueryString["id"]);
            //userForUpdate = user.GetUser(id);
            //NameLabel.Text = userForUpdate.Name;
            //UsernameLabel.Text = userForUpdate.Username;
        }

        protected void ChangePasswordButton_Click(object sender, EventArgs e)
        {            
            string password1 = Pass1TextBox.Text;
            string password2 = Pass2TextBox.Text;
            string checkPassword = utility.CheckPassword(password1, password2);
            if (checkPassword == "OK")
            {
                user.Password = password1;
                if (!user.UpdatePassword(user))
                {
                    string reDirect = String.Format("Error.aspx?message={0}", "Did not manage it!");
                    Response.Redirect(reDirect);
                }
                else
                    Response.Redirect("Account.aspx");
            }
            else
            {
                
                if (checkPassword == "pass1error")
                {
                    Pass1Label.Text = "Need a password!";
                    Pass2Label.Text = "";
                }
                if (checkPassword == "pass2error")
                {
                    Pass1Label.Text = "";
                    Pass2Label.Text = "Need the password again!";
                }
                if (checkPassword == "Pass1notpass2")
                {
                    Pass1Label.Text = "";
                    Pass2Label.Text = "Passwords don't match!";
                }
            }
        }
    }
}