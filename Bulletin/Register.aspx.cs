using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class Register : System.Web.UI.Page
    {
        User user = new User();
        Utility utility = new Utility();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string username = UsernameTextBox.Text;
            string password1 = Pass1TextBox.Text;
            string password2 = Pass2TextBox.Text;
            string checkName = utility.CheckName(name);
            string checkUsername = utility.CheckUsername(username, "register");
            string checkPassword = utility.CheckPassword(password1, password2);
            if (checkName == "OK" && checkUsername == "OK" && checkPassword == "OK")
            {
                user.Name = name;
                user.Username = username;
                user.Password = password1;
                user.UserType = "USER";
                user.LastLoginDate = DateTime.Parse("1900-01-01");
                if (user.Register(user) == false)
                {
                    string reDirect = String.Format("Error.aspx?message={0}", "Did not manage it!");
                    Response.Redirect(reDirect);
                }
                else
                    Response.Redirect("Default.aspx");
            }
            else
            {
                NameLabel.Text = checkName;
                UsernameLabel.Text = checkUsername;
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