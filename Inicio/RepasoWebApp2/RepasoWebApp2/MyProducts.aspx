<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyProducts.aspx.cs" Inherits="RepasoWebApp2.MyProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>My Products</center>
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
                <asp:BoundField DataField="Existencias" HeaderText="Existencias" SortExpression="Existencias" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbDeltaNov2023ConnectionString1 %>" DeleteCommand="DELETE FROM [misProductos] WHERE [id] = @id" InsertCommand="INSERT INTO [misProductos] ([Nombre], [Precio], [Existencias]) VALUES (@Nombre, @Precio, @Existencias)" ProviderName="<%$ ConnectionStrings:dbDeltaNov2023ConnectionString1.ProviderName %>" SelectCommand="SELECT [id], [Nombre], [Precio], [Existencias] FROM [misProductos]" UpdateCommand="UPDATE [misProductos] SET [Nombre] = @Nombre, [Precio] = @Precio, [Existencias] = @Existencias WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Precio" Type="Decimal" />
                <asp:Parameter Name="Existencias" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Precio" Type="Decimal" />
                <asp:Parameter Name="Existencias" Type="Int32" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar Producto" />
    </form>
</body>
</html>
