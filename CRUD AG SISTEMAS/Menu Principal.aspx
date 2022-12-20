<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu Principal.aspx.cs" Inherits="CRUD_AG_SISTEMAS.WebForm1" %>

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
               <br /><br />
                <asp:button runat="server" ID="Main_Menu" Text="principal" onClick="Main_Menu_Click" height="30px" width="100px" /> 
               <br /><br />
                <asp:button runat="server" ID="Car_Button" Text="Veículos" onClick="Car_Button_Click" height="30px" width="100px" /> 
               <br /><br />
                <asp:button runat="server" ID="Motorist_Button" Text="Motoristas" onClick="Motorist_Button_Click" height="30px" width="100px" /> 
                <br /><br />
                <asp:button runat="server" ID="Control_Button" Text="Inserir controle" onClick="Control_Button_Click" height="30px" width="100px" /> 

        </div>
    </form>
</body>
</html>
