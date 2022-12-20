<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alterar.aspx.cs" Inherits="CRUD_AG_SISTEMAS.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div class="center">
            <div>
            <h1>Controle de veículos</h1>

            </div>
            <br />
            <asp:Label runat="server" ID="lbl_Data_saida" Text="Data de Saida"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_Data_saida" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_Hora_Saida" Text="Hora de Saida"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_Hora_Saida" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_Km_saida" Text="Km do Veiculo no horario de partida"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_Km_saida" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_Destino" Text="Destino do veiculo"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_Destino" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_Data_retorno" Text="Data de retorno"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_Data_retorno" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_Hora_retorno" Text="hora de retorno"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_Hora_retorno" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_Km_Retorno" Text="Km do veiculo de retorno"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_Km_Retorno" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_Km_Percorrido" Text="Km percorrido"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_Km_Percorrido" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_Veiculo" Text="Veiculo utilizado"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_Veiculo" ></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lbl_Motorista" Text="Motorista utilizando o veiculo"></asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txt_Motorista" ></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" ID="btn_alterar" Text="alterar" OnClick="btn_alterar_Click"/>
            <br />
            <br />
            <asp:Button runat="server" ID="btn_excluir" Text="Excluir"  OnClick="btn_excluir_Click"/>
            <br />
            <br /><br />
            <br />

            <asp:Label runat="server" ID="lbl_retorno" Text=""></asp:Label>
            <asp:Button runat="server" ID="buttonback" Text="retornar" OnClick="buttonback_Click"/>
        </div>
    </form>
</body>
</html>
