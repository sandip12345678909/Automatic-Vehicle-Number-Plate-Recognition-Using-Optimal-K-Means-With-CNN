using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace numberplateweb
{
    public partial class Show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Showdata();
        }

        private void Showdata()
        {

            string strcon = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
            SqlConnection sq = new System.Data.SqlClient.SqlConnection(strcon);
            sq.Open();
            SqlCommand cmd = sq.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Select Id, product_name, original_price, discount_price, ProdImg from ProdTab";
            cmd.CommandText = "SELECT Regs.*FROM   Regs";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            sq.Close();
        }

    }
}