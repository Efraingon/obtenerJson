<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="obtenerJson.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Información de los accesos a la aplicación</h3>
            <br />
            <asp:Button ID="Obtener" runat="server" Text="Obtener Información de JSON" OnClick="Obtener_Click" />
            <br />
            <br />

            <asp:Button ID="ObtenerWeb" runat="server" Text="Obtener Información de JSON Web" OnClick="ObtenerWeb_Click" />

            <br />
            <br />
            <br />

            <asp:GridView ID="TablaJson" runat="server" BorderStyle="Dashed" BackColor="Lime" AllowCustomPaging="True"></asp:GridView>
            <asp:GridView ID="TablaJsonWeb" runat="server" BackColor="#CC99FF"></asp:GridView>

        </div>
    </form>
</body>
</html>
