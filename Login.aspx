<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/Login.css">

			
      <link rel="javascript" type="text/javascript" href="js/Login.js">
    
    </head>
<body background="images/computer.jpg">
    <p>
            
       <div class="login-page">
  <div class="form">
    
      <form id="form1" runat="server">
            <asp:TextBox ID="TextBox1" runat="server" placeholder="UserName"></asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" placeholder="password" TextMode="Password"></asp:TextBox>
          <asp:Button ID="Button1" runat="server" Text="Button"   CssClass="form btn" BackColor="#4CAF50" OnClick="Button1_Click"  />
      <p class="message">Forget Password? <a href="forgetPwd.aspx">CLick Here</a></p>
      </form>
  </div>
           <asp:Label ID="Label1" runat="server"></asp:Label>
</div>
        
    </form>
</body>
</html>
