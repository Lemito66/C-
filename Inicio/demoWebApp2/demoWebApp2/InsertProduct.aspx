<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="demoWebApp2.InsertProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Insertando Producto en la base de datos</h1>
        </div>
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">Nombre</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>Precio</td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
        <td>Existencia</td>
        <td>
            <asp:TextBox ID="txtExists" runat="server"></asp:TextBox>
                </td>
        <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancelar" />
            </td>
            <td></td>
        </tr>
    </table>
    </form>
    </body>
</html>
