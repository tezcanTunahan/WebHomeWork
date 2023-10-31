<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyPictures.aspx.cs" Inherits="HomeWorkOne.MyPictures" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Antalya" Value="1"></asp:ListItem>
                <asp:ListItem Text="Mardin" Value="2"></asp:ListItem>
     
            </asp:DropDownList>

            <asp:Image ID="DisplayImage" runat="server" AlternateText="Seçilen Resim" />
        </div>
    </form>
</body>
</html>
