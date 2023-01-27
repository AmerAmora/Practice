using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie_tickets.Admin
{
    public partial class AdminUsers : System.Web.UI.Page
    {
        VisionCinemaEntities db = new VisionCinemaEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var users = from user in db.AspNetUsers select user;
           Users.DataSource = users.ToList();
            Users.DataBind();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}