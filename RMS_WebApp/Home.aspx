<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RMS_WebApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Restaurant Management System</title>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #00CC00">
        <div style="text-align:center"><h2 style="background-color: #FFFF00; color: #FF0066">Restuarent Management System</h2></div><br />
        <br />
        <br />
        Enter below order details and click on &#39;Create&#39; button to create an order.<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        &nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Description: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Type: "></asp:Label>
&nbsp;
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
            <asp:ListItem Selected="True">Veg</asp:ListItem>
            <asp:ListItem>Non-Veg</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Available: "></asp:Label>
&nbsp;
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
            <asp:ListItem Selected="True">Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Category: "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected="True">Gujarati</asp:ListItem>
            <asp:ListItem>Rajasthani</asp:ListItem>
            <asp:ListItem>South-Indian</asp:ListItem>
            <asp:ListItem>Punjabi</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Create" OnClick="Button1_Click1" />
        <br />
        <br />
        Enter below Order ID and click on any below button to perform the corresponding action.<br />
        <br />
        <asp:TextBox ID="txtoi" placeholder="Order ID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show Order(s)" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update" />
&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" OnClientClick="return confirm('Are you sure to delete?');" Text="Delete" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblmsg" runat="server" ForeColor="Black" Text="Message"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" style="margin-left: 0px" ForeColor="#660066">
        </asp:GridView>
        <br />
        About: This project is created by Devang Patel and Mitanshu Patel.</form>
</body>
</html>