using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_AG_SISTEMAS
{
    public partial class WebForm3 : System.Web.UI.Page
    {


        string strSql;

        string strConexao = "Data Source=DESKTOP-TFHHPTF\\SQLEXPRESS;Initial Catalog=Controle_Veiculos;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_inserir_Click(object sender, EventArgs e)
        {
            strSql = " INSERT into Motoristas";

            strSql = strSql + " (nome, telefone, cnh) values ";

            strSql = strSql + " (@nome, @telefone, @cnh) ";

            SqlConnection objConexao = new SqlConnection(strConexao);

            SqlCommand objCmd = new SqlCommand(strSql, objConexao);

   
            objCmd.Parameters.Add(new SqlParameter("@nome", txt_nome.Text));
            objCmd.Parameters.Add(new SqlParameter("@telefone", txt_telefone.Text));
            objCmd.Parameters.Add(new SqlParameter("@cnh", txt_cnh.Text));

            objConexao.Open();

            objCmd.ExecuteNonQuery();

            objConexao.Close();

            lbl_retorno.Text = "O registro: <b>" + txt_nome.Text + "</b> foi inserido com sucesso";

            txt_nome.Text = "";
            txt_telefone.Text = "";
            txt_cnh.Text = "";
        }

        protected void buttonback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu Principal.aspx");
        }
    }
}