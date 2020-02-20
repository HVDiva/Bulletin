using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class MakePost : System.Web.UI.Page
    {
        Post post = new Post();
        Utility utility = new Utility();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //post name of board you will be posting to
            /*
            Session.Add("thisboard", board);
            Board _board = (Board)(Session["thisboard"]);

            //User user = new User();

            //User _user = user.GetUser(id);
            string mp = "<h2>You will post to this board: " + _board.Name + "</h2>";


            ContentPlaceHolder cpmp = Page.Master.FindControl("makePostPlaceHolder") as ContentPlaceHolder;

            cpmp.Controls.Add(new LiteralControl(mp));*/
        }

        protected void CreatePostButton_Click(object sender, EventArgs e)
        {
            //string posttext = PostTextBox.Text;
            string posttext;
            posttext = PostTextArea.Value;
            string checkPostText = utility.CheckPostText(posttext);
            if (checkPostText == "OK")
            {
                post.Text = posttext;
                post.DateCreated = DateTime.Now;

                User _user = (User)(Session["loggedInUser"]);
                User user = new User();

                //access the session for the board that was clicked
               
                Board _board = (Board)(Session["clickedBoard"]);
                Board board = new Board();
                //if (!post.CreatePost(_board, _user, post ))
                if (!post.addPost(_board, _user, post))
                {
                    
                    string reDirect = String.Format("Error.aspx?message={0}", "Did not manage it!");
                    Response.Redirect(reDirect);
                }


                else
                {/*
                    User _user = (User)(Session["loggedInUser"]);
                    int id = int.Parse(Request.QueryString["id"]);

                    Board board = new Board();
                    

                    Board _board = board.GetBoard(id);
                    string boardid = board.ID.ToString();
                    //Response.Redirect("BoardPage.aspx?id={0}", boardid);

                    string reDirect = String.Format("BoardPage.aspx?id={0}", boardid);
                    Response.Redirect(reDirect);*/

                    //Session.Add("thisboard", board);
                    //Board _board = (Board)(Session["thisboard"]);
                    //string boardid = board.ID.ToString();
                    //string reDirect = String.Format("BoardPage.aspx?id={0}", boardid);
                    //Response.Redirect(reDirect);
                    string reDirect = String.Format("BoardPage.aspx?id={0}", _board.ID);
                    Response.Redirect(reDirect);
                }

            }
            else
                MessageLabel.Text = "Need post text.";
        }
    }
}