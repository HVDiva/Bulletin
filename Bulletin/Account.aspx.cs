using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = new User();

            User _user = (User)(Session["loggedInUser"]);
            user = (User)(Session["loggedInUser"]);
            //User _user = user.GetUser(1);
            //string u1 = "<h2 class='bannertitle'>User Name: " + _user.Name + "</h2>";
            string u1 = "<h2 class='bannertitle'>Your Account</h2>";

            ContentPlaceHolder cpu1 = Page.Master.FindControl("accountPlaceHolder1") as ContentPlaceHolder;

            cpu1.Controls.Add(new LiteralControl(u1));

            //Table headings for user info
            string u2 = @"
                        <table class='table1'>
                        <tr><th colspan='6'><h2>Your Details</h2></th></tr>
                        <tr><th align ='center'>ID</th>
                        <th align ='center'>Name</th>
                        <th align ='center'>Username</th>
                        <th align ='center'>Password</th>
                        <th align ='center'>User Type</th>
                        <th align ='center'>Last Login</th></tr>";
            // Populate table with user info
                u2 = u2 + "<tr>";
                u2 = u2 + "<td align ='center'>" + user.ID + "</td>";
                u2 = u2 + "<td align ='center'>" + user.Name + "</td>";
                u2 = u2 + "<td align ='center'>" + user.Username + "</td>";
                u2 = u2 + "<td align ='center'>" + user.Password + "</td>";
                u2 = u2 + "<td align ='center'>" + user.UserType + "</td>";
                u2 = u2 + "<td align ='center'>" + user.LastLoginDate + "</td>";            
                u2 = u2 + "</tr></table>";
            // Create a ContentPlaceHolder holder object and set its value to the
            //  userPlaceHolder in site master for this page
            ContentPlaceHolder cpu2 = Page.Master.FindControl("accountPlaceHolder2") as ContentPlaceHolder;
            // Add a LiteralControl to the controls of userPlaceHolder
            cpu2.Controls.Add(new LiteralControl(u2));


            //list posts
            
            Post post = new Post();
            // Create a list of the user's posts: listOfPost
            //if userID of post is the same as logginuser, add it to the list.

            List<Post> listOfPost = new List<Post>();
            listOfPost = _user.Posts.ToList();


            //  to populate the list of user

            //Create the First Row, with the Headings
            string p = @"
                        <table class='table1'>
                        <tr><th colspan='2'><h2>Your Posts</h2></th></tr>
                        <tr>
                        <th align ='center'>Text</th>
                        <th align ='center'>Date Created</th></tr>";
            // Increment through the List and Create the HTML string
            for (int n = 0; n < listOfPost.Count; n = n + 1)
            {
                if (n % 2 == 0)
                    p = p + "<tr>";
                else
                    p = p + "</tr><tr>";
                p = p + "<td align ='center'>" + listOfPost.ElementAt(n).Text + "</td>";
                p = p + "<td align ='center'>" + listOfPost.ElementAt(n).DateCreated + "</td>";
            }
            p = p + "</tr></table>";
            // Create a ContentPlaceHolder holder object and set its value to the
            //  userPlaceHolder in site master for this page
            ContentPlaceHolder cpp = Page.Master.FindControl("accountPlaceHolder3") as ContentPlaceHolder;
            // Add a LiteralControl to the controls of userPlaceHolder
            cpp.Controls.Add(new LiteralControl(p));
            
        }

        //protected void ChangePasswordButton_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("ChangePassword.aspx");
        //}
    }
}