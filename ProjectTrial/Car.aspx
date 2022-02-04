<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Car.aspx.cs" Inherits="ProjectTrial.User_Info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <table >
                <tr>
                    <td>
                
            
            <asp:Label ID="Label1" runat="server" Text="Car Model"></asp:Label></td>
            <td><asp:TextBox ID="txtcramodel" runat="server"></asp:TextBox></td></tr>
      
       
          <tr>  <td><asp:Label ID="Label" runat="server" Text="Category"></asp:Label></td>
            <td><asp:TextBox ID="txtcategory" runat="server"></asp:TextBox></td></tr>
       
       <tr><td> <asp:Label ID="Label2" runat="server" Text="Prize"></asp:Label></td>
       <td> <asp:TextBox ID="txtprize" runat="server"></asp:TextBox></td></tr>
      <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Year of Model"></asp:Label></td>
           <td> <asp:TextBox ID="txtyear" runat="server"></asp:TextBox></td></tr>
        
       <tr><td> <asp:Label ID="Label4" runat="server" Text="Description"></asp:Label></td>
        <td><asp:TextBox ID="txtdescription" runat="server"></asp:TextBox></td></tr>
       
          <tr><td> <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" />
            <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" />
            <asp:Button ID="btnreset" runat="server" Text="Reset" OnClick="btnreset_Click" /></td> </tr>
        </table>
            <hr />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
              </div>
        <hr />
        <div>
            <asp:GridView ID="gvDisplay" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
