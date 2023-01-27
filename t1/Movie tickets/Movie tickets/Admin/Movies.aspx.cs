using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie_tickets.Admin
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        VisionCinemaEntities obj = new VisionCinemaEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
           

                var q1 = (from s in obj.Movies

                          select new
                          {
                              s.Movie_Id,
                              s.Title,
                              s.Duration,
                              s.genre,
                              s.Release_Date,
                              s.Movie_Description,
                              s.Movie_Image,

                          }).ToList();
           
            GridView1.DataSource = q1;
                GridView1.DataBind();
            
        }
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add-Movies");
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            var q1 = (from s in obj.Movies
                      where (s.Title == TextSearch.Text)
                      select new
                      {
                          s.Movie_Id,
                          s.Title,
                          s.Duration,
                          s.genre,
                          s.Release_Date,
                          s.Movie_Description,
                          s.Movie_Image,

                      }).ToList();
            GridView1.DataSource = q1;
            GridView1.DataBind();


        }

        protected void TextSearch_TextChanged(object sender, EventArgs e)
        {

            var q1 = (from s in obj.Movies
                      where(s.Title.Contains(TextSearch.Text))
                      select new
                      {
                          s.Movie_Id,
                          s.Title,
                          s.Duration,
                          s.genre,
                          s.Release_Date,
                          s.Movie_Description,
                          s.Movie_Image,

                      }).ToList();


            GridView1.DataSource = q1;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            
        }
    }
}