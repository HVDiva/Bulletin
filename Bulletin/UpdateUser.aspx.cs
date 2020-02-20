using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        User user;
        static User userForUpdate;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = new User();
            int id = int.Parse(Request.QueryString["id"]);
            userForUpdate = user.GetUser(id);
            NameLabel.Text = userForUpdate.Name;
            UsernameLabel.Text = userForUpdate.Username;
            if (!Page.IsPostBack)
            {
                RoleRadio.SelectedValue = userForUpdate.UserType;
            }
        }

        protected void RoleRadio_SelectedIndexChanged(object sender, EventArgs e)
        {
            userForUpdate.UserType = RoleRadio.SelectedValue;
        }

        protected void UpdateUserButton_Click(object sender, EventArgs e)
        {
            user.UpdateUser(userForUpdate);
            Response.Redirect("Users.aspx");
        }

        protected void DeleteUserButton_Click(object sender, EventArgs e)
        {
            user.DeleteUser(userForUpdate);
            Response.Redirect("Users.aspx");            
        }
    }
}