<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="RepasoWebApp2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar.">
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
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbDeltaNov2023ConnectionString1 %>" DeleteCommand="DELETE FROM SalesLt.[Product] WHERE [ProductID] = @ProductID" InsertCommand="INSERT INTO SalesLt.[Product] ([Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [Weight], [ProductCategoryID], [ProductModelID], [SellStartDate], [SellEndDate], [DiscontinuedDate], [ThumbnailPhotoFileName], [rowguid], [ModifiedDate]) VALUES (@Name, @ProductNumber, @Color, @StandardCost, @ListPrice, @Size, @Weight, @ProductCategoryID, @ProductModelID, @SellStartDate, @SellEndDate, @DiscontinuedDate, @ThumbnailPhotoFileName, @rowguid, @ModifiedDate)" SelectCommand="SELECT [ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [Weight], [ProductCategoryID], [ProductModelID], [SellStartDate], [SellEndDate], [DiscontinuedDate], [ThumbNailPhoto], [ThumbnailPhotoFileName], [rowguid], [ModifiedDate] FROM SalesLt.[Product]" UpdateCommand="UPDATE SalesLt.[Product] SET [Name] = @Name, [ProductNumber] = @ProductNumber, [Color] = @Color, [StandardCost] = @StandardCost, [ListPrice] = @ListPrice, [Size] = @Size, [Weight] = @Weight, [ProductCategoryID] = @ProductCategoryID, [ProductModelID] = @ProductModelID, [SellStartDate] = @SellStartDate, [SellEndDate] = @SellEndDate, [DiscontinuedDate] = @DiscontinuedDate, [ThumbnailPhotoFileName] = @ThumbnailPhotoFileName, [rowguid] = @rowguid, [ModifiedDate] = @ModifiedDate WHERE [ProductID] = @ProductID">
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
        </div>
    </form>
</body>
</html>
