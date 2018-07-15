<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Course.aspx.cs" Inherits="Course" %>

<head>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        body {
            background-image:url("images/pencils.jpg");
            background-attachment: fixed;
            background-position: center;
            background-repeat: no-repeat;
            background-size: cover;
        }

    </style>
</head>

<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>
                 <div class="javascript">

  <img src="images/js.png" alt="javascript" style="width:300px" id="101">
        <ul>
        <asp:Button ID="Button1" runat="server" Text="Add To Bucket" OnClick="Button1_Click1"   />
        </ul>
    </div>
            </td>
            <td>
                 <div class="javascript">

  <img src="images/angular.png" alt="Forest" style="width:300px">
        <ul>
        <asp:Button ID="Button2" runat="server" Text="Add To Bucket" OnClick="Button2_Click"   />
        </ul>
    </div>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" text-color="black" ForeColor="black"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                 <div class="javascript">

  <img src="images/react.png" alt="Forest" style="width:300px">
        <ul>
        <asp:Button ID="Button3" runat="server" Text="Add To Bucket" OnClick="Button3_Click"   />
        </ul>
    </div>
            </td>
            <td>
               
                 <div class="javascript">

  <asp:Image ID="Image1" runat="server" ImageUrl="~/images/monodb2.jpg" />
        <ul>
        <asp:Button ID="Button4" runat="server" Text="Add To Bucket" OnClick="Button4_Click"   />
        </ul>
    </div>
                 
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>
                 <div class="javascript">

  <img src="images/nodejs.png" alt="Forest" style="width:300px">
        <ul>
        <asp:Button ID="Button5" runat="server" Text="Add To Bucket" OnClick="Button5_Click"   />
        </ul>
    </div>
            </td>
            <td>
                 <div class="javascript">

  <img src="images/.net.png" alt="Forest" style="width:300px">
        <ul>
        <asp:Button ID="Button6" runat="server" Text="Add To Bucket" OnClick="Button6_Click"  />
        </ul>
    </div>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</form>

    </body>

