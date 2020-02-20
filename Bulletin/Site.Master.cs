using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class SiteMaster : MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["loggedInUser"] == null)
                {
                    this.Page.Master.FindControl("Account").Visible = false;
                    this.Page.Master.FindControl("MainPage").Visible = false;
                    this.Page.Master.FindControl("Users").Visible = false;
                    this.Page.Master.FindControl("Logout").Visible = false;
                }
                else
                {
                    this.Page.Master.FindControl("Account").Visible = true;
                    this.Page.Master.FindControl("MainPage").Visible = true;
                    this.Page.Master.FindControl("Logout").Visible = true;
                    if (((User)Session["loggedInUser"]).UserType == "ADMIN")
                        this.Page.Master.FindControl("Users").Visible = true;
                    else
                        this.Page.Master.FindControl("Users").Visible = false;
                }
            }
        }
    }
}