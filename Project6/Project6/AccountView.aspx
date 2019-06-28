<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AccountView.aspx.cs" Inherits="Project6.AccountView" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <h1>Accounts Page</h1>
    <br />
    <br />
  
    <asp:CheckBox ID="chkChangeGV" CssClass="MarginLeft" AutoPostBack="true" OnCheckedChanged="chkChangeGV_CheckedChanged" Text="Negative Account Balances" runat="server" />
    <br />
    <br />
    <asp:GridView ID="AccountsGV" runat="server" AllowSorting="True"  AutoGenerateColumns="False" DataKeyNames="AccountID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="AccountID" HeaderText="AccountID" ReadOnly="True" SortExpression="AccountID" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
            <asp:BoundField DataField="InterestRate" HeaderText="InterestRate" SortExpression="InterestRate" />
            <asp:BoundField DataField="Balance" HeaderText="Balance" SortExpression="Balance" />
        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CS364_ExampleConnectionString %>" SelectCommand="SELECT * FROM [Accounts]"></asp:SqlDataSource>

</asp:Content>
