<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ServiceConsumerWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table class="table table-hover">
            <tr>
                <td>
                    <b>Scaled Min</b>
                </td>
                <td>
                    <asp:TextBox ID="txtScaledMin" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Scaled Max</b>
                </td>
                <td>
                    <asp:TextBox ID="txtScaledMax" runat="server"></asp:TextBox>
                </td>
                </tr>
            <tr>
                <td>
                    <b>Raw Min</b>
                </td>
                <td>
                    <asp:TextBox ID="txtRawMin" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>    
                <td>
                    <b>Raw Max</b>
                </td>
                <td>
                    <asp:TextBox ID="txtRawMax" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Scaled Current</b>
                </td>
                <td>
                    <asp:TextBox ID="txtScaledInp" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Raw Current</b>
                </td>
                <td>
                    <asp:TextBox ID="txtRawInp" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Output</b>
                </td>
                <td>
                    <asp:Label ID="lblOutput" runat="server" ></asp:Label>
                </td>
            </tr>
            
            <tr>
                <td>
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                </td>
            </tr>
        </table>
    
    
    </form>
</body>
</html>
