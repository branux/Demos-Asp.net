<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="UserControl.Home" %>

<%@ Register Src="~/UserControls/Header.ascx" TagPrefix="headerUsercontrol" TagName="Header" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <headerUsercontrol:Header runat="server" id="Header" />
    <form id="form1" runat="server">
    <div>
        <h1>Home</h1>
    </div>
    </form>
</body>
</html>
