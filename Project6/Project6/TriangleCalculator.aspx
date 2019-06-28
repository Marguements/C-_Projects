<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="TriangleCalculator.aspx.cs" Inherits="Project6.TriangleCalculator" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <h1>Triangle Calculator</h1>
    <br />
    <br />
    <div class="MarginLeft">
        <asp:Label ID="lbSideA" runat="server" Text="Enter Side A:"></asp:Label>
        <br />
        <asp:Label ID="err1" runat="server" Text=""></asp:Label>
        <br />
        <asp:TextBox ID="SideA" MaxLength="12" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbSideB" runat="server" Text="Enter Side B:"></asp:Label>
        <br />
        <asp:Label ID="err2" runat="server" Text=""></asp:Label>
        <br />
        <asp:TextBox ID="SideB" MaxLength="12" runat="server"></asp:TextBox>

        <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Calculate" />
        <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear" />
    </div>
    <br />
    <hr />
    <br />
    <h1>Results</h1>
    <br />
    <asp:Label ID="SideC" CssClass="MarginLeft" runat="server" Text="Hypotenuse:"></asp:Label>
    <br />
    <asp:Label ID="Perimeter" CssClass="MarginLeft" runat="server" Text="Perimeter:"></asp:Label>
    <br />
    <asp:Label ID="Area" CssClass="MarginLeft" runat="server" Text="Area:"></asp:Label>
    <br />

</asp:Content>
