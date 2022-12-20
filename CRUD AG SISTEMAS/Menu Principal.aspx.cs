using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_AG_SISTEMAS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Main_Menu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina Principal.aspx");
        }

        protected void Car_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Veiculos.aspx");
        }

        protected void Motorist_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Motoristas.aspx");
        }

        protected void Control_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Controle.aspx");
        }
    }
}