using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Repository;
namespace WebApplication1.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PostDaoImp po = new PostDaoImp();

            System.Diagnostics.Debug.WriteLine(po.getPosts()[0].name);
            

        }
    }
}