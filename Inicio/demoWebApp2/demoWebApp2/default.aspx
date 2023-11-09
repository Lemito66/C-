<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="demoWebApp2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Emill</h1>
            <p>Hi Emill, <strong>welcome</strong>  back</p>
        </div>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server">
        </asp:EntityDataSource>
        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ProductID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="ProductNumber" HeaderText="ProductNumber" SortExpression="ProductNumber" />
                <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
                <asp:BoundField DataField="StandardCost" HeaderText="StandardCost" SortExpression="StandardCost" />
                <asp:BoundField DataField="ListPrice" HeaderText="ListPrice" SortExpression="ListPrice" />
                <asp:BoundField DataField="Size" HeaderText="Size" SortExpression="Size" />
                <asp:BoundField DataField="Weight" HeaderText="Weight" SortExpression="Weight" />
                <asp:BoundField DataField="ProductCategoryID" HeaderText="ProductCategoryID" SortExpression="ProductCategoryID" />
                <asp:BoundField DataField="ProductModelID" HeaderText="ProductModelID" SortExpression="ProductModelID" />
                <asp:BoundField DataField="SellStartDate" HeaderText="SellStartDate" SortExpression="SellStartDate" />
                <asp:BoundField DataField="SellEndDate" HeaderText="SellEndDate" SortExpression="SellEndDate" />
                <asp:BoundField DataField="DiscontinuedDate" HeaderText="DiscontinuedDate" SortExpression="DiscontinuedDate" />
                <asp:BoundField DataField="ThumbnailPhotoFileName" HeaderText="ThumbnailPhotoFileName" SortExpression="ThumbnailPhotoFileName" />
                <asp:BoundField DataField="rowguid" HeaderText="rowguid" SortExpression="rowguid" />
                <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" SortExpression="ModifiedDate" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbDeltaNov2023ConnectionString %>" DeleteCommand="DELETE FROM SalesLT.Product WHERE [ProductID] = @ProductID" InsertCommand="INSERT INTO SalesLT.Product ([Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [Weight], [ProductCategoryID], [ProductModelID], [SellStartDate], [SellEndDate], [DiscontinuedDate], [ThumbnailPhotoFileName], [rowguid], [ModifiedDate]) VALUES (@Name, @ProductNumber, @Color, @StandardCost, @ListPrice, @Size, @Weight, @ProductCategoryID, @ProductModelID, @SellStartDate, @SellEndDate, @DiscontinuedDate, @ThumbnailPhotoFileName, @rowguid, @ModifiedDate)" SelectCommand="SELECT [ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [Weight], [ProductCategoryID], [ProductModelID], [SellStartDate], [SellEndDate], [DiscontinuedDate], [ThumbNailPhoto], [ThumbnailPhotoFileName], [rowguid], [ModifiedDate] FROM SalesLT.Product" UpdateCommand="UPDATE SalesLT.Product SET [Name] = @Name, [ProductNumber] = @ProductNumber, [Color] = @Color, [StandardCost] = @StandardCost, [ListPrice] = @ListPrice, [Size] = @Size, [Weight] = @Weight, [ProductCategoryID] = @ProductCategoryID, [ProductModelID] = @ProductModelID, [SellStartDate] = @SellStartDate, [SellEndDate] = @SellEndDate, [DiscontinuedDate] = @DiscontinuedDate, [ThumbnailPhotoFileName] = @ThumbnailPhotoFileName, [rowguid] = @rowguid, [ModifiedDate] = @ModifiedDate WHERE [ProductID] = @ProductID" ProviderName="<%$ ConnectionStrings:dbDeltaNov2023ConnectionString.ProviderName %>">
            <DeleteParameters>
                <asp:Parameter Name="ProductID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="ProductNumber" Type="String" />
                <asp:Parameter Name="Color" Type="String" />
                <asp:Parameter Name="StandardCost" Type="Decimal" />
                <asp:Parameter Name="ListPrice" Type="Decimal" />
                <asp:Parameter Name="Size" Type="String" />
                <asp:Parameter Name="Weight" Type="Decimal" />
                <asp:Parameter Name="ProductCategoryID" Type="Int32" />
                <asp:Parameter Name="ProductModelID" Type="Int32" />
                <asp:Parameter Name="SellStartDate" Type="DateTime" />
                <asp:Parameter Name="SellEndDate" Type="DateTime" />
                <asp:Parameter Name="DiscontinuedDate" Type="DateTime" />
                <asp:Parameter Name="ThumbnailPhotoFileName" Type="String" />
                <asp:Parameter Name="rowguid" Type="Object" />
                <asp:Parameter Name="ModifiedDate" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="ProductNumber" Type="String" />
                <asp:Parameter Name="Color" Type="String" />
                <asp:Parameter Name="StandardCost" Type="Decimal" />
                <asp:Parameter Name="ListPrice" Type="Decimal" />
                <asp:Parameter Name="Size" Type="String" />
                <asp:Parameter Name="Weight" Type="Decimal" />
                <asp:Parameter Name="ProductCategoryID" Type="Int32" />
                <asp:Parameter Name="ProductModelID" Type="Int32" />
                <asp:Parameter Name="SellStartDate" Type="DateTime" />
                <asp:Parameter Name="SellEndDate" Type="DateTime" />
                <asp:Parameter Name="DiscontinuedDate" Type="DateTime" />
                <asp:Parameter Name="ThumbnailPhotoFileName" Type="String" />
                <asp:Parameter Name="rowguid" Type="Object" />
                <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                <asp:Parameter Name="ProductID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
