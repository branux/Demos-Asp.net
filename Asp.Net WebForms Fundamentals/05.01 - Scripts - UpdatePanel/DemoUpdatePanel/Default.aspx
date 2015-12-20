<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoUpdatePanel.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label runat="server" ID="timeLabel" Text="Label"></asp:Label>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="getTimeBtn" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
        <asp:Button ID="getTimeBtn" runat="server" Text="Get Time" OnClick="getTimeBtn_Click" />
    </form>
</body>
</html>
