<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Veiculos.aspx.cs" Inherits="CRUD_AG_SISTEMAS.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
         .center {
             text-align: center;
             border: 5px;
          }
    </style>
</head>
    
<body>
   <form id="form1" runat="server">
        <div class="center">
            <div>
            <h1>Inclusão de Veiculos</h1>

            </div>
            <br />
            <asp:Label runat="server" ID="lbl_placa" Text="Placa"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_placa" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_marca" Text="Marca"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_marca" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_veiculo" Text="veiculo"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_veiculo" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_km_troca_oleo" Text="km_oleo"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_km_troca_oleo" ></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" ID="btn_inserir" Text="Inserir" OnClick="btn_inserir_Click"/>
            <br />
            <br />
            <br /><br />
            <asp:Label runat="server" ID="lbl_retorno" Text=""></asp:Label>
            <asp:Button runat="server" ID="buttonback" Text="retornar" OnClick="buttonback_Click"/>
        </div>
    </form>
</body>
</html>
