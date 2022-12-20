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
    public partial class WebForm6 : System.Web.UI.Page
    {
        string strSql = ""; 
        string strConexao = "Data Source=DESKTOP-TFHHPTF\\SQLEXPRESS;Initial Catalog=Controle_Veiculos;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["cod"] = Request.QueryString["cod"];
                strSql = strSql + " SELECT * FROM Controles";
                strSql = strSql + " WHERE cod = " + Session["cod"];


                SqlConnection objConexao = new SqlConnection(Convert.ToString(strConexao));
                SqlCommand objCmd = new SqlCommand(strSql, objConexao);
                objConexao.Open();
                SqlDataReader dr = objCmd.ExecuteReader();

                dr.Read();


                txt_Data_saida.Text = Convert.ToString(dr["Data_saida"]);
                txt_Hora_Saida.Text = Convert.ToString(dr["Hora_Saida"]);
                txt_Km_saida.Text = Convert.ToString(dr["Km_saida"]);
                txt_Destino.Text = Convert.ToString(dr["Destino"]);
                txt_Data_retorno.Text = Convert.ToString(dr["Data_retorno"]);
                txt_Hora_retorno.Text = Convert.ToString(dr["Hora_retorno"]);
                txt_Km_Retorno.Text = Convert.ToString(dr["Km_Retorno"]);
                txt_Km_Percorrido.Text = Convert.ToString(dr["Km_Percorrido"]);
                txt_Veiculo.Text = Convert.ToString(dr["Veiculo"]);
                txt_Motorista.Text = Convert.ToString(dr["Motorista"]);
            }

        }

        protected void btn_excluir_Click(object sender, EventArgs e)
        {
            strSql = " DELETE Controles WHERE cod = " + Session["cod"];

            SqlConnection objConexao = new SqlConnection(Convert.ToString(strConexao));
            SqlCommand objCmd = new SqlCommand(strSql, objConexao);

            
            objConexao.Open();
            objCmd.ExecuteNonQuery();
            objConexao.Close();

            lbl_retorno.Text = "O registro de controle foi excluido com sucesso";
        }

        protected void btn_alterar_Click(object sender, EventArgs e)
        {
            strSql = " UPDATE Controles SET ";
            strSql = strSql + " Data_Saida=@Data_Saida, Hora_Saida=@Hora_Saida, Km_Saida=@Km_Saida, Destino=@Destino, Data_Retorno=@Data_Retorno, Hora_Retorno=@Hora_Retorno," +
                " Km_Retorno=@Km_Retorno, Km_Percorrido=@Km_Percorrido, Veiculo=@Veiculo, Motorista=@Motorista";

            strSql = strSql + " WHERE cod = " + Session["cod"];

         
            SqlConnection objConexao = new SqlConnection(Convert.ToString(strConexao));
            SqlCommand objCmd = new SqlCommand(strSql, objConexao);
            objCmd.Parameters.Add(new SqlParameter("@Data_Saida", txt_Data_saida.Text));
            objCmd.Parameters.Add(new SqlParameter("@Hora_Saida", txt_Hora_Saida.Text));
            objCmd.Parameters.Add(new SqlParameter("@Km_Saida", txt_Km_saida.Text));
            objCmd.Parameters.Add(new SqlParameter("@Destino", txt_Destino.Text));
            objCmd.Parameters.Add(new SqlParameter("@Data_Retorno", txt_Data_retorno.Text));
            objCmd.Parameters.Add(new SqlParameter("@Hora_Retorno", txt_Hora_retorno.Text));
            objCmd.Parameters.Add(new SqlParameter("@Km_Retorno", txt_Km_Retorno.Text));
            objCmd.Parameters.Add(new SqlParameter("@Km_Percorrido", txt_Km_Percorrido.Text));
            objCmd.Parameters.Add(new SqlParameter("@Veiculo", txt_Veiculo.Text));
            objCmd.Parameters.Add(new SqlParameter("@Motorista", txt_Motorista.Text));

         
            objConexao.Open();
            objCmd.ExecuteNonQuery();
            objConexao.Close();



            lbl_retorno.Text = "O registro de controle foi Alterado com sucesso";

        }

        protected void buttonback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu Principal.aspx");
        }
    }
}