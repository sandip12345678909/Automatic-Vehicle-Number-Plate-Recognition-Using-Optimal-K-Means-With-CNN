using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace numberplateweb
{
    public partial class Dashbord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;

            SqlConnection sq = new System.Data.SqlClient.SqlConnection(constr);
           
            sq.Open();
            SqlCommand sc = new SqlCommand(@"INSERT INTO [numberplatedata].[dbo].[Regs]
           ([Owner_Name]
           ,[Vehicle_number]
           ,[Vehicle_Name]
           ,[Vehicle_reg_date]
           ,[Vehicle_chessis_number])
     VALUES
           ('"+txtname.Text+"','"+txtnumber.Text+"','"+txtvehiclename.Text+"','"+txtRegDate.Text+"','"+txtchassis.Text+"')", sq);
            sc.ExecuteNonQuery();

            sq.Close();
        }
    }
}