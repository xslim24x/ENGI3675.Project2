<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableWebForm.aspx.cs" Inherits="Project2_Engi3675.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ENGI3675 ASP Project 2 - Animal Management System</title>
    <link rel="stylesheet" type="text/css" href="animalstyle.css">
</head>
<body>
    <div id="title"><h4>ENGI3675 ASP Dynamic Database System:</h4></div> 
    <h1 id="title">Animal Management System</h1>
    <img src="pets.jpg" id="topimg">
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
            </asp:TableRow>   
        </asp:Table> 
    </div>
    </form>
<!--<form action="action_page.php">
<table class="tg">
  <tr>
    <td class="tg-031e">
        Serial Number
    </td>
    <td class="tg-031e">
        Breed
    </td>
    <td class="tg-031e">
        Weight
    </td>
    <td class="tg-031e">
        Age
    </td>
    <td class="tg-031e">
        Delete
    </td>
  </tr>
  <tr>
    <td class="tg-031e">        
        <input type="text" name="serialInput" value="Input"/>
    </td>
    <td class="tg-031e">
        <form action="demo_form.asp">
        <input type="text" name="breedInput" value="Input"/>
        </form>
    </td>
    <td>
        <input type="text" text="Echo Input" name="weightInput" value="Input"/>
    </td>
    <td>
        <input type="text" name="ageInput" value="Input"/>
    </td>
    <td>
        <input type="submit" value="Delete">
    </td>
  </tr>
  <tr>
    <td class="tg-031e">        
        Turquoise
    </td>
    <td class="tg-031e">        
        <form action="demo_form.asp">
        <input type="text" name="turqInput" value="Input"/>
        </form>
    </td>
  </tr>
  <tr>
    <td class="tg-031e">        
        Grey
    </td>
    <td class="tg-031e">
        <form action="demo_form.asp">
        <input type="text" name="greyInput" value="Input"/>
        </form>
    </td>
  </tr>
  <tr>
    <td class="tg-031e">        
        Indigo
    </td>
    <td class="tg-031e">
        <form action="demo_form.asp">
        <input type="text" name="greyInput" value="Input"/>
        </form>
    </td>
  </tr>
-->
<br><br>
<asp:Button ID="NewRow" runat="server" onclick="Page_Load" Text="New Row">
<asp:Button runat="server" ID=UpdateDB" runat="server" OnClick="dataUpdate" Text="Submit">

</body>
</html>
