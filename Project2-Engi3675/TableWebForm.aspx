<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableWebForm.aspx.cs" Inherits="Project2_Engi3675.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ENGI3675 ASP Project 2 - Animal Management System</title>
    <link rel="stylesheet" type="text/css" href="animalstyle.css" />
</head>
<body>
    <div class="title">
        <h4>ENGI3675 ASP Dynamic Database System:</h4>
    </div>
    <h1 class="title">Animal Management System</h1>
    <img src="pets.jpg" id="topimg" />
    <form id="form1" runat="server">
        <div>

            <asp:Table ID="tblAnimals" runat="server" BorderWidth="1">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell ColumnSpan="2">
                    Animals
                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell BackColor="#94D4E9">
                    Serial Number
                    </asp:TableCell>
                    <asp:TableCell BackColor="#94D4E9">
                    Breed
                    </asp:TableCell>
                    <asp:TableCell BackColor="#94D4E9">
                    Weight
                    </asp:TableCell>
                    <asp:TableCell BackColor="#94D4E9">
                    Age
                    </asp:TableCell>
                    <asp:TableCell BackColor="#94D4E9">

                    </asp:TableCell>
                    <asp:TableCell BackColor="#94D4E9">

                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <br />
            <asp:Button ID="NewRow" runat="server" OnClick="Page_Load" Text="New Row" />
        </div>
    </form>
</body>
</html>
