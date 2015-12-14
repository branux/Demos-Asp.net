<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="Validacao.cadastro" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Cadastro</title>
    <style>
        .label {
            min-width: 100px;
            display: inline-block;
        }

        div.form-containner {
            margin: 10px auto;
            border:1px solid #808080;
            padding:10px;
            width: 400px;
        }

        div.form-containner>div{
            margin:10px 0;
        }
            div.form-containner > div > input[type=text] {
                min-width:50%;
            }
        header{
            text-align:center;
        }
    </style>
</head>
<body>
    <header>
    <h2>Cadastro</h2>
    <p>Validação</p>
        </header>
    <form id="form1" runat="server">
        <div class="form-containner">
            <div>
                <asp:Label CssClass="label" ID="Label1" runat="server" Text="Nome:">
                </asp:Label>
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nome é obrigatório" ControlToValidate="nameTextBox">*</asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label CssClass="label" ID="Label2" runat="server" Text="SobreNome:">
                </asp:Label>
                <asp:TextBox ID="lastnameTextBox" runat="server" TabIndex="1"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Sobrenome é obrigatório" ControlToValidate="lastnameTextBox">*</asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label CssClass="label" ID="Label3" runat="server" Text="Nascimento:">
                </asp:Label>
                <asp:TextBox ID="birthdayTextBox" runat="server" TabIndex="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Nascimento é obrigatório" ControlToValidate="birthdayTextBox">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="birthdayTextBox" ErrorMessage="Data inválida" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
            </div>
            <div>
                <asp:Label CssClass="label" ID="Label4" runat="server" Text="UF:">
                </asp:Label>
                <asp:DropDownList ID="stateDropDownList" runat="server" TabIndex="3">
                    <asp:ListItem Value="">Selecione...</asp:ListItem>
                    <asp:ListItem Value="SP">São Paulo</asp:ListItem>
                    <asp:ListItem Value="RJ">Rio de Janeiro</asp:ListItem>
                </asp:DropDownList>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="UF é obrigatório" ControlToValidate="stateDropDownList">*</asp:RequiredFieldValidator>

            </div>
            <div>
                <asp:Label CssClass="label" ID="Label5" runat="server" Text="Email:">
                </asp:Label>
                <asp:TextBox ID="emailTextBox" runat="server" TabIndex="1"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailTextBox" ErrorMessage="E-mail inválido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </div>

            <div>
                <asp:Button ID="enviarButton" runat="server" Text="Enviar" OnClick="enviarButton_Click" />
            </div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

        </div>
    </form>
</body>
</html>
