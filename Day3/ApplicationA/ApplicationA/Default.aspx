<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ApplicationA.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>First Name:</strong><br />
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            <strong>Last Name:</strong><br />
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            <strong>Age:</strong><br />
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnShowResults" runat="server" OnClick="btnShowResults_Click" Text="Show Results" />
            <br />
            <br />
            <strong>Results:</strong><br />
            <asp:Label ID="lblResults" runat="server" ForeColor="Red" Text="Results Show Here"></asp:Label>
        </div>
    </form>
</body>
</html>
