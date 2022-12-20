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
    public partial class WebForm5 : System.Web.UI.Page
    {

    string strSql; 
    string strConexao = "Data Source=DESKTOP-TFHHPTF\\SQLEXPRESS;Initial Catalog=Controle_Veiculos;Integrated Security=True";


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_inserir_Click(object sender, EventArgs e)
        {
            strSql = " INSERT into Controles";

            strSql = strSql + " (Data_Saida, Hora_Saida, Km_Saida, Destino, Data_Retorno, Hora_Retorno, Km_Retorno, Km_Percorrido, Veiculo, Motorista) values ";

            strSql = strSql + " (@Data_Saida, @Hora_Saida, @Km_Saida, @Destino, @Data_Retorno, @Hora_Retorno, @Km_Retorno, @Km_Percorrido, @Veiculo, @Motorista) ";

            SqlConnection objConexao = new SqlConnection(strConexao);

            SqlCommand objCmd = new SqlCommand(strSql, objConexao);

            objCmd.Parameters.Add(new SqlParameter("@Data_Saida", txt_Data_saida.Text));
            objCmd.Parameters.Add(new SqlParameter("@Hora_Saida", txt_Hora_Saida.Text));
            objCmd.Parameters.Add(new SqlParameter("@Km_Saida", txt_Km_saida.Text));
            objCmd.Parameters.Add(new SqlParameter("@Destino", txt_Destino.Text));
            objCmd.Parameters.Add(new SqlParameter("@Data_Retorno", txt_Data_retorno.Text));
            objCmd.Parameters.Add(new SqlParameter("@Hora_Retorno", txt_Hora_retorno.Text));
            objCmd.Parameters.Add(new SqlParameter("@Km_Retorno", txt_Km_Retorno.Text));
            objCmd.Parameters.Add(new SqlParameter("@Km_Percorrido",txt_Km_Percorrido.Text));
            objCmd.Parameters.Add(new SqlParameter("@Veiculo", txt_Veiculo.Text));
            objCmd.Parameters.Add(new SqlParameter("@Motorista", txt_Motorista.Text));


            objConexao.Open();

            objCmd.ExecuteNonQuery();

            objConexao.Close();

            lbl_retorno.Text = "O registro de controle foi inserido com sucesso";

            txt_Data_saida.Text = "";
            txt_Hora_Saida.Text = "";
            txt_Km_saida.Text = "";
            txt_Destino.Text = "";
            txt_Data_retorno.Text = "";
            txt_Hora_retorno.Text = "";
            txt_Km_Retorno.Text = "";
            txt_Km_Percorrido.Text = "";
            txt_Veiculo.Text = "";
            txt_Motorista.Text = "";

        }

        protected void buttonback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu Principal.aspx");
        }
    }
}