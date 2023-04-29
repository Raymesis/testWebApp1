using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using WebApplication1.Database;

namespace WebApplication1.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DoGridView();
            }
        }
        private void DoGridView()
        {
            try
            {
                Db.Instance.cnn.Open();
                using (SqlCommand myCom = new SqlCommand("dbo.usp_GetPost", Db.Instance.cnn))
                {
                    myCom.Connection = Db.Instance.cnn;
                    myCom.CommandType = CommandType.StoredProcedure;

                    SqlDataReader myDr = myCom.ExecuteReader();

                    gvCompanies.DataSource = myDr;
                    gvCompanies.DataBind();

                    myDr.Close();
                }
            }
            catch (Exception ex) { lblMessage.Text = "Error in Companies doGridView: " + ex.Message; }
            finally { Db.Instance.cnn.Close(); }
        }
        

    }
}
    