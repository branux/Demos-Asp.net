<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ADOEntityDataSource.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        País:
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="CountriesEntityDataSource" DataTextField="Country">
        </asp:DropDownList>
    
        <asp:EntityDataSource ID="CountriesEntityDataSource" runat="server" 
            ConnectionString="name=NORTHWNDEntitiesConn" 
            DefaultContainerName="NORTHWNDEntitiesConn" 
            EnableFlattening="False" 
            EntitySetName="Customers" 
            EntityTypeFilter="Customers" 
            Select="Distinct it.[Country]">
        </asp:EntityDataSource>
    
    </div>
    </form>
</body>
</html>
