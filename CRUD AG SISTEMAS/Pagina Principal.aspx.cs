using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace CRUD_AG_SISTEMAS
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        string strSql;
        string strConexao;

        protected void Page_Load(object sender, EventArgs e)
        {
            strConexao = "Data Source=DESKTOP-TFHHPTF\\SQLEXPRESS;Initial Catalog=Controle_Veiculos;Integrated Security=True";
            strSql = " SELECT * FROM Controles ";

            SqlConnection objConexao = new SqlConnection(strConexao);
            SqlCommand objCmd = new SqlCommand(strSql, objConexao);
            objConexao.Open();
            SqlDataReader dr = objCmd.ExecuteReader();


            GridView1.DataSource = dr;


            GridView1.DataBind();


            objConexao.Close();
            dr.Close();
        }

        protected void btn_inserir_Click(object sender, EventArgs e)
        {
          
        }
    }
}