using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Display last login

            User _user2 = (User)(Session["lastLogin"]);
            //User user = new User();

            //User _user = user.GetUser(id);
            //string mp = "<h2>Your last login: " + _user.LastLoginDate + "</h2>";
            //string actual_last_login = Request.QueryString["actual_last_login"];
            string actual_last_login = _user2.LastLoginDate.ToString();
            string mp = "<p>Your last login: " + actual_last_login + "</p>";
            


            ContentPlaceHolder cpmp = Page.Master.FindControl("mainPagePlaceHolder1") as ContentPlaceHolder;

            cpmp.Controls.Add(new LiteralControl(mp));


            // Prepare the List of boards
            Board board = new Board();
            // Create a User object and use its appropriate method 
            List<Board> listOfBoard = new List<Board>();
            listOfBoard = board.GetBoards();
            //  to populate the list of user

            //Create the First Row, with the Headings
            string b = @"
                        <table class='table1'>
                        <th align ='center'>Board</th>
                        <th align ='center'>When Created</th></tr>";
            // Increment through the List and Create the HTML string
            for (int n = 0; n < listOfBoard.Count; n = n + 1)
            {
                if (n % 2 == 0)
                {
                    b = b + "<tr>";
                }
                else
                {
                    b = b + "</tr><tr>";
                }
                    string reDirect = String.Format("BoardPage.aspx?id={0}", listOfBoard.ElementAt(n).ID);
                    string hyperLink = "<td align ='center'>"+"<a href = '" + reDirect + "'>"+listOfBoard.ElementAt(n).Name+"</a>";
                    b = b + hyperLink + "</td>";
                    //b = b + "<td align ='center'>" + listOfBoard.ElementAt(n).Name + "</td>";
                    b = b + "<td align ='center'>" + listOfBoard.ElementAt(n).DateCreated + "</td>";
                    //string reDirect = String.Format("BoardPage.aspx?id={0}", listOfBoard.ElementAt(n).ID);
                    //string hyperLink = "<a href = '" + reDirect + "'>Go to board to see posts!</a>";
                    //b = b + hyperLink + "</td>";
                

            }
            b = b + "</tr></table>";
            // Create a ContentPlaceHolder holder object and set its value to the
            //  userPlaceHolder in site master for this page
            ContentPlaceHolder cpu = Page.Master.FindControl("mainPagePlaceHolder2") as ContentPlaceHolder;
            // Add a LiteralControl to the controls of userPlaceHolder
            cpu.Controls.Add(new LiteralControl(b));
        }
    }
}