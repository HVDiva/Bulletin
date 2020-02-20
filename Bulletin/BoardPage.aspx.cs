using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class BoardPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            
            Board board = new Board();
            
            
            Board _board = board.GetBoard(id);
            Session.Add("clickedBoard", _board);
            string p1 = "<h2 class='bannertitle'>" + _board.Name + "</h2>";

            ContentPlaceHolder cpp1 = Page.Master.FindControl("boardPlaceHolder1") as ContentPlaceHolder;

            cpp1.Controls.Add(new LiteralControl(p1));

            //Create the First Row, with the Headings
            string p2 = @"
                        <table class='table1'>
                        <tr>
                        <th align ='center'>Post</th>
                        <th align ='center'>When Created</th>
                        <th align ='center'>Post author</th></tr>";
            // Increment through the List and Create the HTML string
            for (int n = 0; n < _board.Posts.Count; n = n + 1)
            {
                if (n % 2 == 0)
                    p2 = p2 + "<tr>";
                else
                    p2 = p2 + "</tr><tr>";
                //int postid = _board.Posts.ElementAt(n).ID;
                p2 = p2 + "<td align ='left'>" + _board.Posts.ElementAt(n).Text + "</td>";
                p2 = p2 + "<td align ='center'>" + _board.Posts.ElementAt(n).DateCreated + "</td>";
                User user = new User();
                string postauthor = user.GetUsername(_board.Posts.ElementAt(n));
                p2 = p2 + "<td align ='center'>" + postauthor + "</td>";

            }
            //p2 = p2 + "</tr><tr><td><a href='MakePost.aspx'>Make a post</a></td>";
            p2 = p2 + "</tr></table>";
            // Create a ContentPlaceHolder holder object and set its value to the
            //  userPlaceHolder in site master for this page
            ContentPlaceHolder cpp2 = Page.Master.FindControl("boardPlaceHolder2") as ContentPlaceHolder;
            // Add a LiteralControl to the controls of userPlaceHolder
            cpp2.Controls.Add(new LiteralControl(p2));
        }
    }
}