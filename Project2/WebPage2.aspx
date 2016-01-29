<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPage2.aspx.cs" Inherits="Project2.WebPage2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style ="background-image:url('Images/background.jpe'); background-repeat: no-repeat; background-size:cover">
    <form style="width: 100%; height: 100px;" id="form2" runat="server">
        <p>
            Your vehicles will be a:
            <br />
            <br />
            <asp:Label ID="lblCar1" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Image ID="img1" runat="server" Width="400px" border="3px solid black"/>
        </p>
        <p>
            and a
            <asp:Label ID="lblCar2" runat="server"></asp:Label>
        </p>
        <asp:Image ID="img2" runat="server" Width="400px" border="3px solid black" />
    </form>
    </body>
</html>
