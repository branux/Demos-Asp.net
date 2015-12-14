<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="UserControl.UserControls.Header" %>

<style>
    .headerUC>div{
        max-width:40%;
        font-family:Verdana;
        font-size:18px;
        display:inline-block;
    }
    #dataUC{
        float:right;
        text-align:right;
    }

</style>
<div class="headerUC">
    <div id="acmeUC">Acme Corp.</div>
    <div id="dataUC">
        <asp:Label ID="dataLabel" runat="server" Text="Label"></asp:Label>
    </div>
</div>
