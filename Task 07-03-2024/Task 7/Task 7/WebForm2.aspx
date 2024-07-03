<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Task_7.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Number 1"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Number 2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="+" BackColor="green" OnClick="Button1_Click" Width="100px" Font-Size="40px" />
            <asp:Button ID="Button2" runat="server" Text="-" BackColor="yellow" OnClick="Button2_Click" Width="100px" Font-Size="40px" />
            <asp:Button ID="Button3" runat="server" Text="*" BackColor="red" OnClick="Button3_Click" Width="100px" Font-Size="40px" />
            <asp:Button ID="Button4" runat="server" Text="/" BackColor="pink" OnClick="Button4_Click" Width="100px" Font-Size="40px" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
