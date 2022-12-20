<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina Principal.aspx.cs" Inherits="CRUD_AG_SISTEMAS.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Veiculos</h1>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:HyperLinkField DataTextField="cod" DataNavigateUrlFields="cod"
                        DataNavigateUrlFormatString="Alterar.aspx?cod={0}"
                        HeaderText="Codigo" HeaderStyle-Width="10%" /> 

                    
                     <asp:BoundField DataField="Data_Saida" HeaderText="Data de Saida"
                        HeaderStyle-Width="10%" />

                     <asp:BoundField DataField="Hora_Saida" HeaderText="Hora de Saida"
                        HeaderStyle-Width="10%" />

                    <asp:BoundField DataField="Km_Saida" HeaderText="Km de Saida"
                        HeaderStyle-Width="10%" />

                    
                    <asp:BoundField DataField="Destino" HeaderText="Destino"
                        HeaderStyle-Width="10%" />

                    
                    <asp:BoundField DataField="Data_retorno" HeaderText="Data de retorno"
                        HeaderStyle-Width="10%" />

                      <asp:BoundField DataField="Hora_retorno" HeaderText="Hora de retorno"
                        HeaderStyle-Width="10%" />
                      <asp:BoundField DataField="Km_Retorno" HeaderText="Km de retorno"
                        HeaderStyle-Width="10%" />
                      <asp:BoundField DataField="Km_Percorrido" HeaderText="Km percorrida"
                        HeaderStyle-Width="10%" />
                      <asp:BoundField DataField="Veiculo" HeaderText="Veiculo "
                        HeaderStyle-Width="10%" />
                      <asp:BoundField DataField="Motorista" HeaderText="Motorista"
                        HeaderStyle-Width="10%" />
                    </Columns>
            </asp:GridView>

            <p class="auto-style1">

            <br class="auto-style1" />
           <asp:Button runat="server" ID="btn_inserir" Text="Inserir" OnClick="btn_inserir_Click"/> 

            
            </p>

            
        </div>
      
    </form>
</body>
</html>
