<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPage1.aspx.cs" Inherits="Project2.WebPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style ="background-image:url('Images/background.jpe'); background-repeat: no-repeat; background-size:cover">
    <form style="width: 100%; height: 100px;" id="form1" runat="server">
    <div style="align-content:center; margin:auto; width:300px; border-style: outset; border-width: 8px;">
    
        <p style="margin-left: 40px">
    
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Personal Information<br />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Size="Small" Text="First Name:"></asp:Label>
        &nbsp;&nbsp; </strong><asp:TextBox ID="txtBox1" runat="server" OnTextChanged="txtBox1_TextChanged" Height="16px" Width="140px"></asp:TextBox>
    
        <br />
        <strong>
        <asp:Label ID="Label2" runat="server" Font-Size="Small" Text="Last Name:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtBox3" runat="server" OnTextChanged="txtBox3_TextChanged" Height="16px" Width="140px"></asp:TextBox>
        &nbsp;
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="Small" Text="Favorite Color:"></asp:Label>
        <asp:DropDownList ID="color" runat="server" OnSelectedIndexChanged="color_SelectedIndexChanged">
            <asp:ListItem>Black</asp:ListItem>
            <asp:ListItem>White</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label4" runat="server" Font-Size="Small" Text="Married?"></asp:Label>
        <asp:DropDownList ID="married" runat="server" OnSelectedIndexChanged="married_SelectedIndexChanged">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label5" runat="server" Font-Size="Small" Text="Children?"></asp:Label>
        <asp:DropDownList ID="children" runat="server" OnSelectedIndexChanged="children_SelectedIndexChanged">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label6" runat="server" Font-Size="Small" Text="Income Bracket:"></asp:Label>
        </strong>
        <asp:DropDownList ID="income" runat="server" OnSelectedIndexChanged="income_SelectedIndexChanged">
            <asp:ListItem>&gt;$50,000</asp:ListItem>
            <asp:ListItem>&lt;$50,000</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Small" Text="Gender:"></asp:Label>
        &nbsp;<asp:DropDownList ID="gender" runat="server" OnSelectedIndexChanged="gender_SelectedIndexChanged" Height="16px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;
        </p>
        <p style="margin-left: 40px;">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn1" runat="server" OnClick="btn1_Click1" Text="Submit"/>
        </p>
        
        </div>
    </form>
</body>
</html>
