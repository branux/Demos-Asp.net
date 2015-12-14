<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloWorld.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>HelloWorld</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Nome: <asp:TextBox ID="NameTextBox" autofocus="autofocus" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        <br />
        <asp:Label ID="Output" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
