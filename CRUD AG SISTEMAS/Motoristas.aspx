<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Motoristas.aspx.cs" Inherits="CRUD_AG_SISTEMAS.WebForm3" %>

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
            <h1>Inclusão de Motoristas</h1>

            </div>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_nome" Text="Nome"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_nome" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_telefone" Text="Telefone"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_telefone" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_cnh" Text="CNH"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_cnh" ></asp:TextBox>
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