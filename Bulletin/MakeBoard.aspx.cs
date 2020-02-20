using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class MakeBoard : System.Web.UI.Page
    {
        Board board = new Board();
        Utility utility = new Utility();
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void CreateBoardButton_Click(object sender, EventArgs e)
        {
            string boardname = BoardNameTextBox.Text;
            string checkBoardName = utility.CheckBoardName(boardname);
            if (checkBoardName == "OK")
            {
                board.Name = boardname;
                board.DateCreated = DateTime.Now;

                User _user = (User)(Session["loggedInUser"]);
                User user = new User();


                //add user ID


                if (/*!board.CreateBoard(board) ||*/ !user.UpdateUserBoard(board, _user.ID))
                {
                    string reDirect = String.Format("Error.aspx?message={0}", "Did not manage it!");
                    Response.Redirect(reDirect);
                }
                else
                    Response.Redirect("MainPage.aspx");
            }
            else
                MessageLabel.Text = "Need a board name.";
        }
    }
}