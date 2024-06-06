<%@ Page Title="" Language="C#" MasterPageFile="~/bloodbank.Master" AutoEventWireup="true" CodeBehind="stock.aspx.cs" Inherits="HelpingHands_blood_.stock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="background-image:url('images/blooddrive.jpg');height:800px;width:1492px; " > 
            <center>
            <asp:Label ID="Label1" runat="server" Text="enter bloodgroup"></asp:Label>&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>select</asp:ListItem>
                        <asp:ListItem>O+</asp:ListItem>
                        <asp:ListItem>O-</asp:ListItem>
                        <asp:ListItem>AB+</asp:ListItem>
                        <asp:ListItem>AB-</asp:ListItem>
                        <asp:ListItem>A+</asp:ListItem>
                        <asp:ListItem>B+</asp:ListItem>
                        <asp:ListItem>A-</asp:ListItem>
                        <asp:ListItem>B-</asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
            </asp:DropDownList><br />
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Increase" GroupName="s"  />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Decrease" GroupName="s"  /><br />
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                <br />
                <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </center>
</asp:Content>
