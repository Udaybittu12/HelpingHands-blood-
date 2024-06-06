<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customer.aspx.cs" Inherits="HelpingHands_blood_.customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
    <div style="background-image:url('images/blooddrive.jpg');height:800px;width:1492px; " > 
    <h4><b>Add New Donor Here ..</b></h4>
    <style> 
        h4{text-align: center;} 
         h3{text-align: right;}
    </style>
       <h3> click here for <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/loginpage.aspx"  >Log out</asp:HyperLink></h3><br />
    <b><asp:Label ID="Label1"  runat="server" Text="DonorID"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="DonorID Required" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label2" runat="server" Text="DonorName"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="DonorName Required" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Fathername"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label9" runat="server" Text="BloodGroup"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" >
                        <asp:ListItem>select</asp:ListItem>
                        <asp:ListItem>o+</asp:ListItem>
                        <asp:ListItem>o-</asp:ListItem>
                        <asp:ListItem>Ab+</asp:ListItem>
                        <asp:ListItem>Ab-</asp:ListItem>
                        <asp:ListItem>A+</asp:ListItem>
                        <asp:ListItem>B+</asp:ListItem>
                        <asp:ListItem>A-</asp:ListItem>
                        <asp:ListItem>B-</asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
    </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="BloodGroup Required" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label4" runat="server" Text="MotherName"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="City"></asp:Label>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Date-Of-Birth"></asp:Label>
    <asp:TextBox ID="TextBox6" runat="server" TextMode="Date"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Date-Of-Birth Required" ControlToValidate="TextBox6"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Mobile"></asp:Label>
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="MobileNo Required" ControlToValidate="TextBox7"></asp:RequiredFieldValidator>
&nbsp; <br />
    <asp:Label ID="Label10" runat="server" Text="Gender"></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server"  >
                        <asp:ListItem>select</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
     </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Gender Required" ControlToValidate="DropDownList2"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Address"></asp:Label>
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Address Required" ControlToValidate="TextBox8"></asp:RequiredFieldValidator>
    <br />
        <center><b><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></b></center>
        </div>
    </form>
</body>
</html>
