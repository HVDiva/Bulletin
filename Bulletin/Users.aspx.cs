using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((User)Session["loggedInUser"] == null)
            {
                Response.Redirect("Register.aspx");
            }
            else if (((User)Session["loggedInUser"]).UserType == "ADMIN")
            {
                User user = new User();
                List<User> listOfUser = new List<User>();

                listOfUser = user.GetUsers();
                //  to poipulate the list of user

                //Create the First Row, with the Headings
                string u = @"
                        <table class='table1'>
                        <tr><th align ='center'>ID</th>
                        <th align ='center'>Name</th>
                        <th align ='center'>Username</th>
                        <th align ='center'>Password</th>
                        <th align ='center'>Usertype</th>
                        <th align ='center'>Last login</th>
                        <th align ='center'>Action</th></tr>";
                // Increment through the List and Create the HTML string
                for (int n = 0; n < listOfUser.Count; n = n + 1)
                {
                    if (n % 2 == 0)
                        u = u + "<tr>";
                    else
                        u = u + "</tr><tr>";
                    u = u + "<td align ='center'>" + listOfUser.ElementAt(n).ID + "</td>";
                    u = u + "<td align ='center'>" + listOfUser.ElementAt(n).Name + "</td>";
                    u = u + "<td align ='center'>" + listOfUser.ElementAt(n).Username + "</td>";
                    u = u + "<td align ='center'>" + listOfUser.ElementAt(n).Password + "</td>";
                    u = u + "<td align ='center'>" + listOfUser.ElementAt(n).UserType + "</td>";
                    u = u + "<td align ='center'>" + listOfUser.ElementAt(n).LastLoginDate + "</td>";
                    u = u + "<td align ='center'>";
                    string reDirect = String.Format("UpdateUser.aspx?id={0}", listOfUser.ElementAt(n).ID);
                    string hyperLink = "<a href = '" + reDirect + "'>Update user!</a>";
                    u = u + hyperLink + "</td>";
                }
                u = u + "</tr></table>";
                // Create a ContentPlaceHolder holder object and set its value to the
                //  userPlaceHolder in site master for this page
                ContentPlaceHolder cpu = Page.Master.FindControl("usersPlaceHolder") as ContentPlaceHolder;
                // Add a LiteralControl to the controls of userPlaceHolder
                cpu.Controls.Add(new LiteralControl(u));
            }
            else if (((User)Session["loggedInUser"]).UserType == "BLOCKED")
            {
                string reDirect = String.Format("Error.aspx?message={0}", "You are blocked mate");
                Response.Redirect(reDirect);
            }
            else if (((User)Session["loggedInUser"]).UserType == "USER")
            {
                string reDirect = String.Format("Error.aspx?message={0}", "You are not admin!");
                Response.Redirect(reDirect);
            }
            else
                Response.Redirect("Register.aspx");
        }
    }
}