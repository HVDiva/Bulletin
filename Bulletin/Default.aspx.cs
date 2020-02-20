using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    
    public partial class Login : System.Web.UI.Page
    {
        User user = new User();
        Utility utility = new Utility();
        static int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PassTextBox.Text;
            string checkUsername = utility.CheckUsername(username, "login");
            string checkPassword = utility.CheckPassword(password);
            if (checkUsername == "OK" && checkPassword == "OK")
            {
                //save last login date before it's updated so that it can be displayed on the main page

                // Response.Redirect("MainPage.aspx?actual_last_login=" + grablogin.LastLoginDate.ToString());
                User tempUser = new User();
                User grablogin = tempUser.GetUser(username);
                Session.Add("lastLogin", grablogin);
                if (checkUsername == "OK" && checkPassword == "OK")

                    user = user.Login(username, password);
                if (user != null)
                {
                    count = 0;
                    Session.Add("loggedInUser", user);
                    // Session["loggedInUser"] = user;
                    //User _user = (User)(Session["loggedInUser"]);
                    Response.Redirect("MainPage.aspx?");
                }
                else if (count < 3)
                {
                    UsernameLabel.Text = "Incorrect username or password";
                    PassLabel.Text = "Incorrect username or password";
                    count++;
                }
                else
                    Response.Redirect("Register.aspx");
            }
            else
            {
                if (count < 3)
                {
                    UsernameLabel.Text = checkUsername;
                    PassLabel.Text = checkPassword;
                    count++;
                }
                else
                    Response.Redirect("Register.aspx");
            }
        }
    }
}