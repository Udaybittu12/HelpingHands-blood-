<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="HelpingHands_blood_.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <center> <h1>Welcome To Customer LOGIN</h1>
            <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br />
              click here for:
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/adminloginpage.aspx" >Admin LogIN</asp:HyperLink>
              </center> 
        </div>
    </form>
</body>
</html>
