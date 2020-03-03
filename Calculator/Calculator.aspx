<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-right: auto; margin-left: auto">
            <asp:TextBox ID="tbx_expression" runat="server" Style="width: 200px"></asp:TextBox>
            <asp:Button ID="Number_0_btn" runat="server" Text="0" OnClick="Number_0_btn_Click" />
            <asp:Button ID="Number_1_btn" runat="server" Text="1" OnClick="Number_1_btn_Click" />
            <asp:Button ID="Number_2_btn" runat="server" Text="2" OnClick="Number_2_btn_Click" />
            <asp:Button ID="Number_3_btn" runat="server" Text="3" OnClick="Number_3_btn_Click" />
            <asp:Button ID="Number_4_btn" runat="server" Text="4" OnClick="Number_4_btn_Click" />
            <asp:Button ID="Number_5_btn" runat="server" Text="5" OnClick="Number_5_btn_Click" />
            <asp:Button ID="Number_6_btn" runat="server" Text="6" OnClick="Number_6_btn_Click" />
            <asp:Button ID="Number_7_btn" runat="server" Text="7" OnClick="Number_7_btn_Click" />
            <asp:Button ID="Number_8_btn" runat="server" Text="8" OnClick="Number_8_btn_Click" />
            <asp:Button ID="Number_9_btn" runat="server" Text="9" OnClick="Number_9_btn_Click" />

            <asp:Button ID="Multiplication_btn" runat="server" Text="*" OnClick="Multiplication_btn_Click" />
            <asp:Button ID="Division_btn" runat="server" Text="/" OnClick="Division_btn_Click" />
            <asp:Button ID="Addition_btn" runat="server" Text="+" OnClick="Addition_btn_Click" />
            <asp:Button ID="Subtraction_btn" runat="server" Text="-" OnClick="Subtraction_btn_Click" />

            <asp:Button ID="Clear_btn" runat="server" Text="C" OnClick="Clear_btn_Click" />
            <asp:Button ID="Result_btn" runat="server" Text="=" OnClick="Result_btn_Click" />
        </div>
    </form>
</body>
</html>
