using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie_tickets.Admin
{
    public partial class WebForm10 : System.Web.UI.Page
    { VisionCinemaEntities obj = new VisionCinemaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var q1 = (from s in obj.suggestion1

                      select new
                      {
                          s.id,
                          s.username,
                          s.moviename,
                          s.movie_history,
                          s.movie_type,
                          s.siggestion,

                      }).ToList();

            GridView1.DataSource = q1;
            GridView1.DataBind();

        }
       
        protected void TextSearch_TextChanged(object sender, EventArgs e)
        {
            var q1 = (from s in obj.suggestion1
                      where(s.movie_type == TextSearch.Text)

                      select new
                      {
                          s.id,
                          s.username,
                          s.moviename,
                          s.movie_history,
                          s.movie_type,
                          s.siggestion,

                      }).ToList();

            GridView1.DataSource = q1;
            GridView1.DataBind();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            var q1 = (from s in obj.suggestion1
                      where (s.movie_type == TextSearch.Text)

                      select new
                      {
                          s.id,
                          s.username,
                          s.moviename,
                          s.movie_history,
                          s.movie_type,
                          s.siggestion,

                      }).ToList();

            GridView1.DataSource = q1;
            GridView1.DataBind();
        }
    }
}