<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyPictures.aspx.cs" Inherits="HomeWorkOne.MyPictures" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col">
           <div class="col">
            <asp:Label ID="Label1" runat="server" Text="Select on of my pictures "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" Height="27px" Width="137px">
            </asp:DropDownList>
               <br />
               <br />
              
               <asp:CheckBox ID="CheckBox2" runat="server" Text="Add border to Img" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="true" />

                <asp:CheckBox ID="RedCheckBox" runat="server" Text="Red" OnCheckedChanged="CheckBox_CheckedChanged" AutoPostBack="true" />
                <asp:CheckBox ID="BrownCheckBox" runat="server" Text="Brown" OnCheckedChanged="CheckBox_CheckedChanged" AutoPostBack="true" />
                <asp:CheckBox ID="BlueCheckBox" runat="server" Text="Blue" OnCheckedChanged="CheckBox_CheckedChanged" AutoPostBack="true" />
                <asp:CheckBox ID="GreenCheckBox" runat="server" Text="Green" OnCheckedChanged="CheckBox_CheckedChanged" AutoPostBack="true" />


           </div>
            <asp:Image ID="DisplayImage" runat="server" AlternateText="Seçilen Resim" Height="511px" Width="1211px" />
        </div>
    </form>
</body>
</html>
