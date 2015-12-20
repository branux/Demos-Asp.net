<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoScriptManager.Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Demo ScriptManager</title>
    <meta charset="utf-8" />
</head>
<body>
    <form id="form1" runat="server">

        <asp:ScriptManager ID="sm" runat="server">
            <Scripts>
                <asp:ScriptReference Path="~/Scripts/MeuScript.js" />
            </Scripts>
            
        </asp:ScriptManager>


    <div>
    
        <span id="output"></span>
    </div>
    </form>
</body>
</html>
