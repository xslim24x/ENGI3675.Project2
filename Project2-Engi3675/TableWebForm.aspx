<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableWebForm.aspx.cs" Inherits="Project2_Engi3675.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;}
.tg td{font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}
.tg th{font-family:Arial, sans-serif;font-size:14px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}
</style>
<form action="action_page.php">
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
 <!-- <tr>
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
</table>
<br><br>
<input type="submit" value="New Row">
<input type="submit" value="Save"/>
</form>
    <div>
    
    </div>
    </form>
</body>
</html>
