<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoUpdateProgress.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #UpdateProgress1{
            width:200px;
            background-color:#ff0000;
            color:#fff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Button ID="getTimebtn" runat="server" Text="Button" OnClick="getTimebtn_Click" />

                <asp:TextBox ID="timeTextBox" runat="server" />
            </ContentTemplate>
            
        </asp:UpdatePanel>

        <br />

        <asp:UpdateProgress ID="UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1" runat="server" DisplayAfter="300" DynamicLayout="True">
            <ProgressTemplate>
                Buscando horário ...
            </ProgressTemplate>
        </asp:UpdateProgress>
        <br />




        <div>
        </div>
    </form>
</body>
</html>
