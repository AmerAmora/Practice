using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie_tickets.Admin
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        VisionCinemaEntities obj = new VisionCinemaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var q1 = (from s in obj.Feedbacks

                      select new
                      {
                         s.FeedBack_id,
                         s.Comment,
                         s.approve,
                      }).ToList();

            GridView1.DataSource = q1;
            GridView1.DataBind();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (AcceptedFeedBack.Checked)
            {
                var q1 = (from s in obj.Feedbacks
                          where (s.approve == false)

                          select new
                          {
                              s.FeedBack_id,
                              s.Comment,
                              s.approve,
                          }).ToList();

                GridView1.DataSource = q1;
                GridView1.DataBind();
            }
            else {
                var q1 = (from s in obj.Feedbacks
                          select new
                          {
                              s.FeedBack_id,
                              s.Comment,
                              s.approve,
                          }).ToList();

                GridView1.DataSource = q1;
                GridView1.DataBind();
            }
        }
    }
}