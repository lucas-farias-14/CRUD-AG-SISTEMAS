using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_AG_SISTEMAS
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        string strSql;

        string strConexao = "Data Source=DESKTOP-TFHHPTF\\SQLEXPRESS;Initial Catalog=Controle_Veiculos;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_inserir_Click(object sender, EventArgs e)
        {
            strSql = " INSERT into Veiculos";

            strSql = strSql + " (placa, marca, veiculo, km_troca_oleo) values ";

            strSql = strSql + " (@placa, @marca, @veiculo, @km_troca_oleo) ";

            SqlConnection objConexao = new SqlConnection(strConexao);

            SqlCommand objCmd = new SqlCommand(strSql, objConexao);

            objCmd.Parameters.Add(new SqlParameter("@placa", txt_placa.Text));
            objCmd.Parameters.Add(new SqlParameter("@marca", txt_marca.Text));
            objCmd.Parameters.Add(new SqlParameter("@veiculo", txt_veiculo.Text));
            objCmd.Parameters.Add(new SqlParameter("@km_troca_oleo", txt_km_troca_oleo.Text));

            objConexao.Open();

            objCmd.ExecuteNonQuery();

            objConexao.Close();

            lbl_retorno.Text = "O registro: <b>" + txt_placa.Text + "</b> foi inserido com sucesso";

            txt_placa.Text = "";
            txt_marca.Text = "";
            txt_veiculo.Text = "";
            txt_km_troca_oleo.Text = "";
        }

        protected void buttonback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu Principal.aspx");
        }
    }
}