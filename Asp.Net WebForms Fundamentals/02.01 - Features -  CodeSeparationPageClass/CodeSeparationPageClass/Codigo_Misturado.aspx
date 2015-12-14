<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="OutPut" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
<script type="text/C#" runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        OutPut.Text = DateTime.Now.ToShortTimeString();
    }
</script>